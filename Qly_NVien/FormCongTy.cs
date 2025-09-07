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
using BusinessLayer;

namespace Qly_NVien
{
    public partial class FormCongTy : Form
    {
        public FormCongTy()
        {
            InitializeComponent();
        }

        //BIẾN
        CONGTY_bs _congty;
        bool _them;
        int _idct;

        private void FormCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CONGTY_bs();
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
            textEditTen.Enabled = !kt;
            textEditSoDienThoai.Enabled = !kt;
            textEditEmail.Enabled = !kt;
            textEditDiaChi.Enabled = !kt;

        }

        void loadData()
        {
            gcDanhSach.DataSource = _congty.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            textEditTen.Text = string.Empty;
            textEditSoDienThoai.Text = string.Empty;
            textEditEmail.Text = string.Empty;
            textEditDiaChi.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _congty.Delete(_idct);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            showHide(true);

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
        }

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
                CONGTY ct = new CONGTY();
                ct.TENCTY = textEditTen.Text;
                ct.SĐT = textEditSoDienThoai.Text;
                ct.EMAIL = textEditEmail.Text;
                ct.DIACHI = textEditDiaChi.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_idct);
                ct.TENCTY = textEditTen.Text;
                ct.SĐT = textEditSoDienThoai.Text;
                ct.EMAIL = textEditEmail.Text;
                ct.DIACHI = textEditDiaChi.Text;
                _congty.Update(ct);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _idct = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_CTY").ToString());
                textEditTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                textEditSoDienThoai.Text = gvDanhSach.GetFocusedRowCellValue("SĐT").ToString();
                textEditEmail.Text = gvDanhSach.GetFocusedRowCellValue("EMAIL").ToString();
                textEditDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIACHI").ToString();
            }
        }
    }
}
