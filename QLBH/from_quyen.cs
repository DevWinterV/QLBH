using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Fields;
using QLBH_BUS;
using QLBH_Enity;
namespace QLBH
{
    public partial class from_quyen : Form
    {
        BUS_QUYEN BUSQUYEN = new BUS_QUYEN();
        Quyen quyen = new Quyen();
        public from_quyen()
        {
            InitializeComponent();
        }
        private void Load_DSQUYEN()
        {
            try
            {
                dgv_dsquyen.DataSource = BUSQUYEN.LoadDuLieu("");
            }
             catch { }
        }
        private void from_quyen_Load(object sender, EventArgs e)
        {
            Load_DSQUYEN();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string Replace_whitepace_FirstWord(string chuoi)
        {
            string newstring = chuoi.Trim();
            Regex trimer = new Regex(@"\s\s+");
            newstring = trimer.Replace(newstring, " ");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newstring.ToLower());
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(txt_id.Text=="")
            { MessageBox.Show("Bạn chưa nhập ID cần sửa!", "Thông báo");txt_id.Focus(); return; }
            if (txt_id.Text == "")
            { MessageBox.Show("Tên quyền không được trống!", "Thông báo"); txt_ten.Focus(); return; }
            if(txt_id.Text != "" && txt_ten.Text !="")
            {
                quyen.Id = int.Parse(txt_id.Text.Trim());
                quyen.TenQuyen = Replace_whitepace_FirstWord(txt_ten.Text);
                BUSQUYEN.Update(quyen);
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                Load_DSQUYEN();
            }    
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_ten.Text!="")
            {
                quyen.TenQuyen = txt_ten.Text;
                BUSQUYEN.Add(quyen);
                MessageBox.Show("Thêm thành công!", "Thông báo");
                Load_DSQUYEN();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên quyên!", "Thông báo");
                txt_ten.Focus();
            }
        }

        private void dgv_dsquyen_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_dsquyen.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null )
                {
                    txt_id.Text = dr.Cells[0].Value.ToString();
                    txt_ten.Text = dr.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
