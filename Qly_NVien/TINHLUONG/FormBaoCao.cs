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

namespace Qly_NVien.TINHLUONG
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        //BIẾN
        BAOCAO_bs _baocao;
        NHANVIEN_bs _nhanvien;
        bool _them;
        int _id;

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            //THAO TÁC
            _them = false;
            _baocao = new BAOCAO_bs();
            _nhanvien = new NHANVIEN_bs();
            showHide(true);
            loadNhanVien();
            loadBaoCao();
            loadData();
            comboBoxBaoCao.SelectedIndexChanged += CboBaoCao_SelectedIndexChanged;
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
        }

        //HIỆN THỊ SỐ TIỀN THEO BÁO CÁO
        private void CboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bc = _baocao.getItemBC(int.Parse(comboBoxBaoCao.SelectedValue.ToString()));
            if(bc != null)
            {
                spinEditSoTien.EditValue = bc.SOTIEN;
            }    
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
            textBoxNoiDung.Enabled = !kt;
            spinEditSoTien.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;
            comboBoxBaoCao.Enabled = !kt;

        }

        //HÀM NVIEN
        void loadNhanVien()
        {
            searchLookUpEditNhanVien.Properties.DataSource = _nhanvien.getListFull();
            searchLookUpEditNhanVien.Properties.DisplayMember = "HOTEN";
            searchLookUpEditNhanVien.Properties.ValueMember = "MANV";
        }

        //HÀM BÁO CÁO
        void loadBaoCao()
        {
            comboBoxBaoCao.DataSource = _baocao.getListBC();
            comboBoxBaoCao.DisplayMember = "TENBC";
            comboBoxBaoCao.ValueMember = "ID_BC";
        }


        void loadData()
        {
            gcDanhSach.DataSource = _baocao.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            textBoxNoiDung.Text = string.Empty;
            spinEditSoTien.EditValue = 0;
            searchLookUpEditNhanVien.EditValue = 0;
            comboBoxBaoCao.SelectedIndex = 0;
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
                _baocao.Delete(_id, 1);
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
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        //HÀM LƯU DL
        void saveData()
        {
            if (_them)
            {
                NHANVIEN_BAOCAO nvbc = new NHANVIEN_BAOCAO();
                nvbc.ID_BC = int.Parse(comboBoxBaoCao.SelectedValue.ToString());
                nvbc.SOTIEN = double.Parse(spinEditSoTien.EditValue.ToString());
                nvbc.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                nvbc.NOIDUNG = textBoxNoiDung.Text;
                nvbc.NGAY = DateTime.Now;
                nvbc.CREATED_BY = 1;
                nvbc.CREATED_DATE = DateTime.Now;
                _baocao.Add(nvbc);
            }
            else
            {
                var nvbc = _baocao.getItem(_id);
                nvbc.ID_BC = int.Parse(comboBoxBaoCao.SelectedValue.ToString());
                nvbc.SOTIEN = double.Parse(spinEditSoTien.EditValue.ToString());
                nvbc.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                nvbc.NOIDUNG = textBoxNoiDung.Text;
                nvbc.NGAY = DateTime.Now;
                nvbc.UPDATED_BY = 1;
                nvbc.UPDATED_DATE = DateTime.Now;
                _baocao.Update(nvbc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                textBoxNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("NOIDUNG").ToString();
                spinEditSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                searchLookUpEditNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
                comboBoxBaoCao.SelectedValue = gvDanhSach.GetFocusedRowCellValue("ID_BC");
            }
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
