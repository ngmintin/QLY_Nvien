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
            Qly_NvienEntities1 db = new Qly_NvienEntities1();

            //
            public PHONGBAN getItem(int idpb)
            {
                return db.PHONGBANs.FirstOrDefault(x => x.ID_PB == idpb);
            }

            //LẤY VỀ DANH SÁCH
            public List<PHONGBAN> getList()
            {
                return db.PHONGBANs.ToList();
            }

            //THÊM
            public PHONGBAN Add(PHONGBAN pb)
            {
                try
                {
                    db.PHONGBANs.Add(pb);
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
                    var _pb = db.PHONGBANs.FirstOrDefault(x => x.ID_PB == pb.ID_PB);
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
                    var _pb = db.PHONGBANs.FirstOrDefault(x => x.ID_PB == idpb);
                    db.PHONGBANs.Remove(_pb);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }
    }
