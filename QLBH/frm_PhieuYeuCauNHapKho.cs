using Microsoft.Reporting.WinForms;
using QLBH_Enity;
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
    public partial class frm_PhieuYeuCauNHapKho : Form
    {
        public frm_PhieuYeuCauNHapKho()
        {
            InitializeComponent();
        }

        public frm_PhieuYeuCauNHapKho(string tenncc, string tenNV, List<SanPham> dssp)
        {
            InitializeComponent();
            _tenncc = tenncc;
            _tenNV = tenNV;
            this.DS_SP = dssp;
        }
        List<SanPham> DS_SP = new List<SanPham>();
        private string _tenncc, _tenNV;

        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        
        private void frm_PhieuYeuCauNHapKho_Load(object sender, EventArgs e)
        {
            
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report4.rdlc"; ;
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("p_ngaylap", DateTime.Now.ToString()),
                new ReportParameter("p_nguoilap", TenNV),
                new ReportParameter("p_tenncc", Tenncc)
            };
            ReportDataSource rpdts = new ReportDataSource();
            rpdts.Name = "DataSet1";
            rpdts.Value = DS_SP;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "Report4.rdlc";
            this.reportViewer1.LocalReport.SetParameters(reports);
            reportViewer1.LocalReport.DataSources.Add(rpdts);
            reportViewer1.RefreshReport();
        }
    }
}
