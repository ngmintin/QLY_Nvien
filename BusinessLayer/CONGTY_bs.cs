using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CONGTY_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        //
        public CONGTY getItem(int idct)
        {
            return db.CONGTY.FirstOrDefault(x => x.ID_CTY == idct);
        }

        //LẤY VỀ DANH SÁCH
        public List<CONGTY> getList()
        {
            return db.CONGTY.ToList();
        }

        //THÊM
        public CONGTY Add(CONGTY ct)
        {
            try
            {
                db.CONGTY.Add(ct);
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public CONGTY Update(CONGTY ct)
        {
            try
            {
                var _ct = db.CONGTY.FirstOrDefault(x => x.ID_CTY == ct.ID_CTY);
                _ct.TENCTY = ct.TENCTY;
                _ct.SĐT = ct.SĐT;
                _ct.EMAIL = ct.EMAIL;
                _ct.DIACHI = ct.DIACHI;
                db.SaveChanges();
                return ct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idct)
        {
            try
            {
                var _ct = db.CONGTY.FirstOrDefault(x => x.ID_CTY == idct);
                db.CONGTY.Remove(_ct);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
