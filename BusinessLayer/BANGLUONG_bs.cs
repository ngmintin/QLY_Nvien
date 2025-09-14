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
        public List<BANGLUONG> getList(int makycong)
        {
            return db.BANGLUONGs.Where(x=>x.MAKYCONG==makycong).ToList();
        }

        //HÀM TÍNH LƯƠNG
        public void tinhLuongNhanVien(int makycong)
        {
            double luongngaythuong, luongphep, luongchunhat, luongngayle, baocao, hesoluong, thuclanh;
            var lstnv = db.NHANVIENs.Where(x => x.DATHOIVIEC == null).ToList();
            foreach (var item in lstnv)
            {
                var hd = db.HOPDONGs.FirstOrDefault(x=>x.MANV==item.MANV&&x.DELETED_BY==null);
                //KTRA NVIEN ĐÃ CÓ HỢP ĐỒNG CHƯA
                if(hd!=null)
                {
                    var kcct = db.KYCONGCHITIETs.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == item.MANV);
                    var nangluong = db.NHANVIEN_NANGLUONG.OrderByDescending(x => x.NGAYKY).FirstOrDefault(x => x.SOHD == hd.SOHD&&x.MANV==item.MANV&&x.DELETED_BY==null);
                    if (nangluong != null)
                        hesoluong = Convert.ToDouble(nangluong.HESOLUONGMOI);
                    else
                        hesoluong = Convert.ToDouble(hd.HESOLUONG);

                    var luong1ngaycong = hd.LUONGCOBAN * hesoluong / Convert.ToDouble(kcct.NGAYCONG);
                    //TÍNH LƯƠNG NGÀY THƯỜNG
                    luongngaythuong = Convert.ToDouble(kcct.TONGNGAYCONG * luong1ngaycong);
                    luongphep = Convert.ToDouble(kcct.NGAYPHEP * luong1ngaycong * 0.3);
                    luongchunhat = Convert.ToDouble(kcct.CONGCHUNHAT * luong1ngaycong * 2);
                    luongngayle = Convert.ToDouble(kcct.CONGNGAYLE * luong1ngaycong * 3);
                    baocao = Convert.ToDouble(db.NHANVIEN_BAOCAO.Where(x => x.MANV == item.MANV).Sum(x => x.SOTIEN));

                    thuclanh = luongngaythuong + luongphep + luongngayle + luongchunhat + baocao;
                    BANGLUONG bl = new BANGLUONG();
                    bl.MAKYCONG = makycong;
                    bl.MANV = item.MANV;
                    bl.HOTEN = item.HOTEN;
                    bl.NGAYCONGTRONGTHANG = int.Parse(kcct.NGAYCONG.ToString());
                    bl.NGAYPHEP = luongphep;
                    bl.NGAYCHUNHAT = luongchunhat;
                    bl.NGAYLE = luongngayle;
                    bl.NGAYTHUONG = luongngaythuong;
                    bl.BAOCAO = baocao;
                    bl.THUCLANH = thuclanh;
                    bl.CREATED_BY = 1;
                    bl.CREATED_DATE = DateTime.Now;
                    Add(bl);
                }    
                
            }
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
