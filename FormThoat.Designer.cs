namespace Qly_NVien
{
    partial class FormThoat
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
            label1 = new Label();
            buttonCo = new Button();
            buttonKhong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 64);
            label1.Name = "label1";
            label1.Size = new Size(432, 31);
            label1.TabIndex = 0;
            label1.Text = "Bạn có chắc chắn muốn thoát không ?";
            // 
            // buttonCo
            // 
            buttonCo.Font = new Font("Times New Roman", 15.75F);
            buttonCo.Location = new Point(135, 141);
            buttonCo.Name = "buttonCo";
            buttonCo.Size = new Size(95, 45);
            buttonCo.TabIndex = 1;
            buttonCo.Text = "Có";
            buttonCo.UseVisualStyleBackColor = true;
            // 
            // buttonKhong
            // 
            buttonKhong.Font = new Font("Times New Roman", 15.75F);
            buttonKhong.Location = new Point(332, 141);
            buttonKhong.Name = "buttonKhong";
            buttonKhong.Size = new Size(95, 45);
            buttonKhong.TabIndex = 2;
            buttonKhong.Text = "Không";
            buttonKhong.UseVisualStyleBackColor = true;
            // 
            // FormThoat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 266);
            Controls.Add(buttonKhong);
            Controls.Add(buttonCo);
            Controls.Add(label1);
            Name = "FormThoat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThoat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCo;
        private Button buttonKhong;
    }
}