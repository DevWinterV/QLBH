using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frm_baocaokhachhang : Form
    {
        DataSet ds = new DataSet("TB_BAOCAOKH");

        public frm_baocaokhachhang()
        {
            InitializeComponent();
        }

        private void frm_baocaokhachhang_Load(object sender, EventArgs e)
        {

            ds.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=RANGDONG\DONGCHAU;Initial Catalog=QLBH;User ID=dong;Password=09032002");
            string query = "select * from khachhang ";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report7.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = ds.Tables[0];
                 reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report7.rdlc";
               // reportViewer1.LocalReport.ReportPath = "Report7.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.Show();
                MessageBox.Show("Không có khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
