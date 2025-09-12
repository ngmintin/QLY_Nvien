using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAICONG_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        public LOAICONG getItem(int idloaicong)
        {
            return db.LOAICONGs.FirstOrDefault(x => x.ID_LC == idloaicong);
        }

        public List<LOAICONG> getList()
        {
            return db.LOAICONGs.ToList();
        }

        //THÊM
        public LOAICONG Add(LOAICONG lc)
        {
            try
            {
                db.LOAICONGs.Add(lc);
                db.SaveChanges();
                return lc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //CẬP NHẬT
        public LOAICONG Update(LOAICONG lc)
        {
            try
            {
                var _lc = db.LOAICONGs.FirstOrDefault(x => x.ID_LC == lc.ID_LC);
                _lc.TENLC = lc.TENLC;
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
        public void Delete(int idloaicong, int iduser)
        {
            try
            {
                var _lc = db.LOAICONGs.FirstOrDefault(x => x.ID_LC == idloaicong);
                _lc.DELETED_BY = _lc.DELETED_BY;
                _lc.UPDATED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
