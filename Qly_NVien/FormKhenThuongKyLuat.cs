using BusinessLayer;
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

namespace Qly_NVien
{
    public partial class FormKhenThuongKyLuat : Form
    {
        public FormKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        //BIẾN TOÀN CỤC
        bool _them;
        string _soqd;
        KHENTHUONGKYLUAT_bs _ktkl;
        NHANVIEN_bs _nv = new NHANVIEN_bs();

        private void FormKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONGKYLUAT_bs();
            _nv = new NHANVIEN_bs();
            _them = false;
            showHide(true);
            loadNhanVien();
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
            gcDanhSach.Enabled = kt;
            textEditSoQD.Enabled = !kt;
            //dateTimePickerNgayBD.Enabled = !kt;
            //dateTimePickerNgayKT.Enabled = !kt;
            textEditLyDo.Enabled = !kt;
            textEditNoiDung.Enabled = !kt;
            dateTimePickerNgay.Enabled = !kt;
            searchLookUpEditNhanVien.Enabled = !kt;

        }

        //HÀM RESET
        void _reset()
        {
            textEditSoQD.Text = string.Empty;
            //dateTimePickerNgayBD.Value = DateTime.Now;
            //dateTimePickerNgayBD.Value = dateTimePickerNgayBD.Value.AddMonths(6);
            textEditLyDo.Text = string.Empty;
            textEditNoiDung.Text = string.Empty;

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
            gcDanhSach.DataSource = _ktkl.getListFull(1);
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soqd,1);
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
                var maxSoQD = _ktkl.maxSoQD(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                KHENTHUONGKYLUAT ktkl = new KHENTHUONGKYLUAT();
                ktkl.SOQUYETDINH = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QDKTKL";
                //hd.NGAYBDAU = dateTimePickerNgayBD.Value;
                //hd.NGAYKTHUC = dateTimePickerNgayKT.Value;
                ktkl.LYDO = textEditLyDo.Text;
                ktkl.NOIDUNG = textEditNoiDung.Text;
                ktkl.NGAY = dateTimePickerNgay.Value;
                ktkl.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                ktkl.LOAI = 1; //1: KHEN THƯỞNG, 2: KỶ LUẬT
                ktkl.CREATED_BY = 1;
                ktkl.CREATED_DATE = DateTime.Now;
                _ktkl.Add(ktkl);
            }
            else
            {
                var ktkl = _ktkl.getItem(_soqd);
                //hd.NGAYBDAU = dateTimePickerNgayBD.Value;
                //hd.NGAYKTHUC = dateTimePickerNgayKT.Value;
                ktkl.MANV = int.Parse(searchLookUpEditNhanVien.EditValue.ToString());
                ktkl.LYDO = textEditLyDo.Text;
                ktkl.NOIDUNG = textEditNoiDung.Text;
                ktkl.NGAY = dateTimePickerNgay.Value;
                ktkl.UPDATED_BY = 1;
                ktkl.UPDATED_DATE = DateTime.Now;
                _ktkl.Update(ktkl);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _soqd = gvDanhSach.GetFocusedRowCellValue("SOQUYETDINH").ToString();
            var ktkl = _ktkl.getItem(_soqd);
            textEditSoQD.Text = _soqd;
            //dateTimePickerNgayBD.Value = hd.NGAYBDAU.Value;
            //dateTimePickerNgayKT.Value = hd.NGAYKTHUC.Value;
            searchLookUpEditNhanVien.EditValue = ktkl.MANV;
            textEditLyDo.Text = ktkl.LYDO;
            textEditNoiDung.Text = ktkl.NOIDUNG;
            dateTimePickerNgay.Value = ktkl.NGAY.Value;
        }
    }
}
