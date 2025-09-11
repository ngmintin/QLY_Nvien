namespace Qly_NVien
{
    partial class TEST
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
            txtten = new TextBox();
            txtho = new TextBox();
            label2 = new Label();
            ho = new Label();
            textEditNoiDung = new DevExpress.XtraEditors.TextEdit();
            textEditLyDo = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)textEditNoiDung.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditLyDo.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtten
            // 
            txtten.Location = new Point(379, 238);
            txtten.Name = "txtten";
            txtten.Size = new Size(100, 23);
            txtten.TabIndex = 6;
            // 
            // txtho
            // 
            txtho.Location = new Point(379, 189);
            txtho.Name = "txtho";
            txtho.Size = new Size(100, 23);
            txtho.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 246);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 3;
            label2.Text = "tên";
            // 
            // ho
            // 
            ho.AutoSize = true;
            ho.Location = new Point(322, 189);
            ho.Name = "ho";
            ho.Size = new Size(21, 15);
            ho.TabIndex = 4;
            ho.Text = "họ";
            // 
            // textEditNoiDung
            // 
            textEditNoiDung.Location = new Point(109, 233);
            textEditNoiDung.Name = "textEditNoiDung";
            textEditNoiDung.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditNoiDung.Properties.Appearance.Options.UseFont = true;
            textEditNoiDung.Size = new Size(662, 26);
            textEditNoiDung.TabIndex = 9;
            // 
            // textEditLyDo
            // 
            textEditLyDo.Location = new Point(109, 191);
            textEditLyDo.Name = "textEditLyDo";
            textEditLyDo.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditLyDo.Properties.Appearance.Options.UseFont = true;
            textEditLyDo.Size = new Size(662, 26);
            textEditLyDo.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(30, 238);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(73, 21);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Nội dung:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(54, 194);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(49, 21);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Lý do:";
            // 
            // TEST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textEditNoiDung);
            Controls.Add(textEditLyDo);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(txtten);
            Controls.Add(txtho);
            Controls.Add(label2);
            Controls.Add(ho);
            Name = "TEST";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)textEditNoiDung.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditLyDo.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtten;
        private TextBox txtho;
        private Label label2;
        private Label ho;
        private DevExpress.XtraEditors.TextEdit textEditNoiDung;
        private DevExpress.XtraEditors.TextEdit textEditLyDo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}