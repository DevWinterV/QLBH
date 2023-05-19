using DevExpress.XtraDiagram.Base;
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
    public partial class frm_NHapSoLuongCapNhat : Form
    {
        public frm_NHapSoLuongCapNhat()
        {
            InitializeComponent();
        }
        BUS_SanPham sp = new BUS_SanPham();
        private string id_sp;
        private bool barcode_mode = false;
        frm_hoadonbanhang hdbh;
        public DataGridView Dgv { get; set; }

        public frm_NHapSoLuongCapNhat(string idSp, bool barcode_mode, frm_hoadonbanhang bh)
        {
            InitializeComponent();
            this.Id_sp = idSp;
            this.barcode_mode = barcode_mode;
            this.hdbh = bh;
        }
        public frm_NHapSoLuongCapNhat(string dongia, string tenloai, string tensp, int soluong, int soluongcon)
        {
            InitializeComponent();
            this.dongia = dongia;
            this.tenloai = tenloai;
            this.tensp = tensp;
            _soluong = soluong;
            this._soluongcon = soluongcon;
        }
        
        private string dongia, tenloai, tensp;
        private int _soluongcon,_soluongtru,_soluong;
        private double _thanhtien;
        private int _chapnhan;
        private int _SoluongcapNHat;
        public string Dongia { get => dongia; set => dongia = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
        private bool Check_Soluong(int soluong)
        {
            if (soluong > 0)
            {
                if (soluong > int.Parse(lbsoluongconn.Text) + Soluong)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }    
            return true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {

                    if (Check_Soluong(int.Parse(txtsldacos.Value.ToString())) == false)
                    {
                        //int soluong = int.Parse(sp.GetDulieu("select sluong from sanphamdgd where masp = '" + Get_IDHD(tensp).ToString() + "'")) - int.Parse(txtsldacos.Text);
                        MessageBox.Show("Số lượng sản phẩm không đủ! Số lượng còn " + lbsoluongconn.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsldacos.Focus();
                    }
                    else
                    {
                        if (txtsldacos.Text == "")
                        {
                            errorProvider1.SetError(txtsldacos, "Số lượng không được trống!");
                            txtsldacos.Focus();
                        }
                        else
                        {
                            if (txtsldacos.Value > 0)
                            {
                                if (barcode_mode == false)
                                {
                                    Chapnhan = 1;
                                    Soluongtru = int.Parse(txtsldacos.Value.ToString()) - Soluong;
                                    SoluongcapNHat = int.Parse(txtsldacos.Value.ToString());
                                    this.Close();
                                }
                                else
                            {
                                hdbh.CapjNhat_SoLuong(Id_sp, int.Parse(txtsldacos.Value.ToString() )-hdbh.SoLuongCo_TrongHD(id_sp));// Cập nhật lại số lượng danh sách sản phẩm
                                hdbh.Update_Data_Barcode(Id_sp, txtsldacos.Value.ToString());// cập nhật lại số lượng sản phẩm trong danh sách mua hàng
                                    hdbh.Enable_DGVCTHD();
                                    hdbh.lb_tongtien.Text = hdbh.TongTien_ModeBarcode().ToString("c", new CultureInfo("vi-VN"));
                                    this.Close();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtsldacos, "Số lượng không được âm!");
                                txtsldacos.Focus();
                            }
                        }
                    
                   
                    }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsldacos, ex.Message);
            }
        }

        private void frm_NHapSoLuongCapNhat_Load(object sender, EventArgs e)
        {
            if (barcode_mode == false)
            {
                txtsldacos.Focus();
                lb_dongia.Text = dongia;
                lb_tenloai.Text = tenloai;
                lb_tensp.Text = tensp;
                txtsldacos.Value = Soluong;
                lbsoluongconn.Text = Soluongcon.ToString();
            }
            else
            {
                if (Id_sp != "")
                {
                    lb_dongia.Text = sp.GetDulieu("select dongia from sanphamdgd where masp = '" + Id_sp + "'");
                    dongia = lb_dongia.Text;
                    txtsldacos.Focus();
                    txtsldacos.Value = hdbh.SoLuongCo_TrongHD(Id_sp);
                    string idloai = sp.GetDulieu("select maloai from sanphamdgd where masp = '" + Id_sp + "'");
                    lb_tenloai.Text = sp.GetDulieu("select tenloai from loaispdgd where maloai = '" + idloai + "'");
                    lb_tensp.Text = sp.GetDulieu("select tensp from sanphamdgd where masp = '" + Id_sp + "'");
                    lbsoluongconn.Text = hdbh.SoLuongCon(Id_sp).ToString();
                }
            }    
        }

        private void txtsoluongthem_TextChanged(object sender, EventArgs e)
        {       
           
        }

        private void txtsoluongthem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }        
        }

        private void txtsldacos_ValueChanged(object sender, EventArgs e)
        {
            try
            {   
                if (txtsldacos.Value == 0)
                {
                    txtthanhtien.Clear();
                }
                if(txtsldacos.Value > 0)
                {
                    int soluong = int.Parse(txtsldacos.Value.ToString());
                    double thanhtien = (double)soluong * Convert.ToDouble(dongia);
                    txtthanhtien.Text = thanhtien.ToString();
                }
                if (Check_Soluong(int.Parse(txtsldacos.Value.ToString())) == false)
                {
                    // int soluong1 = int.Parse(sp.GetDulieu("select sluong from sanphamdgd where masp = '" + Get_IDHD(tensp).ToString() + "'")) - int.Parse(txtsldacos.Text);
                    MessageBox.Show("Số lượng sản phẩm không đủ! Số lượng còn " + lbsoluongconn.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsldacos.Focus();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.Clear();
            }
        }

        private void txtsldacos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }    
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int Chapnhan { get => _chapnhan; set => _chapnhan = value; }
        public int SoluongcapNHat { get => _SoluongcapNHat; set => _SoluongcapNHat = int.Parse(txtsldacos.Text); }
        public int Soluongtru { get => _soluongtru; set => _soluongtru = value; }
        public int Soluongcon { get => _soluongcon; set => _soluongcon = value; }
        public string Id_sp { get => id_sp; set => id_sp = value; }
    }
}
