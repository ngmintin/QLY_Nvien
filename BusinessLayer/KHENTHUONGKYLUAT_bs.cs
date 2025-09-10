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

        public List<NHANVIEN_dto> getListFull()
        {
            var lsnv = db.NHANVIENs.ToList();
            List<NHANVIEN_dto> lsnvdto = new List<NHANVIEN_dto>();
            NHANVIEN_dto _nvdto;
            foreach (var item in lsnv)
            {
                _nvdto = new NHANVIEN_dto();
                _nvdto.MANV = item.MANV;
                _nvdto.HOTEN = item.HOTEN;
                _nvdto.GIOITINH = item.GIOITINH;
                _nvdto.NGAYSINH = item.NGAYSINH;
                _nvdto.SDT = item.SDT;
                _nvdto.DIACHI = item.DIACHI;
                _nvdto.EMAIL = item.EMAIL;
                _nvdto.HINHANH = item.HINHANH;
                _nvdto.DATHOIVIEC = item.DATHOIVIEC;
                _nvdto.ID_PB = item.ID_PB;
                var pb = db.PHONGBANs.FirstOrDefault(x => x.ID_PB == item.ID_PB);
                _nvdto.TENPB = pb.TENPB;

                _nvdto.ID_BP = item.ID_BP;
                var bp = db.BOPHANs.FirstOrDefault(x => x.ID_BP == item.ID_BP);
                _nvdto.TENBP = bp.TENBP;

                _nvdto.ID_CV = item.ID_CV;
                var cv = db.CHUCVUs.FirstOrDefault(x => x.ID_CV == item.ID_CV);
                _nvdto.TENCV = cv.TENCV;

                _nvdto.ID_TD = item.ID_TD;
                var td = db.TRINHDOes.FirstOrDefault(x => x.ID_TD == item.ID_TD);
                _nvdto.TENTD = td.TENTD;

                lsnvdto.Add(_nvdto);
            }
            return lsnvdto;
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
        public void Delete(string soqd) 
        {
            try
            {
                
                KHENTHUONGKYLUAT _ktkl = db.KHENTHUONGKYLUATs.FirstOrDefault(x => x.SOQUYETDINH == soqd);
                _ktkl.DELETED_BY = _ktkl.DELETED_BY;
                _ktkl.DELETED_DATE = _ktkl.DELETED_DATE;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

    }
}
