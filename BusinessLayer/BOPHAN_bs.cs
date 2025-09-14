using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BOPHAN_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        //
        public BOPHAN getItem(int idbp)
        {
            return db.BOPHAN.FirstOrDefault(x => x.ID_BP == idbp);
        }

        //LẤY VỀ DANH SÁCH
        public List<BOPHAN> getList()
        {
            return db.BOPHAN.ToList();
        }

        //THÊM
        public BOPHAN Add(BOPHAN bp)
        {
            try
            {
                db.BOPHAN.Add(bp);
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public BOPHAN Update(BOPHAN bp)
        {
            try
            {
                var _bp = db.BOPHAN.FirstOrDefault(x => x.ID_BP == bp.ID_BP);
                _bp.TENBP = bp.TENBP;
                db.SaveChanges();
                return bp;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idbp)
        {
            try
            {
                var _bp = db.BOPHAN.FirstOrDefault(x => x.ID_BP == idbp);
                db.BOPHAN.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
