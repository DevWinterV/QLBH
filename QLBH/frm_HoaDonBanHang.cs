using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Utils.About;
using QLBH;
using QLBH_BUS;
using QLBH_Enity;
namespace frm_BanHang
{
    public partial class frm_banhang : Form
    {
        public frm_banhang()
        {
            InitializeComponent();
        }
        public frm_banhang(string tennv, string manv)
        {
            this.tennv = tennv;
            this.manv = manv;
            InitializeComponent();
        }
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD cthd = new BUS_CTHD();
        HoaDon hoadon = new HoaDon();
        CTHD chitiethd = new CTHD();
        SanPham sanPham = new SanPham();
        BUS_LoaiHang lh = new BUS_LoaiHang();
        BUS_SanPham sp = new BUS_SanPham();
        BUS_KhachHang kh = new BUS_KhachHang();
        int vitri;
        int dong, dem = 0;
        private string tennv, manv;
        private void Loadccb_loaihang()
        {
            cbb_loaihang.DataSource = lh.LoadDuLieu("");
            cbb_loaihang.DisplayMember = "Tenloai";
            cbb_loaihang.ValueMember = "maloai";
        }
        private void Loadccb_Sanpham()
        {
            //cbb_masp.DataSource = sp.LoadDuLieu(" where maloai ='" + cbb_loaihang.SelectedValue.ToString() + "' and sluong > 0");
            cbb_masp.DisplayMember = "tensp";
            cbb_masp.ValueMember = "masp";
        }
        private void LoadcbbKH()
        {
            cbb_tenkhachhang.DataSource = kh.LoadDuLieu("");
            cbb_tenkhachhang.DisplayMember = "hoten";
            cbb_tenkhachhang.ValueMember = "makh";
        }
        private void LoadDonGia()
        {
            txtdongia.Text = sp.GetDulieu("select dongia from sanphamDGD where masp = '" + cbb_masp.SelectedValue.ToString() + "'");
        }

        private void frm_banhang_Load(object sender, EventArgs e)
        {
            frmChuongTrinh ct = new frmChuongTrinh();
            Loadccb_loaihang();
            LoadcbbKH();
            Loadccb_Sanpham();
            txt_manv.Text = manv;
            txt_tennv.Text = tennv;
           // Enable_DGV();
        }
        private void Enable_DGV()
        {
            if (dgv_CTHD.Rows.Count > 1)
            {
                dgv_CTHD.Enabled = true;
                btnluuhoadon.Enabled = true;
            }
            else
            {
                dgv_CTHD.Enabled = false;
                 btnluuhoadon.Enabled = false;
            }
        }
        private void cbb_loaihang_SelectedValueChanged(object sender, EventArgs e)
        {
            cbb_masp.Text = "";
            txtsoluong.Text = "";
           // cbb_masp.DataSource = sp.LoadDuLieu(" where maloai ='" + cbb_loaihang.SelectedValue.ToString() + "' and sluong > 0");
            cbb_masp.DisplayMember = "tensp";
            cbb_masp.ValueMember = "masp";
        }


