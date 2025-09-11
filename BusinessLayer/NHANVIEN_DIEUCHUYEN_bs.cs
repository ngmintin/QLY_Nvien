using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO_bs;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN_DIEUCHUYEN_bs
    {

        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        //
        public NHANVIEN_DIEUCHUYEN getItem(string soqd)
        {
            return db.NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
        }

        //LẤY VỀ DANH SÁCH
        public List<NHANVIEN_DIEUCHUYEN> getList()
        {
            return db.NHANVIEN_DIEUCHUYEN.ToList();
        }

        public List<NHANVIEN_DIEUCHUYEN_dto> getListFull()
        {
            var lsnvdc = db.NHANVIEN_DIEUCHUYEN.ToList();
            List<NHANVIEN_DIEUCHUYEN_dto> lsnvdcdto = new List<NHANVIEN_DIEUCHUYEN_dto>();
            NHANVIEN_DIEUCHUYEN_dto nvdcdto;
            foreach (var item in lsnvdc)
            {
                nvdcdto = new NHANVIEN_DIEUCHUYEN_dto();
                nvdcdto.SOQD = item.SOQD;
                nvdcdto.NGAY = item.NGAY;
                nvdcdto.MANV = item.MANV;
                var nv = db.NHANVIENs.FirstOrDefault(n => n.MANV == item.MANV);
                nvdcdto.HOTEN = nv.HOTEN;

                nvdcdto.ID_PB = item.ID_PB;
                var pb = db.PHONGBANs.FirstOrDefault(p => p.ID_PB == item.ID_PB);
                nvdcdto.TENPB = pb.TENPB;

                nvdcdto.ID_PB2 = item.ID_PB2;
                var pb2 = db.PHONGBANs.FirstOrDefault(p2 => p2.ID_PB == item.ID_PB);
                nvdcdto.TENPB2 = pb2.TENPB;

                nvdcdto.LYDO = item.LYDO;
                nvdcdto.GHICHU = item.GHICHU;
                nvdcdto.CREATED_BY = item.CREATED_BY;
                nvdcdto.CREATED_DATE = item.CREATED_DATE;
                nvdcdto.UPDATED_BY = item.UPDATED_BY;
                nvdcdto.UPDATED_DATE = item.UPDATED_DATE;
                nvdcdto.DELETED_BY = item.DELETED_BY;
                nvdcdto.DELETED_DATE = item.DELETED_DATE;
                lsnvdcdto.Add(nvdcdto);
            }
            return lsnvdcdto;
        }

        //THÊM
        public NHANVIEN_DIEUCHUYEN Add(NHANVIEN_DIEUCHUYEN nvdc)
        {
            try
            {
                db.NHANVIEN_DIEUCHUYEN.Add(nvdc);
                db.SaveChanges();
                return nvdc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public NHANVIEN_DIEUCHUYEN Update(NHANVIEN_DIEUCHUYEN nvdc)
        {
            try
            {
                var _nvdc = db.NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == nvdc.SOQD);
                
                _nvdc.ID_PB2 = nvdc.ID_PB2;
                _nvdc.MANV = nvdc.MANV;
                _nvdc.NGAY = nvdc.NGAY;
                _nvdc.LYDO = nvdc.LYDO;
                _nvdc.GHICHU = nvdc.GHICHU;
                _nvdc.UPDATED_BY = nvdc.UPDATED_BY;
                _nvdc.UPDATED_DATE = nvdc.UPDATED_DATE;
                db.SaveChanges();
                return nvdc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _nvdc = db.NHANVIEN_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
                _nvdc.DELETED_BY = iduser;
                _nvdc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public string maxSoQD()
        {
            var _qd = db.NHANVIEN_DIEUCHUYEN.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SOQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
