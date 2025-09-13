using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO_bs;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        //
        public NHANVIEN getItem(int idnv)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.MANV == idnv);
        }

        public NHANVIEN_dto getItemFull(int id)
        {
            var item = db.NHANVIENs.FirstOrDefault(x=>x.MANV==id);
            NHANVIEN_dto _nvdto = new NHANVIEN_dto();
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
                return _nvdto;
        }

        //LẤY VỀ DANH SÁCH
        public List<NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();
        }

        public List<NHANVIEN_dto> getListFull()
        {
            var lsnv = db.NHANVIENs.ToList();
            List<NHANVIEN_dto> lsnvdto = new List<NHANVIEN_dto>();
            NHANVIEN_dto _nvdto;
            foreach(var item in lsnv)
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
        public NHANVIEN Add(NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public NHANVIEN Update(NHANVIEN nv)
        {
            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == nv.MANV);
                _nv.MANV = nv.MANV;
                _nv.HOTEN = nv.HOTEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.SDT = nv.SDT;
                _nv.DIACHI = nv.DIACHI;
                _nv.EMAIL = nv.EMAIL;
                _nv.HINHANH = nv.HINHANH;
                _nv.DATHOIVIEC = nv.DATHOIVIEC;
                _nv.ID_PB = nv.ID_PB;
                _nv.ID_BP = nv.ID_BP;
                _nv.ID_CV = nv.ID_CV;
                _nv.ID_TD = nv.ID_TD;
                _nv.ID_CTY = nv.ID_CTY;
         
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idnv)
        {
            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == idnv);
                db.NHANVIENs.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //HÀM LẤY NHÂN VIÊN SINH NHẬT TRONG THÁNG
        public List<NHANVIEN> getSinhNhat()
        {
            return db.NHANVIENs.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
        }
    }
}
