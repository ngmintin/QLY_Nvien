using BusinessLayer.DTO_bs;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHANVIEN_NANGLUONG_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        public NHANVIEN_NANGLUONG getItem(string soqd)
        {
            return db.NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<NHANVIEN_NANGLUONG> getList()
        {
            return db.NHANVIEN_NANGLUONG.ToList();
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
                var nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == item.MANV);
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
        public NHANVIEN_NANGLUONG Add(NHANVIEN_NANGLUONG nl)
        {
            try
            {
                db.NHANVIEN_NANGLUONG.Add(nl);
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public NHANVIEN_NANGLUONG Update(NHANVIEN_NANGLUONG nl)
        {
            try
            {
                var _nl = db.NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == nl.SOQD);
                _nl.SOQD = nl.SOQD;
                _nl.MANV = nl.MANV;
                _nl.HESOLUONGHIENTAI = nl.HESOLUONGHIENTAI;
                _nl.HESOLUONGMOI = nl.HESOLUONGMOI;
                _nl.NGAYKY = nl.NGAYKY;
                _nl.NGAYLENLUONG = nl.NGAYLENLUONG;
                _nl.GHICHU = nl.GHICHU;
                _nl.UPDATED_BY = nl.UPDATED_BY;
                _nl.UPDATED_DATE = nl.UPDATED_DATE;
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(string soqd, int uid)
        {
            try
            {
                var _nl = db.NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
                _nl.DELETED_BY = uid;
                _nl.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string maxSoQD()
        {
            var _hd = db.NHANVIEN_NANGLUONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
