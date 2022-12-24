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
    public partial class frm_bieudodoanhthu : Form
    {
        DataSet ds = new DataSet("TB_BIEUDO");

        public frm_bieudodoanhthu()
        {
            InitializeComponent();
        }

        private void demBieuDo_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            ds.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=RANGDONG\DONGCHAU;Initial Catalog=QLBH;Integrated Security=True");
            string query = "Select MONTH(ngayGD) as 'THANG', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE YEAR(ngayGD) = "+dateTimePicker2.Text+" Group by MONTH(ngayGD)";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report3.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
          {
                new ReportParameter("P_NAM", dateTimePicker2.Text)
          };
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = ds.Tables[0];
                reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report3.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.SetParameters(reports);
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }
            else
            {

                reportViewer1.Show();
                MessageBox.Show("Không có doanh thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
