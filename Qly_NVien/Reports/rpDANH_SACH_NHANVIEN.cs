using BusinessLayer.DTO_bs;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Qly_NVien.Reports
{
    public partial class rpDANH_SACH_NHANVIEN : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDANH_SACH_NHANVIEN()
        {
            InitializeComponent();
        }

        List<NHANVIEN_dto> _lstnv;    
        public rpDANH_SACH_NHANVIEN(List<NHANVIEN_dto> lstnv)
        {
            InitializeComponent();
            this._lstnv = lstnv;
            this.DataSource = _lstnv;
            loadData();
        }

        void loadData()
        {
            lbMANV.DataBindings.Add("Text", _lstnv, "MANV");
            LBHoTen.DataBindings.Add("Text", _lstnv, "HOTEN");
            lbGioiTinh.DataBindings.Add("Text", _lstnv, "GIOITINH");
            lbNgaySinh.DataBindings.Add("Text", _lstnv, "NGAYSINH");
            lbSDT.DataBindings.Add("Text", _lstnv, "SDT");
            lbDiaChi.DataBindings.Add("Text", _lstnv, "DIACHI");
            lbEmail.DataBindings.Add("Text", _lstnv, "EMAIL");
            lbPhongBan.DataBindings.Add("Text", _lstnv, "TENPB");
            lbBoPhan.DataBindings.Add("Text", _lstnv, "TENBP");
            lbChucVu.DataBindings.Add("Text", _lstnv, "TENCV");
            lbTrinhDo.DataBindings.Add("Text", _lstnv, "TENTD");
        }
    }
}
