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
    public partial class FormNhanVIen_DieuChuyen : Form
    {
        public FormNhanVIen_DieuChuyen()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        bool _them;
        string _soqd;
        NHANVIEN_DIEUCHUYEN_bs _nvdc;
        NHANVIEN_bs _nv;
        PHONGBAN_bs _pb;


        private void FormNhanVIen_DieuChuyen_Load(object sender, EventArgs e)
        {
            _nvdc = new NHANVIEN_DIEUCHUYEN_bs();
            _nv = new NHANVIEN_bs();
            _pb = new PHONGBAN_bs();
            _them = false;
            showHide(true);
            loadNhanVien();
            loadDonViDen();
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
            dateTimePickerNgay.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;
            comboBoxDVDen.Enabled = !kt;

        }

        //HÀM RESET
        void _reset()
        {
            textEditSoQD.Text = string.Empty;
            //dateTimePickerNgayBD.Value = DateTime.Now;
            //dateTimePickerNgayBD.Value = dateTimePickerNgayBD.Value.AddMonths(6);
            textEditLyDo.Text = string.Empty;
            textEditGhiChu.Text = string.Empty;

        }

        void loadNhanVien()
        {
            searchLookUpEditNhanVien.Properties.DataSource = _nv.getList();
            searchLookUpEditNhanVien.Properties.ValueMember = "MANV";
            searchLookUpEditNhanVien.Properties.DisplayMember = "HOTEN";
        }

        void loadDonViDen()
        {
            comboBoxDVDen.DataSource = _pb.getList();
            comboBoxDVDen.ValueMember = "ID_PB";
            comboBoxDVDen.DisplayMember = "TENPB";
        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _nvdc.getListFull();
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
                _nvdc.Delete(_soqd, 1);
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

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void saveData()
        {
            if (_them)
            {
                //SỐ HD CÓ DẠNG: 00001/2025/HDLD
                var maxSoQD = _nvdc.maxSoQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                NHANVIEN_DIEUCHUYEN nvdc = new NHANVIEN_DIEUCHUYEN();
                nvdc.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDDC";
                nvdc.LYDO = textEditLyDo.Text;
                nvdc.GHICHU = textEditGhiChu.Text;
                nvdc.NGAY = dateTimePickerNgay.Value;
                nvdc.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                nvdc.ID_PB = _nv.getItem(int.Parse(searchLookUpEditNhanVien.EditValue.ToString())).ID_BP;
                nvdc.ID_PB2 = int.Parse(comboBoxDVDen.SelectedValue.ToString());
                nvdc.GHICHU = textEditGhiChu.Text;
                nvdc.CREATED_BY = 1;
                nvdc.CREATED_DATE = DateTime.Now;
                _nvdc.Add(nvdc);
            }
            else
            {
                var nvdc = _nvdc.getItem(_soqd);
                nvdc.LYDO = textEditLyDo.Text;
                nvdc.GHICHU = textEditGhiChu.Text;
                nvdc.NGAY = dateTimePickerNgay.Value;
                nvdc.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                nvdc.ID_PB2 = int.Parse(comboBoxDVDen.SelectedValue.ToString());
                nvdc.UPDATED_BY = 1;
                nvdc.UPDATED_DATE = DateTime.Now;
                _nvdc.Update(nvdc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _soqd = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
            var nvdc = _nvdc.getItem(_soqd);
            textEditSoQD.Text = _soqd;
            searchLookUpEditNhanVien.EditValue = nvdc.MANV;
            textEditLyDo.Text = nvdc.LYDO;
            textEditGhiChu.Text = nvdc.GHICHU;
            dateTimePickerNgay.Value = nvdc.NGAY.Value;
            comboBoxDVDen.SelectedValue = nvdc.ID_PB2;
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.letterx;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}
