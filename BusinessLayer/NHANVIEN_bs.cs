using BusinessLayer.DTO_bs;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class NHANVIEN_bs
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();

        //
        private string GetNameOrDefault<T>(T entity, Func<T, string> selector, string defaultValue = "") where T : class
        {
            return entity != null ? selector(entity) : defaultValue;
        }

        public NHANVIEN getItem(int idnv)
        {
            return db.NHANVIEN.FirstOrDefault(x => x.MANV == idnv);
        }

        public NHANVIEN_dto getItemFull(int id)
        {
            var item = db.NHANVIEN.FirstOrDefault(x => x.MANV == id);
            if (item == null) return null;

            return MapToDto(item);
        }

        //LẤY VỀ DANH SÁCH
        public List<NHANVIEN> getList()
        {
            return db.NHANVIEN.ToList();
        }

        public List<NHANVIEN_dto> getListFull()
        {
            return db.NHANVIEN
                     .ToList()
                     .Select(item => MapToDto(item))
                     .ToList();
        }

        //THÊM
        public NHANVIEN Add(NHANVIEN nv)
        {
            try
            {
                db.NHANVIEN.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //SỬA
        public NHANVIEN Update(NHANVIEN nv)
        {
            try
            {
                var _nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == nv.MANV);
                if (_nv == null)
                    throw new Exception("Nhân viên không tồn tại!");
                _nv.MANV = nv.MANV;
                _nv.HOTEN = nv.HOTEN;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.SDT = nv.SDT;
                _nv.DIACHI = nv.DIACHI;
                _nv.EMAIL = nv.EMAIL;
                _nv.HINHANH = nv.HINHANH;
                _nv.MATKHAU = nv.MATKHAU;
                _nv.DATHOIVIEC = nv.DATHOIVIEC;
                _nv.ID_PB = nv.ID_PB;
                _nv.ID_BP = nv.ID_BP;
                _nv.ID_CV = nv.ID_CV;
                _nv.ID_TD = nv.ID_TD;
                _nv.ID_CTY = nv.ID_CTY;

                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //XÓA
        public void Delete(int idnv)
        {
            try
            {
                var _nv = db.NHANVIEN.FirstOrDefault(x => x.MANV == idnv);
                if (_nv == null)
                    throw new Exception("Nhân viên không tồn tại!");
                db.NHANVIEN.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        //HÀM LẤY NHÂN VIÊN SINH NHẬT TRONG THÁNG
        public List<NHANVIEN> getSinhNhat()
        {
            return db.NHANVIEN.Where(x => x.NGAYSINH.Value.Month == DateTime.Now.Month).ToList();
        }

        //HÀM ĐĂNG KÝ TÀI KHOẢN CHO NHÂN VIÊN
        public NHANVIEN DangKy(string hoTen, string taiKhoan, string matKhau, string email)
        {
            if (db.NHANVIEN.Any(x => x.TAIKHOAN == taiKhoan))
                throw new Exception("Tài khoản đã tồn tại!");
            if (db.NHANVIEN.Any(x => x.EMAIL == email))
                throw new Exception("Email đã tồn tại!");

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(matKhau);

            NHANVIEN nv = new NHANVIEN
            {
                HOTEN = hoTen,
                TAIKHOAN = taiKhoan,
                MATKHAU = passwordHash,
                EMAIL = email,
                DATHOIVIEC = false
            };

            try
            {
                db.NHANVIEN.Add(nv);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                    foreach (var ve in eve.ValidationErrors)
                        MessageBox.Show($"Property: {ve.PropertyName}, Error: {ve.ErrorMessage}");
                throw;
            }

            return nv;
        }

        public NHANVIEN DangNhap(string taiKhoan, string matKhau)
        {
            var nv = db.NHANVIEN.FirstOrDefault(x => x.TAIKHOAN == taiKhoan);
            if (nv == null) throw new Exception("Tài khoản không tồn tại!");

            bool valid = BCrypt.Net.BCrypt.Verify(matKhau, nv.MATKHAU);
            if (!valid) throw new Exception("Mật khẩu không đúng!");

            return nv;
        }
        private NHANVIEN_dto MapToDto(NHANVIEN item)
        {
            var _nvdto = new NHANVIEN_dto
            {
                MANV = item.MANV,
                HOTEN = item.HOTEN,
                GIOITINH = item.GIOITINH,
                NGAYSINH = item.NGAYSINH,
                SDT = item.SDT,
                DIACHI = item.DIACHI,
                EMAIL = item.EMAIL,
                HINHANH = item.HINHANH,
                DATHOIVIEC = item.DATHOIVIEC,
                TAIKHOAN = item.TAIKHOAN,
                MATKHAU = item.MATKHAU,
                ID_PB = item.ID_PB,
                ID_BP = item.ID_BP,
                ID_CV = item.ID_CV,
                ID_TD = item.ID_TD,
                ID_CTY = item.ID_CTY
            };

            _nvdto.TENPB = GetNameOrDefault(db.PHONGBAN.FirstOrDefault(x => x.ID_PB == item.ID_PB), x => x.TENPB, "Chưa có phòng ban");
            _nvdto.TENBP = GetNameOrDefault(db.BOPHAN.FirstOrDefault(x => x.ID_BP == item.ID_BP), x => x.TENBP, "Chưa có bộ phận");
            _nvdto.TENCV = GetNameOrDefault(db.CHUCVU.FirstOrDefault(x => x.ID_CV == item.ID_CV), x => x.TENCV, "Chưa có chức vụ");
            _nvdto.TENTD = GetNameOrDefault(db.TRINHDO.FirstOrDefault(x => x.ID_TD == item.ID_TD), x => x.TENTD, "Chưa có trình độ");

            return _nvdto;
        }
    }
}