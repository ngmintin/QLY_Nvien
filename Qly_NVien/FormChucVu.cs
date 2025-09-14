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
    public partial class FormChucVu : Form
    {
        public FormChucVu()
        {
            InitializeComponent();
        }

        //BIẾN
        CHUCVU_bs _chucvu;
        bool _them;
        int _idcv;

        private void FormChucVu_Load(object sender, EventArgs e)
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
            _chucvu = new CHUCVU_bs();
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
            gcDanhSach.DataSource = _chucvu.getList();
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
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _chucvu.Delete(_idcv);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEditTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên chúc vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void btDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        //HÀM LƯU DL
        void saveData()
        {
            if (_them)
            {
                CHUCVU cv = new CHUCVU();
                cv.TENCV = textEditTen.Text;
                _chucvu.Add(cv);
            }
            else
            {
                var cv = _chucvu.getItem(_idcv);
                cv.TENCV = textEditTen.Text;
                _chucvu.Update(cv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idcv = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID_CV").ToString());
                textEditTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCV").ToString();
            }
        }
    }
}
