namespace Qly_NVien
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBoxHo = new TextBox();
            textBoxTen = new TextBox();
            textBoxTenDangNhap = new TextBox();
            textBoxMatKhau = new TextBox();
            textBoxXacNhan = new TextBox();
            textBoxEmail = new TextBox();
            button1 = new Button();
            LLQuayLai = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sport;
            pictureBox1.Location = new Point(238, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 6);
            tableLayoutPanel1.Controls.Add(label5, 0, 8);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxTenDangNhap, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxMatKhau, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxXacNhan, 0, 7);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 0, 9);
            tableLayoutPanel1.Location = new Point(153, 202);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(390, 407);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 14.25F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(384, 40);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(384, 40);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Times New Roman", 14.25F);
            label3.Location = new Point(3, 160);
            label3.Name = "label3";
            label3.Size = new Size(384, 40);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Times New Roman", 14.25F);
            label4.Location = new Point(3, 240);
            label4.Name = "label4";
            label4.Size = new Size(384, 40);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận lại mật khẩu: ";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 14.25F);
            label5.Location = new Point(3, 320);
            label5.Name = "label5";
            label5.Size = new Size(384, 40);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4895821F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.9375F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5729179F));
            tableLayoutPanel2.Controls.Add(textBoxHo, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxTen, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 43);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(384, 34);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // textBoxHo
            // 
            textBoxHo.Dock = DockStyle.Fill;
            textBoxHo.Font = new Font("Times New Roman", 12F);
            textBoxHo.ForeColor = Color.Gray;
            textBoxHo.Location = new Point(3, 3);
            textBoxHo.Name = "textBoxHo";
            textBoxHo.Size = new Size(161, 26);
            textBoxHo.TabIndex = 0;
            textBoxHo.Text = "Họ";
            textBoxHo.Enter += textBoxHo_Enter;
            textBoxHo.Leave += textBoxHo_Leave;
            // 
            // textBoxTen
            // 
            textBoxTen.Dock = DockStyle.Fill;
            textBoxTen.Font = new Font("Times New Roman", 12F);
            textBoxTen.ForeColor = Color.Gray;
            textBoxTen.Location = new Point(212, 3);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(169, 26);
            textBoxTen.TabIndex = 1;
            textBoxTen.Text = "Tên";
            textBoxTen.Enter += textBoxTen_Enter;
            textBoxTen.Leave += textBoxTen_Leave;
            // 
            // textBoxTenDangNhap
            // 
            textBoxTenDangNhap.Dock = DockStyle.Fill;
            textBoxTenDangNhap.Font = new Font("Times New Roman", 12F);
            textBoxTenDangNhap.ForeColor = Color.Gray;
            textBoxTenDangNhap.Location = new Point(3, 123);
            textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            textBoxTenDangNhap.Size = new Size(384, 26);
            textBoxTenDangNhap.TabIndex = 6;
            textBoxTenDangNhap.Text = "Tên đăng nhập";
            textBoxTenDangNhap.Enter += textBoxTenDangNhap_Enter;
            textBoxTenDangNhap.Leave += textBoxTenDangNhap_Leave;
            // 
            // textBoxMatKhau
            // 
            textBoxMatKhau.Dock = DockStyle.Fill;
            textBoxMatKhau.Font = new Font("Times New Roman", 12F);
            textBoxMatKhau.ForeColor = Color.Gray;
            textBoxMatKhau.Location = new Point(3, 203);
            textBoxMatKhau.Name = "textBoxMatKhau";
            textBoxMatKhau.Size = new Size(384, 26);
            textBoxMatKhau.TabIndex = 7;
            textBoxMatKhau.Text = "Mật khẩu";
            textBoxMatKhau.Enter += textBoxMatKhau_Enter;
            textBoxMatKhau.Leave += textBoxMatKhau_Leave;
            // 
            // textBoxXacNhan
            // 
            textBoxXacNhan.Dock = DockStyle.Fill;
            textBoxXacNhan.Font = new Font("Times New Roman", 12F);
            textBoxXacNhan.ForeColor = Color.Gray;
            textBoxXacNhan.Location = new Point(3, 283);
            textBoxXacNhan.Name = "textBoxXacNhan";
            textBoxXacNhan.Size = new Size(384, 26);
            textBoxXacNhan.TabIndex = 8;
            textBoxXacNhan.Text = "Xác nhận";
            textBoxXacNhan.Enter += textBoxXacNhan_Enter;
            textBoxXacNhan.Leave += textBoxXacNhan_Leave;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Fill;
            textBoxEmail.Font = new Font("Times New Roman", 12F);
            textBoxEmail.ForeColor = Color.Gray;
            textBoxEmail.Location = new Point(3, 363);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(384, 26);
            textBoxEmail.TabIndex = 9;
            textBoxEmail.Text = "example@gmail.com";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(282, 642);
            button1.Name = "button1";
            button1.Size = new Size(142, 68);
            button1.TabIndex = 2;
            button1.Text = "Hoàn tất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LLQuayLai
            // 
            LLQuayLai.AutoSize = true;
            LLQuayLai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LLQuayLai.Location = new Point(563, 741);
            LLQuayLai.Name = "LLQuayLai";
            LLQuayLai.Size = new Size(125, 19);
            LLQuayLai.TabIndex = 3;
            LLQuayLai.TabStop = true;
            LLQuayLai.Text = "Quay lại đăng nhập";
            LLQuayLai.LinkClicked += LLQuayLai_LinkClicked;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 778);
            Controls.Add(LLQuayLai);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxHo;
        private TextBox textBoxTen;
        private TextBox textBoxTenDangNhap;
        private TextBox textBoxMatKhau;
        private TextBox textBoxXacNhan;
        private TextBox textBoxEmail;
        private Button button1;
        private LinkLabel LLQuayLai;
    }
}