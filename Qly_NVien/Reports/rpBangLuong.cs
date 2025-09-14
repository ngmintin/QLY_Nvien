using DataLayer;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Qly_NVien.Reports
{
    public partial class rpBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public rpBangLuong()
        {
            InitializeComponent();
        }

        //BIẾN
        List<BANGLUONG> _lst;
        int _namky;

        public rpBangLuong(List<BANGLUONG> _lstbangluong, int namky)
        {
            InitializeComponent();
            this._lst = _lstbangluong;
            this._namky = namky;
            lblTHANGNAM.Text = "Tháng "+_namky.ToString().Substring(4)+" năm"+_namky.ToString().Substring(0,4);
            this.DataSource = _lst;
            loadData();
        }

        void loadData()
        {
            lblMANV.DataBindings.Add("Text", DataSource, "MANV");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNGAYCONGTRONGTHANG.DataBindings.Add("Text", DataSource, "NGAYCONGTRONGTHANG");
            lblLUONGPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblLUONGLE.DataBindings.Add("Text", DataSource, "NGAYLE");
            lblLUONGCN.DataBindings.Add("Text", DataSource, "NGAYCHUNHAT");
            lblBAOCAO.DataBindings.Add("Text", DataSource, "BAOCAO");
            lblLUONGNGAYTHUONG.DataBindings.Add("Text", DataSource, "NGAYTHUONG");
            lblTHUCLINH.DataBindings.Add("Text", DataSource, "THUCLANH");
        }
    }
}
