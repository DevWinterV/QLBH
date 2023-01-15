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
    public partial class frm_XacNhanGhiNo : Form
    {
        public frm_XacNhanGhiNo()
        {
            InitializeComponent();
        }
        BUS_PHIEUNO pn = new BUS_PHIEUNO();
        public frm_XacNhanGhiNo(string makh,string hoten, string sodt, string diachi, double tongtienhoadon,double tratruoc)
        {
            InitializeComponent();
            this.Makh = makh;
            this.hoten = hoten;
            this.sodt = sodt;
            this.diachi = diachi;
            this.tongtienhoadon = tongtienhoadon;
            this.tratruoc = tratruoc;
        }

        private string hoten, sodt, diachi;
        private double  tongtienhoadon;
        private double nocu;
        private double tratruoc;
        private int trangThai;
        private string ghichu;
        private string makh;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public double Tongtienhoadon { get => tongtienhoadon; set => tongtienhoadon = value; }
        public double Nocu { get => nocu; set => nocu = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Makh { get => makh; set => makh = value; }
        public double Tratruoc { get => tratruoc; set => tratruoc = value; }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                    if(MessageBox.Show("Bạn thực sự xác nhận ghi nợ cho khách hàng không?","Chú ý",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                    {
                        TrangThai = 1;
                        Ghichu = txt_ghichu.Text;
                        this.Close();
                    }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TrangThai = 0;
            this.Close();
        }

        private void frm_XacNhanGhiNo_Load(object sender, EventArgs e)
        {
            try {
                lb_tenkh.Text = Hoten;
                lb_sdt.Text = Sodt;
                ln_diachi.Text = Diachi;
                lb_thanhtoantrc.Text = tratruoc.ToString("c", new CultureInfo("vi-VN"));
                lb_tongtienhd.Text = Tongtienhoadon.ToString("c", new CultureInfo("vi-Vn"));
                if(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + makh + "' and hd.maHD = pn.mahd")!="")
                    lb_nocu.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + makh + "' and hd.maHD = pn.mahd")).ToString("c", new CultureInfo("vi-Vn"));
               else
                    lb_nocu.Text = "0";
                double nocon = Tongtienhoadon - tratruoc;
                if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + makh + "' and hd.maHD = pn.mahd") != "")
                    lb_tongno.Text = (double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + makh + "' and hd.maHD = pn.mahd")) + nocon).ToString("c", new CultureInfo("vi-VN"));
                else
                    lb_tongno.Text = (nocon).ToString("c", new CultureInfo("vi-VN"));
            }
            catch
            {

            }
         }
        private double TinhTongNo(double Tientra)
        {
            double tongno = 0;
            tongno = (Tongtienhoadon - Tientra) + Nocu;
            return tongno;
        }

        private void txt_tientratruoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TinhTongNo(double.Parse(lb_thanhtoantrc.Text));
            }
            catch
            {

            }
        }
    }
}
