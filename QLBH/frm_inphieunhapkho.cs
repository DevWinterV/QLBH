using Microsoft.Reporting.WinForms;
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
    public partial class frm_inphieunhapkho : Form
    {
        public frm_inphieunhapkho()
        {
            InitializeComponent();
        }

        public frm_inphieunhapkho(string tenncc, string sophieun, string ngaylap, string tennv, string ghichu, List<PHIEUNHAP_CHITIET> list)
        {
            InitializeComponent();
            _tenncc = tenncc;
            _sophieun = sophieun;
            _ngaylap = ngaylap;
            _tennv = tennv;
            _ghichu = ghichu;
            this.list = list;
        }
        List<PHIEUNHAP_CHITIET> list;
        private string _tenncc, _sophieun, _ngaylap, _tennv, _ghichu;

        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public string Sophieun { get => _sophieun; set => _sophieun = value; }
        public string Ngaylap { get => _ngaylap; set => _ngaylap = value; }
        public string Tennv { get => _tennv; set => _tennv = value; }
        public string Ghichu { get => _ghichu; set => _ghichu = value; }

        private void frm_inphieunhapkho_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report5.rdlc"; ;
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("p_ngaylap", Ngaylap),
                new ReportParameter("p_nguoilap", Tennv),
                new ReportParameter("p_sophieuN", Sophieun),
                new ReportParameter("p_tenncc", Tenncc),
                new ReportParameter("p_ghichu", Ghichu)

            };
            ReportDataSource rpdts = new ReportDataSource();
            rpdts.Name = "DataSet1";
            rpdts.Value = list;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report5.rdlc";
            this.reportViewer1.LocalReport.SetParameters(reports);
            reportViewer1.LocalReport.DataSources.Add(rpdts);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
