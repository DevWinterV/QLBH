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
    public partial class frm_ChinhSuaSoluongNhap : Form
    {
        private string _tenSp;
        private int _soluong;
        private double _dongia, _thanhtien;
        private int _trangthai;
        public frm_ChinhSuaSoluongNhap()
        {
            InitializeComponent();
        }

        public frm_ChinhSuaSoluongNhap(string tenSp, int soluong, double dongia)
        {
            InitializeComponent();
            _tenSp = tenSp;
            _soluong = soluong;
            _dongia = dongia;
        }

        public string TenSp { get => _tenSp; set => _tenSp = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
        public double Dongia { get => _dongia; set => _dongia = value; }

        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            Trangthai = 1;
            Soluong =int.Parse( txt_soluong.Value.ToString());
            Thanhtien = Soluong * Dongia;
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Trangthai = 0;
            this.Close();
        }

        private void frm_ChinhSuaSoluongNhap_Load(object sender, EventArgs e)
        {
            lb_tensp.Text = TenSp;
            lb_dongia.Text = Dongia.ToString("c",new CultureInfo("vi-VN"));
            txt_soluong.Value = Soluong;
            lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
        }
        private double TongTien()
        {
            return double.Parse(txt_soluong.Value.ToString()) * Dongia;

        }
        private void txt_soluong_ValueChanged(object sender, EventArgs e)
        {
                if (txt_soluong.Value > 0)
                {
                    lb_tongtien.Text = TongTien().ToString("c",new CultureInfo( "vi-VN"));
                }
                else
                {
                    lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
                    MessageBox.Show("Số lượng không được âm!", "Chú ý");
                }
        }

        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
