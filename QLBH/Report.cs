using DevExpress.Office.Utils;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using QLBH_Enity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Report()
        {
            InitializeComponent();
        }
        public void InitData( List<CTHD> cthd,string mahd, DateTime ngaylap, string tennhanvien, string tenKH, string diachiKH, string sdt, string TienChu, string tienkhachtra, string tientthoilai)
        {
            p_MaHD.Value = mahd;
            p_ngaylap.Value = ngaylap;
            p_nhanvien.Value = tennhanvien;
            p_khachhang.Value = tenKH;
            p_diachi.Value = diachiKH;
            p_phone.Value = sdt;
            p_chuyensosangchu.Value = TienChu;
            p_tienkhachtra.Value = tienkhachtra;
            p_tienthoilai.Value = tientthoilai;
            objectDataSource1.DataSource = cthd.ToArray();
        }
    }
}