        private void cbb_masp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdongia.Text =   float.Parse(sp.GetDulieu("select dongia from sanphamDGD where masp = '" + cbb_masp.SelectedValue.ToString() + "'")).ToString();
        }
        private void txtsoluong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text.Length > 0)
                {
                    double thanhtien;
                    int soluong = int.Parse(txtsoluong.Text);
                    double dongia = double.Parse(txtdongia.Text);
                    thanhtien = dongia * soluong;
                    txtthanhtien.Text = thanhtien.ToString();
                }
                else
                    txtthanhtien.Text = "0";
            }
            catch {; }
        }
        /// <summary>
        /// Chức năng kiểm tra mã sản phẩm tồn tại trên lưới
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool check_masp(string id)
        {
            if (dgv_CTHD.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_CTHD.RowCount -1; i++)
                    {
                        if (id == (string)dgv_CTHD.Rows[i].Cells[1].Value)
                        {
                            vitri = i;
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            return true;
        }
        /// <summary>
        /// hàm cập nhật lại số lượng và thành tiền của
        /// </summary>
        private void update()
        {
            try
            {
                DataGridViewRow row = dgv_CTHD.Rows[dgv_CTHD.CurrentRow.Index];
                row.Cells[0].Value = cbb_loaihang.Text;
                row.Cells[1].Value = cbb_masp.SelectedValue.ToString();
                row.Cells[2].Value = cbb_masp.Text;
                row.Cells[4].Value = txtdongia.Text;
                row.Cells[3].Value = txtsoluong.Text;
                row.Cells[5].Value = txtthanhtien.Text;
                txt_tongtien.Text = TongTien().ToString();
                dgv_CTHD.Update();
            }
            catch
            {
                MessageBox.Show("Chọn vào dòng sản phẩm cần cập nhật!","Lỗi",MessageBoxButtons.OK);
            }
        }
        private void update_Them(string id)
        {
            try
            {
                if (int.Parse(txtsoluong.Text) > 0)
                {
                    DataGridViewRow row = dgv_CTHD.Rows[vitri];
                    double thanhtien;
                    try
                    {
                        row.Cells[0].Value = cbb_loaihang.Text;
                        row.Cells[1].Value = cbb_masp.SelectedValue.ToString();
                        row.Cells[2].Value = cbb_masp.Text;
                        row.Cells[4].Value = txtdongia.Text;
                        int soluongcapnhat = int.Parse(txtsoluong.Text.Trim()) + int.Parse(row.Cells[3].Value.ToString().Trim());
                        if (soluongcapnhat <= int.Parse(sp.GetDulieu("select sluong from sanphamdgd where masp = '" + id + "'")))
                        {
                            row.Cells[3].Value = soluongcapnhat.ToString();
                            thanhtien = double.Parse(txtdongia.Text) * soluongcapnhat;
                        }
                        else
                        {
                            txtsoluong.Text = "0";
                            txtthanhtien.Text = "0";
                            dxErrorProvider1.SetError(txtsoluong, "Số lượng sản phẩm không đủ! Số lượng còn " + sp.GetDulieu("select sluong from sanphamdgd where masp = '" + cbb_masp.SelectedValue.ToString() + "'"));
                            txtsoluong.Focus();
                            row.Cells[3].Value = 0;
                            thanhtien = 0;
                        }
                        row.Cells[5].Value = thanhtien.ToString();
                        txt_tongtien.Text = TongTien().ToString();
                        dgv_CTHD.Update();
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    dxErrorProvider1.SetError(txtsoluong, "Số lượng không được âm");
                    txtsoluong.Text = " ";
                    txtsoluong.Focus();
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }
        private bool Check_Soluong(int soluong, string masp)
        {
            if(soluong > 0)
            {
                if (soluong > int.Parse(sp.GetDulieu("select sluong from sanphamdgd where masp = '" + masp + "'")))
                {
                    return false;
                }    
            }
            return true;
        }

        /// <summary>
        /// Thêm mới 1 sản phẩm vào chi tiết hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnthemhd_Click(object sender, EventArgs e)
        {
            if (cbb_masp.Text != "")
            {
                if (check_masp(cbb_masp.SelectedValue.ToString())) // Nếu sản phẩm không có trong hóa đơn thì thêm mới
                {
                    try
                    {
                        if (int.Parse(txtsoluong.Text.Trim()) > 0)
                        {
                            if (Check_Soluong(int.Parse(txtsoluong.Text.Trim()), cbb_masp.SelectedValue.ToString()))
                            {
                                dgv_CTHD.Rows.Add(cbb_loaihang.Text, cbb_masp.SelectedValue.ToString().Trim(), cbb_masp.Text.Trim(), txtsoluong.Text, txtdongia.Text, txtthanhtien.Text);
                                txtsoluong.Text = " ";
                                txtthanhtien.Text = " ";
                                txt_tongtien.Text = TongTien().ToString();
                            }
                            else
                            {
                                dxErrorProvider1.SetError(txtsoluong, "Số lượng sản phẩm không đủ! Số lượng còn " + sp.GetDulieu("select sluong from sanphamdgd where masp = '" + cbb_masp.SelectedValue.ToString() + "'"));
                            }
                        }
                        else
                        {
                            dxErrorProvider1.SetError(txtsoluong, "Số lượng không được âm");
                            txtsoluong.Text = " ";
                            txtsoluong.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        dxErrorProvider1.SetError(txtsoluong, ex.Message);
                    }
                }
                else
                {
                    // Nếu sản phẩm thêm mới tồn tại trong hóa đơn thì cập nhật lại số lượng và thanh tiền
                    if (Check_Soluong(int.Parse(txtsoluong.Text.Trim()), cbb_masp.SelectedValue.ToString()))
                    {
                        update_Them(cbb_masp.SelectedValue.ToString());
                    }
                    else
                    {
                        dxErrorProvider1.SetError(txtsoluong, "Số lượng sản phẩm mua thêm không đủ cung cấp! Số lượng còn " + sp.GetDulieu("select sluong from sanphamdgd where masp = '" + cbb_masp.SelectedValue.ToString() + "'"));
                    }
                }
            }
            else
            {
                dxErrorProvider1.SetError(cbb_masp, "Chọn sản phẩm!");
            }
            Enable_DGV();
        }

        /// <summary>
        /// Lưu hóa đơn vào Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            hoadon.NgayGD = Convert.ToDateTime(DT_ngaylap.Text);
            hoadon.Thanhtien1 = SqlMoney.Parse(txt_tongtien.Text);
            hoadon.Manv = "NV108";
            hoadon.MaKH = cbb_tenkhachhang.SelectedValue.ToString();
            hd.Add(hoadon);
            string mahd = "HD" +hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");
            if (dgv_CTHD.Rows.Count > 0)
            {
                 try
                 {
                     for (int i = 0; i < dgv_CTHD.RowCount -1; i++)
                     {
                         {
                             chitiethd.MaHD = mahd;
                             chitiethd.Masp =  dgv_CTHD.Rows[i].Cells[1].Value.ToString();
                             chitiethd.Tenloai = dgv_CTHD.Rows[i].Cells[0].Value.ToString();
                             sanPham.Masp = dgv_CTHD.Rows[i].Cells[1].Value.ToString();
                             chitiethd.Soluuong = int.Parse(dgv_CTHD.Rows[i].Cells[3].Value.ToString());
                             sanPham.SLuong = int.Parse(dgv_CTHD.Rows[i].Cells[3].Value.ToString());
                             cthd.Add(chitiethd);
                             sp.Update_SaukhiMua(sanPham);// Cập nhật lại số lượng sản phẩm sau khi mua hàng thành công
                         }
                     }
                    if(MessageBox.Show("Lưu hóa đơn thành công! Bạn có muốn In hóa đơn không", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        InhoaDon();
                        btn_themmoiHD.Enabled = false;
                        btnhuyhd.Enabled = false;
                        btnluuhoadon.Enabled = false;
                        txtsoluong.Text = "0";
                        txtthanhtien.Text = "0";
                    }    
                }
                 catch (Exception ex)
                 { MessageBox.Show("Lỗi không lưu thành công !"+ex.Message); }
            }
            
        }
        /// <summary>
        /// Xóa các chi tiết hóa đơn trên lưới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            dgv_CTHD.Rows.Clear();
            Enable_DGV();
            txt_tongtien.Text = "0";
            Enable_HD(false);
            txtsoluong.Text = "0";
            txtthanhtien.Text = "0";
        }

        /// <summary>
        /// Hiển thị Số điệnthoai khách hàng
        /// Hiển thị địa chỉ khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_tenkhachhang_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_sdt.Text = sp.GetDulieu("select sodt from khachhang where makh = '" + cbb_tenkhachhang.SelectedValue.ToString() + "'");
            txt_diachi.Text = sp.GetDulieu("select dchi from khachhang where makh = '" + cbb_tenkhachhang.SelectedValue.ToString() + "'");
        }
        /// <summary>
        /// Tính Tổng Tiền Hóa Đơn
        /// </summary>
        /// <returns> tổng tiền </returns>
        private double TongTien()
        {
            double tongtien = 0;
            if (dgv_CTHD.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_CTHD.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToDouble(dgv_CTHD.Rows[i].Cells[5].Value);
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

        private void dgv_CTHD_DoubleClick(object sender, EventArgs e)
        {
            try 
            { 
                dgv_CTHD.Rows.Remove(dgv_CTHD.CurrentRow);
                txt_tongtien.Text = TongTien().ToString();
                txtsoluong.Text = "0";
                cbb_loaihang.SelectedIndex = 0;
                cbb_masp.SelectedIndex = 0;
                txtthanhtien.Text = "0";
                btncapnhat.Enabled = false;
                btnhuy.Enabled = false;
                btnthemhd.Enabled = true;
            }
            catch {; }
            Enable_DGV();

        }

        private void Enable_HD(bool t)
        {
            btnthemhd.Enabled = t;
            btnhuyhd.Enabled = t;
            cbb_loaihang.Enabled = t;
            cbb_masp.Enabled = t;
            txtsoluong.Enabled = t;
            btn_themmoiHD.Enabled = !t;
        }
        /// <summary>
        /// Thêm mới hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_themmoiHD_Click(object sender, EventArgs e)
        {
            Enable_HD(true);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_CTHD.Rows.Count > 0)
                {
                    if (int.Parse(txtsoluong.Text.Trim()) > 0)
                    {
                        try
                        {
                            if (Check_Soluong(int.Parse(txtsoluong.Text.Trim()), cbb_masp.SelectedValue.ToString()))
                            {
                                update();
                                cbb_masp.Enabled = true;
                                cbb_loaihang.Enabled = true;
                            }
                            else
                            {
                                dxErrorProvider1.SetError(txtsoluong, "Số lượng sản phẩm không đủ! Số lượng còn " + sp.GetDulieu("select sluong from sanphamdgd where masp = '" + cbb_masp.SelectedValue.ToString() + "'"));
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        }
                    else
                    {
                        dxErrorProvider1.SetError(txtsoluong, "Số lượng không được âm");
                        txtsoluong.Text = " ";
                        txtsoluong.Focus();
                    }
                }
                cbb_masp.Enabled = true;
                cbb_loaihang.Enabled = true;
                txtsoluong.Text = "0";
                txtthanhtien.Text = "0";
                btncapnhat.Enabled = false;
                btnthemhd.Enabled = true;
                btnhuy.Enabled = false;
            }
            catch(Exception ex)
            {
                dxErrorProvider1.SetError(txtsoluong, ex.Message);
            }
            Enable_DGV();
        }

        private void dgv_CTHD_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_CTHD.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null)
                {
                    cbb_loaihang.Text = dr.Cells[0].Value.ToString();
                    cbb_masp.Text = dr.Cells[1].Value.ToString();
                    txtsoluong.Text = dr.Cells[3].Value.ToString();
                    txtdongia.Text = dr.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
            cbb_loaihang.Enabled = false;
            cbb_masp.Enabled = false;
            btnhuy.Enabled = true;
            btncapnhat.Enabled = true ;
            btnthemhd.Enabled = false;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Enable_DGV();
            txtsoluong.Text = "0";
            txtthanhtien.Text = "0";
            btncapnhat.Enabled = false;
            btnthemhd.Enabled=true;
            btnhuy.Enabled = false;
            cbb_masp.Enabled = true;
            cbb_loaihang.Enabled = true;
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtsoluong.Text.Trim()) < 0)
                {
                    dxErrorProvider1.SetError(txtsoluong, "Số lượng không được âm!");
                }
                else
                {
                    dxErrorProvider1.ClearErrors();
                }
            }
            catch {; }
        }

        private void InhoaDon()
        {
            
            chitiethd.MaHD = "HD" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");
            chitiethd.Ngaylap = Convert.ToDateTime( DT_ngaylap.Text);
            chitiethd.Tennv = txt_tennv.Text;
            chitiethd.TenKH = cbb_tenkhachhang.Text;
            chitiethd.DiachiKH = txt_diachi.Text;
            chitiethd.SdtKH = txt_sdt.Text;
            chitiethd.Tenloai = cbb_loaihang.Text;
            BUS_SanPham sp = new BUS_SanPham();
            List<CTHD> cthd1 = new List<CTHD> { };
            for (int i = 0; i < dgv_CTHD.RowCount -1; i++)
            {
                {
                    CTHD hd = new CTHD();
                    hd.Masp = dgv_CTHD.Rows[i].Cells[2].Value.ToString();
                    hd.Tenloai = dgv_CTHD.Rows[i].Cells[0].Value.ToString();
                    hd.Soluuong = int.Parse(dgv_CTHD.Rows[i].Cells[3].Value.ToString());
                    hd.Dongia = float.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString());
                    hd.Thanhtien1 = float.Parse(dgv_CTHD.Rows[i].Cells[5].Value.ToString());
                    dem++;
                    cthd1.Add(hd);
                }
            }
    
        }

        private void btnexxit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}