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
    public partial class frm_TraNoKhachhang : Form
    {
        public frm_TraNoKhachhang()
        {
            InitializeComponent();
        }

        public frm_TraNoKhachhang(string tenkh, string mahd, string tienconno)
        {
            InitializeComponent();
            Tenkh = tenkh;
            Mahd = mahd;
            Tienconno = tienconno;
        }
        private int _trangthai;
        private string _tenkh, _mahd;
        private string _tienconno;
        private string _tienkhachtra;
        private string _ghichu;
        frm_CongNo congno = new frm_CongNo();

        public string Tenkh { get => _tenkh; set => _tenkh = value; }
        public string Mahd { get => _mahd; set => _mahd = value; }
        public string Tienconno { get => _tienconno; set => _tienconno = value; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tienkhachtra.Text != "")
                {
                    if (double.Parse(txt_tienkhachtra.Text) <= double.Parse(lb_tienno.Text))
                    {
                        if (MessageBox.Show("Bạn muốn thanh toán nợ cho khách hàng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Trangthai = 1;
                            congno.Tienkhachtra =double.Parse( txt_tienkhachtra.Text);
                            Tienkhachtra = txt_tienkhachtra.Text;
                            Ghichu = txtghichu.Text;
                            this.Close();
                        }
                    }
                
                     else
                    {
                        MessageBox.Show("Số tiền trả vượt quá số tiền đang nợ. Vui lòng kiểm tra lại!", "Thông báo");
                        txt_tienkhachtra.Focus();
                    }

            }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền khách trả nợ!", "Thông báo");
                    txt_tienkhachtra.Focus();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        public int Trangthai { get => _trangthai; set => _trangthai = value; }

        private void txt_tienkhachtra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double noconlai = 0;
                noconlai = double.Parse( Tienconno) - double.Parse(txt_tienkhachtra.Text);
                lb_noconlai.Text = noconlai.ToString("c", new CultureInfo("vi-Vn"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Trangthai = 0;
        }

        private void frm_TraNoKhachhang_Load(object sender, EventArgs e)
        {
            try
            {
                lb_tienno.Text = Tienconno;
                lb_tenkh.Text = Tenkh;
                lb_mahd.Text = Mahd;
            }
            catch { }
        }

        public string Tienkhachtra { get => _tienkhachtra; set => _tienkhachtra = value; }
        public string Ghichu { get => _ghichu; set => _ghichu = value; }
    }
}
