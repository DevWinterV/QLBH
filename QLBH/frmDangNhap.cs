using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using frm_BanHang;
using QLBH_BUS;
using QLBH_Enity;

namespace QLBH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(string chon)
        {
            _chon = chon;
            InitializeComponent();
        }

        private string _chon;
        private string manv, phanquyen, tennv;
        BUS_NguoiDung nv = new BUS_NguoiDung();
        BUS_ADMIN admin = new BUS_ADMIN();

        public string Chon { get => _chon; set => _chon = value; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnpass_Click_1(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                btnXempass.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }

        private void btnXempass_Click_1(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                btnAnpass.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaikhoan.Focus();
            panel1.BackColor = Color.FromArgb(120,0,0,0);

        }

        private void txtTaikhoan_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTaikhoan.Text == "")
                {
                    this.errorProvider1.SetError(txtTaikhoan, "This is not null");
                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtpass_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTaikhoan.Text == "")
                {
                    this.errorProvider1.SetError(txtTaikhoan, "This is not null");
                }
                else
                {
                    this.errorProvider1.Clear();
                    btnXempass_Click_1(sender, e);
                    btnAnpass_Click_1(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void txtTaikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTaikhoan.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtpass.Focus();
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtpass.Text != " ")
            {
                if(e.KeyCode == Keys.Enter)
                {
                    btnDangNhap_Click_1(sender, e);
                }    
            }    
        }
       
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTaikhoan.Text.ToUpper() !="ADMIN")
                {
                    if (txtTaikhoan.Text != "" && txtpass.Text != "")
                    {
                        if (nv.Check_LogIn(txtTaikhoan.Text, txtpass.Text) == 1)
                        {
                            tennv = nv.GetValue("select nv.hoten from nhanvien nv, NguoiDung ng where ng.pass = '" + txtpass.Text.Trim() + "' and ng.username = '" + txtTaikhoan.Text.Trim() + "' and nv.manv = ng.manv");
                            phanquyen = nv.GetValue("select MA_QUYEN from nguoidung where username ='" + txtTaikhoan.Text + "' and pass = '" + txtpass.Text + "'");
                            manv = nv.GetValue("select manv from NguoiDung where pass = '" + txtpass.Text.Trim() + "' and username = '" + txtTaikhoan.Text.Trim() + "'");
                            string tenquyen = nv.GetValue("select tenquyen from quyen where ma_quyen ='" + phanquyen + "'");
                            MessageBox.Show("Đăng nhập vào hệ thống!(Quyền: "+tenquyen.ToUpper() + ")", "THÔNG BÁO");
                            frmChuongTrinh bh = new frmChuongTrinh(phanquyen, tennv, manv);
                            this.Hide();
                            bh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (txtTaikhoan.Text.ToUpper() == "ADMIN" )
                {
                    if (txtTaikhoan.Text != "" && txtpass.Text != "")
                    {
                        if (admin.Check_logIn(txtTaikhoan.Text, txtpass.Text) == 1)
                        {
                            tennv = "ADMIN";
                            phanquyen = admin.GetValue("select phanquyen from adminn where username ='" + txtTaikhoan.Text + "' and pass = '" + txtpass.Text + "'");
                            manv = tennv;
                            MessageBox.Show("Đăng nhập vào hệ thống!(Quyền: ADMIN)", "THÔNG BÁO");
                            frmChuongTrinh bh = new frmChuongTrinh(phanquyen, tennv, manv);
                            this.Hide();
                            bh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                if ((this.txtTaikhoan.Text == "dangthithuyvy") && (this.txtpass.Text == "dth206071"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Hide();

                    frmChuongTrinh f2 = new frmChuongTrinh();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtTaikhoan.Clear();
                    this.txtpass.Clear(); this.txtTaikhoan.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
           
        }
    }
}
