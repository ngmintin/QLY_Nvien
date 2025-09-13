namespace Qly_NVien.CHAMCONG
{
    partial class FormCapNhatNgayCong
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
            btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Appearance.Options.UseFont = true;
            btnCapNhat.Location = new Point(279, 294);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(75, 23);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // FormCapNhatNgayCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 446);
            Controls.Add(btnCapNhat);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormCapNhatNgayCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CẬP NHẬT NGÀY CÔNG";
            Load += FormCapNhatNgayCong_Load;
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
    }
}