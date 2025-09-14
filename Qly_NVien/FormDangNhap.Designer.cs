namespace Qly_NVien
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            txbTaiKhoan = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            txbMatKhau = new TextBox();
            cbGhiNho = new CheckBox();
            buttonDangNhap = new Button();
            label2 = new Label();
            llDangKy = new LinkLabel();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pictureBoxAn = new PictureBox();
            pictureBoxHien = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHien).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.9624F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35.0375938F));
            tableLayoutPanel1.Size = new Size(560, 628);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.LOGO2024_FULL_CL;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 401);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 407);
            label1.Name = "label1";
            label1.Size = new Size(554, 221);
            label1.TabIndex = 1;
            label1.Text = "TRUNG TÂM ĐÀO TẠO BÓNG RỔ\r\n\r\nHÀNG ĐẦU TẠI HÀ NỘI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.61326F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.38674F));
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(txbTaiKhoan, 1, 0);
            tableLayoutPanel2.Location = new Point(648, 244);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(362, 37);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Profile;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.Dock = DockStyle.Fill;
            txbTaiKhoan.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbTaiKhoan.ForeColor = Color.Gray;
            txbTaiKhoan.Location = new Point(74, 3);
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(285, 29);
            txbTaiKhoan.TabIndex = 0;
            txbTaiKhoan.Text = "Tên đăng nhập";
            txbTaiKhoan.Enter += txbTaiKhoan_Enter;
            txbTaiKhoan.Leave += txbTaiKhoan_Leave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.61326F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.38674F));
            tableLayoutPanel3.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel3.Controls.Add(txbMatKhau, 1, 0);
            tableLayoutPanel3.Location = new Point(648, 296);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(362, 37);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Unlock;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txbMatKhau
            // 
            txbMatKhau.Dock = DockStyle.Fill;
            txbMatKhau.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbMatKhau.ForeColor = Color.Gray;
            txbMatKhau.Location = new Point(74, 3);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.PasswordChar = '*';
            txbMatKhau.Size = new Size(285, 29);
            txbMatKhau.TabIndex = 0;
            txbMatKhau.Text = "Mật khẩu";
            txbMatKhau.Enter += txbMatKhau_Enter;
            txbMatKhau.Leave += txbMatKhau_Leave;
            // 
            // cbGhiNho
            // 
            cbGhiNho.AutoSize = true;
            cbGhiNho.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbGhiNho.Location = new Point(722, 363);
            cbGhiNho.Name = "cbGhiNho";
            cbGhiNho.Size = new Size(78, 21);
            cbGhiNho.TabIndex = 2;
            cbGhiNho.Text = "Ghi nhớ";
            cbGhiNho.UseVisualStyleBackColor = true;
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDangNhap.Location = new Point(788, 457);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new Size(145, 64);
            buttonDangNhap.TabIndex = 4;
            buttonDangNhap.Text = "ĐĂNG NHẬP";
            buttonDangNhap.UseVisualStyleBackColor = true;
            buttonDangNhap.Click += buttonDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(747, 547);
            label2.Name = "label2";
            label2.Size = new Size(156, 19);
            label2.TabIndex = 5;
            label2.Text = "Bạn chưa có tài khoản ?";
            // 
            // llDangKy
            // 
            llDangKy.AutoSize = true;
            llDangKy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llDangKy.Location = new Point(900, 547);
            llDangKy.Name = "llDangKy";
            llDangKy.Size = new Size(64, 19);
            llDangKy.TabIndex = 5;
            llDangKy.TabStop = true;
            llDangKy.Text = "Đăng ký ";
            llDangKy.LinkClicked += llDangKy_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.dribble;
            pictureBox4.Location = new Point(761, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(178, 129);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            label3.Location = new Point(747, 28);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 7;
            label3.Text = "XIN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            label4.Location = new Point(900, 126);
            label4.Name = "label4";
            label4.Size = new Size(95, 31);
            label4.TabIndex = 8;
            label4.Text = "CHÀO";
            // 
            // pictureBoxAn
            // 
            pictureBoxAn.Image = Properties.Resources.hide;
            pictureBoxAn.Location = new Point(1031, 299);
            pictureBoxAn.Name = "pictureBoxAn";
            pictureBoxAn.Size = new Size(38, 31);
            pictureBoxAn.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAn.TabIndex = 9;
            pictureBoxAn.TabStop = false;
            pictureBoxAn.Click += pictureBoxAn_Click;
            // 
            // pictureBoxHien
            // 
            pictureBoxHien.Image = Properties.Resources.view;
            pictureBoxHien.Location = new Point(1031, 299);
            pictureBoxHien.Name = "pictureBoxHien";
            pictureBoxHien.Size = new Size(38, 31);
            pictureBoxHien.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHien.TabIndex = 10;
            pictureBoxHien.TabStop = false;
            pictureBoxHien.Click += pictureBoxHien_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1106, 608);
            Controls.Add(pictureBoxAn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(llDangKy);
            Controls.Add(label2);
            Controls.Add(buttonDangNhap);
            Controls.Add(cbGhiNho);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBoxHien);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txbTaiKhoan;
        private TextBox txbMatKhau;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox cbGhiNho;
        private Button buttonDangNhap;
        private Label label2;
        private LinkLabel llDangKy;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private PictureBox pictureBoxAn;
        private PictureBox pictureBoxHien;
    }
}
