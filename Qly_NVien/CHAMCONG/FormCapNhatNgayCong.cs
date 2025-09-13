using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NVien.CHAMCONG
{
    public partial class FormCapNhatNgayCong : Form
    {
        public FormCapNhatNgayCong()
        {
            InitializeComponent();
        }

        //BIẾN
        public int _manv, _makycong;
        public string _hoten, _ngay;
        private void FormCapNhatNgayCong_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_manv.ToString()+" - "+_makycong.ToString()+" - "+_ngay);
        }
    }
}
