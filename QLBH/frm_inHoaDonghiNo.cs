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
    public partial class frm_inHoaDonghiNo : Form
    {
        public frm_inHoaDonghiNo()
        {
            InitializeComponent();
        }
        public frm_inHoaDonghiNo(string mahd, string tennv, string tenkh, string sdtkh, string tienchu, string tienkhachtra, string tiennolai, DateTime ngaylap, string chietkhau, string tongtien,string tongno, List<CTHD> dS_cthd)
        {
            InitializeComponent();
            _mahd = mahd;
            _tennv = tennv;
            _tenkh = tenkh;
            _sdtkh = sdtkh;
            _tienchu = tienchu;
            _tienkhachtra = tienkhachtra;
            _tienthoilai = tiennolai;
            _ngaylap = ngaylap;
            DS_cthd = dS_cthd;
            Chietkhau = chietkhau;
            Tongtien = tongtien;
            TongNoKH = tongno;
        }
        private string _mahd, _tennv, _tenkh, _sdtkh, _tienchu, _tienkhachtra, _tienthoilai;
        private string _chietkhau;
        private string _tongtien,_tongno;
        private DateTime _ngaylap;
        List<CTHD> DS_cthd = new List<CTHD>();

        public List<CTHD> DS_cthd1 { get => DS_cthd; set => DS_cthd = value; }
        public string Mahd { get => _mahd; set => _mahd = value; }
        public string Tennv { get => _tennv; set => _tennv = value; }
        public string Tenkh { get => _tenkh; set => _tenkh = value; }
        public string Sdtkh { get => _sdtkh; set => _sdtkh = value; }
        public string Tienchu { get => _tienchu; set => _tienchu = value; }
        public string Tienkhachtra { get => _tienkhachtra; set => _tienkhachtra = value; }
        public string Tienthoilai { get => _tienthoilai; set => _tienthoilai = value; }
        public DateTime Ngaylap { get => _ngaylap; set => _ngaylap = value; }
        public string Chietkhau { get => _chietkhau; set => _chietkhau = value; }
        public string Tongtien { get => _tongtien; set => _tongtien = value; }
        public string TongNoKH { get => _tongno; set => _tongno = value; }

        private void frm_inHoaDonghiNo_Load(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report8.rdlc"; ;
            Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new ReportParameter("p_ngaylap",Ngaylap.ToString()),
                new ReportParameter("p_tennv", Tennv),
                new ReportParameter("p_tenKH", Tenkh),
                new ReportParameter("p_sdt", Sdtkh),
                new ReportParameter("p_chuyendoisangchu", Tienchu),
                new ReportParameter("p_tienkhachtra", Tienkhachtra),
                new ReportParameter("p_tiennolai", Tienthoilai),
                new ReportParameter("p_tongnoKH", TongNoKH),
                new ReportParameter("p_mahd", Mahd),
               // new ReportParameter("p_chietkhau", Chietkhau),
                new ReportParameter("p_phaithanhtoan", Tongtien),
            };
            ReportDataSource rpdts = new ReportDataSource();
            rpdts.Name = "DataSet1";
            rpdts.Value = DS_cthd1;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report8.rdlc";
           // reportViewer1.LocalReport.ReportPath = "Report8.rdlc";
            this.reportViewer1.LocalReport.SetParameters(reports);
            reportViewer1.LocalReport.DataSources.Add(rpdts);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
