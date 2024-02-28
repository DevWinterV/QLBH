using DevExpress.CodeParser;
using Microsoft.Reporting.WinForms;
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
    
    public partial class frm_xuatbarcodesanpham : Form
    {
        DataSet1.BarcodeDataTable _barcode;

        public frm_xuatbarcodesanpham(DataSet1.BarcodeDataTable barcode)
        {
            InitializeComponent();
            this._barcode = barcode;
        }

        private void frm_xuatbarcodesanpham_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = _barcode;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
