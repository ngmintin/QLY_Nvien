using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class PHONGBAN_bs
    {
            Qly_NvienEntities2 db = new Qly_NvienEntities2();

            //
            public PHONGBAN getItem(int idpb)
            {
                return db.PHONGBAN.FirstOrDefault(x => x.ID_PB == idpb);
            }

            //LẤY VỀ DANH SÁCH
            public List<PHONGBAN> getList()
            {
                return db.PHONGBAN.ToList();
            }

            //THÊM
            public PHONGBAN Add(PHONGBAN pb)
            {
                try
                {
                    db.PHONGBAN.Add(pb);
                    db.SaveChanges();
                    return pb;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }

            //SỬA
            public PHONGBAN Update(PHONGBAN pb)
            {
                try
                {
                    var _pb = db.PHONGBAN.FirstOrDefault(x => x.ID_PB == pb.ID_PB);
                    _pb.TENPB = pb.TENPB;
                    db.SaveChanges();
                    return pb;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }

            //XÓA
            public void Delete(int idpb)
            {
                try
                {
                    var _pb = db.PHONGBAN.FirstOrDefault(x => x.ID_PB == idpb);
                    db.PHONGBAN.Remove(_pb);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }
    }
