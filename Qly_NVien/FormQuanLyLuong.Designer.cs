namespace Qly_NVien
{
    partial class FormQuanLyLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyLuong));
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
            spinEditHSLMoi = new DevExpress.XtraEditors.SpinEdit();
            spinEditHSLHienTai = new DevExpress.XtraEditors.SpinEdit();
            dateTimePickerNgayLenLuong = new DateTimePicker();
            dateTimePickerNgayKy = new DateTimePicker();
            searchLookUpEditHopDong = new DevExpress.XtraEditors.SearchLookUpEdit();
            searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumnHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            textEditNhanVien = new DevExpress.XtraEditors.TextEdit();
            textEditGhiChu = new DevExpress.XtraEditors.TextEdit();
            textEditSoQD = new DevExpress.XtraEditors.TextEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            SOQD = new DevExpress.XtraGrid.Columns.GridColumn();
            MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            NGAYLENLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            HESOLUONGHIENTAI = new DevExpress.XtraGrid.Columns.GridColumn();
            HESOLUONGMOI = new DevExpress.XtraGrid.Columns.GridColumn();
            GHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spinEditHSLMoi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEditHSLHienTai.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEditHopDong.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditNhanVien.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditGhiChu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditSoQD.Properties).BeginInit();
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
            barManager1.MaxItemId = 306;
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
            splitContainerControl1.Panel1.Controls.Add(spinEditHSLMoi);
            splitContainerControl1.Panel1.Controls.Add(spinEditHSLHienTai);
            splitContainerControl1.Panel1.Controls.Add(dateTimePickerNgayLenLuong);
            splitContainerControl1.Panel1.Controls.Add(dateTimePickerNgayKy);
            splitContainerControl1.Panel1.Controls.Add(searchLookUpEditHopDong);
            splitContainerControl1.Panel1.Controls.Add(textEditNhanVien);
            splitContainerControl1.Panel1.Controls.Add(textEditGhiChu);
            splitContainerControl1.Panel1.Controls.Add(textEditSoQD);
            splitContainerControl1.Panel1.Controls.Add(labelControl7);
            splitContainerControl1.Panel1.Controls.Add(labelControl8);
            splitContainerControl1.Panel1.Controls.Add(labelControl5);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(labelControl3);
            splitContainerControl1.Panel1.Controls.Add(labelControl6);
            splitContainerControl1.Panel1.Controls.Add(labelControl4);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1029, 522);
            splitContainerControl1.SplitterPosition = 191;
            splitContainerControl1.TabIndex = 9;
            // 
            // spinEditHSLMoi
            // 
            spinEditHSLMoi.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditHSLMoi.Location = new Point(736, 83);
            spinEditHSLMoi.MenuManager = barManager1;
            spinEditHSLMoi.Name = "spinEditHSLMoi";
            spinEditHSLMoi.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            spinEditHSLMoi.Properties.Appearance.Options.UseFont = true;
            spinEditHSLMoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditHSLMoi.Size = new Size(111, 26);
            spinEditHSLMoi.TabIndex = 7;
            // 
            // spinEditHSLHienTai
            // 
            spinEditHSLHienTai.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditHSLHienTai.Location = new Point(459, 83);
            spinEditHSLHienTai.MenuManager = barManager1;
            spinEditHSLHienTai.Name = "spinEditHSLHienTai";
            spinEditHSLHienTai.Properties.Appearance.Font = new Font("Times New Roman", 12F);
            spinEditHSLHienTai.Properties.Appearance.Options.UseFont = true;
            spinEditHSLHienTai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditHSLHienTai.Properties.ReadOnly = true;
            spinEditHSLHienTai.Size = new Size(111, 26);
            spinEditHSLHienTai.TabIndex = 6;
            // 
            // dateTimePickerNgayLenLuong
            // 
            dateTimePickerNgayLenLuong.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayLenLuong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayLenLuong.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayLenLuong.Location = new Point(736, 34);
            dateTimePickerNgayLenLuong.Name = "dateTimePickerNgayLenLuong";
            dateTimePickerNgayLenLuong.Size = new Size(111, 26);
            dateTimePickerNgayLenLuong.TabIndex = 5;
            // 
            // dateTimePickerNgayKy
            // 
            dateTimePickerNgayKy.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgayKy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerNgayKy.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgayKy.Location = new Point(459, 34);
            dateTimePickerNgayKy.Name = "dateTimePickerNgayKy";
            dateTimePickerNgayKy.Size = new Size(111, 26);
            dateTimePickerNgayKy.TabIndex = 5;
            // 
            // searchLookUpEditHopDong
            // 
            searchLookUpEditHopDong.Location = new Point(138, 83);
            searchLookUpEditHopDong.MenuManager = barManager1;
            searchLookUpEditHopDong.Name = "searchLookUpEditHopDong";
            searchLookUpEditHopDong.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchLookUpEditHopDong.Properties.Appearance.Options.UseFont = true;
            searchLookUpEditHopDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            searchLookUpEditHopDong.Properties.PopupView = searchLookUpEdit1View;
            searchLookUpEditHopDong.Size = new Size(172, 26);
            searchLookUpEditHopDong.TabIndex = 4;
            searchLookUpEditHopDong.EditValueChanged += searchLookUpEditHopDong_EditValueChanged;
            // 
            // searchLookUpEdit1View
            // 
            searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnMANV, gridColumnHOTEN });
            searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnMANV
            // 
            gridColumnMANV.AppearanceHeader.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridColumnMANV.AppearanceHeader.Options.UseFont = true;
            gridColumnMANV.Caption = "MÃ NHÂN VIÊN";
            gridColumnMANV.FieldName = "MANV";
            gridColumnMANV.MaxWidth = 50;
            gridColumnMANV.MinWidth = 50;
            gridColumnMANV.Name = "gridColumnMANV";
            gridColumnMANV.Visible = true;
            gridColumnMANV.VisibleIndex = 0;
            gridColumnMANV.Width = 50;
            // 
            // gridColumnHOTEN
            // 
            gridColumnHOTEN.AppearanceHeader.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gridColumnHOTEN.AppearanceHeader.Options.UseFont = true;
            gridColumnHOTEN.Caption = "HỌ TÊN";
            gridColumnHOTEN.FieldName = "HOTEN";
            gridColumnHOTEN.MaxWidth = 250;
            gridColumnHOTEN.MinWidth = 250;
            gridColumnHOTEN.Name = "gridColumnHOTEN";
            gridColumnHOTEN.Visible = true;
            gridColumnHOTEN.VisibleIndex = 1;
            gridColumnHOTEN.Width = 250;
            // 
            // textEditNhanVien
            // 
            textEditNhanVien.Location = new Point(670, 129);
            textEditNhanVien.Name = "textEditNhanVien";
            textEditNhanVien.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditNhanVien.Properties.Appearance.Options.UseFont = true;
            textEditNhanVien.Size = new Size(177, 26);
            textEditNhanVien.TabIndex = 1;
            // 
            // textEditGhiChu
            // 
            textEditGhiChu.Location = new Point(138, 129);
            textEditGhiChu.Name = "textEditGhiChu";
            textEditGhiChu.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditGhiChu.Properties.Appearance.Options.UseFont = true;
            textEditGhiChu.Size = new Size(432, 26);
            textEditGhiChu.TabIndex = 1;
            // 
            // textEditSoQD
            // 
            textEditSoQD.Location = new Point(138, 34);
            textEditSoQD.MenuManager = barManager1;
            textEditSoQD.Name = "textEditSoQD";
            textEditSoQD.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditSoQD.Properties.Appearance.Options.UseFont = true;
            textEditSoQD.Properties.ReadOnly = true;
            textEditSoQD.Size = new Size(120, 26);
            textEditSoQD.TabIndex = 1;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Location = new Point(349, 86);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(95, 21);
            labelControl7.TabIndex = 0;
            labelControl7.Text = "HSL hiện tại:";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl8.Appearance.Options.UseFont = true;
            labelControl8.Location = new Point(659, 86);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(71, 21);
            labelControl8.TabIndex = 0;
            labelControl8.Text = "HSL mới:";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(586, 132);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(78, 21);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "Nhân viên:";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(52, 86);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(80, 21);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Hợp đồng:";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(69, 131);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(63, 21);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Ghi chú:";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Location = new Point(614, 36);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(116, 21);
            labelControl6.TabIndex = 0;
            labelControl6.Text = "Ngày lên lương:";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(378, 39);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(66, 21);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Ngày ký:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 14.25F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(30, 36);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(102, 21);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Số hợp đồng:";
            // 
            // gcDanhSach
            // 
            gcDanhSach.Dock = DockStyle.Fill;
            gcDanhSach.EmbeddedNavigator.Margin = new Padding(4);
            gcDanhSach.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gcDanhSach.Location = new Point(0, 0);
            gcDanhSach.MainView = gvDanhSach;
            gcDanhSach.Margin = new Padding(4);
            gcDanhSach.MenuManager = barManager1;
            gcDanhSach.Name = "gcDanhSach";
            gcDanhSach.Size = new Size(1029, 321);
            gcDanhSach.TabIndex = 0;
            gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDanhSach });
            // 
            // gvDanhSach
            // 
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { DELETED_BY, SOQD, MANV, HOTEN, NGAYKY, NGAYLENLUONG, HESOLUONGHIENTAI, HESOLUONGMOI, GHICHU });
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
            DELETED_BY.Caption = "DELETED_BY <>";
            DELETED_BY.FieldName = "DELETED_BY";
            DELETED_BY.MaxWidth = 50;
            DELETED_BY.MinWidth = 50;
            DELETED_BY.Name = "DELETED_BY";
            DELETED_BY.Visible = true;
            DELETED_BY.VisibleIndex = 0;
            DELETED_BY.Width = 50;
            // 
            // SOQD
            // 
            SOQD.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SOQD.AppearanceHeader.Options.UseFont = true;
            SOQD.Caption = "SỐ QUYẾT ĐỊNH";
            SOQD.FieldName = "SOQD";
            SOQD.MaxWidth = 100;
            SOQD.MinWidth = 100;
            SOQD.Name = "SOQD";
            SOQD.Visible = true;
            SOQD.VisibleIndex = 1;
            SOQD.Width = 100;
            // 
            // MANV
            // 
            MANV.Caption = "MANV";
            MANV.FieldName = "MANV";
            MANV.Name = "MANV";
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
            HOTEN.VisibleIndex = 6;
            HOTEN.Width = 200;
            // 
            // NGAYKY
            // 
            NGAYKY.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NGAYKY.AppearanceHeader.Options.UseFont = true;
            NGAYKY.Caption = "NGÀY KÝ";
            NGAYKY.FieldName = "NGAYKY";
            NGAYKY.MaxWidth = 100;
            NGAYKY.MinWidth = 100;
            NGAYKY.Name = "NGAYKY";
            NGAYKY.Visible = true;
            NGAYKY.VisibleIndex = 2;
            NGAYKY.Width = 100;
            // 
            // NGAYLENLUONG
            // 
            NGAYLENLUONG.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NGAYLENLUONG.AppearanceHeader.Options.UseFont = true;
            NGAYLENLUONG.Caption = "NGÀY LÊN LƯƠNG";
            NGAYLENLUONG.FieldName = "NGAYLENLUONG";
            NGAYLENLUONG.MaxWidth = 100;
            NGAYLENLUONG.MinWidth = 100;
            NGAYLENLUONG.Name = "NGAYLENLUONG";
            NGAYLENLUONG.Visible = true;
            NGAYLENLUONG.VisibleIndex = 3;
            NGAYLENLUONG.Width = 100;
            // 
            // HESOLUONGHIENTAI
            // 
            HESOLUONGHIENTAI.Caption = "HSL HIỆN TẠI";
            HESOLUONGHIENTAI.FieldName = "HESOLUONGHIENTAI";
            HESOLUONGHIENTAI.MaxWidth = 70;
            HESOLUONGHIENTAI.MinWidth = 70;
            HESOLUONGHIENTAI.Name = "HESOLUONGHIENTAI";
            HESOLUONGHIENTAI.Visible = true;
            HESOLUONGHIENTAI.VisibleIndex = 4;
            HESOLUONGHIENTAI.Width = 70;
            // 
            // HESOLUONGMOI
            // 
            HESOLUONGMOI.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            HESOLUONGMOI.AppearanceHeader.Options.UseFont = true;
            HESOLUONGMOI.Caption = "HSL MỚI";
            HESOLUONGMOI.FieldName = "HESOLUONGMOI";
            HESOLUONGMOI.MaxWidth = 70;
            HESOLUONGMOI.MinWidth = 70;
            HESOLUONGMOI.Name = "HESOLUONGMOI";
            HESOLUONGMOI.Visible = true;
            HESOLUONGMOI.VisibleIndex = 5;
            HESOLUONGMOI.Width = 70;
            // 
            // GHICHU
            // 
            GHICHU.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            GHICHU.AppearanceHeader.Options.UseFont = true;
            GHICHU.Caption = "GHI CHÚ";
            GHICHU.FieldName = "GHICHU";
            GHICHU.MaxWidth = 300;
            GHICHU.MinWidth = 300;
            GHICHU.Name = "GHICHU";
            GHICHU.Visible = true;
            GHICHU.VisibleIndex = 7;
            GHICHU.Width = 300;
            // 
            // FormQuanLyLuong
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
            Name = "FormQuanLyLuong";
            Text = "DANH SÁCH NÂNG LƯƠNG";
            Load += FormQuanLyLuong_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spinEditHSLMoi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEditHSLHienTai.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEditHopDong.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditNhanVien.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditGhiChu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditSoQD.Properties).EndInit();
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
        private DateTimePicker dateTimePickerNgayLenLuong;
        private DateTimePicker dateTimePickerNgayKy;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditHopDong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMANV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHOTEN;
        private DevExpress.XtraEditors.TextEdit textEditGhiChu;
        private DevExpress.XtraEditors.TextEdit textEditSoQD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn SOQD;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKY;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLENLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONGMOI;
        private DevExpress.XtraGrid.Columns.GridColumn GHICHU;
        private DevExpress.XtraEditors.TextEdit textEditNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditHSLMoi;
        private DevExpress.XtraEditors.SpinEdit spinEditHSLHienTai;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONGHIENTAI;
    }
}