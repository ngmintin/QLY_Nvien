namespace Qly_NVien
{
    partial class FormBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoPhan));
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
            textEditTen = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gcDanhSach = new DevExpress.XtraGrid.GridControl();
            gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            ID_BP = new DevExpress.XtraGrid.Columns.GridColumn();
            TENBP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditTen.Properties).BeginInit();
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
            barDockControlTop.Size = new Size(1272, 28);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 755);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Margin = new Padding(4);
            barDockControlBottom.Size = new Size(1272, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 28);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Margin = new Padding(4);
            barDockControlLeft.Size = new Size(0, 727);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1272, 28);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Margin = new Padding(4);
            barDockControlRight.Size = new Size(0, 727);
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
            splitContainerControl1.Panel1.Controls.Add(textEditTen);
            splitContainerControl1.Panel1.Controls.Add(labelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gcDanhSach);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1272, 727);
            splitContainerControl1.SplitterPosition = 149;
            splitContainerControl1.TabIndex = 5;
            // 
            // textEditTen
            // 
            textEditTen.Location = new Point(162, 51);
            textEditTen.Margin = new Padding(4);
            textEditTen.MenuManager = barManager1;
            textEditTen.Name = "textEditTen";
            textEditTen.Properties.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEditTen.Properties.Appearance.Options.UseFont = true;
            textEditTen.Size = new Size(354, 30);
            textEditTen.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(47, 54);
            labelControl1.Margin = new Padding(4);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(107, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Tên bộ phận:";
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
            gcDanhSach.Size = new Size(1272, 568);
            gcDanhSach.TabIndex = 0;
            gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvDanhSach });
            // 
            // gvDanhSach
            // 
            gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ID_BP, TENBP });
            gvDanhSach.DetailHeight = 443;
            gvDanhSach.GridControl = gcDanhSach;
            gvDanhSach.Name = "gvDanhSach";
            gvDanhSach.OptionsEditForm.PopupEditFormWidth = 1029;
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            gvDanhSach.Click += gvDanhSach_Click;
            // 
            // ID_BP
            // 
            ID_BP.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID_BP.AppearanceHeader.Options.UseFont = true;
            ID_BP.Caption = "ID";
            ID_BP.FieldName = "ID_BP";
            ID_BP.MaxWidth = 64;
            ID_BP.MinWidth = 64;
            ID_BP.Name = "ID_BP";
            ID_BP.Visible = true;
            ID_BP.VisibleIndex = 0;
            ID_BP.Width = 64;
            // 
            // TENBP
            // 
            TENBP.AppearanceHeader.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TENBP.AppearanceHeader.Options.UseFont = true;
            TENBP.Caption = "BỘ PHẬN";
            TENBP.FieldName = "TENBP";
            TENBP.MaxWidth = 386;
            TENBP.MinWidth = 386;
            TENBP.Name = "TENBP";
            TENBP.Visible = true;
            TENBP.VisibleIndex = 1;
            TENBP.Width = 386;
            // 
            // FormBoPhan
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 775);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FormBoPhan";
            Text = "BỘ PHẬN";
            Load += FormBoPhan_Load;
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEditTen.Properties).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEditTen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID_BP;
        private DevExpress.XtraGrid.Columns.GridColumn TENBP;
    }
}