using DevExpress.Pdf.Native;
using DevExpress.Utils.UI;
using DevExpress.XtraPrinting.DataNodes;
using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmBaoCaoThongKE : Form
    {
        public frmBaoCaoThongKE()
        {
            InitializeComponent();
        }
        public frmBaoCaoThongKE(string tennv)
        {
            this.TenNv = tennv;
            InitializeComponent();
        }
        BUS_SanPham sp = new BUS_SanPham();
        BUS_HoaDon hd = new BUS_HoaDon();


        private void Load_DSSPHET()
        {
            DSSPhet.DataSource = sp.GetData("select loai.tenloai, sp.tensp, sp.dongia  from sanphamdgd sp, loaispdgd loai where  sp.tinhtrang = N'CÒN BÁN' AND loai.maloai = sp.maloai and sp.sluong <=5");
        }
        private void Load_DSTONKHO()
        {
            DMSP_Tonkho.DataSource = sp.GetData("Select loai.tenloai, sp.tensp, sp.sluong, sp.dongia, sp.dongia * sp.sluong as thanhtien from sanphamdgd sp, loaiSPDGD loai where sp.tinhtrang = N'CÒN BÁN' AND loai.maloai = sp.maloai and sp.sluong >0");
        }
        private void Load_DSHD_NGAY()
        {
            DSHD_trongngay.DataSource = hd.GetData("select cthd.maHD, hd.ngaygd, sum(CTHD.soluong) as soluong, nv.hoten as tennv, kh.hoten as tenkh, hd.thanhtien,hd.trangthai from chitietHD cthd , hoadon hd, nhanvien nv, KHACHHANG kh where cthd.maHD = hd.maHD and nv.manv =hd.manv and hd.maKH =kh.maKH and  HD.ngayGD BETWEEN '" + dateTime_ngaychon.Text + " 00:00:00' AND '" + dateTime_ngaychon.Text + " 23:59:59' group by cthd.maHD, nv.hoten, kh.hoten, hd.ngayGD, hd.thanhtien,HD.TRANGTHAI");
        }
        private void Load_DS_thang()
        {
            DSHD_thang.DataSource = hd.GetData("select cthd.maHD, hd.ngaygd, sum(CTHD.soluong) as soluong, nv.hoten as tennv, kh.hoten as tenkh, hd.thanhtien, hd.trangthai from chitietHD cthd , hoadon hd, nhanvien nv, KHACHHANG kh where cthd.maHD = hd.maHD and nv.manv = hd.manv and hd.maKH = kh.maKH and MONTH(hd.ngayGD) = " + datetime_thang.Text + " AND YEAR(hd.ngayGD) = " + date_nam.Text + " group by cthd.maHD, nv.hoten, kh.hoten, hd.ngayGD, hd.thanhtien, HD.TRANGTHAI");
        }

        private  bool Check_maSP(string ID)
        {
            foreach(DataGridViewRow row in dgv_Nhap.Rows)
            {
                if (ID == (string)row.Cells[0].Value)
                    return false;

            }    
            return true;
        }
        private void TongDoanhThuNgay()
        {
            double tongtien = 0;
            if (DSHD_trongngay.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < DSHD_trongngay.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToDouble(DSHD_trongngay.Rows[i].Cells[5].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;
            lb_DTN.Text = tongtien.ToString("c", new CultureInfo("vi-VN"));
        }
        private void TongDoanhThuThang()
        {
            double tongtien = 0;
            if (DSHD_thang.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < DSHD_thang.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToDouble(DSHD_thang.Rows[i].Cells[5].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;
            lb_DTT.Text = tongtien.ToString("c", new CultureInfo("vi-VN"));
        }
        private void Tong_SLSP_Thang()
        {
            int tongtien = 0;
            if (DSHD_thang.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < DSHD_thang.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToInt32(DSHD_thang.Rows[i].Cells[2].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;

            lb_SLT.Text = tongtien.ToString();
        }
        private void Tong_SLSP_NGay()
        {
            int tongtien = 0;
            if (DSHD_trongngay.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < DSHD_trongngay.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToInt32(DSHD_trongngay.Rows[i].Cells[2].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;
            lb_SLSPN.Text = tongtien.ToString();
        }
        private string _tenNv;
        BUS_LoaiHang lh = new BUS_LoaiHang();
        BUS_NHACUNGCAP ncc = new BUS_NHACUNGCAP();
        NHACUNGCAP nhacungcap = new NHACUNGCAP();
        SanPham sanpham = new SanPham();
        PHIEUNHAP pn = new PHIEUNHAP();
        PHIEUNHAP_CHITIET pnchitiet = new PHIEUNHAP_CHITIET();
        BUS_PHIEUNHAPCHITIET phieunhap_CT = new BUS_PHIEUNHAPCHITIET();
        BUS_PHIEUNHAP phieunhap = new BUS_PHIEUNHAP();
        public string TenNv { get => _tenNv; set => _tenNv = value; }

        private void Load_NCC()
        {
            try
            {
                cb_NCC.DataSource = ncc.LoadDuLieu("where tinhtrang = 1");
                cb_NCC.DisplayMember = "tenncc";
                cb_NCC.ValueMember = "mancc";
            }
            catch {; }
        }
        private void InitializeCustomAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();

            // Fetch data from database
            var dataTable = sp.GetData("select * from sanphamdgd where tinhtrang =N'Còn bán'");

            // Populate the AutoCompleteStringCollection with data from the database
            foreach (DataRow row in dataTable.Rows)
            {
                autoCompleteSource.Add(row["tensp"].ToString());
            }

            // Set up autocomplete for the ComboBox
            cb_tenSP.AutoCompleteCustomSource = autoCompleteSource;
            cb_tenSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_tenSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Load_SP()
        {
            try
            {
                if (cb_NCC.Items.Count > 0)
                {
                    cb_tenSP.DataSource = sp.GetData("select * from sanphamdgd where tinhtrang = N'Còn bán'");
                    cb_tenSP.DisplayMember = "tensp";
                    cb_tenSP.ValueMember = "masp";
                }
            }
            catch
            {
                ;
            }
        }
        private void frmBaoCaoThongKE_Load(object sender, EventArgs e)
        {
            try
            {
                tabPage1.Show();
                lb_sphet.Text += sp.GetDulieu("select count(masp) from sanphamdgd where sluong = 0 and tinhtrang = N'CÒN BÁN'");
                lb_sptonkho.Text += sp.GetDulieu("select sum(sluong) from sanphamdgd");
                Load_DSSPHET();
                Load_DSTONKHO();
                Load_DSHD_NGAY();
                Load_DS_thang();
                TongDoanhThuNgay();
                Load_NCC();
                InitializeCustomAutoComplete();
                Load_SP();
                Enabel_DSPHIEUNHAP();
            }
            catch {; }
        }

        private void dateTime_ngaychon_ValueChanged(object sender, EventArgs e)
        {
            Load_DSHD_NGAY();
            TongDoanhThuNgay();
            Tong_SLSP_NGay();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Load_DSHD_NGAY();
            TongDoanhThuNgay();
            Tong_SLSP_NGay();
        }

        private void datetime_thang_ValueChanged(object sender, EventArgs e)
        {
            Load_DS_thang();
            Tong_SLSP_Thang();
            TongDoanhThuThang();
        }

        private void date_nam_ValueChanged(object sender, EventArgs e)
        {
            Load_DS_thang();
            Tong_SLSP_Thang();
            TongDoanhThuThang();
        }

        private void btn_LoadDTT_Click(object sender, EventArgs e)
        {
            Load_DS_thang();
            Tong_SLSP_Thang();
            TongDoanhThuThang();
        }

        private void btnexitkho_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxuatfile_kho_Click(object sender, EventArgs e)
        {
            frm_BaoCaoKhoSanPham baocao = new frm_BaoCaoKhoSanPham();
            baocao.ShowDialog();
        }

        private void btnexit_DTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxuatfile_DTN_Click(object sender, EventArgs e)
        {
            frmbaocaodoanhthungay bcdtn = new frmbaocaodoanhthungay();
            bcdtn.ShowDialog();
        }

        private void btndongthang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxuatfile_thag_Click(object sender, EventArgs e)
        {
            frm_baocaodoanhthuthang bcthang = new frm_baocaodoanhthuthang();
            bcthang.ShowDialog();
        }

        private void btnxembieudo_Click(object sender, EventArgs e)
        {
            frm_bieudodoanhthu frm = new frm_bieudodoanhthu();
            frm.ShowDialog();
        }
        private double ThanhTien()
        {
            double tongtien = 0;
            if (dgv_Nhap.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_Nhap.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToDouble(dgv_Nhap.Rows[i].Cells[4].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;
            return tongtien;
        }
        private double TongTien(double sl, double dongia)
        {
            return dongia * sl;

        }
        private bool CheckThongTin()
        {
            if(cb_NCC.Text == "") { MessageBox.Show("Chọn nhà cung cấp!", "Thông báo"); cb_NCC.Focus(); return false; }
            if (cb_tenSP.Text == "") { MessageBox.Show("Chọn sản phẩm !", "Thông báo"); cb_tenSP.Focus(); return false; }
            if (txt_SL.Text == "") { MessageBox.Show("Chọn số lượng!", "Thông báo"); cb_NCC.Focus(); return false; }
            if (txt_DgiaN.Text == "0") { return false; }
            return true;

        }
        private void Enabel_DSPHIEUNHAP()
        {
            if (dgv_Nhap.Rows.Count -1 == 0)
            {
                dgv_Nhap.Enabled = false;
                cb_NCC.Enabled = true;
                btn_inphieu.Enabled = false;
            }
            else
            {
                dgv_Nhap.Enabled = true;
                cb_NCC.Enabled = false;
                btn_inphieu.Enabled = true;

            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckThongTin())
                {
                    if (Check_maSP(cb_tenSP.SelectedValue.ToString()))
                    {
                        if (txt_SL.Value > 0)       //$exception	{"Object reference not set to an instance of an object."}	System.NullReferenceException

                        {
                            dgv_Nhap.Rows.Add(cb_tenSP.SelectedValue.ToString(), cb_tenSP.Text, txt_SL.Value.ToString(), double.Parse(txt_DgiaN.Text), TongTien(double.Parse(txt_SL.Value.ToString()), double.Parse(txt_DgiaN.Text)));
                            lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
                            cb_NCC.SelectedIndex = 0;
                            cb_tenSP.SelectedIndex = 0;
                            txt_SL.Value = 1;
                            Enabel_DSPHIEUNHAP();
                        }
                        else
                            MessageBox.Show("Sô lượng không được nhỏ hơn hoặc bằng 0", "Chú ý");
                    }
                    else
                        MessageBox.Show("Sản phẩm đã có trong danh sách!", "Chú ý");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Nhap_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_Nhap.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[5].Value != null)
                {
                    cb_tenSP.Text = dr.Cells[1].Value.ToString();
                    txt_SL.Text = dr.Cells[2].Value.ToString();
                    txt_DgiaN.Text = dr.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
            button1.Enabled = false;
            btn_capnhat.Enabled = true;
            btnhuy.Enabled = true;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow dr = dgv_Nhap.CurrentRow;
                dr.Cells[0].Value = cb_tenSP.SelectedValue.ToString();
                dr.Cells[1].Value = cb_tenSP.Text;
                dr.Cells[2].Value = txt_SL.Text;
                dr.Cells[3].Value = double.Parse(txt_DgiaN.Text);
                dr.Cells[4].Value = TongTien(double.Parse(txt_SL.Value.ToString()), double.Parse(txt_DgiaN.Text));
                dgv_Nhap.Update();
                lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
                btn_capnhat.Enabled = false;
                btnhuy.Enabled = false;
                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_SP();
        }

        private void cb_tenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tenSP.Items.Count > 0)
            {
                if (cb_tenSP.Text != "")
                {
                    txt_DgiaN.Text = sp.GetDulieu("select dongia from sanphamDGD where masp = '" + cb_tenSP.SelectedValue.ToString() + "'");
                    txt_soluongton.Text = sp.GetDulieu("select sluong from sanphamDGD where masp = '" + cb_tenSP.SelectedValue.ToString() + "'");
                }
                else
                {
                    txt_DgiaN.Text = "0";
                    txt_soluongton.Text = "";
                }
            }
        }

        private void dgv_Nhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                if (MessageBox.Show("Bạn có muốn bỏ sản phẩm khỏi danh sách mua hàng", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dgv_Nhap.Rows.Remove(dgv_Nhap.CurrentRow);
                        Enabel_DSPHIEUNHAP();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy danh sách?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgv_Nhap.Rows.Clear();
                if (cb_NCC.Items.Count > 0)
                {
                    cb_NCC.SelectedIndex = 0;
                }
                if (cb_tenSP.Items.Count > 0)
                {
                    cb_tenSP.SelectedIndex = 0;
                }
                lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
                Enabel_DSPHIEUNHAP();
                groupBox11.Enabled = false;
                button1.Enabled = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
        private void btn_inphieu_Click(object sender, EventArgs e)
        {
            List<SanPham> dssp = new List<SanPham> { };
            if (dgv_Nhap.RowCount > 0)
            {
                for (int i = 0; i < dgv_Nhap.RowCount - 1; i++)
                {
                    {
                        SanPham sp = new SanPham();
                        sp.Masp = dgv_Nhap.Rows[i].Cells[0].Value.ToString();
                        sp.Tensp= dgv_Nhap.Rows[i].Cells[1].Value.ToString();
                        sp.SLuong= int.Parse(dgv_Nhap.Rows[i].Cells[2].Value.ToString());
                        sp.DongiaNhap= SqlMoney.Parse(dgv_Nhap.Rows[i].Cells[3].Value.ToString());
                        sp.Thanhtien = double.Parse(dgv_Nhap.Rows[i].Cells[4].Value.ToString());
                        dssp.Add(sp);
                    }
                }
                frm_PhieuYeuCauNHapKho pnk = new frm_PhieuYeuCauNHapKho(cb_NCC.Text, TenNv, dssp);
                pnk.ShowDialog();
            }
        }

        private void dgv_Nhap_Leave(object sender, EventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            btn_capnhat.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            groupBox11.Enabled = true;
            btntaomoi.Enabled = false;
            btn_huy.Enabled = true;
            dgv_Nhap.Rows.Clear();
            if(cb_NCC.Items.Count>0)
            cb_NCC.SelectedIndex = 0;
            if(cb_tenSP.Items.Count>0)
            cb_tenSP.SelectedIndex = 0;
            txt_SL.Value = 1;
            lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
            Enabel_DSPHIEUNHAP();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
