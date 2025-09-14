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
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        public KYCONG getItem(int makycong)
        {
            return db.KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
        }

        public List<KYCONG> getList()
        {
            return db.KYCONG.ToList();
        }

        //THÊM
        public KYCONG Add(KYCONG kc)
        {
            try
            {
                db.KYCONG.Add(kc);
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
                var _kc = db.KYCONG.FirstOrDefault(x => x.MAKYCONG == kc.MAKYCONG);
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
        public void Delete(int makycong, int iduser)
        {
            try
            {
                var _kc = db.KYCONG.FirstOrDefault(x => x.MAKYCONG == makycong);
                _kc.DELETED_BY = iduser;
                _kc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //KTRA TRẠNG THÁI
        public bool kiemTraPhatSinhKyCong(int makycong)
        {
            var kc = db.KYCONG.FirstOrDefault(x=>x.MAKYCONG==makycong);
            if(kc == null)
            {
                return false;
            }
            else
            {
                if (kc.TRANGTHAI == true)
                    return true;
                else
                    return false;
            }    
        }

    }
}
