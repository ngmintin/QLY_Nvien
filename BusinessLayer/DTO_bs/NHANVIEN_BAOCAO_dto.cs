using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTO_bs
{
    public class NHANVIEN_BAOCAO_dto
    {
        public int ID { get; set; }
        public Nullable<int> MANV { get; set; }
        public string HOTEN { get; set; }
        public string TENCV { get; set; }
        public Nullable<int> ID_BC { get; set; }
        public string TENBC { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<double> SOTIEN { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_DATE { get; set; }
        public Nullable<int> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
        public Nullable<int> UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }

        public virtual BAOCAO BAOCAO { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
