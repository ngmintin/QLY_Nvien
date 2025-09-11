using BusinessLayer.DTO_bs;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KHENTHUONGKYLUAT_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        //
        public KHENTHUONGKYLUAT getItem(string soqd)
        {
            return db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQUYETDINH == soqd);
        }

        //LẤY VỀ DANH SÁCH
        public List<KHENTHUONGKYLUAT> getList(int loai)
        {
            return db.KHENTHUONGKYLUATs.Where(x=>x.LOAI == loai).ToList();
        }

        public List<KHENTHUONGKYLUAT_dto> getListFull(int loai)
        {
            List<KHENTHUONGKYLUAT> lsktkl = db.KHENTHUONGKYLUATs.Where(x=>x.LOAI==loai).ToList();
            List<KHENTHUONGKYLUAT_dto> lsktkldto = new List<KHENTHUONGKYLUAT_dto>();
            KHENTHUONGKYLUAT_dto ktkldto;
            foreach (var item in lsktkl)
            {
                ktkldto = new KHENTHUONGKYLUAT_dto();
                ktkldto.SOQUYETDINH = item.SOQUYETDINH;
                ktkldto.TUNGAY = item.TUNGAY;
                ktkldto.DENNGAY = item.DENNGAY;
                ktkldto.NOIDUNG = item.NOIDUNG;
                ktkldto.LOAI = item.LOAI;
                ktkldto.NGAY = item.NGAY;
                ktkldto.LYDO = item.LYDO;
                ktkldto.MANV = item.MANV;
                var nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == item.MANV);
                ktkldto.HOTEN = nv.HOTEN;
                ktkldto.CREATED_BY = item.CREATED_BY;
                ktkldto.CREATED_DATE = item.CREATED_DATE;
                ktkldto.UPDATED_BY = item.UPDATED_BY;
                ktkldto.UPDATED_DATE = item.UPDATED_DATE;
                ktkldto.DELETED_BY = item.DELETED_BY;
                ktkldto.DELETED_DATE = item.DELETED_DATE;
                lsktkldto.Add(ktkldto);
            }
            return lsktkldto;
        }

        //THÊM
        public KHENTHUONGKYLUAT Add(KHENTHUONGKYLUAT ktkl)
        {
            try
            {
                db.KHENTHUONGKYLUATs.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public KHENTHUONGKYLUAT Update(KHENTHUONGKYLUAT ktkl)
        {
            try
            {
                KHENTHUONGKYLUAT _ktkl = db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQUYETDINH == ktkl.SOQUYETDINH);
                _ktkl.NGAY = ktkl.NGAY;
                _ktkl.LYDO = ktkl.LYDO;
                _ktkl.NOIDUNG = ktkl.NOIDUNG;
                _ktkl.MANV = ktkl.MANV;
                _ktkl.LOAI = ktkl.LOAI;
                _ktkl.TUNGAY = ktkl.TUNGAY;
                _ktkl.DENNGAY = ktkl.DENNGAY;
                _ktkl.UPDATED_BY = ktkl.UPDATED_BY;
                _ktkl.UPDATED_DATE = ktkl.UPDATED_DATE;
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(string soqd, int manv) 
        {
            try
            {
                
                KHENTHUONGKYLUAT _ktkl = db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQUYETDINH == soqd);
                _ktkl.DELETED_BY = manv;
                _ktkl.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string maxSoQD(int loai)
        {
            var _hd = db.KHENTHUONGKYLUATs.Where(x=>x.LOAI==loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_hd != null)
            {
                return _hd.SOQUYETDINH;
            }
            else
            {
                return "00000";
            }
        }
    }
}
