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
    public partial class FormSuKien : Form
    {
        Qly_NvienEntities2 db = new Qly_NvienEntities2();
        public FormSuKien()
        {
            InitializeComponent();
        }

        //GÁN LINK 
        private void Link1_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/photo/?fbid=1231377425682989&set=pb.100064322304465.-2207520000";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void Link2_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/photo/?fbid=1215542843933114&set=a.472477128239693";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void Link3_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/photo.php?fbid=1223193943168004&set=pb.100064322304465.-2207520000&type=3";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        //ĐỔI MÀU CHỮ
        private void Link1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightBlue;
            tableLayoutPanel2.BackColor = Color.LightBlue;
        }

        private void Link1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            tableLayoutPanel2.BackColor = Color.White;
        }

        private void Link2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.LightBlue;
            tableLayoutPanel3.BackColor = Color.LightBlue;
        }

        private void Link2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
            tableLayoutPanel3.BackColor = Color.White;
        }

        private void Link3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightBlue;
            tableLayoutPanel4.BackColor = Color.LightBlue;
        }

        private void Link3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
            tableLayoutPanel4.BackColor = Color.White;
        }
    }
}
