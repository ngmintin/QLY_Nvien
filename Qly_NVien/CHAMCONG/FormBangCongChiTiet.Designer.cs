namespace Qly_NVien.CHAMCONG
{
    partial class FormBangCongChiTiet
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangCongChiTiet));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnPhatSinh = new DevExpress.XtraBars.BarButtonItem();
            btnSua = new DevExpress.XtraBars.BarButtonItem();
            btnXoa = new DevExpress.XtraBars.BarButtonItem();
            btnLuu = new DevExpress.XtraBars.BarButtonItem();
            btnHuy = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemXemBangCong = new DevExpress.XtraBars.BarButtonItem();
            btDong = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            btnDong = new DevExpress.XtraBars.BarButtonItem();
            btnIn = new DevExpress.XtraBars.BarButtonItem();
            btIn = new DevExpress.XtraBars.BarButtonItem();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            comboBoxThang = new ComboBox();
            comboBoxNam = new ComboBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcBangCongChiTiet = new DevExpress.XtraGrid.GridControl();
            gvBangCongChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            ID = new DevExpress.XtraGrid.Columns.GridColumn();
            MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            NAM = new DevExpress.XtraGrid.Columns.GridColumn();
            KHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYTINHCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            MACTY = new DevExpress.XtraGrid.Columns.GridColumn();
            TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            checkBoxKhoa = new CheckBox();
            checkBoxTrangThai = new CheckBox();
            barButtonItemLamMoi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcBangCongChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBangCongChiTiet).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnPhatSinh, btnSua, btnXoa, btnLuu, btnHuy, btnDong, btnIn, btIn, btDong, barButtonItemXemBangCong, barButtonItemLamMoi });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 11;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarAppearance.Normal.FontSizeDelta = 4;
            bar2.BarAppearance.Normal.Options.UseFont = true;
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnPhatSinh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barButtonItemLamMoi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barButtonItemXemBangCong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnPhatSinh
            // 
            btnPhatSinh.Caption = "Phát sinh";
            btnPhatSinh.Id = 0;
            btnPhatSinh.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnThem.ImageOptions.SvgImage");
            btnPhatSinh.Name = "btnPhatSinh";
            // 
            // btnSua
            // 
            btnSua.Caption = "Sửa";
            btnSua.Id = 1;
            btnSua.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSua.ImageOptions.SvgImage");
            btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            btnXoa.Caption = "Xóa";
            btnXoa.Id = 2;
            btnXoa.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnXoa.ImageOptions.SvgImage");
            btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            btnLuu.Caption = "Lưu";
            btnLuu.Id = 3;
            btnLuu.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnLuu.ImageOptions.SvgImage");
            btnLuu.Name = "btnLuu";
            // 
            // btnHuy
            // 
            btnHuy.Caption = "Hủy";
            btnHuy.Id = 4;
            btnHuy.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnHuy.ImageOptions.SvgImage");
            btnHuy.Name = "btnHuy";
            // 
            // barButtonItemXemBangCong
            // 
            barButtonItemXemBangCong.Caption = "Xem bảng công";
            barButtonItemXemBangCong.Id = 9;
            barButtonItemXemBangCong.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemXemBangCong.ImageOptions.SvgImage");
            barButtonItemXemBangCong.Name = "barButtonItemXemBangCong";
            // 
            // btDong
            // 
            btDong.Caption = "Đóng";
            btDong.Id = 8;
            btDong.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btDong.ImageOptions.SvgImage");
            btDong.Name = "btDong";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Margin = new Padding(4);
            barDockControlTop.Size = new Size(1029, 28);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 550);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(4);
            barDockControlBottom.Size = new Size(1029, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 28);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(4);
            barDockControlLeft.Size = new Size(0, 522);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1029, 28);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(4);
            barDockControlRight.Size = new Size(0, 522);
            // 
            // btnDong
            // 
            btnDong.Caption = "Đóng";
            btnDong.Id = 5;
            btnDong.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDong.ImageOptions.SvgImage");
            btnDong.Name = "btnDong";
            // 
            // btnIn
            // 
            btnIn.Caption = "In";
            btnIn.Id = 6;
            btnIn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnIn.ImageOptions.SvgImage");
            btnIn.Name = "btnIn";
            // 
            // btIn
            // 
            btIn.Caption = "In";
            btIn.Id = 7;
            btIn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btIn.ImageOptions.SvgImage");
            btIn.Name = "btIn";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new Point(0, 28);
            splitContainerControl1.Margin = new Padding(4);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(checkBoxKhoa);
            splitContainerControl1.Panel1.Controls.Add(checkBoxTrangThai);
            splitContainerControl1.Panel1.Controls.Add(comboBoxThang);
            splitContainerControl1.Panel1.Controls.Add(comboBoxNam);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcBangCongChiTiet);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1029, 522);
            splitContainerControl1.SplitterPosition = 145;
            splitContainerControl1.TabIndex = 14;
            // 
            // comboBoxThang
            // 
            comboBoxThang.Font = new Font("Tahoma", 15.75F);
            comboBoxThang.FormattingEnabled = true;
            comboBoxThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxThang.Location = new Point(114, 81);
            comboBoxThang.Name = "comboBoxThang";
            comboBoxThang.Size = new Size(191, 33);
            comboBoxThang.TabIndex = 1;
            // 
            // comboBoxNam
            // 
            comboBoxNam.Font = new Font("Tahoma", 15.75F);
            comboBoxNam.FormattingEnabled = true;
            comboBoxNam.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            comboBoxNam.Location = new Point(114, 26);
            comboBoxNam.Name = "comboBoxNam";
            comboBoxNam.Size = new Size(191, 33);
            comboBoxNam.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 15.75F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(50, 87);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 23);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Tháng:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 15.75F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(61, 31);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(46, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Năm:";
            // 
            // gcBangCongChiTiet
            // 
            gcBangCongChiTiet.Dock = DockStyle.Fill;
            gcBangCongChiTiet.EmbeddedNavigator.Margin = new Padding(4);
            gcBangCongChiTiet.Location = new Point(0, 0);
            gcBangCongChiTiet.MainView = gvBangCongChiTiet;
            gcBangCongChiTiet.Margin = new Padding(4);
            gcBangCongChiTiet.MenuManager = barManager1;
            gcBangCongChiTiet.Name = "gcBangCongChiTiet";
            gcBangCongChiTiet.Size = new Size(1029, 367);
            gcBangCongChiTiet.TabIndex = 0;
            gcBangCongChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvBangCongChiTiet });
            // 
            // gvBangCongChiTiet
            // 
            gvBangCongChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { DELETED_BY, ID, MAKYCONG, NAM, KHOA, NGAYTINHCONG, NGAYCONGTRONGTHANG, MACTY, TRANGTHAI });
            gvBangCongChiTiet.DetailHeight = 443;
            gvBangCongChiTiet.GridControl = gcBangCongChiTiet;
            gvBangCongChiTiet.Name = "gvBangCongChiTiet";
            gvBangCongChiTiet.OptionsEditForm.PopupEditFormWidth = 1029;
            gvBangCongChiTiet.OptionsView.ShowGroupPanel = false;
            // 
            // DELETED_BY
            // 
            DELETED_BY.FieldName = "DELETED_BY";
            DELETED_BY.MaxWidth = 50;
            DELETED_BY.MinWidth = 50;
            DELETED_BY.Name = "DELETED_BY";
            DELETED_BY.Visible = true;
            DELETED_BY.VisibleIndex = 0;
            DELETED_BY.Width = 50;
            // 
            // ID
            // 
            ID.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.AppearanceHeader.Options.UseFont = true;
            ID.Caption = "ID";
            ID.FieldName = "ID";
            ID.MaxWidth = 80;
            ID.MinWidth = 80;
            ID.Name = "ID";
            ID.Visible = true;
            ID.VisibleIndex = 1;
            ID.Width = 80;
            // 
            // MAKYCONG
            // 
            MAKYCONG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MAKYCONG.AppearanceHeader.Options.UseFont = true;
            MAKYCONG.Caption = "MÃ KỲ CÔNG";
            MAKYCONG.FieldName = "MAKYCONG";
            MAKYCONG.MaxWidth = 100;
            MAKYCONG.MinWidth = 100;
            MAKYCONG.Name = "MAKYCONG";
            MAKYCONG.Visible = true;
            MAKYCONG.VisibleIndex = 2;
            MAKYCONG.Width = 100;
            // 
            // NAM
            // 
            NAM.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NAM.AppearanceHeader.Options.UseFont = true;
            NAM.Caption = "NĂM";
            NAM.FieldName = "NAM";
            NAM.MaxWidth = 80;
            NAM.MinWidth = 80;
            NAM.Name = "NAM";
            NAM.Visible = true;
            NAM.VisibleIndex = 3;
            NAM.Width = 80;
            // 
            // KHOA
            // 
            KHOA.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            KHOA.AppearanceHeader.Options.UseFont = true;
            KHOA.Caption = "KHÓA";
            KHOA.FieldName = "KHOA";
            KHOA.MaxWidth = 50;
            KHOA.MinWidth = 50;
            KHOA.Name = "KHOA";
            KHOA.Visible = true;
            KHOA.VisibleIndex = 4;
            KHOA.Width = 50;
            // 
            // NGAYTINHCONG
            // 
            NGAYTINHCONG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYTINHCONG.AppearanceHeader.Options.UseFont = true;
            NGAYTINHCONG.Caption = "NGÀY TÍNH CÔNG";
            NGAYTINHCONG.FieldName = "NGAYTINHCONG";
            NGAYTINHCONG.MaxWidth = 150;
            NGAYTINHCONG.MinWidth = 150;
            NGAYTINHCONG.Name = "NGAYTINHCONG";
            NGAYTINHCONG.Visible = true;
            NGAYTINHCONG.VisibleIndex = 5;
            NGAYTINHCONG.Width = 150;
            // 
            // NGAYCONGTRONGTHANG
            // 
            NGAYCONGTRONGTHANG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG TRONG THÁNG";
            NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            NGAYCONGTRONGTHANG.MaxWidth = 50;
            NGAYCONGTRONGTHANG.MinWidth = 50;
            NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            NGAYCONGTRONGTHANG.Visible = true;
            NGAYCONGTRONGTHANG.VisibleIndex = 6;
            NGAYCONGTRONGTHANG.Width = 50;
            // 
            // MACTY
            // 
            MACTY.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            MACTY.AppearanceHeader.Options.UseFont = true;
            MACTY.Caption = "MACTY";
            MACTY.FieldName = "MACTY";
            MACTY.MaxWidth = 50;
            MACTY.MinWidth = 50;
            MACTY.Name = "MACTY";
            MACTY.Width = 50;
            // 
            // TRANGTHAI
            // 
            TRANGTHAI.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            TRANGTHAI.AppearanceHeader.Options.UseFont = true;
            TRANGTHAI.Caption = "TRẠNG THÁI";
            TRANGTHAI.FieldName = "TRANGTHAI";
            TRANGTHAI.MaxWidth = 200;
            TRANGTHAI.MinWidth = 200;
            TRANGTHAI.Name = "TRANGTHAI";
            TRANGTHAI.Visible = true;
            TRANGTHAI.VisibleIndex = 7;
            TRANGTHAI.Width = 200;
            // 
            // checkBoxKhoa
            // 
            checkBoxKhoa.AutoSize = true;
            checkBoxKhoa.Font = new Font("Times New Roman", 15.75F);
            checkBoxKhoa.Location = new Point(378, 83);
            checkBoxKhoa.Name = "checkBoxKhoa";
            checkBoxKhoa.Size = new Size(74, 27);
            checkBoxKhoa.TabIndex = 2;
            checkBoxKhoa.Text = "Khóa";
            checkBoxKhoa.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrangThai
            // 
            checkBoxTrangThai.AutoSize = true;
            checkBoxTrangThai.Font = new Font("Times New Roman", 15.75F);
            checkBoxTrangThai.Location = new Point(378, 30);
            checkBoxTrangThai.Name = "checkBoxTrangThai";
            checkBoxTrangThai.Size = new Size(112, 27);
            checkBoxTrangThai.TabIndex = 2;
            checkBoxTrangThai.Text = "Trạng thái";
            checkBoxTrangThai.UseVisualStyleBackColor = true;
            // 
            // barButtonItemLamMoi
            // 
            barButtonItemLamMoi.Caption = "Làm mới";
            barButtonItemLamMoi.Id = 10;
            barButtonItemLamMoi.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItemLamMoi.ImageOptions.SvgImage");
            barButtonItemLamMoi.Name = "barButtonItemLamMoi";
            // 
            // FormBangCongChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBangCongChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BẢNG CÔNG CHI TIẾT";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcBangCongChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBangCongChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnPhatSinh;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonItemXemBangCong;
        private DevExpress.XtraBars.BarButtonItem btDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btIn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private CheckBox checkBoxKhoa;
        private CheckBox checkBoxTrangThai;
        private ComboBox comboBoxThang;
        private ComboBox comboBoxNam;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcBangCongChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangCongChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn NAM;
        private DevExpress.XtraGrid.Columns.GridColumn KHOA;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTINHCONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn MACTY;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraBars.BarButtonItem barButtonItemLamMoi;
    }
}