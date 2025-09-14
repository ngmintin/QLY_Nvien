using DataLayer;
using BCrypt.Net;

namespace Qly_NVien

{
    public partial class FormDangNhap : Form
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        //CHỮ CHÌM
        //TÀI KHOẢN
        private void txbTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "Tên đăng nhập")
            {
                txbTaiKhoan.Text = "";
                txbTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txbTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txbTaiKhoan.Text == "")
            {
                txbTaiKhoan.Text = "Tên đăng nhập";
                txbTaiKhoan.ForeColor = Color.Gray;
            }
        }

        //MẬT KHẨU
        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "Mật khẩu")
            {
                txbMatKhau.Text = "";
                txbMatKhau.ForeColor = Color.Black;
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txbMatKhau.Text == "")
            {
                txbMatKhau.Text = "Mật khẩu";
                txbMatKhau.ForeColor = Color.Gray;
            }
        }

        //LIÊN KẾT FORM ĐĂNG KÝ
        private void llDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            dk.Show();
            this.Hide();
        }

        //ẨN HIỆN MẬT KHẨU
        private void pictureBoxHien_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '\0')
            {
                pictureBoxAn.BringToFront();
                txbMatKhau.PasswordChar = '*';
            }
        }

        private void pictureBoxAn_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '*')
            {
                pictureBoxHien.BringToFront();
                txbMatKhau.PasswordChar = '\0';
            }
        }

        //LIÊN KẾT FORM QUÊN MẬT KHẨU
        private void llQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau qmk = new FormQuenMatKhau();
            qmk.Show();
            this.Hide();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txbTaiKhoan.Text.Trim();
            string matKhau = txbMatKhau.Text.Trim();

            if (taiKhoan == "Tên đăng nhập" || taiKhoan == "")
            {
                MessageBox.Show("Tài khoản không được để trống!");
                return;
            }

            if (matKhau == "Mật khẩu" || matKhau == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            var nv = db.NHANVIEN.SingleOrDefault(x => x.TAIKHOAN == taiKhoan);
            if (nv == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                return;
            }

            if (!BCrypt.Net.BCrypt.Verify(matKhau, nv.MATKHAU))
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return;
            }

            // Đăng nhập thành công
            MessageBox.Show($"Xin chào {nv.HOTEN}!");
            FormTrangChu main = new FormTrangChu();
            main.Show();
            this.Hide();
        }
    }
}
