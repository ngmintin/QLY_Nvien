using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.DTO_bs;

namespace Qly_NVien
{
    public partial class FormHopDongLaoDong : Form
    {
        public FormHopDongLaoDong()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        HOPDONGLAODONG_bs _hdld;
        NHANVIEN_bs _nv;
        bool _them;
        string _sohd;
        string _maxSoHD;
        List<HOPDONGLAODONG_dto> _lsthddto;

        private void FormHopDongLaoDong_Load(object sender, EventArgs e)
        {
            _hdld = new HOPDONGLAODONG_bs();
            _nv = new NHANVIEN_bs();
            _them = false;
            showHide(true);
            loadData();
            loadNhanVien();
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2; //CHỈ HIỆN THỊ PANEL 2

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
            gcDanhSach.Enabled = kt;
            textEditSoHD.Enabled = !kt;
            dateTimePickerNgayBD.Enabled = !kt;
            dateTimePickerNgayKT.Enabled = !kt;
            dateTimePickerNgayKy.Enabled = !kt;
            spinEditLanKy.Enabled = !kt;
            spinEditHeSoLuong.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;
            richEditControlNoiDung.Enabled = !kt;

        }

        //HÀM RESET
        void _reset()
        {
            textEditSoHD.Text = string.Empty;
            dateTimePickerNgayBD.Value = DateTime.Now;
            dateTimePickerNgayBD.Value = dateTimePickerNgayBD.Value.AddMonths(6);
            dateTimePickerNgayKy.Value = DateTime.Now;
            spinEditLanKy.Text = "1";
            spinEditHeSoLuong.Text = "1";
            richEditControlNoiDung.Text = string.Empty;

        }

        void loadNhanVien()
        {
            searchLookUpEditNhanVien.Properties.DataSource = _nv.getList();
            searchLookUpEditNhanVien.Properties.ValueMember = "MANV";
            searchLookUpEditNhanVien.Properties.DisplayMember = "HOTEN";
        }

        //CẬP NHẬT DL
        void loadData()
        {
            gcDanhSach.DataSource = _hdld.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
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
            gcDanhSach.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _hdld.Delete(_sohd, 1);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            showHide(true);
            splitContainerControl1.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2;    //CHỈ HIỆN THỊ PANEL 2

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
        void saveData()
        {
            if (_them)
            {
                //SỐ HD CÓ DẠNG: 00001/2025/HDLD
                var maxSoHD = _hdld.maxSoHD();
                int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;

                HOPDONG hd = new HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/HDLD";
                hd.NGAYBDAU = dateTimePickerNgayBD.Value;
                hd.NGAYKTHUC = dateTimePickerNgayKT.Value;
                hd.NGAYKY = dateTimePickerNgayKy.Value;
                hd.THOIHAN = comboBoxThoiHan.Text;
                hd.HESOLUONG = double.Parse(spinEditHeSoLuong.Value.ToString());
                hd.LUONGCOBAN = int.Parse(spinEditLuongCoBan.Value.ToString());
                hd.LANKY = int.Parse(spinEditLanKy.Value.ToString());
                hd.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                hd.NOIDUNG = richEditControlNoiDung.RtfText;
                hd.ID_CTY = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_sohd);
                hd.NGAYBDAU = dateTimePickerNgayBD.Value;
                hd.NGAYKTHUC = dateTimePickerNgayKT.Value;
                hd.NGAYKY = dateTimePickerNgayKy.Value;
                hd.THOIHAN = comboBoxThoiHan.Text;
                hd.HESOLUONG = double.Parse(spinEditHeSoLuong.Value.ToString());
                hd.LUONGCOBAN = int.Parse(spinEditLuongCoBan.Value.ToString());
                hd.LANKY = int.Parse(spinEditLanKy.Value.ToString());
                hd.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                hd.NOIDUNG = richEditControlNoiDung.RtfText;
                hd.ID_CTY = 1;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Update(hd);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _sohd = gvDanhSach.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hdld.getItem(_sohd);
                textEditSoHD.Text = _sohd;
                dateTimePickerNgayBD.Value = hd.NGAYBDAU.Value;
                dateTimePickerNgayKT.Value = hd.NGAYKTHUC.Value;
                dateTimePickerNgayKy.Value = hd.NGAYKY.Value;
                comboBoxThoiHan.Text = hd.THOIHAN;
                spinEditHeSoLuong.EditValue = hd.HESOLUONG;
                spinEditLuongCoBan.EditValue = hd.HESOLUONG;
                spinEditLanKy.Text = hd.LANKY.ToString();
                searchLookUpEditNhanVien.EditValue = hd.MANV;
                richEditControlNoiDung.RtfText = hd.NOIDUNG;
                _lsthddto = _hdld.getItemFull(_sohd);
            }

        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if(e.Column.Name=="DELETED_BY"&&e.CellValue!=null)
            {
                Image img = Properties.Resources.letterx;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }    
        }
    }
}
