using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO_bs;
using DataLayer;

namespace BusinessLayer
{
    public class HOPDONGLAODONG_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        public HOPDONG getItem(string sohd)
        {
            return db.HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }

        public List<HOPDONGLAODONG_dto> getItemFull(string sohd)
        {
            List<HOPDONG> lshd = db.HOPDONG.Where(x => x.SOHD == sohd).ToList();
            List<HOPDONGLAODONG_dto> lshddto = new List<HOPDONGLAODONG_dto>();
            HOPDONGLAODONG_dto hddto;
            foreach (var item in lshd)
            {
                hddto = new HOPDONGLAODONG_dto();
                hddto.SOHD = item.SOHD;
                hddto.NGAYBDAU = item.NGAYBDAU;
                hddto.NGAYKTHUC = item.NGAYKTHUC;
                hddto.NGAYKY = item.NGAYKY;
                hddto.NOIDUNG = item.NOIDUNG;
                hddto.LANKY = item.LANKY;
                hddto.HESOLUONG = item.HESOLUONG;
                hddto.LUONGCOBAN = item.LUONGCOBAN;
                hddto.THOIHAN = item.THOIHAN;
                hddto.MANV = item.MANV;
                var nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hddto.HOTEN = nv.HOTEN;
                hddto.ID_CTY = item.ID_CTY;
                hddto.CREATED_BY = item.CREATED_BY;
                hddto.CREATED_DATE = item.CREATED_DATE;
                hddto.UPDATED_BY = item.UPDATED_BY;
                hddto.UPDATED_DATE = item.UPDATED_DATE;
                hddto.DELETED_BY = item.DELETED_BY;
                hddto.DELETED_DATE = item.DELETED_DATE;
                lshddto.Add(hddto);
            }
            return lshddto;
        }

        public List<HOPDONG> getList()
        {
            return db.HOPDONG.ToList();
        }

        public List<HOPDONGLAODONG_dto> getListFull()
        {
            List<HOPDONG> lshd = db.HOPDONG.ToList();
            List<HOPDONGLAODONG_dto> lshddto = new List<HOPDONGLAODONG_dto>();
            HOPDONGLAODONG_dto hddto;
            foreach(var item in lshd)
            {
                hddto = new HOPDONGLAODONG_dto();
                hddto.SOHD = item.SOHD;
                hddto.NGAYBDAU = item.NGAYBDAU;
                hddto.NGAYKTHUC = item.NGAYKTHUC;
                hddto.NGAYKY = item.NGAYKY;
                hddto.NOIDUNG = item.NOIDUNG;
                hddto.LANKY = item.LANKY;
                hddto.HESOLUONG = item.HESOLUONG;
                hddto.LUONGCOBAN = item.LUONGCOBAN;
                hddto.THOIHAN = item.THOIHAN;
                hddto.MANV = item.MANV;
                var nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hddto.HOTEN = nv.HOTEN;
                hddto.ID_CTY = item.ID_CTY;
                hddto.CREATED_BY = item.CREATED_BY;
                hddto.CREATED_DATE = item.CREATED_DATE;
                hddto.UPDATED_BY = item.UPDATED_BY;
                hddto.UPDATED_DATE = item.UPDATED_DATE;
                hddto.DELETED_BY = item.DELETED_BY;
                hddto.DELETED_DATE = item.DELETED_DATE;
                lshddto.Add(hddto);
            }
            return lshddto;
        }

        //THÊM
        public HOPDONG add(HOPDONG hd)
        {
            try
            {
                db.HOPDONG.Add(hd);
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CẬP NHẬT
        public HOPDONG Update(HOPDONG hd)
        {
            try
            {
                var _hd = db.HOPDONG.FirstOrDefault(x => x.SOHD == hd.SOHD);
                _hd.NGAYBDAU = hd.NGAYBDAU;
                _hd.NGAYKTHUC = hd.NGAYKTHUC;
                _hd.NGAYKY = hd.NGAYKY;
                _hd.NOIDUNG = hd.NOIDUNG;
                _hd.LANKY = hd.LANKY;
                _hd.THOIHAN = hd.THOIHAN;
                _hd.HESOLUONG = hd.HESOLUONG;
                _hd.LUONGCOBAN = hd.LUONGCOBAN;
                _hd.MANV = hd.MANV;
                _hd.SOHD = hd.SOHD;
                _hd.ID_CTY = hd.ID_CTY;
                _hd.UPDATED_BY = hd.UPDATED_BY;
                _hd.UPDATED_DATE = hd.UPDATED_DATE;
                db.SaveChanges();
                return hd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //XÓA
        public void Delete(string idhd, int manv)
        {
            var _hd = db.HOPDONG.FirstOrDefault(x => x.SOHD == idhd);
            _hd.DELETED_BY = manv;
            _hd.DELETED_DATE = DateTime.Now;
            db.SaveChanges();
        }

        public string maxSoHD()
        {
            var _hd = db.HOPDONG.OrderByDescending(x=>x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOHD;
            }
            else
            {
                return "00000";
            }
        }
        public List<HOPDONGLAODONG_dto> getLenLuong()
        {
            List<HOPDONG> lshd = db.HOPDONG.Where(x=>(x.NGAYBDAU.Value.Month-DateTime.Now.Month)==0&&(DateTime.Now.Year-x.NGAYBDAU.Value.Year)==1).ToList();
            List<HOPDONGLAODONG_dto> lshddto = new List<HOPDONGLAODONG_dto>();
            HOPDONGLAODONG_dto hddto;
            foreach (var item in lshd)
            {
                hddto = new HOPDONGLAODONG_dto();
                hddto.SOHD = item.SOHD;
                hddto.NGAYBDAU = item.NGAYBDAU;
                hddto.NGAYKTHUC = item.NGAYKTHUC;
                hddto.NGAYKY = item.NGAYKY;
                hddto.NOIDUNG = item.NOIDUNG;
                hddto.LANKY = item.LANKY;
                hddto.HESOLUONG = item.HESOLUONG;
                hddto.LUONGCOBAN = item.LUONGCOBAN;
                hddto.THOIHAN = item.THOIHAN;
                hddto.MANV = item.MANV;
                var nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                hddto.HOTEN = nv.HOTEN;
                hddto.ID_CTY = item.ID_CTY;
                hddto.CREATED_BY = item.CREATED_BY;
                hddto.CREATED_DATE = item.CREATED_DATE;
                hddto.UPDATED_BY = item.UPDATED_BY;
                hddto.UPDATED_DATE = item.UPDATED_DATE;
                hddto.DELETED_BY = item.DELETED_BY;
                hddto.DELETED_DATE = item.DELETED_DATE;
                lshddto.Add(hddto);
            }
            return lshddto;
        }
    }
}
