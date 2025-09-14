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
using DataLayer;
using DevExpress.XtraReports.UI;
using Qly_NVien.Reports;

namespace Qly_NVien.CHAMCONG
{
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }

        //BIẾN
        BANGLUONG_bs _bangluong;
        List<BANGLUONG> _lstbangluong;
        int _namky;

        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BANGLUONG_bs();
            comboBoxNam.Text = DateTime.Now.Year.ToString();
            comboBoxThang.Text = DateTime.Now.Month.ToString();

        }

        void loadData()
        {
            gcDanhSach.DataSource = _bangluong.getList(int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text));
            gvDanhSach.OptionsBehavior.Editable = false;
            _lstbangluong = _bangluong.getList(int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text));
            _namky = int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text);
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.tinhLuongNhanVien(int.Parse(comboBoxNam.Text) * 100 + int.Parse(comboBoxThang.Text));
            loadData();
        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXemBangLuong_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void barButtonItemIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpBangLuong rp = new rpBangLuong(_lstbangluong, _namky);
            rp.ShowPreviewDialog();
        }
    }
}
