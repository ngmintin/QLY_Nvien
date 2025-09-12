namespace Qly_NVien.CHAMCONG
{
    partial class FormLoaiCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiCong));
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
            spinEditHeSo = new DevExpress.XtraEditors.SpinEdit();
            textEditLoaiCong = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            ID_LC = new DevExpress.XtraGrid.Columns.GridColumn();
            TENLC = new DevExpress.XtraGrid.Columns.GridColumn();
            HESO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spinEditHeSo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditLoaiCong.Properties).BeginInit();
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
            splitContainerControl1.Panel1.Controls.Add(spinEditHeSo);
            splitContainerControl1.Panel1.Controls.Add(textEditLoaiCong);
            splitContainerControl1.Panel1.Controls.Add(labelControl2);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1029, 522);
            splitContainerControl1.SplitterPosition = 145;
            splitContainerControl1.TabIndex = 7;
            // 
            // spinEditHeSo
            // 
            spinEditHeSo.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditHeSo.Location = new Point(158, 74);
            spinEditHeSo.MenuManager = barManager1;
            spinEditHeSo.Name = "spinEditHeSo";
            spinEditHeSo.Properties.Appearance.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spinEditHeSo.Properties.Appearance.Options.UseFont = true;
            spinEditHeSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditHeSo.Size = new Size(100, 26);
            spinEditHeSo.TabIndex = 2;
            // 
            // textEditLoaiCong
            // 
            textEditLoaiCong.Location = new Point(158, 27);
            textEditLoaiCong.Margin = new Padding(4);
            textEditLoaiCong.MenuManager = barManager1;
            textEditLoaiCong.Name = "textEditLoaiCong";
            textEditLoaiCong.Properties.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditLoaiCong.Properties.Appearance.Options.UseFont = true;
            textEditLoaiCong.Size = new Size(186, 30);
            textEditLoaiCong.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(97, 77);
            labelControl2.Margin = new Padding(4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(54, 23);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Hệ số:";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(62, 30);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(89, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Loại công:";
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
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { DELETED_BY, ID_LC, TENLC, HESO });
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
            // ID_LC
            // 
            ID_LC.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_LC.AppearanceHeader.Options.UseFont = true;
            ID_LC.Caption = "ID";
            ID_LC.FieldName = "ID_LC";
            ID_LC.MaxWidth = 80;
            ID_LC.MinWidth = 80;
            ID_LC.Name = "ID_LC";
            ID_LC.Visible = true;
            ID_LC.VisibleIndex = 1;
            ID_LC.Width = 80;
            // 
            // TENLC
            // 
            TENLC.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TENLC.AppearanceHeader.Options.UseFont = true;
            TENLC.Caption = "LOẠI CÔNG";
            TENLC.FieldName = "TENLC";
            TENLC.MaxWidth = 200;
            TENLC.MinWidth = 200;
            TENLC.Name = "TENLC";
            TENLC.Visible = true;
            TENLC.VisibleIndex = 2;
            TENLC.Width = 200;
            // 
            // HESO
            // 
            HESO.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            HESO.AppearanceHeader.Options.UseFont = true;
            HESO.Caption = "HỆ SỐ";
            HESO.FieldName = "HESO";
            HESO.MaxWidth = 100;
            HESO.MinWidth = 100;
            HESO.Name = "HESO";
            HESO.Visible = true;
            HESO.VisibleIndex = 3;
            HESO.Width = 100;
            // 
            // FormLoaiCong
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
            Name = "FormLoaiCong";
            Text = "LOẠI CÔNG";
            Load += FormLoaiCong_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spinEditHeSo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditLoaiCong.Properties).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn ID_LC;
        private DevExpress.XtraGrid.Columns.GridColumn TENLC;
        private DevExpress.XtraGrid.Columns.GridColumn HESO;
        private DevExpress.XtraEditors.SpinEdit spinEditHeSo;
        private DevExpress.XtraEditors.TextEdit textEditLoaiCong;
    }
}