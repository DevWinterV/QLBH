using DevExpress.XtraPivotGrid.Data;
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
    public partial class frm_Nhapsanpham : Form
    {
        public frm_Nhapsanpham()
        {
            InitializeComponent();
        }

        public frm_Nhapsanpham(string tenNhanvien,string MaNV)
        {
            InitializeComponent();
            this.TenNhanvien = tenNhanvien;
            this.MaNhanvien = MaNV;
        }

        BUS_SanPham sp = new BUS_SanPham();
        BUS_LoaiHang lh = new BUS_LoaiHang();
        BUS_NHACUNGCAP ncc = new BUS_NHACUNGCAP();
        NHACUNGCAP nhacungcap = new NHACUNGCAP();
        SanPham sanpham = new SanPham();
        PHIEUNHAP pn = new PHIEUNHAP();
        PHIEUNHAP_CHITIET pnchitiet = new PHIEUNHAP_CHITIET();
        BUS_PHIEUNHAPCHITIET phieunhap_CT = new BUS_PHIEUNHAPCHITIET();
        BUS_PHIEUNHAP phieunhap = new BUS_PHIEUNHAP();

        private string _tenNhanvien;
        private string _MaNhanvien;
        public string TenNhanvien { get => _tenNhanvien; set => _tenNhanvien = value; }
        public string MaNhanvien { get => _MaNhanvien; set => _MaNhanvien = value; }

        private void btn_ThemNCC_Click(object sender, EventArgs e)
        {
            frmDMSP dmsp = new frmDMSP();
            dmsp.ShowDialog();
        }

        private void btn_themtensp_Click(object sender, EventArgs e)
        {
            frmDMSP dmsp = new frmDMSP();
            dmsp.ShowDialog();
        }
        private void Load_NCC()
        {
            cb_NCC.DataSource = ncc.LoadDuLieu("where tinhtrang =1");
            cb_NCC.DisplayMember = "tenncc";
            cb_NCC.ValueMember = "mancc";
        }
        private void Load_SP()
        {
            cb_tenSP.DataSource = sp.GetData("select * from sanphamdgd where mancc ='" + cb_NCC.SelectedValue.ToString() + "'");
            cb_tenSP.DisplayMember = "tensp";
            cb_tenSP.ValueMember = "masp";
        }
        private void frm_Nhapsanpham_Load(object sender, EventArgs e)
        {
            Enabel_DSPHIEUNHAP();
            Load_NCC();
            Load_SP();
            lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
            txt_tennhanvien.Text = TenNhanvien;
            txt_SoPN.Text = "PN" + phieunhap.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAPN_TU_TANG'");
        }

        private void cb_tenSP_SelectedValueChanged(object sender, EventArgs e)
        {

            //txt_DgiaN.Text = sp.GetDulieu("select dongia from sanphamDGD where masp = '" + cb_tenSP.SelectedValue.ToString() + "'");
        }
        private double TongTien(double sl, double dongia)
        {
            return dongia * sl;

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
        private bool Check_maSP(string ID)
        {
            foreach (DataGridViewRow row in dgv_Nhap.Rows)
            {
                if (ID == (string)row.Cells[0].Value)
                    return false;

            }
            return true;
        }
        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_maSP(cb_tenSP.SelectedValue.ToString()))
                {
                    if (CheckThongTin())
                    {
                        if (txt_SL.Value > 0)       //$exception	{"Object reference not set to an instance of an object."}	System.NullReferenceException

                        {
                            dgv_Nhap.Rows.Add(cb_tenSP.SelectedValue.ToString(), cb_tenSP.Text, txt_SL.Value.ToString(), double.Parse(txt_DgiaN.Text), TongTien(double.Parse(txt_SL.Value.ToString()), double.Parse(txt_DgiaN.Text)));
                            lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
                            Enabel_DSPHIEUNHAP();
                        }
                        else
                            MessageBox.Show("Sô lượng không được nhỏ hơn hoặc bằng 0", "Chú ý");
                    }
                }
                else
                    MessageBox.Show("Sản phẩm đã có trong danh sách nhập hàng!", "Chú ý");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cb_NCC_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_tenSP.Text = "";
            txt_DgiaN.Clear();
            Load_SP();
        }

        private void cb_tenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tenSP.Text != "")
                txt_DgiaN.Text = sp.GetDulieu("select dongia from sanphamDGD where masp = '" + cb_tenSP.SelectedValue.ToString() + "'");
            else
                txt_DgiaN.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Nhap_DoubleClick(object sender, EventArgs e)
        {
            frm_ChinhSuaSoluongNhap frm = new frm_ChinhSuaSoluongNhap(dgv_Nhap.CurrentRow.Cells[1].Value.ToString(), int.Parse(dgv_Nhap.CurrentRow.Cells[2].Value.ToString()), double.Parse(dgv_Nhap.CurrentRow.Cells[3].Value.ToString()));
            frm.ShowDialog();
            if (frm.Trangthai == 1)
            {
                dgv_Nhap.CurrentRow.Cells[0].Value = dgv_Nhap.CurrentRow.Cells[0].Value.ToString();
                dgv_Nhap.CurrentRow.Cells[1].Value = dgv_Nhap.CurrentRow.Cells[1].Value.ToString();
                dgv_Nhap.CurrentRow.Cells[2].Value = frm.Soluong;
                dgv_Nhap.CurrentRow.Cells[3].Value = dgv_Nhap.CurrentRow.Cells[3].Value.ToString();
                dgv_Nhap.CurrentRow.Cells[4].Value = frm.Thanhtien;
                lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
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
                        lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
                        Enabel_DSPHIEUNHAP();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn lưu phiếu nhập kho không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    pn.NgayNhap = Convert.ToDateTime(_ngaynhap.Value);
                    pn.Manv1 = MaNhanvien;
                    pn.Ghichu = txtghichu.Text;
                    pn.TongCong = SqlMoney.Parse(ThanhTien().ToString());
                    phieunhap.Add(pn);
                    string soPN = "PN" + phieunhap.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAPN_TU_TANG'");
                    if (dgv_Nhap.Rows.Count > 0)
                    {
                        try
                        {
                            for (int i = 0; i < dgv_Nhap.RowCount ; i++)
                            {
                                {
                                    pnchitiet.SoPN = soPN;
                                    pnchitiet.Masp = dgv_Nhap.Rows[i].Cells[0].Value.ToString();
                                    pnchitiet.Soluong = int.Parse(dgv_Nhap.Rows[i].Cells[2].Value.ToString());
                                    pnchitiet.Dongia1 = SqlMoney.Parse(dgv_Nhap.Rows[i].Cells[3].Value.ToString());
                                    pnchitiet.Mancc = cb_NCC.SelectedValue.ToString() ;
                                    phieunhap_CT.Add(pnchitiet);
                                    sanpham.SLuong = float.Parse(dgv_Nhap.Rows[i].Cells[2].Value.ToString());
                                    sanpham.Masp = dgv_Nhap.Rows[i].Cells[0].Value.ToString();
                                    sp.Update_SaukhiNhapKho(sanpham);// Cập nhật lại số lượng sản phẩm sau khi nhập kho thành công
                                    btn_taoMoi.Enabled = true;
                                    groupBox1.Enabled = false;
                                }
                            }
                            MessageBox.Show("Lưu phiếu nhập thành công! Bạn có thể xem lại phiếu nhập trong Danh mục phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi không lưu thành công !" + ex.Message);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool CheckThongTin()
        {
            if (cb_NCC.Text == "") { MessageBox.Show("Chọn nhà cung cấp!", "Thông báo"); cb_NCC.Focus(); return false; }
            if (cb_tenSP.Text == "") { MessageBox.Show("Chọn sản phẩm !", "Thông báo"); cb_tenSP.Focus(); return false; }
            if (txt_SL.Text == "") { MessageBox.Show("Chọn số lượng!", "Thông báo"); cb_NCC.Focus(); return false; }
            if (txt_DgiaN.Text == "0") { return false; }
            return true;

        }
        private void Enabel_DSPHIEUNHAP()
        {
            if (dgv_Nhap.Rows.Count  == 0)
            {
                dgv_Nhap.Enabled = false;
                cb_NCC.Enabled = true;
            }
            else
            {
                dgv_Nhap.Enabled = true;
                cb_NCC.Enabled = false;
            }
        }
        private void btn_Huybo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy danh sách nhập hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cb_NCC.SelectedIndex = 0;
                cb_tenSP.SelectedIndex = 0;
                txt_SL.Value = 1;
                txtghichu.Clear();
                dgv_Nhap.Rows.Clear();
                Enabel_DSPHIEUNHAP();
                btn_taoMoi.Enabled = true;
                btn_Huybo.Enabled = false;
                btn_Save.Enabled = false;
                lb_thongtien.Text = "0";
                groupBox1.Enabled = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btn_taoMoi_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
            btn_Huybo.Enabled = true;
            btn_taoMoi.Enabled = false;
            lb_thongtien.Text = ThanhTien().ToString("c", new CultureInfo("vi-Vn"));
            cb_NCC.SelectedIndex = 0;
            cb_tenSP.SelectedIndex = 0;
            txt_SL.Value = 1;
            txtghichu.Clear();
            dgv_Nhap.Rows.Clear();
            Enabel_DSPHIEUNHAP();
            groupBox1.Enabled = true;
        }
    }
}
