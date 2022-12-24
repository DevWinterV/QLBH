using DevExpress.XtraEditors.DXErrorProvider;
using QLBH_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public int Soluong { get => _soluong; set => _soluong = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
        public int Chapnhan { get => _chapnhan; set => _chapnhan = value; }

        frm_hoadonbanhang frm = new frm_hoadonbanhang();
        BUS_SanPham sp = new BUS_SanPham();
        private void frm_NhapSoLuong_Load(object sender, EventArgs e)
        {
            txtsoluong.Focus();
            lb_dongia.Text = dongia;
            lb_tenloai.Text = tenloai;
            lb_tensp.Text = tensp;
            lbsoluong.Text = Soluong.ToString();
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
                    else if(int.Parse(txtsoluong.Text)< 0)
                    {
                        errorProvider1.SetError(txtsoluong, "Số lượng không được âm!");
                        txtsoluong.Clear();
                        txtsoluong.Focus();
                    }    
                    else
                    {
                        this.Close();
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


        public frm_NhapSoLuong(string dongia, string tenloai, string tensp, int soluong)
        {
            InitializeComponent();
            this.dongia = dongia;
            this.tenloai = tenloai;
            this.tensp = tensp;
            this._soluong = soluong;
        }
        

    }
}
