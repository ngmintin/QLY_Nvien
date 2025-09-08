using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //LẤY VỀ DANH SÁCH
        public List<NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();
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
                _nv.ID_PB = nv.ID_PB;
                _nv.ID_BP = nv.ID_BP;
                _nv.ID_CV = nv.ID_CV;
                _nv.ID_TD = nv.ID_TD;
                _nv.ID_CTY = nv.ID_CTY;
                _nv.HINHANH = nv.HINHANH;
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
    }
}
