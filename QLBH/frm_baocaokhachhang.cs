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
    public partial class frm_baocaokhachhang : Form
    {
        public frm_baocaokhachhang()
        {
            InitializeComponent();
        }

        private void frm_baocaokhachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.QLBHDataSet.KHACHHANG);
            this.reportViewer1.RefreshReport();
        }
    }
}
