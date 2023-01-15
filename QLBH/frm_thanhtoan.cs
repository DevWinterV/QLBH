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
    public partial class frm_thanhtoan : Form
    {
        private int _trangthai;

        public int Trangthai { get => _trangthai; set => _trangthai = value; }

        public frm_thanhtoan()
        {
            InitializeComponent();
        }
        private void frm_thanhtoan_Load(object sender, EventArgs e)
        {
            toolTip1.Active = true;
            toolTip1.SetToolTip(btnTT, "Thanh toán không tạo hóa đơn.");
            toolTip1.SetToolTip(btnInHD, "Thanh toán và xuất hóa đơn bán hàng.");
            toolTip1.SetToolTip(btnCancel, "Quay lại trang hóa đơn bán hàng.");
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Trangthai = 1; 
            this.Close();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            Trangthai = 2;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
