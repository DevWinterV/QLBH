using QLBH_BUS;
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
    public partial class frm_report_SP : Form
    {
        public frm_report_SP()
        {
            InitializeComponent();
        }

        private void frm_report_SP_Load(object sender, EventArgs e)
        {
            cbb_chon.SelectedIndex = 0;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            SANPHAM_LOAISANPHAM_BindingSource.DataSource = SP.GetData_SP_LSP();
            reportViewer1.RefreshReport();
        }
        BUS_LoaiHang LH = new BUS_LoaiHang();
        BUS_DONVITINH DVT = new BUS_DONVITINH();
        BUS_NHACUNGCAP NCC = new BUS_NHACUNGCAP();
        BUS_SanPham SP = new BUS_SanPham();
        private void cbb_chon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_chon.SelectedIndex == 0)//LSP
            {
                cbb_DS.DataSource = LH.LoadDuLieu("");
                cbb_DS.DisplayMember = "tenloai";
                cbb_DS.ValueMember = "maloai";

            }
            else if(cbb_chon.SelectedIndex == 1)//DVT
            {
                cbb_DS.DataSource = DVT.LoadDuLieu("");
                cbb_DS.DisplayMember = "tenDVT";
                cbb_DS.ValueMember = "maDVt";
            }
            else
            {
                cbb_DS.DataSource = NCC.LoadDuLieu("");
                cbb_DS.DisplayMember = "tenncc";
                cbb_DS.ValueMember = "mancc";
            }
        }

        private void btn_xemDSSP_Click(object sender, EventArgs e)
        {
            if (cbb_chon.SelectedIndex == 0 && cbb_DS.Text != "")
            {
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                // TODO: This line of code loads data into the 'QLBHDataSet_SP.SANPHAM_LOAISANPHAM_' table. You can move, or remove it, as needed.
                SANPHAM_LOAISANPHAM_BindingSource.DataSource = SP.GetData_SP_LSP(cbb_DS.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }
            else if (cbb_chon.SelectedIndex == 2 && cbb_DS.Text != "")
            {
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                // TODO: This line of code loads data into the 'QLBHDataSet_SP.SANPHAM_LOAISANPHAM_' table. You can move, or remove it, as needed.
                SANPHAM_LOAISANPHAM_BindingSource.DataSource = SP.GetData_SP_NCC(cbb_DS.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }    
            else
            {
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                // TODO: This line of code loads data into the 'QLBHDataSet_SP.SANPHAM_LOAISANPHAM_' table. You can move, or remove it, as needed.
                SANPHAM_LOAISANPHAM_BindingSource.DataSource = SP.GetData_SP_DVT(cbb_DS.SelectedValue.ToString());
                this.reportViewer1.RefreshReport();
            }    
        }

        private void btn_xemall_Click(object sender, EventArgs e)
        {
            frm_report_SP_Load(sender, e);
        }
    }
}
