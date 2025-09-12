using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KYCONG_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        public KYCONG getItem(int id)
        {
            return db.KYCONGs.FirstOrDefault(x => x.ID == id);
        }

        public List<KYCONG> getList()
        {
            return db.KYCONGs.ToList();
        }

        //THÊM
        public KYCONG Add(KYCONG kc)
        {
            try
            {
                db.KYCONGs.Add(kc);
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //CẬP NHẬT
        public KYCONG Update(KYCONG kc)
        {
            try
            {
                var _kc = db.KYCONGs.FirstOrDefault(x => x.ID == kc.ID);
                _kc.MAKYCONG = kc.MAKYCONG;
                _kc.NAM = kc.NAM;
                _kc.THANG = kc.THANG;
                _kc.KHOA = kc.KHOA;
                _kc.NGAYCONGTRONGTHANG = kc.NGAYCONGTRONGTHANG;
                _kc.NGAYTINHCONG = kc.NGAYTINHCONG;
                _kc.TRANGTHAI = kc.TRANGTHAI;
                _kc.UPDATED_BY = kc.UPDATED_BY;
                _kc.UPDATED_DATE = kc.UPDATED_DATE; 
                db.SaveChanges();
                return kc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int id, int iduser)
        {
            try
            {
                var _kc = db.KYCONGs.FirstOrDefault(x => x.ID == id);
                _kc.DELETED_BY = iduser;
                _kc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
