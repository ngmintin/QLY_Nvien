using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICA_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        public LOAICA getItem(int idloaica)
        {
            return db.LOAICAs.FirstOrDefault(x => x.ID_LCA == idloaica);
        }

        public List<LOAICA> getList()
        {
            return db.LOAICAs.ToList();
        }

        //THÊM
        public LOAICA Add(LOAICA lc)
        {
            try
            {
                db.LOAICAs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //CẬP NHẬT
        public LOAICA Update(LOAICA lc)
        {
            try
            {
                var _lc = db.LOAICAs.FirstOrDefault(x => x.ID_LCA == lc.ID_LCA);
                _lc.TENLCA = lc.TENLCA;
                _lc.HESO = lc.HESO;
                _lc.UPDATED_BY = lc.UPDATED_BY;
                _lc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idloaica, int iduser)
        {
                var _lc = db.LOAICAs.FirstOrDefault(x => x.ID_LCA == idloaica);
                _lc.DELETED_BY = iduser;
                _lc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
        }
    }
}
