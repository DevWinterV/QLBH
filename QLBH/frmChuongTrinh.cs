using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;
using DevExpress.Pdf.Native.BouncyCastle.Security.Certificates;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Forms;
using frm_BanHang;
using QLBH_BUS;

namespace QLBH
{
    public partial class frmChuongTrinh : Form
    {
        public frmChuongTrinh(string phanquyen, string tennv, string manv)
        {
        // chỉnh sửa của Rạng Đông @@
            InitializeComponent();
            this.phanquyen = phanquyen;
            this.tennv = tennv;
            this.manv = manv;
        }
        public frmChuongTrinh()
        {

            InitializeComponent();
        } 

        string phanquyen;
        public string  tennv, manv;
        bool isMouseDown;
        BUS_QUYEN quyen = new BUS_QUYEN();
        int xLast;
        int yLast;
        private Form currentFomchild ;

        private void Openformchild(Form childForm)
        {
           
            bool IsOpen = false;
            foreach(Form frm in Application.OpenForms)
            {
                if(childForm.Text == frm.Text)
                {
                    IsOpen = true;
                    lb_tenfrm.Text = frm.Text;
                    frm.BringToFront();
                    break;
                }
            }
            if(IsOpen == false)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_home.Controls.Add(childForm);
                panel_home.Tag = childForm;
                lb_tenfrm.Text = childForm.Text;
                childForm.BringToFront();
                childForm.Show();
            }

            
            
        }
        private void Openformchild_DASHBOARD(Form childForm)
        {

            frm_dashboard kh = new frm_dashboard();
            if (currentFomchild != null)
            {
                currentFomchild.Close();
            }
            currentFomchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_home.Controls.Add(childForm);
            panel_home.Tag = childForm;
            lb_tenfrm.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Openformchild_DASHBOARD(new frm_dashboard());            
        }

