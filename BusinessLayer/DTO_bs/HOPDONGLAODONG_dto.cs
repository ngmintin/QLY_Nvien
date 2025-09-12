using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO_bs
{
    public class HOPDONGLAODONG_dto
    {
        public string SOHD { get; set; }
        public Nullable<System.DateTime> NGAYBDAU { get; set; }
        public Nullable<System.DateTime> NGAYKTHUC { get; set; }
        public Nullable<System.DateTime> NGAYKY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<int> LANKY { get; set; }
        public string THOIHAN { get; set; }
        public Nullable<double> HESOLUONG { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { set; get; }
        public Nullable<int> ID_CTY { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
