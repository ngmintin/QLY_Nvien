using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BAOCAO_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        public NHANVIEN_BAOCAO getItem(int id)
        {
            return db.NHANVIEN_BAOCAO.FirstOrDefault(x => x.ID == id);
        }

        public List<NHANVIEN_BAOCAO> getList()
        {
            return db.NHANVIEN_BAOCAO.ToList();
        }

        public List<BAOCAO> getListBC()
        {
            return db.BAOCAOs.ToList();
        }

        //THÊM
        public NHANVIEN_BAOCAO Add(NHANVIEN_BAOCAO nvbc)
        {
            try
            {
                db.NHANVIEN_BAOCAO.Add(nvbc);
                db.SaveChanges();
                return nvbc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //CẬP NHẬT
        public NHANVIEN_BAOCAO Update(NHANVIEN_BAOCAO nvbc)
        {
            try
            {
                var _nvbc = db.NHANVIEN_BAOCAO.FirstOrDefault(x => x.ID == nvbc.ID);
                _nvbc.ID_BC = nvbc.ID;
                _nvbc.MANV = nvbc.MANV;
                _nvbc.NGAY = nvbc.NGAY;
                _nvbc.NOIDUNG = nvbc.NOIDUNG;
                _nvbc.SOTIEN = nvbc.SOTIEN;
                _nvbc.UPDATED_BY = nvbc.UPDATED_BY;
                _nvbc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return nvbc;
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
                var _bc = db.NHANVIEN_BAOCAO.FirstOrDefault(x => x.ID == id);
                _bc.DELETED_BY = _bc.DELETED_BY;
                _bc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
