using DevExpress.XtraReports.Design;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XTL;
namespace QLBH
{
    public partial class frm_InHoaDon : Form
    {
        private double tienchu;
        private double _tienkhachtra, _tienthoi;

        public frm_InHoaDon(double TienChu, double tienkhachtra, double tienthoi)
        {
            this.tienchu = TienChu;
            this._tienkhachtra = tienkhachtra;
            this._tienthoi = tienthoi;
            InitializeComponent();
        }
        public frm_InHoaDon(double TienChu)
        {
            this.tienchu = TienChu;
            InitializeComponent();
        }


        public void InHoaDon(CTHD cthd, List<CTHD> data)
        {
            Report rp = new Report();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in rp.Parameters)
            {
                p.Visible = false;
            }
            rp.InitData(data, cthd.MaHD, cthd.Ngaylap, cthd.Tennv, cthd.TenKH, cthd.DiachiKH, cthd.SdtKH, "( " + XTL.Utils.NumberToText(tienchu) + " )", _tienkhachtra.ToString("N", CultureInfo.InvariantCulture) +" VNĐ", _tienthoi.ToString("N", CultureInfo.InvariantCulture)+" VNĐ") ;
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }    
    }
}
