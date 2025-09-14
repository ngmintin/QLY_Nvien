using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDOs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        //
        public TRINHDO getItem(int idtd)
        {
            return db.TRINHDO.FirstOrDefault(x => x.ID_TD == idtd);
        }

        //LẤY VỀ DANH SÁCH
        public List<TRINHDO> getList()
        {
            return db.TRINHDO.ToList();
        }

        //THÊM
        public TRINHDO Add(TRINHDO td)
        {
            try
            {
                db.TRINHDO.Add(td);
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public TRINHDO Update(TRINHDO td)
        {
            try
            {
                var _td = db.TRINHDO.FirstOrDefault(x => x.ID_TD == td.ID_TD);
                _td.TENTD = td.TENTD;
                db.SaveChanges();
                return td;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idtd)
        {
            try
            {
                var _td = db.TRINHDO.FirstOrDefault(x => x.ID_TD == idtd);
                db.TRINHDO.Remove(_td);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
