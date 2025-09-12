using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Qly_NVien.CHAMCONG;

namespace Qly_NVien
{
    public partial class FormTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        //ĐK KH BỊ LẶP FORM
        void openForm(Type typeForm)
        {
            foreach (var fr in MdiChildren)
            {
                if (fr.GetType() == typeForm)
                {
                    fr.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }

        //BIẾN TOÀN CỤC
        NHANVIEN_bs _nhanvien;

        private void btThongBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormThongBao));
        }

        private void btSuKien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormSuKien));
        }

        private void btmTrinhDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormTrinhDo));
        }

        private void btnPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormPhongBan));
        }

        private void btnCongTy_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormCongTy));
        }

        private void btnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormBoPhan));
        }

        private void btnChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormChucVu));
        }

        private void btNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormNhanVien));
        }

        private void btnHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormHopDongLaoDong));
        }

        private void btKhenThuongKyLuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormKhenThuongKyLuat));
        }

        private void btmThoat_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btThoiViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormNhanVien_ThoiViec));
        }

        private void barButtonItemQuanLyLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormQuanLyLuong));
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            _nhanvien = new NHANVIEN_bs();
            loadSinhNhat();
        }

        //HÀM SNHAT
        void loadSinhNhat()
        {
            listBoxControlSinhNhat.DataSource = _nhanvien.getSinhNhat();
            listBoxControlSinhNhat.DisplayMember = "HOTEN";
            listBoxControlSinhNhat.ValueMember = "MANV";
        }

        private void listBoxControlSinhNhat_CustomizeItem(object sender, DevExpress.XtraEditors.CustomizeTemplatedItemEventArgs e)
        {
            if (e.TemplatedItem.Elements[1].Text.Substring(0, 2) == DateTime.Now.Day.ToString())
            {
                e.TemplatedItem.Appearance.ForeColor = Color.Red;
            }
        }

        private void barButtonItemLoaiCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormLoaiCa));
        }

        private void btLoaiCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormLoaiCong));
        }

        private void btBangCong_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormBangCong));
        }
    }
}