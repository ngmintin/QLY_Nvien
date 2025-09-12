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

namespace Qly_NVien.CHAMCONG
{
    public partial class FormBangCong : Form
    {
        public FormBangCong()
        {
            InitializeComponent();
        }

        //BIẾN
        KYCONG_bs _kycong;
        bool _them;
        int _id;

        private void FormBangCong_Load(object sender, EventArgs e)
        {
            //THAO TÁC
            _them = false;
            _kycong = new KYCONG_bs();
            showHide(true);
            loadData();
            comboBoxNam.Text = DateTime.Now.Year.ToString();
            comboBoxThang.Text = DateTime.Now.Month.ToString();
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

        }

        void loadData()
        {
            gcDanhSach.DataSource = _kycong.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            comboBoxNam.Text = DateTime.Now.Year.ToString();
            comboBoxThang.Text = DateTime.Now.Month.ToString();
            checkBoxTrangThai.Checked = false;
            checkBoxKhoa.Checked = false;
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
                _kycong.Delete(_id, 1);
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
                KYCONG kc = new KYCONG();
                kc.MAKYCONG = int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text); //Mã KC 202501
                kc.NAM = int.Parse(comboBoxNam.Text);
                kc.THANG = int.Parse(comboBoxThang.Text);
                kc.KHOA = checkBoxKhoa.Checked;
                kc.TRANGTHAI = checkBoxTrangThai.Checked;
                kc.NGAYCONGTRONGTHANG = Functions.demSoNgayLamViecTrongThang(int.Parse(comboBoxThang.Text), int.Parse(comboBoxNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Add(kc);
            }
            else
            {
                var kc = _kycong.getItem(_id);
                kc.MAKYCONG = int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text); //Mã KC 202501
                kc.NAM = int.Parse(comboBoxNam.Text);
                kc.THANG = int.Parse(comboBoxThang.Text);
                kc.KHOA = checkBoxKhoa.Checked;
                kc.TRANGTHAI = checkBoxTrangThai.Checked;
                kc.NGAYCONGTRONGTHANG = Functions.demSoNgayLamViecTrongThang(int.Parse(comboBoxThang.Text), int.Parse(comboBoxNam.Text));
                kc.NGAYTINHCONG = DateTime.Now;
                kc.CREATED_BY = 1;
                kc.CREATED_DATE = DateTime.Now;
                _kycong.Update(kc);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                comboBoxNam.Text = gvDanhSach.GetFocusedRowCellValue("NAM").ToString();
                comboBoxThang.Text = gvDanhSach.GetFocusedRowCellValue("THANG").ToString();
                checkBoxKhoa.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("KHOA").ToString());
                checkBoxTrangThai.Checked = bool.Parse(gvDanhSach.GetFocusedRowCellValue("TRANGTHAI").ToString());

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
