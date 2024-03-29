﻿using Microsoft.Reporting.WinForms;
using QLBH_BUS;
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
    public partial class frm_baocaodoanhthuthang : Form
    {
        DataSet ds = new DataSet("TB_BAOCAODOANHTHUTHANG");
        public frm_baocaodoanhthuthang()
        {
            InitializeComponent();
        }

        private void frm_baocaodoanhthuthang_Load(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > DateTime.Now)
            {
                dateTimePicker1.Text = "";
                dateTimePicker1.Focus();
            }    
            if(dateTimePicker1.Text.Length > 2)
            {
                dateTimePicker1.Text = "";
                dateTimePicker1.Focus();
            }    
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > DateTime.Now)
            {
                dateTimePicker2.Text = "";
                dateTimePicker2.Focus();
            }
            if (dateTimePicker2.Text.Length > 4 || dateTimePicker2.Text.Length < 4)
            {
                dateTimePicker2.Text = "";
                dateTimePicker2.Focus();
            }
        }
        BUS_PHIEUNO pHIEUNO = new BUS_PHIEUNO();
        private void bt_load_Click(object sender, EventArgs e)
        {
                double TongTien = 0;
            ds.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=rangdong\dongchau;Initial Catalog=QLBH;Integrated Security=True");
            string query = "select cthd.maHD, hd.ngaygd, sum(soluong) as soluong, nv.hoten as tennv, kh.hoten as tenkh, hd.thanhtien,hd.trangthai from chitietHD cthd , hoadon hd, nhanvien nv, KHACHHANG kh where cthd.maHD = hd.maHD and nv.manv =hd.manv and hd.maKH =kh.maKH and MONTH(hd.ngayGD) = '"+dateTimePicker1.Text.Trim()+"' AND YEAR(hd.ngayGD) = '"+dateTimePicker2.Text.Trim()+"' group by cthd.maHD, nv.hoten, kh.hoten, hd.ngayGD, hd.thanhtien, HD.TRANGTHAI ";
            if (pHIEUNO.GetValue(" select SUM(tienno) from Phieuno where Month(ngayNo) =" + dateTimePicker1.Text.Trim() + " and YEAR(ngayno)= " + dateTimePicker2.Text.Trim() + "") != "")
                TongTien = Double.Parse(pHIEUNO.GetValue(" select SUM(tienno) from Phieuno where Month(ngayNo) =" + dateTimePicker1.Text.Trim() + " and YEAR(ngayno)= " + dateTimePicker2.Text.Trim() + ""));
            else
                TongTien = 0;
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Report_DOANHTHUTHANG.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
             {
                new ReportParameter("p_ngaybaocao", DateTime.Now.ToString()),
                new ReportParameter("p_tongno", TongTien.ToString())
             };
                ReportDataSource rpdts = new ReportDataSource();
                rpdts.Name = "DataSet1";
                rpdts.Value = ds.Tables[0];
                 reportViewer1.LocalReport.ReportPath = @"D:\HK1 - Nam 3\Lap trinh_NET\DO AN QLBH .NET\QLBH\QLBH\Report_DOANHTHUTHANG.rdlc";
                //reportViewer1.LocalReport.ReportPath = "Report_DOANHTHUTHANG.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.SetParameters(reports);
                reportViewer1.LocalReport.DataSources.Add(rpdts);
                reportViewer1.RefreshReport();
            }
            else
            {
                TongTien = 0;
                Microsoft.Reporting.WinForms.ReportParameter[] reports = new Microsoft.Reporting.WinForms.ReportParameter[]
             {
                new ReportParameter("p_ngaybaocao", DateTime.Now.ToString()),
                new ReportParameter("p_tongno", TongTien.ToString())
             };
                reportViewer1.RefreshReport();
                MessageBox.Show("Không có doanh thu trong ngày này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
