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
    public partial class frmbaocaodoanhthungay : Form
    {
        DataSet ds = new DataSet("TB_BAOCAODOANHTHUNGAY");
        public frmbaocaodoanhthungay()
        {
            InitializeComponent();
        }

        private void frmbaocao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(date_ngaychon.Text) < DateTime.Now)
            {
                ds.Clear();
                SqlConnection cn = new SqlConnection(@"Data Source=RANGDONG\DONGCHAU;Initial Catalog=QLBH;Integrated Security=True");
                string query = "select cthd.maHD, hd.ngaygd, sum(soluong) as soluong, nv.hoten as tennv, kh.hoten as tenkh, hd.thanhtien from chitietHD cthd , hoadon hd, nhanvien nv, KHACHHANG kh where cthd.maHD = hd.maHD and nv.manv =hd.manv and hd.maKH =kh.maKH and  HD.ngayGD BETWEEN '"+date_ngaychon.Text+" 00:00:00' AND '"+date_ngaychon.Text+" 23:59:59' group by cthd.maHD, nv.hoten, kh.hoten, hd.ngayGD, hd.thanhtien\r\n";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(ds);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer1.LocalReport.ReportEmbeddedResource = "Report2.rdlc";
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
                 {
                new ReportParameter("p_ngaybaocao", DateTime.Now.ToString())
                 };
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportDataSource rpdts = new ReportDataSource();
                    rpdts.Name = "DataSet1";
                    rpdts.Value = ds.Tables[0];
                    reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report2.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.SetParameters(reports);
                    reportViewer1.LocalReport.DataSources.Add(rpdts);
                }
                else
                {
                    reportViewer1.RefreshReport();
                    MessageBox.Show("Ngày bạn chọn hiện tại không có doanh thu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ngày bạn chọn không được lớn hơn hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date_ngaychon.Focus();
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
