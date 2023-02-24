using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.ComponentModel.DataAnnotations;

namespace QLBH
{
    public partial class frm_BaoCaoKhoSanPham : Form
    {
        DataSet ds = new DataSet("QLNV");
        public frm_BaoCaoKhoSanPham()
        {
            InitializeComponent();
        }

        private void frm_BaoCaoKhoSanPham_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=RANGDONG\DONGCHAU;Initial Catalog=QLBH;User ID=dong;Password=09032002");
            string query = "Select loai.tenloai, sp.tensp, sp.sluong, sp.dongia, sp.dongia * sp.sluong as thanhtien from sanphamdgd sp, loaiSPDGD loai where loai.maloai = sp.maloai and sp.sluong >0";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report4.rdlc"; ;
           Microsoft.Reporting.WinForms. ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("p_ngaybaocao", DateTime.Now.ToString())
            };
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                //reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report1.rdlc";
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                this.reportViewer1.LocalReport.SetParameters(reports);
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }    
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
