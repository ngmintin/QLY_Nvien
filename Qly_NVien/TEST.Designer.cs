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
            // TEST
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtten);
            Controls.Add(txtho);
            Controls.Add(label2);
            Controls.Add(ho);
            Name = "TEST";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtten;
        private TextBox txtho;
        private Label label2;
        private Label ho;
    }
}