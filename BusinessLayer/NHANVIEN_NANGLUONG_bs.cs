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
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        public NHANVIEN_NANGLUONG getItem(string soqd)
        {
            return db.NHANVIEN_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<NHANVIEN_NANGLUONG> getList()
        {
            return db.NHANVIEN_NANGLUONG.ToList();
        }

        public List<NHANVIEN_NANGLUONG_dto> getListFull()
        {
            var lsnl = db.NHANVIEN_NANGLUONG.ToList();
            List<NHANVIEN_NANGLUONG_dto> lsnldto = new List<NHANVIEN_NANGLUONG_dto>();
            NHANVIEN_NANGLUONG_dto nldto;
            foreach (var item in lsnl)
            {
                nldto = new NHANVIEN_NANGLUONG_dto();
                nldto.SOQD = item.SOQD;
                nldto.SOHD = item.SOHD;
                nldto.HESOLUONGHIENTAI = item.HESOLUONGHIENTAI;
                nldto.HESOLUONGMOI = item.HESOLUONGMOI;
                nldto.MANV = item.MANV;
                var nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                nldto.HOTEN = nv.HOTEN;
                nldto.NGAYKY = item.NGAYKY;
                nldto.NGAYLENLUONG = item.NGAYLENLUONG;
                nldto.GHICHU = item.GHICHU;
                nldto.CREATED_BY = item.CREATED_BY;
                nldto.CREATED_DATE = item.CREATED_DATE;
                nldto.UPDATED_BY = item.UPDATED_BY;
                nldto.UPDATED_DATE = item.UPDATED_DATE;
                nldto.DELETED_BY = item.DELETED_BY;
                nldto.DELETED_DATE = item.DELETED_DATE;
                lsnldto.Add(nldto);
            }
            return lsnldto;
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
