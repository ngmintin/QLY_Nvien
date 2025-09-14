using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO_bs;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();
        
        public NHANVIEN_THOIVIEC getItem(string soqd)
        {
            return db.NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<NHANVIEN_THOIVIEC> getList()
        {
            return db.NHANVIEN_THOIVIEC.ToList();
        }

        public List<NHANVIEN_THOIVIEC_dto> getListFull()
        {
            var lstv = db.NHANVIEN_THOIVIEC.ToList();
            List<NHANVIEN_THOIVIEC_dto> lstvdto = new List<NHANVIEN_THOIVIEC_dto>();
            NHANVIEN_THOIVIEC_dto _tvdto;
            foreach (var item in lstv)
            {
                _tvdto = new NHANVIEN_THOIVIEC_dto();
                _tvdto.SOQD = item.SOQD;
                _tvdto.MANV = item.MANV;
                var nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                _tvdto.HOTEN = nv.HOTEN;
                _tvdto.NGAYNOPDON = item.NGAYNOPDON;
                _tvdto.NGAYNGHI = item.NGAYNGHI;
                _tvdto.LYDO = item.LYDO;
                _tvdto.GHICHU = item.GHICHU;
                _tvdto.CREATED_BY = item.CREATED_BY;
                _tvdto.CREATED_DATE = item.CREATED_DATE;
                _tvdto.UPDATE_BY = item.UPDATE_BY;
                _tvdto.UPDATE_DATE = item.UPDATE_DATE;
                _tvdto.DELETED_BY = item.DELETED_BY;
                _tvdto.DELETED_DATE = item.DELETED_DATE;
                lstvdto.Add(_tvdto);
            }
            return lstvdto;
        }

        //THÊM
        public NHANVIEN_THOIVIEC Add(NHANVIEN_THOIVIEC tv)
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
                _tv.MANV = tv.MANV;
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

        public string maxSoQD()
        {
            var soqd = db.NHANVIEN_THOIVIEC.OrderByDescending(x=>x.CREATED_DATE).FirstOrDefault();
            if (soqd != null)
            { 
                return soqd.SOQD;
            }     
            else
            {
                return "00000"; 
            }
        }
    }
}
