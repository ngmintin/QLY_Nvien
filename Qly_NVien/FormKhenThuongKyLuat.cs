using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Qly_NVien
{
    public partial class FormKhenThuongKyLuat : Form
    {
        public FormKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        bool _them;
        string _sohd;
        KHENTHUONGKYLUAT_bs _ktkl;

        private void FormKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONGKYLUAT_bs();
            _them = false;
            showHide(true);
            loadData();
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
            textEditSoHD.Enabled = !kt;
            dateTimePickerNgayBD.Enabled = !kt;
            dateTimePickerNgayKT.Enabled = !kt;
            dateTimePickerNgayKy.Enabled = !kt;
            spinEditLanKy.Enabled = !kt;
            spinEditHeSoLuong.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;

        }

        //HÀM RESET
        void _reset()
        {
            textEditSoHD.Text = string.Empty;
            dateTimePickerNgayBD.Value = DateTime.Now;
            dateTimePickerNgayBD.Value = dateTimePickerNgayBD.Value.AddMonths(6);
            dateTimePickerNgayKy.Value = DateTime.Now;
            spinEditLanKy.Text = "1";
            spinEditHeSoLuong.Text = "1";

        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _ktkl.getList(1);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
