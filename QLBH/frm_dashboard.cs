using DevExpress.DataAccess.Sql;
using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using XTL;
namespace QLBH
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_NhanVien nv = new BUS_NhanVien();
        BUS_PHIEUNO pn = new BUS_PHIEUNO();
        private void cbb_chonxem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chonxem.SelectedIndex == 0)//NGÀY
                {
                    chart_doanhthu.DataSource = hd.GetData("Select DAY(ngayGD) as 'NGAY', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE ngayGD  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  Group by DAY(ngayGD)");
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueMember = "NGAY";
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueMembers = "TONGDOANHTHU";
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    if (hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON WHERE ngayGD  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  Group by DAY(ngayGD)") != null)
                        lb_tongdoanhthu.Text = double.Parse(hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON WHERE ngayGD  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ")).ToString("c", new CultureInfo("vi-VN"));
                    if (hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON where ngayGD  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  Group by DAY(ngayGD)") != "")
                        lb_tonghoadon.Text = hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON  where ngayGD  BETWEEN '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ");
                    if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd and pn.ngayno between  '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59' ") != "")
                        lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = 'kh.makh' and hd.maHD = pn.mahd and pn.ngayno between  '" + DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00' AND '" + DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59'  ")).ToString("c", new CultureInfo("vi-VN"));
                }
                else if (cbb_chonxem.SelectedIndex == 1)//TUẦN
                {
                    var first = DateTime.Now.FirstDayOfWeek();
                    var last = DateTime.Now.LastDayOfWeek();
                    chart_doanhthu.DataSource = hd.GetData("Select DAY(ngayGD) as 'NGAY', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE ngayGD BETWEEN '" + first + "'  AND '" + last + "' Group by DAY(ngayGD)");
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueMember = "NGAY";
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueMembers = "TONGDOANHTHU";
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    if (hd.GetValue("Select Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE ngayGD BETWEEN '" + first + "'  AND '" + last + "'") != "")
                        lb_tongdoanhthu.Text = double.Parse(hd.GetValue("Select Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE ngayGD BETWEEN '" + first + "'  AND '" + last + "'")).ToString("c", new CultureInfo("vi-VN"));
                    if (hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON  WHERE ngayGD BETWEEN '" + first + "'  AND '" + last + "'") != "")
                        lb_tonghoadon.Text = hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON  WHERE ngayGD BETWEEN '" + first + "'  AND '" + last + "'");
                    if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd and pn.ngayno BETWEEN '" + first + "'  AND '" + last + "' ") != "")
                        lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = 'kh.makh' and hd.maHD = pn.mahd and pn.ngayno BETWEEN '" + first + "'  AND '" + last + "' ")).ToString("c", new CultureInfo("vi-VN"));
                }
                else if (cbb_chonxem.SelectedIndex == 2)//THÁNG
                {
                    DateTime month = DateTime.Now;
                    int thang = month.Month;
                    chart_doanhthu.DataSource = hd.GetData("Select DAY(ngayGD) as 'THANG', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE MONTH(ngayGD) = " + thang + " Group by DAY(ngayGD)");
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueMember = "THANG";
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueMembers = "TONGDOANHTHU";
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    if (hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON  WHERE MONTH(ngayGD) = " + thang + "") != "")
                        lb_tongdoanhthu.Text = double.Parse(hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON  WHERE MONTH(ngayGD) = " + thang + " ")).ToString("c", new CultureInfo("vi-VN"));
                    if (hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON  WHERE MONTH(ngayGD) = " + thang + " ") != "")
                        lb_tonghoadon.Text = hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON  WHERE MONTH(ngayGD) = " + thang + "");
                    if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd and MONTH(pn.ngayno) = " + thang + "") != "")
                        lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = 'kh.makh' and hd.maHD = pn.mahd and MONTH(pn.ngayno) = " + thang + "")).ToString("c", new CultureInfo("vi-VN"));
                }
                else if (cbb_chonxem.SelectedIndex == 3)//NĂM
                {
                    int namhientai = KHOANGCACHNGAY.CurrentYear();
                    chart_doanhthu.DataSource = hd.GetData("Select MONTH(ngayGD) as 'THANG', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON WHERE ngayGD BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59' Group by MONTH(ngayGD)");
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueMember = "THANG";
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueMembers = "TONGDOANHTHU";
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    if (hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON WHERE ngayGD BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'") != "")
                        lb_tongdoanhthu.Text = double.Parse(hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON WHERE ngayGD BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'")).ToString("c", new CultureInfo("vi-VN"));
                    if (hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON WHERE ngayGD BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'") != "")
                        lb_tonghoadon.Text = hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON WHERE ngayGD BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'");
                    if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd and pn.ngayno  BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'") != "")
                        lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = 'kh.makh' and hd.maHD = pn.mahd and pn.ngayno  BETWEEN '" + namhientai + "-01-01 00:00:00' AND '" + namhientai + "-12-31  23:59:59'")).ToString("c", new CultureInfo("vi-VN"));

                }
                else
                {
                    chart_doanhthu.DataSource = hd.GetData("Select YEAR(ngayGD) as 'NAM', Sum(thanhtien) as 'TONGDOANHTHU' From HOADON group by YEAR(ngayGD)");
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueMember = "NAM";
                    chart_doanhthu.Series["TONGDOANHTHU"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueMembers = "TONGDOANHTHU";
                    chart_doanhthu.Series["TONGDOANHTHU"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    if (hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON") != "")
                        lb_tongdoanhthu.Text = double.Parse(hd.GetValue("Select  Sum(thanhtien) as 'THANHTIEN' From HOADON")).ToString("c", new CultureInfo("vi-VN"));
                    if (hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON") != "")
                        lb_tonghoadon.Text = hd.GetValue("Select  count(maHD) as 'TONGSOHOADON' From HOADON");
                    if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd , KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd") != "")
                        lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = 'kh.makh' and hd.maHD = pn.mahd")).ToString("c", new CultureInfo("vi-VN"));

                }
            }
            catch {; }

        }
        private void frm_dashboard_Load(object sender, EventArgs e)
        {
                cbb_chonxem.SelectedIndex = 0;
                timer1.Interval = 1000;
                timer1.Start();
                timer1.Enabled = true;
                chart_topsanphambanchay.DataSource = hd.GetData("select top 10 sp.tensp as 'TENSP', SUM(cthd.soluong) as 'SOLUONG' from chitietHD cthd inner join sanphamDGD sp on sp.masp = cthd.masp INNER JOIN HOADON HD ON HD.maHD = cthd.maHD GROUP BY SP.tensp ORDER BY SOLUONG desc");
                chart_topsanphambanchay.Series["TONGSOLUONG"].XValueMember = "TENSP";
                chart_topsanphambanchay.Series["TONGSOLUONG"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chart_topsanphambanchay.Series["TONGSOLUONG"].YValueMembers = "SOLUONG";
                chart_topsanphambanchay.Series["TONGSOLUONG"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                if (kh.GetValue("Select  count(maKH) as 'TONGSOKHACHHANG' From KHACHHANG") != "")
                    lb_tongkhachhang.Text = kh.GetValue("Select  count(maKH) as 'TONGSOKHACHHANG' From KHACHHANG");
                if (pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHAChHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd") != "")
                   lb_tongnhanvien.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd, KHACHHANG kh WHERE hd.maKH = kh.makh and hd.maHD = pn.mahd")).ToString("c", new CultureInfo("vi-VN"));

            // lb_tongnhanvien.Text = nv.Getvalue("Select  count(manv) as 'TONGSONHANVIEN' From nhanvien  WHERE MANV NOT LIKE 'ADMIN'");


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_dashboard_Load(sender, e);
            chart_topsanphambanchay.DataSource = hd.GetData("select top 10 sp.tensp as 'TENSP', SUM(cthd.soluong) as 'SOLUONG' from chitietHD cthd inner join sanphamDGD sp on sp.masp = cthd.masp INNER JOIN HOADON HD ON HD.maHD = cthd.maHD GROUP BY SP.tensp ORDER BY SOLUONG desc");
            chart_topsanphambanchay.Series["TONGSOLUONG"].XValueMember = "TENSP";
            chart_topsanphambanchay.Series["TONGSOLUONG"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart_topsanphambanchay.Series["TONGSOLUONG"].YValueMembers = "SOLUONG";
            chart_topsanphambanchay.Series["TONGSOLUONG"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_ngaygiohientai.Text = DateTime.Now.ToLongTimeString();
        }

        private void chart_topsanphambanchay_Click(object sender, EventArgs e)
        {

        }
    }
}
