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
    public partial class frmThongTinNhanVien : Form
    {
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien nv = new BUS_NhanVien();

        public frmThongTinNhanVien(string manv, string hoten,string phanquyen)
        {
            InitializeComponent();
            this.manv = manv;
            this.hoten = hoten;
            this.phanquyen = phanquyen;
        }
        
        string phanquyen;
        string manv, hoten;

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thaydoi_Click(object sender, EventArgs e)
        {
            if (hoten != "ADMIN")
            {
                frm_Doimatkhau f1 = new frm_Doimatkhau();
                f1.ShowDialog();
            }
            else
            {
                frm_DoimatkhaiAdmin f2 = new frm_DoimatkhaiAdmin();
                f2.ShowDialog();
            }    
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            lb_Email.Text = nv.Getvalue("select dchi from nhanvien where manv = '"+manv+"'");
            lbgiotinh.Text = nv.Getvalue("select gioitinh from nhanvien where manv = '" + manv + "'");
            lb_ngaysinh.Text = nv.Getvalue("select ngaysinh from nhanvien where manv = '" + manv + "'");
            lb_manv.Text = manv;
            lb_hoten.Text = hoten;
            lb_sdtnv.Text = nv.Getvalue("select sodt from nhanvien where manv = '" + manv + "'");
        }
    }
}
