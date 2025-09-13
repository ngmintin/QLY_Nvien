using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BANGLUONG_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();
        public BANGLUONG getItem(int makycong, int manv)
        {
            return db.BANGLUONGs.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv);
        }

        public BANGLUONG Add(BANGLUONG bl)
        {
            try
            {
                db.BANGLUONGs.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: "+ex.Message);
            }
        }
        public BANGLUONG Update(BANGLUONG bl)
        {
            try
            {
                BANGLUONG _bl = db.BANGLUONGs.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG && x.MANV == bl.MANV);
                _bl.MANV = bl.MANV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.HOTEN = bl.HOTEN;
                _bl.NGAYPHEP = bl.NGAYPHEP;
                _bl.KHONGPHEP = bl.KHONGPHEP;
                _bl.NGAYLE = bl.NGAYLE;
                _bl.NGAYCHUNHAT = bl.NGAYCHUNHAT;
                _bl.NGAYCONGTRONGTHANG = bl.NGAYCONGTRONGTHANG;
                _bl.NGAYTHUONG = bl.NGAYTHUONG;
                _bl.THUCLANH = bl.THUCLANH;
                _bl.UPDATED_BY = bl.UPDATED_BY;
                _bl.UPDATED_DATE = bl.UPDATED_DATE;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
