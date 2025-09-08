using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUCVU_bs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        //
        public CHUCVU getItem(int idcv)
        {
            return db.CHUCVUs.FirstOrDefault(x => x.ID_CV == idcv);
        }

        //LẤY VỀ DANH SÁCH
        public List<CHUCVU> getList()
        {
            return db.CHUCVUs.ToList();
        }

        //THÊM
        public CHUCVU Add(CHUCVU cv)
        {
            try
            {
                db.CHUCVUs.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public CHUCVU Update(CHUCVU cv)
        {
            try
            {
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.ID_CV == cv.ID_CV);
                _cv.TENCV = cv.TENCV;
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idcv)
        {
            try
            {
                var _cv = db.CHUCVUs.FirstOrDefault(x => x.ID_CV == idcv);
                db.CHUCVUs.Remove(_cv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
