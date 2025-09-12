using BusinessLayer;
using DataLayer;
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
    public partial class FormQuanLyLuong : Form
    {
        public FormQuanLyLuong()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        bool _them;
        string _soqd;
        NHANVIEN_NANGLUONG_bs _nvnl;
        HOPDONGLAODONG_bs _hd;
        NHANVIEN_bs _nv;

        private void FormQuanLyLuong_Load(object sender, EventArgs e)
        {
            _nvnl = new NHANVIEN_NANGLUONG_bs();
            _hd = new HOPDONGLAODONG_bs();
            _nv = new NHANVIEN_bs();
            _them = false;
            showHide(true);
            loadHopDong();
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
            searchLookUpEditHopDong.Enabled = !kt;
            textEditGhiChu.Enabled = !kt;
            dateTimePickerNgayKy.Enabled = !kt;
        }

        //HÀM RESET
        void _reset()
        {
            textEditSoQD.Text = string.Empty;
            dateTimePickerNgayKy.Value = DateTime.Now;
            dateTimePickerNgayLenLuong.Value = dateTimePickerNgayLenLuong.Value.AddDays(30);
            textEditGhiChu.Text = string.Empty;

        }

        void loadHopDong()
        {
            searchLookUpEditHopDong.Properties.DataSource = _hd.getList();
            searchLookUpEditHopDong.Properties.ValueMember = "SOHD";
            searchLookUpEditHopDong.Properties.DisplayMember = "SOHD";
        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _nvnl.getList();
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
                _nvnl.Delete(_soqd, 1);
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
            if (_them)
            {
                NHANVIEN_NANGLUONG nl;
                //SỐ HD CÓ DẠNG: 00001/2025/HDLD
                var maxSoQD = _nvnl.maxSoQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                nl = new NHANVIEN_NANGLUONG();
                nl.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDNL";
                nl.GHICHU = textEditGhiChu.Text;
                nl.NGAYKY = dateTimePickerNgayKy.Value;
                nl.NGAYLENLUONG = dateTimePickerNgayLenLuong.Value;
                nl.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                nl.CREATED_BY = 1;
                nl.CREATED_DATE = DateTime.Now;
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

        private void searchLookUpEditHopDong_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hd.getItemFull(searchLookUpEditHopDong.EditValue.ToString());
            if (hd.Count != 0)
            {
                textEditNhanVien.Text = hd[0].MANV + " - " + hd[0].HOTEN;
            }
        }
    }
}
