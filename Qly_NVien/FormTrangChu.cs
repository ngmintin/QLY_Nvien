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

        private void btDieuChuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FormNhanVIen_DieuChuyen));
        }
    }
}