        private void btn_KHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();          
            Openformchild(kh);
        }

        private void btn_BHang_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_hoadonbanhang(tennv, manv));
            //Openformchild(new FrmHoaDonBanHang());
            //Openformchild( new frm_banhang(tennv, manv));
        }

        private void btn_DMSP_Click(object sender, EventArgs e)
        {
            Openformchild(new frmDMSP());
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            Openformchild(new Frm_NhanVienn());
        }

        private void btn_HD_Click(object sender, EventArgs e)
        {
            Openformchild(new frmHOADON(tennv,manv));
        }

        private void pictureBox_HOME_Click(object sender, EventArgs e)
        {
            btn_Home_Click(sender, e);
        }
        private void pictureBox_KHANG_menu_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_KhachHang());
        }

        private void pictureBox_BHANG_menu_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_hoadonbanhang(tennv,manv));
        }

        private void pictureBox_DMSP_Menu_Click(object sender, EventArgs e)
        {
            Openformchild(new frmDMSP());
        }

        private void pictureBox_NHANVIEN_menu_Click(object sender, EventArgs e)
        {
            Openformchild(new Frm_NhanVienn());
        }

        private void pictureBox_HD_menu_Click(object sender, EventArgs e)
        {
            Openformchild(new frmHOADON());
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmChuongTrinh_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("XIN CHÀO " + phanquyen + " " + tennv.Trim().ToUpper() + ". CHÚC BẠN MỘT NGÀY TỐT LÀNH!", "ĐĂNG NHẬP THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Openformchild_DASHBOARD(new frm_dashboard());
            btnThuNho_Click_1(sender, e);
            btnPhongTo_Click_1(sender, e);
            panel_menu.BringToFront();
            lb_tenfrm.Text = "HOME";
            lb_name_nv.Text = tennv.ToString();
            if (phanquyen != "ADMIN")
            {
                lb_quyen.Text = quyen.GetValue("select tenquyen from quyen where ma_quyen ='" + phanquyen + "'");
            }
            else
                lb_quyen.Text = phanquyen;
            if (phanquyen =="1")
            {
                btn_NV.Visible = false;
                pictureBox_NHANVIEN_menu.Visible = false;
                btn_NhapHang.Visible = false;
                pictureBox_NhapHang.Visible = false;
            }
            if (phanquyen == "3")
            {
                btn_TK.Visible = false;
                pictureBox_TK_menu.Visible = false;
                btn_Home.Visible = false;
                pictureBox_HOME.Visible = false;
                btn_HD.Visible = false;
                pictureBox_HD_menu.Visible=false;
                btn_KHang.Visible = false;
                pictureBox_KHANG_menu.Visible = false;
                btn_BHang.Visible = false;
                pictureBox_BHANG_menu.Visible=false;
                btn_DMSP.Visible = false;
                pictureBox_DMSP_Menu.Visible=false;
                btn_NV.Visible = false;
                btn_congno.Visible = false;
                pictureBox_conno.Visible = false;
                pictureBox_NHANVIEN_menu.Visible = false;
                btn_NhapHang.Visible = false;
                pictureBox_NhapHang.Visible = false;
            }

        }
        private void btnAn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Font_Click(object sender, EventArgs e)
        {
            int y = 0;
            y = panel_home.Width;
            panel_TD.BringToFront();
            panel_home.BringToFront();
            btn_fontLon.BringToFront();
            panel_menu.SendToBack();
            panel_home.Location = new Point(35, 32);
            lb_tenfrm.Location = new Point(0, 10);
            if (this.WindowState == FormWindowState.Maximized)
                panel_home.Width = y+ 134;
            else
                panel_home.Width = y + 134;
            lb_banquyen.Visible = false;
            pic_anhnen.Visible = false;
        }

        private void btn_fontLon_Click(object sender, EventArgs e)
        {
            int y = 0;
            y = panel_home.Width;
            btn_fontLon.SendToBack();
            panel_home.Location = new Point(170, 32);
            lb_tenfrm.Location = new Point(135, 10);
            if (this.WindowState == FormWindowState.Maximized)
                panel_home.Width = y - 134;
           else
                panel_home.Width = y - 134;
            lb_banquyen.Visible = true;
            pic_anhnen.Visible = true;
        }

        private void btnAn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPhongTo_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnThuNho.BringToFront();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnThuNho_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnPhongTo.BringToFront();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel_TD_MouseDown_1(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            xLast = e.X;
            yLast = e.Y;

            base.OnMouseDown(e);
        }

        private void panel_TD_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int newY = this.Top + (e.Y - yLast);
                int newX = this.Left + (e.X - xLast);

                this.Location = new Point(newX, newY);
            }

            base.OnMouseMove(e);
        }

        private void panel_TD_MouseUp_1(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            base.OnMouseUp(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không ? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmDangNhap f1 = new frmDangNhap();
                f1.Show();
            }    
        }

        private void panel_TD_DoubleClick(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnThuNho.BringToFront();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnPhongTo.BringToFront();
            }
        }

        private void pictureBox_TK_menu_Click(object sender, EventArgs e)
        {
            Openformchild(new frmBaoCaoThongKE(tennv));
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            pictureBox_TK_menu_Click(sender, e);
        }

        private void panel_home_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (panel_home.Controls.Count > 0)
            {
                foreach (Control frm in panel_home.Controls)
                {
                    frm.BringToFront();
                    lb_tenfrm.Text = frm.Text;
                    break;
                }
            }
            else
                lb_tenfrm.Text = "HOME";
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_Nhapsanpham(tennv,manv));
        }

        private void pictureBox_NhapHang_Click(object sender, EventArgs e)
        {
            btn_NhapHang_Click(sender, e);
        }

        private void btn_congno_Click(object sender, EventArgs e)
        {
            Openformchild(new frm_CongNo());
        }

        private void pictureBox_conno_Click(object sender, EventArgs e)
        {
            btn_congno_Click(sender, e);
        }



        private void pictureBox_giaodichquyennhaphang_Click(object sender, EventArgs e)
        {
            Openformchild(new frmHOADON(tennv, manv, phanquyen));
        }

        private void btn_giadichjquyenhaphang_Click(object sender, EventArgs e)
        {
            Openformchild(new frmHOADON(tennv, manv,phanquyen));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien ttnv = new frmThongTinNhanVien(manv,tennv,phanquyen);
            ttnv.ShowDialog();
        }
    }
}
