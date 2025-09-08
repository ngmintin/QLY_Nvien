using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace Qly_NVien
{
    public partial class FormTrinhDo : Form
    {
        public FormTrinhDo()
        {
            InitializeComponent();
        }

        //BIẾN
        TRINHDOs _trinhdo;
        bool _them;
        int _idtd;

        private void FormTrinhDo_Load(object sender, EventArgs e)
        {
            //CHIỀU CAO DÒNG
            gvDanhSach.RowHeight = 30;
            gvDanhSach.ColumnPanelRowHeight = 40;
            //TIÊU ĐỀ CỘT
            gvDanhSach.Appearance.HeaderPanel.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            //Ô DỮ LIỆU
            gvDanhSach.Appearance.Row.Font = new Font("Times New Roman", 15F);
            gvDanhSach.Appearance.Row.Options.UseFont = true;
            //TỤ ĐỘNG CO DÃN THEO NỘI DUNG
            gvDanhSach.OptionsView.RowAutoHeight = true;

            //THAO TÁC
            _them = false;
            _trinhdo = new TRINHDOs();
            showHide(true);
            loadData();
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
        }

        //ẨN NÚT LƯU VÀ HỦY KHI THAO TÁC
        void showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btDong.Enabled = kt;
            btIn.Enabled = kt;
            textEditTen.Enabled = !kt;

        }

        void loadData()
        {
            gcDanhSach.DataSource = _trinhdo.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            textEditTen.Text = string.Empty;
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both; //HIỆN THỊ CẢ 2 PANEL
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(false);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Both; //HIỆN THỊ CẢ 2 PANEL
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                _trinhdo.Delete(_idtd);
                loadData();
            }    
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEditTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                saveData();
                loadData();
                _them = false;
                showHide(true);
                splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2
            }

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            showHide(true);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2

        }

        private void btIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        //HÀM LƯU DL
        void saveData()
        {
            if (_them)
            {
                TRINHDO td = new TRINHDO();
                td.TENTD = textEditTen.Text;
                _trinhdo.Add(td);
            }
            else
            {
                var td = _trinhdo.getItem(_idtd);
                td.TENTD = textEditTen.Text;
                _trinhdo.Update(td);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if(gvDanhSach.RowCount > 0)
            {
                _idtd = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_TD").ToString());
                textEditTen.Text = gvDanhSach.GetFocusedRowCellValue("TENTD").ToString();
            }
        }
    }
}

