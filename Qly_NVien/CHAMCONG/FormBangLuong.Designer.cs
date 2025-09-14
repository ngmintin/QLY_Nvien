namespace Qly_NVien.CHAMCONG
{
    partial class FormBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangLuong));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemIn = new DevExpress.XtraBars.BarButtonItem();
            btDong = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            btnSua = new DevExpress.XtraBars.BarButtonItem();
            btnXoa = new DevExpress.XtraBars.BarButtonItem();
            btnLuu = new DevExpress.XtraBars.BarButtonItem();
            btnHuy = new DevExpress.XtraBars.BarButtonItem();
            btnDong = new DevExpress.XtraBars.BarButtonItem();
            btnIn = new DevExpress.XtraBars.BarButtonItem();
            btIn = new DevExpress.XtraBars.BarButtonItem();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            btnXemBangLuong = new DevExpress.XtraEditors.SimpleButton();
            comboBoxThang = new ComboBox();
            comboBoxNam = new ComboBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID = new DevExpress.XtraGrid.Columns.GridColumn();
            MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            BAOCAO = new DevExpress.XtraGrid.Columns.GridColumn();
            THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gcDanhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvDanhSach).BeginInit();
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
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnTinhLuong, btnSua, btnXoa, btnLuu, btnHuy, btnDong, btnIn, btIn, btDong, barButtonItemIn });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 10;
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
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, barButtonItemIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Caption = "Tính lương";
            btnTinhLuong.Id = 0;
            btnTinhLuong.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnTinhLuong.ImageOptions.SvgImage");
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.ItemClick += btnTinhLuong_ItemClick;
            // 
            // barButtonItemIn
            // 
            barButtonItemIn.Caption = "In";
            barButtonItemIn.Id = 9;
            barButtonItemIn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItemIn.Name = "barButtonItemIn";
            barButtonItemIn.ItemClick += barButtonItemIn_ItemClick;
            // 
            // btDong
            // 
            btDong.Caption = "Đóng";
            btDong.Id = 8;
            btDong.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btDong.ImageOptions.SvgImage");
            btDong.Name = "btDong";
            btDong.ItemClick += btDong_ItemClick;
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
            barDockControlTop.Size = new Size(914, 26);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 490);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(4);
            barDockControlBottom.Size = new Size(914, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 26);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(4);
            barDockControlLeft.Size = new Size(0, 464);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(914, 26);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(4);
            barDockControlRight.Size = new Size(0, 464);
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
            splitContainerControl1.Location = new Point(0, 26);
            splitContainerControl1.Margin = new Padding(4);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(btnXemBangLuong);
            splitContainerControl1.Panel1.Controls.Add(comboBoxThang);
            splitContainerControl1.Panel1.Controls.Add(comboBoxNam);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(914, 464);
            splitContainerControl1.SplitterPosition = 145;
            splitContainerControl1.TabIndex = 8;
            // 
            // btnXemBangLuong
            // 
            btnXemBangLuong.Appearance.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXemBangLuong.Appearance.Options.UseFont = true;
            btnXemBangLuong.ImageOptions.Image = (Image)resources.GetObject("btnXemBangLuong.ImageOptions.Image");
            btnXemBangLuong.Location = new Point(370, 73);
            btnXemBangLuong.Name = "btnXemBangLuong";
            btnXemBangLuong.Size = new Size(132, 34);
            btnXemBangLuong.TabIndex = 2;
            btnXemBangLuong.Text = "Xem bảng lương";
            btnXemBangLuong.Click += btnXemBangLuong_Click;
            // 
            // comboBoxThang
            // 
            comboBoxThang.Font = new Font("Times New Roman", 12F);
            comboBoxThang.FormattingEnabled = true;
            comboBoxThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxThang.Location = new Point(158, 77);
            comboBoxThang.Name = "comboBoxThang";
            comboBoxThang.Size = new Size(160, 27);
            comboBoxThang.TabIndex = 1;
            // 
            // comboBoxNam
            // 
            comboBoxNam.Font = new Font("Times New Roman", 12F);
            comboBoxNam.FormattingEnabled = true;
            comboBoxNam.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
            comboBoxNam.Location = new Point(158, 26);
            comboBoxNam.Name = "comboBoxNam";
            comboBoxNam.Size = new Size(160, 27);
            comboBoxNam.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(94, 77);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 23);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Tháng:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(105, 30);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(46, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Năm:";
            // 
            // gcDanhSach
            // 
            gcDanhSach.Dock = DockStyle.Fill;
            gcDanhSach.EmbeddedNavigator.Margin = new Padding(4);
            gcDanhSach.Location = new Point(0, 0);
            gcDanhSach.MainView = gvDanhSach;
            gcDanhSach.Margin = new Padding(4);
            gcDanhSach.MenuManager = barManager1;
            gcDanhSach.Name = "gcDanhSach";
            gcDanhSach.Size = new Size(914, 309);
            gcDanhSach.TabIndex = 0;
            gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDanhSach });
            // 
            // gvDanhSach
            // 
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID, MAKYCONG, HOTEN, NGAYCONGTRONGTHANG, IDNV, NGAYPHEP, NGAYCHUNHAT, NGAYTHUONG, BAOCAO, THUCLANH });
            gvDanhSach.DetailHeight = 443;
            gvDanhSach.GridControl = gcDanhSach;
            gvDanhSach.Name = "gvDanhSach";
            gvDanhSach.OptionsEditForm.PopupEditFormWidth = 1029;
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            ID.Caption = "ID";
            ID.FieldName = "ID";
            ID.MaxWidth = 50;
            ID.MinWidth = 50;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // MAKYCONG
            // 
            MAKYCONG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MAKYCONG.AppearanceHeader.Options.UseFont = true;
            MAKYCONG.Caption = "KỲ CÔNG";
            MAKYCONG.FieldName = "MAKYCONG";
            MAKYCONG.MaxWidth = 100;
            MAKYCONG.MinWidth = 100;
            MAKYCONG.Name = "MAKYCONG";
            MAKYCONG.Visible = true;
            MAKYCONG.VisibleIndex = 0;
            MAKYCONG.Width = 100;
            // 
            // HOTEN
            // 
            HOTEN.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HOTEN.AppearanceHeader.Options.UseFont = true;
            HOTEN.Caption = "HỌ TÊN";
            HOTEN.FieldName = "HOTEN";
            HOTEN.MaxWidth = 200;
            HOTEN.MinWidth = 200;
            HOTEN.Name = "HOTEN";
            HOTEN.Visible = true;
            HOTEN.VisibleIndex = 1;
            HOTEN.Width = 200;
            // 
            // NGAYCONGTRONGTHANG
            // 
            NGAYCONGTRONGTHANG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYCONGTRONGTHANG.AppearanceHeader.Options.UseFont = true;
            NGAYCONGTRONGTHANG.Caption = "NGÀY CÔNG ";
            NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            NGAYCONGTRONGTHANG.MaxWidth = 100;
            NGAYCONGTRONGTHANG.MinWidth = 100;
            NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            NGAYCONGTRONGTHANG.Visible = true;
            NGAYCONGTRONGTHANG.VisibleIndex = 2;
            NGAYCONGTRONGTHANG.Width = 100;
            // 
            // IDNV
            // 
            IDNV.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            IDNV.AppearanceHeader.Options.UseFont = true;
            IDNV.Caption = "MANV";
            IDNV.FieldName = "IDNV";
            IDNV.MaxWidth = 50;
            IDNV.MinWidth = 50;
            IDNV.Name = "IDNV";
            IDNV.Width = 50;
            // 
            // NGAYPHEP
            // 
            NGAYPHEP.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYPHEP.AppearanceHeader.Options.UseFont = true;
            NGAYPHEP.Caption = "NGÀY PHÉP";
            NGAYPHEP.FieldName = "NGAYPHEP";
            NGAYPHEP.MaxWidth = 100;
            NGAYPHEP.MinWidth = 100;
            NGAYPHEP.Name = "NGAYPHEP";
            NGAYPHEP.Visible = true;
            NGAYPHEP.VisibleIndex = 3;
            NGAYPHEP.Width = 100;
            // 
            // NGAYCHUNHAT
            // 
            NGAYCHUNHAT.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYCHUNHAT.AppearanceHeader.Options.UseFont = true;
            NGAYCHUNHAT.Caption = "CHỦ NHẬT";
            NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            NGAYCHUNHAT.MaxWidth = 100;
            NGAYCHUNHAT.MinWidth = 100;
            NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            NGAYCHUNHAT.Visible = true;
            NGAYCHUNHAT.VisibleIndex = 4;
            NGAYCHUNHAT.Width = 100;
            // 
            // NGAYTHUONG
            // 
            NGAYTHUONG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NGAYTHUONG.AppearanceHeader.Options.UseFont = true;
            NGAYTHUONG.Caption = "NGÀY THƯỜNG";
            NGAYTHUONG.FieldName = "NGAYTHUONG";
            NGAYTHUONG.MaxWidth = 100;
            NGAYTHUONG.MinWidth = 100;
            NGAYTHUONG.Name = "NGAYTHUONG";
            NGAYTHUONG.Visible = true;
            NGAYTHUONG.VisibleIndex = 5;
            NGAYTHUONG.Width = 100;
            // 
            // BAOCAO
            // 
            BAOCAO.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAOCAO.AppearanceHeader.Options.UseFont = true;
            BAOCAO.Caption = "BÁO CÁO";
            BAOCAO.DisplayFormat.FormatString = "n0";
            BAOCAO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            BAOCAO.FieldName = "BAOCAO";
            BAOCAO.MaxWidth = 100;
            BAOCAO.MinWidth = 100;
            BAOCAO.Name = "BAOCAO";
            BAOCAO.Visible = true;
            BAOCAO.VisibleIndex = 6;
            BAOCAO.Width = 100;
            // 
            // THUCLANH
            // 
            THUCLANH.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            THUCLANH.AppearanceHeader.Options.UseFont = true;
            THUCLANH.Caption = "THỰC LĨNH";
            THUCLANH.DisplayFormat.FormatString = "n0";
            THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            THUCLANH.FieldName = "THUCLANH";
            THUCLANH.MaxWidth = 100;
            THUCLANH.MinWidth = 100;
            THUCLANH.Name = "THUCLANH";
            THUCLANH.Visible = true;
            THUCLANH.VisibleIndex = 7;
            THUCLANH.Width = 100;
            // 
            // FormBangLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormBangLuong";
            Text = "BẢNG LƯƠNG";
            Load += FormBangLuong_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gcDanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private ComboBox comboBoxThang;
        private ComboBox comboBoxNam;
        private DevExpress.XtraEditors.SimpleButton btnXemBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraGrid.Columns.GridColumn BAOCAO;
        private DevExpress.XtraBars.BarButtonItem barButtonItemIn;
    }
}