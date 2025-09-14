using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Qly_NVien
{
    public partial class FormDangKy : Form
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();
        public FormDangKy()
        {
            InitializeComponent();
        }

        //CHỮ CHÌM
        private void textBoxHo_Enter(object sender, EventArgs e)                    //HỌ
        {
            if (textBoxHo.Text == "Họ")
            {
                textBoxHo.Text = "";
                textBoxHo.ForeColor = Color.Black;
            }
        }

        private void textBoxHo_Leave(object sender, EventArgs e)
        {
            if (textBoxHo.Text == "")
            {
                textBoxHo.Text = "Họ";
                textBoxHo.ForeColor = Color.Gray;
            }
        }

        private void textBoxTen_Enter(object sender, EventArgs e)                   //TÊN
        {
            if (textBoxTen.Text == "Tên")
            {
                textBoxTen.Text = "";
                textBoxTen.ForeColor = Color.Black;
            }
        }

        private void textBoxTen_Leave(object sender, EventArgs e)
        {
            if (textBoxTen.Text == "")
            {
                textBoxTen.Text = "Tên";
                textBoxTen.ForeColor = Color.Gray;
            }
        }

        private void textBoxTenDangNhap_Enter(object sender, EventArgs e)           //TÊN ĐĂNG NHẬP
        {
            if (textBoxTenDangNhap.Text == "Tên đăng nhập")
            {
                textBoxTenDangNhap.Text = "";
                textBoxTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void textBoxTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "")
            {
                textBoxTenDangNhap.Text = "Tên đăng nhập";
                textBoxTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void textBoxMatKhau_Enter(object sender, EventArgs e)               //MẬT KHẨU
        {
            if (textBoxMatKhau.Text == "Mật khẩu")
            {
                textBoxMatKhau.Text = "";
                textBoxMatKhau.ForeColor = Color.Black;
            }
        }

        private void textBoxMatKhau_Leave(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text == "")
            {
                textBoxMatKhau.Text = "Mật khẩu";
                textBoxMatKhau.ForeColor = Color.Gray;
            }
        }

        private void textBoxXacNhan_Enter(object sender, EventArgs e)           //XÁC NHẬN MẬT KHẨU
        {
            if (textBoxXacNhan.Text == "Xác nhận")
            {
                textBoxXacNhan.Text = "";
                textBoxXacNhan.ForeColor = Color.Black;
            }
        }

        private void textBoxXacNhan_Leave(object sender, EventArgs e)
        {
            if (textBoxXacNhan.Text == "")
            {
                textBoxXacNhan.Text = "Xác nhận";
                textBoxXacNhan.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)         //EMAIL
        {
            if (textBoxEmail.Text == "example@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "example@gmail.com";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        //VỀ FORM ĐĂNG NHẬP
        private void LLQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            dn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ho = textBoxHo.Text.Trim();
                string ten = textBoxTen.Text.Trim();
                string hoTen = ho + " " + ten;
                string taiKhoan = textBoxTenDangNhap.Text.Trim();
                string matKhau = textBoxMatKhau.Text.Trim();
                string xacNhan = textBoxXacNhan.Text.Trim();
                string email = textBoxEmail.Text.Trim();

                if (matKhau != xacNhan)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!");
                    return;
                }

                NHANVIEN_bs bs = new NHANVIEN_bs();
                bs.DangKy(hoTen, taiKhoan, matKhau, email);

                MessageBox.Show("Đăng ký thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
