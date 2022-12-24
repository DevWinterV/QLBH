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
using QLBH_BUS;
using QLBH_Enity;

namespace QLBH
{
    public partial class frm_Doimatkhau : Form
    {
        public frm_Doimatkhau()
        {
            InitializeComponent();
        }
        BUS_NguoiDung nv = new BUS_NguoiDung();
        NguoiDung nguoiDung = new NguoiDung();
        string phanquyen, manv;

        private void check_mk_CheckedChanged(object sender, EventArgs e)
        {
            if(check_mk.Checked==true)
            {
                txt_pass_HT.PasswordChar = '\0';
                txt_pass_moi.PasswordChar = '\0';
            }
            else
            {
                txt_pass_HT.PasswordChar = '*';
                txt_pass_moi.PasswordChar = '*';
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tentk.Text != "" && txt_pass_HT.Text != "")
                {
                    if (nv.Check_LogIn(txt_tentk.Text, txt_pass_HT.Text) == 1)
                    { 
                      if(txt_pass_moi.Text != "")
                        {
                            phanquyen = nv.GetValue("select phanquyen from nguoidung where username ='"+ txt_tentk.Text + "' and pass = '" + txt_pass_HT.Text + "'");
                            manv = nv.GetValue("select manv from NguoiDung where pass = '" + txt_pass_HT.Text.Trim() + "' and username = '" + txt_tentk.Text.Trim() + "'");
                            nguoiDung.Phanquyen = phanquyen;
                            nguoiDung.Manv = manv;
                            nguoiDung.Username = txt_tentk.Text;
                            nguoiDung.Pass = txt_pass_moi.Text;
                            nv.Update(nguoiDung);
                            DialogResult = MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                            if(DialogResult == DialogResult.OK)
                            {
                                this.Close();
                            }    

                        }
                        else
                        {
                            MessageBox.Show("Nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
