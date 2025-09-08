using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();
        
        public NHANVIEN_THOIVIEC getItem(string soqd)
        {
            return db.NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<NHANVIEN_THOIVIEC> getItem()
        {
            return db.NHANVIEN_THOIVIEC.ToList();
        }
        
        //THÊM
        public NHANVIEN_THOIVIEC add(NHANVIEN_THOIVIEC tv)
        {
            try
            {
                db.NHANVIEN_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public NHANVIEN_THOIVIEC Update(NHANVIEN_THOIVIEC tv)
        {
            try
            {
                var _tv = db.NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATE_BY = tv.UPDATE_BY;
                _tv.UPDATE_DATE = tv.UPDATE_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
                _tv.DELETED_BY = iduser;
                _tv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
