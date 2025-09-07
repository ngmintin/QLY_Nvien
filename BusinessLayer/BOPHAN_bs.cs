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
        Qly_NvienEntities1 db = new Qly_NvienEntities1();

        //
        public BOPHAN getItem(int idbp)
        {
            return db.BOPHANs.FirstOrDefault(x => x.ID_BP == idbp);
        }

        //LẤY VỀ DANH SÁCH
        public List<BOPHAN> getList()
        {
            return db.BOPHANs.ToList();
        }

        //THÊM
        public BOPHAN Add(BOPHAN bp)
        {
            try
            {
                db.BOPHANs.Add(bp);
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
                var _bp = db.BOPHANs.FirstOrDefault(x => x.ID_BP == bp.ID_BP);
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
                var _bp = db.BOPHANs.FirstOrDefault(x => x.ID_BP == idbp);
                db.BOPHANs.Remove(_bp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
