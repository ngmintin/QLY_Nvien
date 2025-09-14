using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO_bs;
using DataLayer;

namespace BusinessLayer
{
    public class BAOCAO_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        public NHANVIEN_BAOCAO getItem(int id)
        {
            return db.NHANVIEN_BAOCAO.FirstOrDefault(x => x.ID == id);
        }

        public List<NHANVIEN_BAOCAO_dto> getListFull()
        {
            var lstNVBC = db.NHANVIEN_BAOCAO.ToList();
            List<NHANVIEN_BAOCAO_dto> lstdto = new List<NHANVIEN_BAOCAO_dto>();
            NHANVIEN_BAOCAO_dto nvbcdto;
            NHANVIEN_bs _nhanvien = new NHANVIEN_bs();
            foreach(var item in lstNVBC)
            {
                nvbcdto = new NHANVIEN_BAOCAO_dto();
                nvbcdto.ID = item.ID;
                nvbcdto.MANV = item.MANV;
                var nv = _nhanvien.getItemFull(int.Parse(item.MANV.ToString()));
                nvbcdto.HOTEN = nv.HOTEN;
                nvbcdto.TENCV = nv.TENCV;
                nvbcdto.ID_BC = item.ID_BC;
                var bc = db.BAOCAO.FirstOrDefault(x => x.ID_BC == item.ID_BC);
                nvbcdto.TENBC = bc.TENBC;
                nvbcdto.NOIDUNG = item.NOIDUNG;
                nvbcdto.NGAY = item.NGAY;
                nvbcdto.SOTIEN = item.SOTIEN;
                nvbcdto.UPDATED_BY = item.UPDATED_BY;
                nvbcdto.UPDATED_DATE = item.UPDATED_DATE;
                nvbcdto.CREATED_BY = item.CREATED_BY;
                nvbcdto.CREATED_DATE = item.CREATED_DATE;
                nvbcdto.DELETED_BY = item.DELETED_BY;
                nvbcdto.DELETED_DATE = item.DELETED_DATE;
                lstdto.Add(nvbcdto);
            }    

            return lstdto;
        }

        public BAOCAO getItemBC(int id)
        {
            return db.BAOCAO.FirstOrDefault(x=>x.ID_BC==id);
        }

        public List<BAOCAO> getListBC()
        {
            return db.BAOCAO.ToList();
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
