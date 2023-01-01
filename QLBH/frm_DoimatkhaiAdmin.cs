using QLBH_BUS;
using QLBH_Enity;
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
    public partial class frm_DoimatkhaiAdmin : Form
    {
        public frm_DoimatkhaiAdmin()
        {
            InitializeComponent();
        }
        BUS_ADMIN admin = new BUS_ADMIN();
        Admin am = new Admin();
        private void frm_DoimatkhaiAdmin_Load(object sender, EventArgs e)
        {

        }

        private void check_mk_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mk.Checked == true)
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
                    if (admin.Check_logIn(txt_tentk.Text, txt_pass_HT.Text) == 1)
                    {
                        if (txt_pass_moi.Text != "")
                        {
                            am.User = txt_tentk.Text;
                            am.Password = txt_pass_moi.Text;
                            admin.Update(am);
                            DialogResult = MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (DialogResult == DialogResult.OK)
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
