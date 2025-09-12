using BusinessLayer;
using DataLayer;
using DevExpress.XtraMap.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NVien
{
    public partial class FormNhanVien_ThoiViec : Form
    {
        public FormNhanVien_ThoiViec()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        bool _them;
        string _soqd;
        NHANVIEN_THOIVIEC_bs _nvtv;
        NHANVIEN_bs _nv;


        private void FormNhanVien_ThoiViec_Load(object sender, EventArgs e)
        {
            _nvtv = new NHANVIEN_THOIVIEC_bs();
            _nv = new NHANVIEN_bs();
            _them = false;
            showHide(true);
            loadNhanVien();
            loadData();
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
        }

        //ẨN NÚT LƯU VÀ HỦY KHI THAO TÁC
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btDong.Enabled = kt;
            btIn.Enabled = kt;
            gcDanhSach.Enabled = kt;
            textEditSoQD.Enabled = !kt;
            textEditLyDo.Enabled = !kt;
            textEditGhiChu.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;
            dateTimePickerNgayNopDon.Enabled = !kt;
            dateTimePickerNgayNghi.Enabled = !kt;
        }

        //HÀM RESET
        void _reset()
        {
            textEditSoQD.Text = string.Empty;
            dateTimePickerNgayNopDon.Value = DateTime.Now;
            dateTimePickerNgayNghi.Value = dateTimePickerNgayNopDon.Value.AddDays(30);
            textEditLyDo.Text = string.Empty;
            textEditGhiChu.Text = string.Empty;

        }

        void loadNhanVien()
        {
            searchLookUpEditNhanVien.Properties.DataSource = _nv.getList();
            searchLookUpEditNhanVien.Properties.ValueMember = "MANV";
            searchLookUpEditNhanVien.Properties.DisplayMember = "HOTEN";
        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _nvtv.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            _reset();
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both; //HIỆN THỊ CẢ 2 PANEL
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both; //HIỆN THỊ CẢ 2 PANEL
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nvtv.Delete(_soqd, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            showHide(true);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2; //CHỈ HIỆN THỊ PANEL 2
        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void saveData()
        {
            NHANVIEN_THOIVIEC tv = new NHANVIEN_THOIVIEC();
            if (_them)
            {
                //SỐ HD CÓ DẠNG: 00001/2025/HDLD
                var maxSoQD = _nvtv.maxSoQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tv = new NHANVIEN_THOIVIEC();
                tv.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDTV";
                tv.LYDO = textEditLyDo.Text;
                tv.GHICHU = textEditGhiChu.Text;
                tv.NGAYNOPDON = dateTimePickerNgayNopDon.Value;
                tv.NGAYNGHI = dateTimePickerNgayNghi.Value;
                tv.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                tv.CREATED_BY = 1;
                tv.CREATED_DATE = DateTime.Now;
                _nvtv.Add(tv);
            }
            else
            {
                tv = _nvtv.getItem(_soqd);
                tv.LYDO = textEditLyDo.Text;
                tv.GHICHU = textEditGhiChu.Text;
                tv.NGAYNOPDON = dateTimePickerNgayNopDon.Value;
                tv.NGAYNGHI = dateTimePickerNgayNghi.Value;
                tv.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                tv.UPDATE_BY = 1;
                tv.UPDATE_DATE = DateTime.Now;
                _nvtv.Update(tv);
            }
            var nv = _nv.getItem(tv.MANV.Value);
            nv.DATHOIVIEC = true;
            _nv.Update(nv);
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _soqd = gvDanhSach.GetFocusedRowCellValue("SOQD").ToString();
                var tv = _nvtv.getItem(_soqd);
                textEditSoQD.Text = _soqd;
                dateTimePickerNgayNopDon.Value = tv.NGAYNOPDON.Value;
                dateTimePickerNgayNghi.Value = tv.NGAYNGHI.Value;
                searchLookUpEditNhanVien.EditValue = tv.MANV;
                textEditLyDo.Text = tv.LYDO;
                textEditGhiChu.Text = tv.GHICHU;
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image image = Properties.Resources.letterx;
                e.Graphics.DrawImage(image, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void dateTimePickerNgayNopDon_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNgayNghi.Value = dateTimePickerNgayNopDon.Value.AddDays(30);
        }
    }
}