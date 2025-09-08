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
using System.IO;
using DevExpress.XtraNavBar.ViewInfo;

namespace Qly_NVien
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        //BIẾN
        NHANVIEN_bs _nhanvien;
        bool _them;
        int _idnv;
        BOPHAN_bs _bophan;
        CHUCVU_bs _chucvu;
        PHONGBAN_bs _phongban;
        TRINHDOs _trinhdo;

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            //CHIỀU CAO DÒNG
            gvDanhSach.RowHeight = 30;
            gvDanhSach.ColumnPanelRowHeight = 40;
            //TIÊU ĐỀ CỘT
            gvDanhSach.Appearance.HeaderPanel.Font = new Font("Times New Roman", 10F, FontStyle.Bold);
            gvDanhSach.Appearance.HeaderPanel.Options.UseFont = true;
            //Ô DỮ LIỆU
            gvDanhSach.Appearance.Row.Font = new Font("Times New Roman", 10F);
            gvDanhSach.Appearance.Row.Options.UseFont = true;
            //TỤ ĐỘNG CO DÃN THEO NỘI DUNG
            gvDanhSach.OptionsView.RowAutoHeight = true;

            //THAO TÁC
            _them = false;
            _nhanvien = new NHANVIEN_bs();
            _bophan = new BOPHAN_bs();
            _chucvu = new CHUCVU_bs();
            _phongban = new PHONGBAN_bs();
            _trinhdo = new TRINHDOs();
            showHide(true);
            loadData();
            loadComBo();
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
            textEditHovaTen.Enabled = !kt;
            textEditSDT.Enabled = !kt;
            textEditDiaChi.Enabled = !kt;
            textEditEmail.Enabled = !kt;
            //pictureBoxHinhAnh.Enabled = !kt;
            comboBoxBoPhan.Enabled = !kt;
            comboBoxChucVu.Enabled = !kt;
            comboBoxPhongBan.Enabled = !kt;
            comboBoxTrinhDo.Enabled = !kt;
            simpleButtonHinhAnh.Enabled = !kt;
            dateTimePickerNgaySinh.Enabled = !kt;
            checkBoxGioiTinh.Enabled = !kt;

        }

        //HÀM RESET
        void _reset()
        {
            textEditHovaTen.Text = string.Empty;
            textEditSDT.Text = string.Empty;
            textEditDiaChi.Text = string.Empty;
            textEditEmail.Text = string.Empty;
            checkBoxGioiTinh.Checked = false;

        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _nhanvien.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void loadComBo()
        {
            comboBoxBoPhan.DataSource = _bophan.getList();
            comboBoxBoPhan.DisplayMember = "TENBP";
            comboBoxBoPhan.ValueMember = "ID_BP";

            comboBoxChucVu.DataSource = _chucvu.getList();
            comboBoxChucVu.DisplayMember = "TENCV";
            comboBoxChucVu.ValueMember = "ID_CV";

            comboBoxPhongBan.DataSource = _phongban.getList();
            comboBoxPhongBan.DisplayMember = "TENPB";
            comboBoxPhongBan.ValueMember = "ID_PB";

            comboBoxTrinhDo.DataSource = _trinhdo.getList();
            comboBoxTrinhDo.DisplayMember = "TENTD";
            comboBoxTrinhDo.ValueMember = "ID_TD";

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showHide(false);
            _them = true;
            _reset();
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
                _nhanvien.Delete(_idnv);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEditHovaTen.Text == "" || textEditSDT.Text == "" || textEditEmail.Text == "" || textEditDiaChi.Text == "" || !checkBoxGioiTinh.Checked || comboBoxBoPhan.Text == "" || comboBoxChucVu.Text == "" || comboBoxPhongBan.Text == "" || comboBoxTrinhDo.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2; //CHỈ HIỆN THỊ PANEL 2
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
                NHANVIEN nv = new NHANVIEN();
                nv.HOTEN = textEditHovaTen.Text;
                nv.SDT = textEditSDT.Text;
                nv.DIACHI = textEditDiaChi.Text;
                nv.EMAIL = textEditEmail.Text;
                nv.HINHANH = ImageToBase64(pictureBoxHinhAnh.Image, pictureBoxHinhAnh.Image.RawFormat);
                nv.GIOITINH = checkBoxGioiTinh.Checked;
                nv.NGAYSINH = dateTimePickerNgaySinh.Value;
                nv.ID_BP = int.Parse(comboBoxBoPhan.SelectedValue.ToString());
                nv.ID_CV = int.Parse(comboBoxChucVu.SelectedValue.ToString());
                nv.ID_PB = int.Parse(comboBoxPhongBan.SelectedValue.ToString());
                nv.ID_TD = int.Parse(comboBoxTrinhDo.SelectedValue.ToString());
                nv.ID_CTY = 1; //MẶC ĐỊNH CÔNG TY 1
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_idnv);
                nv.HOTEN = textEditHovaTen.Text;
                nv.SDT = textEditSDT.Text;
                nv.DIACHI = textEditDiaChi.Text;
                nv.EMAIL = textEditEmail.Text;
                nv.GIOITINH = checkBoxGioiTinh.Checked;
                nv.NGAYSINH = dateTimePickerNgaySinh.Value;
                nv.HINHANH = ImageToBase64(pictureBoxHinhAnh.Image, pictureBoxHinhAnh.Image.RawFormat);
                nv.ID_BP = int.Parse(comboBoxBoPhan.SelectedValue.ToString());
                nv.ID_CV = int.Parse(comboBoxChucVu.SelectedValue.ToString());
                nv.ID_PB = int.Parse(comboBoxPhongBan.SelectedValue.ToString());
                nv.ID_TD = int.Parse(comboBoxTrinhDo.SelectedValue.ToString());
                nv.ID_CTY = 1; //MẶC ĐỊNH CÔNG TY 1
                _nhanvien.Update(nv);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idnv = int.Parse(gvDanhSach.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_idnv);
                textEditHovaTen.Text = nv.HOTEN;
                textEditSDT.Text = nv.SDT;
                textEditDiaChi.Text = nv.DIACHI;
                textEditEmail.Text = nv.EMAIL;
                checkBoxGioiTinh.Checked = nv.GIOITINH.Value;
                pictureBoxHinhAnh.Image = Base64ToImage(nv.HINHANH);
                comboBoxBoPhan.SelectedValue = nv.ID_BP;
                comboBoxChucVu.SelectedValue = nv.ID_CV;
                comboBoxPhongBan.SelectedValue = nv.ID_PB;
                comboBoxTrinhDo.SelectedValue = nv.ID_TD;
                //nv.ID_CTY = 1;

            }
        }

        //HÀM CHUYỂN ĐỔI HÌNH ẢNH LƯU VÀO DB
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void simpleButtonHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Picture file (.png, .jpg)| *.png; *.jpg";
            ofd.Title = "Chọn ảnh đại diện";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBoxHinhAnh.Image = Image.FromFile(ofd.FileName);
                pictureBoxHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }
    }
}
