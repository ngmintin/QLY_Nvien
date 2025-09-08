using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.DTO_bs
{
    public class NHANVIEN_dto
    {
        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> ID_PB { get; set; }
        public string TENPB { get; set; }
        public Nullable<int> ID_BP { get; set; }
        public string TENBP { get; set; }
        public Nullable<int> ID_CV { get; set; }
        public string TENCV { get; set; }
        public Nullable<int> ID_TD { get; set; }
        public string TENTD { get; set; }
        public Nullable<int> ID_CTY { get; set; }
        public byte[] HINHANH { get; set; }
        public bool? DATHOIVIEC { get; set; }
    }
}
