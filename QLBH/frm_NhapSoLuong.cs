using DevExpress.XtraEditors.DXErrorProvider;
using QLBH_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frm_NhapSoLuong : Form
    {
        private string dongia, tenloai, tensp;
        private int _soluong;
        private double _thanhtien;
        private int _chapnhan;
        private string _masp;
        private bool barcode_mode = false;
        public int Soluong { get => _soluong; set => _soluong = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
        public int Chapnhan { get => _chapnhan; set => _chapnhan = value; }

        frm_hoadonbanhang frm = new frm_hoadonbanhang();
        BUS_SanPham sp = new BUS_SanPham();
        public DataGridView Dgv { get; set; }

        private void frm_NhapSoLuong_Load(object sender, EventArgs e)
        {
            if (barcode_mode == false)
            {
                txtsoluong.Focus();
                lb_dongia.Text = dongia;
                lb_tenloai.Text = tenloai;
                lb_tensp.Text = tensp;
                lbsoluong.Text = Soluong.ToString();
            }
            else
            {
                if (ID_Sp != "" )
                {
                    lb_dongia.Text = sp.GetDulieu("select dongia from sanphamdgd where masp = '" + ID_Sp + "'");
                    dongia = lb_dongia.Text;
                    txtsoluong.Focus();
                    string idloai = sp.GetDulieu("select maloai from sanphamdgd where masp = '" + ID_Sp + "'");
                    lb_tenloai.Text = sp.GetDulieu("select tenloai from loaispdgd where maloai = '" + idloai + "'");
                    lb_tensp.Text = sp.GetDulieu("select tensp from sanphamdgd where masp = '" + ID_Sp + "'");
                    lbsoluong.Text = hdbh.SoLuongCon(ID_Sp).ToString();
                }

            }    
        }

        private bool Check_Soluong(int soluong)
        {
            if (soluong > 0)
            {
                if (soluong > int.Parse(lbsoluong.Text))
                {
                    return false;
                }
            }
            return true;
        }
        private string Get_IDHD(string tensp)
        {
            string masp = "";
            if (tensp != "")
            {
               masp = sp.GetDulieu("select masp from sanphamdgd where tensp = N'" + tensp + "'");
            }
            return masp;
        }
        public double ThanhTien(double soluong, double dongia)// tính thành tiền của mỗi sản phẩm
        {
            return soluong * dongia;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Soluong(int.Parse(txtsoluong.Text)) == false)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ! Số lượng còn "+lbsoluong.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsoluong.Focus();
                }
                else
                {
                    Chapnhan = 1;
                    if (txtsoluong.Text == "")
                    {
                        errorProvider1.SetError(txtsoluong, "Bạn phải nhập số lượng!");
                        txtsoluong.Focus();
                    }
                    else if (int.Parse(txtsoluong.Text) < 0)
                    {
                        errorProvider1.SetError(txtsoluong, "Số lượng không được âm!");
                        txtsoluong.Clear();
                        txtsoluong.Focus();
                    }
                    else
                    {
                        if (barcode_mode)
                        {
                            //  Dgv.Rows.Add(lb_tenloai.Text, ID_Sp, lb_tensp.Text, lb_dongia.Text, Soluong, ThanhTien(Convert.ToDouble(Soluong), double.Parse(lb_dongia.Text)).ToString());//  thêm sản phẩm vào danh sách mua chi tiết

                            if (hdbh.check_masp(ID_Sp))// kiểm tra Id sản phẩm có tồn tại trong ds mua hàng hay không.
                            {
                                if (hdbh.Check_SL_SP(ID_Sp))// kiểm tra số lượng còn đủ bán hay _ nếu thỏa điều kiện
                                {
                                    hdbh.dgv_CTHD.Rows.Add(lb_tenloai.Text, ID_Sp, lb_tensp.Text, lb_dongia.Text, Soluong, ThanhTien(Convert.ToDouble(Soluong), double.Parse(lb_dongia.Text)).ToString());//  thêm sản phẩm vào danh sách mua chi tiết
                                    hdbh.Enable_DGVCTHD();
                                    hdbh.CapjNhat_SoLuong(ID_Sp, Soluong);// Cập nhật lại số lượng danh sách sản phẩm
                                    hdbh.lb_tongtien.Text = hdbh.TongTien_ModeBarcode().ToString("c", new CultureInfo("vi-VN"));// tính tổng tiền hóa đơn
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Sản phẩm hết số lượng!", "THÔNG BÁO HẾT SỐ LƯỢNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            /*
                            else// sản phẩm tồn tại trong dah sách mua
                            {
                                if (hdbh.Check_SL_SP(ID_Sp))//nếu số lượng còn >0
                                {
                                    if (MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn! Bạn có muốn thay đổi số lượng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        frm_NHapSoLuongCapNhat nslcn = new frm_NHapSoLuongCapNhat(ID_Sp, true, hdbh);
                                        nslcn.ShowDialog();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sản phẩm hết số lượng!", "Thông báo hết số lượng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }*/
                            
                        }else
                        {
                            this.Close();
                        }    
                    }
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsoluong, ex.Message);
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            txtsoluong.Clear();
            txtthanhtien.Clear();
            Chapnhan = 0;
            this.Close();
        }

        private void txtsoluong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            } 
                
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsoluong.Text.Length == 0)
                {
                    txtthanhtien.Clear();
                }
                if (Check_Soluong(int.Parse(txtsoluong.Text)) == false)
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ! Số lượng còn " + lbsoluong.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsoluong.Focus();
                }
                if(int.Parse(txtsoluong.Text)< 0)
                {
                    errorProvider1.SetError(txtsoluong, "Số lượng không được âm!");
                    txtthanhtien.Clear();
                    txtsoluong.Clear();
                    txtsoluong.Focus();
                }    
                else
                {
                    Soluong = Convert.ToInt32(txtsoluong.Text);
                    double thanhtien = (double)Soluong * Convert.ToDouble(dongia);
                    txtthanhtien.Text = thanhtien.ToString();
                }    
            }
            catch (Exception ex)
            {
                errorProvider1.Clear();
                //errorProvider1.SetError(txtsoluong, ex.Message);
            }
        }
        private frm_hoadonbanhang hdbh;
        private string ID_Sp;
        public frm_NhapSoLuong(string dongia, string tenloai, string tensp, int soluong, frm_hoadonbanhang bh)
        {
            InitializeComponent();
            this.dongia = dongia;
            this.tenloai = tenloai;
            this.tensp = tensp;
            this._soluong = soluong;
            this.hdbh = bh;
        }
        public frm_NhapSoLuong(string idSp, bool barcode_mode, frm_hoadonbanhang bh)
        {
            InitializeComponent();
            this.ID_Sp = idSp;
            this.barcode_mode = barcode_mode;
            this.hdbh = bh;
        }

    }
}
