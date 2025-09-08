namespace Qly_NVien
{
    partial class FormCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCongTy));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnThem = new DevExpress.XtraBars.BarButtonItem();
            btnSua = new DevExpress.XtraBars.BarButtonItem();
            btnXoa = new DevExpress.XtraBars.BarButtonItem();
            btnLuu = new DevExpress.XtraBars.BarButtonItem();
            btnHuy = new DevExpress.XtraBars.BarButtonItem();
            btIn = new DevExpress.XtraBars.BarButtonItem();
            btDong = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            btnDong = new DevExpress.XtraBars.BarButtonItem();
            btnIn = new DevExpress.XtraBars.BarButtonItem();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            textEditDiaChi = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            textEditSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEditTen = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditEmail = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID_CTY = new DevExpress.XtraGrid.Columns.GridColumn();
            TENCTY = new DevExpress.XtraGrid.Columns.GridColumn();
            EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            SĐT = new DevExpress.XtraGrid.Columns.GridColumn();
            DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditDiaChi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditSoDienThoai.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditTen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditEmail.Properties).BeginInit();
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
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnDong, btnIn, btIn, btDong });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 9;
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
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            btnThem.Caption = "Thêm";
            btnThem.Id = 0;
            btnThem.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnThem.ImageOptions.SvgImage");
            btnThem.Name = "btnThem";
            btnThem.ItemClick += btnThem_ItemClick;
            // 
            // btnSua
            // 
            btnSua.Caption = "Sửa";
            btnSua.Id = 1;
            btnSua.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSua.ImageOptions.SvgImage");
            btnSua.Name = "btnSua";
            btnSua.ItemClick += btnSua_ItemClick;
            // 
            // btnXoa
            // 
            btnXoa.Caption = "Xóa";
            btnXoa.Id = 2;
            btnXoa.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnXoa.ImageOptions.SvgImage");
            btnXoa.Name = "btnXoa";
            btnXoa.ItemClick += btnXoa_ItemClick;
            // 
            // btnLuu
            // 
            btnLuu.Caption = "Lưu";
            btnLuu.Id = 3;
            btnLuu.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnLuu.ImageOptions.SvgImage");
            btnLuu.Name = "btnLuu";
            btnLuu.ItemClick += btnLuu_ItemClick;
            // 
            // btnHuy
            // 
            btnHuy.Caption = "Hủy";
            btnHuy.Id = 4;
            btnHuy.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnHuy.ImageOptions.SvgImage");
            btnHuy.Name = "btnHuy";
            btnHuy.ItemClick += btnHuy_ItemClick;
            // 
            // btIn
            // 
            btIn.Caption = "In";
            btIn.Id = 7;
            btIn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btIn.ImageOptions.SvgImage");
            btIn.Name = "btIn";
            btIn.ItemClick += btIn_ItemClick;
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
            barDockControlTop.Margin = new Padding(4, 4, 4, 4);
            barDockControlTop.Size = new Size(1272, 28);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 712);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(4, 4, 4, 4);
            barDockControlBottom.Size = new Size(1272, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 28);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(4, 4, 4, 4);
            barDockControlLeft.Size = new Size(0, 684);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1272, 28);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(4, 4, 4, 4);
            barDockControlRight.Size = new Size(0, 684);
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
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new Point(0, 28);
            splitContainerControl1.Margin = new Padding(4, 4, 4, 4);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(textEditDiaChi);
            splitContainerControl1.Panel1.Controls.Add(labelControl4);
            splitContainerControl1.Panel1.Controls.Add(textEditSoDienThoai);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(textEditTen);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(textEditEmail);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1272, 684);
            splitContainerControl1.SplitterPosition = 160;
            splitContainerControl1.TabIndex = 5;
            // 
            // textEditDiaChi
            // 
            textEditDiaChi.Location = new Point(697, 96);
            textEditDiaChi.Margin = new Padding(4, 4, 4, 4);
            textEditDiaChi.Name = "textEditDiaChi";
            textEditDiaChi.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            textEditDiaChi.Properties.Appearance.Options.UseFont = true;
            textEditDiaChi.Size = new Size(334, 26);
            textEditDiaChi.TabIndex = 1;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(630, 101);
            labelControl4.Margin = new Padding(4, 4, 4, 4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(59, 21);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Địa chỉ:";
            // 
            // textEditSoDienThoai
            // 
            textEditSoDienThoai.Location = new Point(697, 34);
            textEditSoDienThoai.Margin = new Padding(4, 4, 4, 4);
            textEditSoDienThoai.Name = "textEditSoDienThoai";
            textEditSoDienThoai.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            textEditSoDienThoai.Properties.Appearance.Options.UseFont = true;
            textEditSoDienThoai.Size = new Size(334, 26);
            textEditSoDienThoai.TabIndex = 1;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(587, 37);
            labelControl3.Margin = new Padding(4, 4, 4, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(102, 21);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Số điện thoại:";
            // 
            // textEditTen
            // 
            textEditTen.Location = new Point(161, 37);
            textEditTen.Margin = new Padding(4, 4, 4, 4);
            textEditTen.Name = "textEditTen";
            textEditTen.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            textEditTen.Properties.Appearance.Options.UseFont = true;
            textEditTen.Size = new Size(334, 26);
            textEditTen.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(59, 40);
            labelControl2.Margin = new Padding(4, 4, 4, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(94, 21);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Tên công ty:";
            // 
            // textEditEmail
            // 
            textEditEmail.Location = new Point(161, 99);
            textEditEmail.Margin = new Padding(4, 4, 4, 4);
            textEditEmail.MenuManager = barManager1;
            textEditEmail.Name = "textEditEmail";
            textEditEmail.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            textEditEmail.Properties.Appearance.Options.UseFont = true;
            textEditEmail.Size = new Size(334, 26);
            textEditEmail.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(108, 101);
            labelControl1.Margin = new Padding(4, 4, 4, 4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(45, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Email:";
            // 
            // gcDanhSach
            // 
            gcDanhSach.Dock = DockStyle.Fill;
            gcDanhSach.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
            gcDanhSach.Location = new Point(0, 0);
            gcDanhSach.MainView = gvDanhSach;
            gcDanhSach.Margin = new Padding(4, 4, 4, 4);
            gcDanhSach.MenuManager = barManager1;
            gcDanhSach.Name = "gcDanhSach";
            gcDanhSach.Size = new Size(1272, 514);
            gcDanhSach.TabIndex = 0;
            gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDanhSach });
            // 
            // gvDanhSach
            // 
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID_CTY, TENCTY, EMAIL, SĐT, DIACHI });
            gvDanhSach.DetailHeight = 443;
            gvDanhSach.GridControl = gcDanhSach;
            gvDanhSach.Name = "gvDanhSach";
            gvDanhSach.OptionsEditForm.PopupEditFormWidth = 1029;
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            gvDanhSach.Click += gvDanhSach_Click;
            // 
            // ID_CTY
            // 
            ID_CTY.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_CTY.AppearanceHeader.Options.UseFont = true;
            ID_CTY.Caption = "ID";
            ID_CTY.FieldName = "ID_CTY";
            ID_CTY.MaxWidth = 64;
            ID_CTY.MinWidth = 64;
            ID_CTY.Name = "ID_CTY";
            ID_CTY.Visible = true;
            ID_CTY.VisibleIndex = 0;
            ID_CTY.Width = 64;
            // 
            // TENCTY
            // 
            TENCTY.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TENCTY.AppearanceHeader.Options.UseFont = true;
            TENCTY.Caption = "CÔNG TY";
            TENCTY.FieldName = "TENCTY";
            TENCTY.MaxWidth = 257;
            TENCTY.MinWidth = 257;
            TENCTY.Name = "TENCTY";
            TENCTY.Visible = true;
            TENCTY.VisibleIndex = 1;
            TENCTY.Width = 257;
            // 
            // EMAIL
            // 
            EMAIL.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EMAIL.AppearanceHeader.Options.UseFont = true;
            EMAIL.Caption = "EMAIL";
            EMAIL.FieldName = "EMAIL";
            EMAIL.MaxWidth = 257;
            EMAIL.MinWidth = 257;
            EMAIL.Name = "EMAIL";
            EMAIL.Visible = true;
            EMAIL.VisibleIndex = 2;
            EMAIL.Width = 257;
            // 
            // SĐT
            // 
            SĐT.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SĐT.AppearanceHeader.Options.UseFont = true;
            SĐT.Caption = "SĐT";
            SĐT.FieldName = "SĐT";
            SĐT.MaxWidth = 167;
            SĐT.MinWidth = 167;
            SĐT.Name = "SĐT";
            SĐT.Visible = true;
            SĐT.VisibleIndex = 3;
            SĐT.Width = 167;
            // 
            // DIACHI
            // 
            DIACHI.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DIACHI.AppearanceHeader.Options.UseFont = true;
            DIACHI.Caption = "ĐỊA CHỈ";
            DIACHI.FieldName = "DIACHI";
            DIACHI.MaxWidth = 386;
            DIACHI.MinWidth = 386;
            DIACHI.Name = "DIACHI";
            DIACHI.Visible = true;
            DIACHI.VisibleIndex = 4;
            DIACHI.Width = 386;
            // 
            // FormCongTy
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 732);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormCongTy";
            Text = "CÔNG TY";
            Load += FormCongTy_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEditDiaChi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditSoDienThoai.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditTen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gcDanhSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btIn;
        private DevExpress.XtraBars.BarButtonItem btDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID_CTY;
        private DevExpress.XtraGrid.Columns.GridColumn TENCTY;
        private DevExpress.XtraEditors.TextEdit textEditDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditTen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn SĐT;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
    }
}