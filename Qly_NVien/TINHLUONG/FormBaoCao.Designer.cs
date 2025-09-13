namespace Qly_NVien.TINHLUONG
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            btnThem = new DevExpress.XtraBars.BarButtonItem();
            btnSua = new DevExpress.XtraBars.BarButtonItem();
            btnXoa = new DevExpress.XtraBars.BarButtonItem();
            btnLuu = new DevExpress.XtraBars.BarButtonItem();
            btnHuy = new DevExpress.XtraBars.BarButtonItem();
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
            textBoxNoiDung = new TextBox();
            comboBoxBaoCao = new ComboBox();
            searchLookUpEditNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            TENCV = new DevExpress.XtraGrid.Columns.GridColumn();
            spinEditSoTien = new DevExpress.XtraEditors.SpinEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            ID = new DevExpress.XtraGrid.Columns.GridColumn();
            clHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            TENBC = new DevExpress.XtraGrid.Columns.GridColumn();
            SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            ID_BC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEditNhanVien.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEditSoTien.Properties).BeginInit();
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
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnLuu, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btnHuy, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, btDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
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
            splitContainerControl1.Panel1.Controls.Add(textBoxNoiDung);
            splitContainerControl1.Panel1.Controls.Add(comboBoxBaoCao);
            splitContainerControl1.Panel1.Controls.Add(searchLookUpEditNhanVien);
            splitContainerControl1.Panel1.Controls.Add(spinEditSoTien);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(labelControl4);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1029, 522);
            splitContainerControl1.SplitterPosition = 145;
            splitContainerControl1.TabIndex = 8;
            // 
            // textBoxNoiDung
            // 
            textBoxNoiDung.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNoiDung.Location = new Point(158, 85);
            textBoxNoiDung.Name = "textBoxNoiDung";
            textBoxNoiDung.Size = new Size(621, 26);
            textBoxNoiDung.TabIndex = 5;
            // 
            // comboBoxBaoCao
            // 
            comboBoxBaoCao.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxBaoCao.FormattingEnabled = true;
            comboBoxBaoCao.Location = new Point(442, 29);
            comboBoxBaoCao.Name = "comboBoxBaoCao";
            comboBoxBaoCao.Size = new Size(121, 27);
            comboBoxBaoCao.TabIndex = 4;
            // 
            // searchLookUpEditNhanVien
            // 
            searchLookUpEditNhanVien.Location = new Point(158, 30);
            searchLookUpEditNhanVien.MenuManager = barManager1;
            searchLookUpEditNhanVien.Name = "searchLookUpEditNhanVien";
            searchLookUpEditNhanVien.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLookUpEditNhanVien.Properties.Appearance.Options.UseFont = true;
            searchLookUpEditNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchLookUpEditNhanVien.Properties.PopupView = searchLookUpEdit1View;
            searchLookUpEditNhanVien.Size = new Size(170, 26);
            searchLookUpEditNhanVien.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { MANV, HOTEN, TENCV });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MANV
            // 
            MANV.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MANV.AppearanceHeader.Options.UseFont = true;
            MANV.Caption = "ID";
            MANV.FieldName = "MANV";
            MANV.MaxWidth = 60;
            MANV.MinWidth = 60;
            MANV.Name = "MANV";
            MANV.Visible = true;
            MANV.VisibleIndex = 0;
            MANV.Width = 60;
            // 
            // HOTEN
            // 
            HOTEN.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
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
            // TENCV
            // 
            TENCV.AppearanceHeader.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TENCV.AppearanceHeader.Options.UseFont = true;
            TENCV.Caption = "CHỨC VỤ";
            TENCV.FieldName = "TENCV";
            TENCV.MaxWidth = 100;
            TENCV.MinWidth = 100;
            TENCV.Name = "TENCV";
            TENCV.Visible = true;
            TENCV.VisibleIndex = 2;
            TENCV.Width = 100;
            // 
            // spinEditSoTien
            // 
            spinEditSoTien.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditSoTien.Location = new Point(670, 28);
            spinEditSoTien.MenuManager = barManager1;
            spinEditSoTien.Name = "spinEditSoTien";
            spinEditSoTien.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spinEditSoTien.Properties.Appearance.Options.UseFont = true;
            spinEditSoTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditSoTien.Size = new Size(109, 26);
            spinEditSoTien.TabIndex = 2;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(361, 33);
            labelControl3.Margin = new Padding(4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(74, 23);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Báo cáo:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(599, 31);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(64, 23);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Số tiền:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(67, 85);
            labelControl4.Margin = new Padding(4);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(84, 23);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Nội dung:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(61, 33);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(90, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Nhân viên:";
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
            gcDanhSach.Size = new Size(1029, 367);
            gcDanhSach.TabIndex = 0;
            gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDanhSach });
            // 
            // gvDanhSach
            // 
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { DELETED_BY, ID, clHOTEN, TENBC, SOTIEN, NOIDUNG, IDNV, ID_BC });
            gvDanhSach.DetailHeight = 443;
            gvDanhSach.GridControl = gcDanhSach;
            gvDanhSach.Name = "gvDanhSach";
            gvDanhSach.OptionsEditForm.PopupEditFormWidth = 1029;
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            gvDanhSach.CustomDrawCell += gvDanhSach_CustomDrawCell;
            gvDanhSach.Click += gvDanhSach_Click;
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
            ID.Width = 80;
            // 
            // clHOTEN
            // 
            clHOTEN.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clHOTEN.AppearanceHeader.Options.UseFont = true;
            clHOTEN.Caption = "HỌ TÊN ";
            clHOTEN.FieldName = "HOTEN";
            clHOTEN.MaxWidth = 200;
            clHOTEN.MinWidth = 200;
            clHOTEN.Name = "clHOTEN";
            clHOTEN.Visible = true;
            clHOTEN.VisibleIndex = 1;
            clHOTEN.Width = 200;
            // 
            // TENBC
            // 
            TENBC.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            TENBC.AppearanceHeader.Options.UseFont = true;
            TENBC.Caption = "LOẠI BÁO CÁO";
            TENBC.FieldName = "TENBC";
            TENBC.MaxWidth = 100;
            TENBC.MinWidth = 100;
            TENBC.Name = "TENBC";
            TENBC.Visible = true;
            TENBC.VisibleIndex = 2;
            TENBC.Width = 100;
            // 
            // SOTIEN
            // 
            SOTIEN.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            SOTIEN.AppearanceHeader.Options.UseFont = true;
            SOTIEN.Caption = "SỐ TIỀN";
            SOTIEN.FieldName = "SOTIEN";
            SOTIEN.MaxWidth = 100;
            SOTIEN.MinWidth = 100;
            SOTIEN.Name = "SOTIEN";
            SOTIEN.Visible = true;
            SOTIEN.VisibleIndex = 3;
            SOTIEN.Width = 100;
            // 
            // NOIDUNG
            // 
            NOIDUNG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            NOIDUNG.AppearanceHeader.Options.UseFont = true;
            NOIDUNG.Caption = "NỘI DUNG";
            NOIDUNG.FieldName = "NOIDUNG";
            NOIDUNG.MaxWidth = 300;
            NOIDUNG.MinWidth = 300;
            NOIDUNG.Name = "NOIDUNG";
            NOIDUNG.Visible = true;
            NOIDUNG.VisibleIndex = 4;
            NOIDUNG.Width = 300;
            // 
            // IDNV
            // 
            IDNV.Caption = "MANV";
            IDNV.FieldName = "IDNV";
            IDNV.MaxWidth = 50;
            IDNV.MinWidth = 50;
            IDNV.Name = "IDNV";
            IDNV.Width = 50;
            // 
            // ID_BC
            // 
            ID_BC.Caption = "ID_BC";
            ID_BC.FieldName = "ID_BC";
            ID_BC.MaxWidth = 50;
            ID_BC.MinWidth = 50;
            ID_BC.Name = "ID_BC";
            ID_BC.Width = 50;
            // 
            // FormBaoCao
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
            Margin = new Padding(4);
            Name = "FormBaoCao";
            Text = "BÁO CÁO";
            Load += FormBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchLookUpEditNhanVien.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEditSoTien.Properties).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit spinEditSoTien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn clHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TENBC;
        private ComboBox comboBoxBaoCao;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private TextBox textBoxNoiDung;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TENCV;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn ID_BC;
    }
}