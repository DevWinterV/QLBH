using QLBH_BUS;
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
    public partial class frmHOADON : Form
    {
        public frmHOADON()
        {
            InitializeComponent();
        }
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD cthd = new BUS_CTHD();
        CTHD chitiethd = new CTHD();
        private int dem = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgv_ChiTietHD.DataSource = null;
            dgv_DSHD.DataSource = hd.LoadDuLieu();
            txt_nhap.Clear();
        }
        private int Check_ID(string id)
        {
            try
            {
                int so;
                if (id.Substring(0, 2) == "HD" || id.Substring(0, 2) == "hd")
                {
                    so = 1;
                }
                else if (id.Substring(0, 2) == "NV" || id.Substring(0, 2) == "nv")
                {
                    so = 2;
                }
                else
                    so = 3;
                return so;
            }
            catch { return 0; }

        }
        private bool Check_Date1(DateTime t1, DateTime t2)
        {

            if (t1.Date > t2.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LOad_DSHD()
        {
            dgv_DSHD.DataSource = hd.LoadDuLieu();
        }
        private void Load_DSCTHD()
        {
            dgv_ChiTietHD.DataSource = cthd.LoadDuLieu();
        }

        private void btntimkiemngay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chontimkiem.SelectedIndex == 1)
                {

                    if (Check_Date1(Convert.ToDateTime(datetime_tungay.Text), Convert.ToDateTime(datetime_den.Text)))
                        dgv_DSHD.DataSource = hd.FindDataFromDate(Convert.ToDateTime(datetime_tungay.Text), Convert.ToDateTime(datetime_den.Text));
                    else
                    {
                        errorProvider1.SetError(datetime_tungay, "Ngày không được lớn hơn!");
                        datetime_tungay.Focus();
                    }
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(datetime_den ,ex.Message);
                txt_nhap.Focus();
            }
        }

        private void cbb_chontimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chontimkiem.SelectedIndex == 0)
            {
                txt_nhap.Enabled = true;
                txt_nhap.Focus();
                datetime_tungay.Enabled = false;
                datetime_den.Enabled = false;
                btntimkiemngay.Enabled = false;
            }
            else if (cbb_chontimkiem.SelectedIndex == 1)
            {

                txt_nhap.Enabled = false;
                datetime_tungay.Enabled = true;
                datetime_den.Enabled = true;
                btntimkiemngay.Enabled = true;
            }
            else
            {
                txt_nhap.Enabled = true;
                datetime_tungay.Enabled = true;
                datetime_den.Enabled = true;
                btntimkiemngay.Enabled = false;
            }
        }
        private void Enable_DSHD()
        {
            if (dgv_DSHD.Rows.Count - 1 == 0)
            {
                dgv_DSHD.Enabled = false;
            }
            else
                dgv_DSHD.Enabled = true; ;

        }
        private void frmHOADON_Load(object sender, EventArgs e)
        {
            LOad_DSHD();
            cbb_chontimkiem.SelectedIndex = 0;
            Enable_DSHD();
            
        }

        private void dgv_DSHD_Click(object sender, EventArgs e)
        {
            try
            {
                btninhoadon.Enabled = true;
                btnhuy.Enabled = true;
                btnthemmoi.Enabled = false;
                dgv_ChiTietHD.Enabled=true;
                DataGridViewRow row = dgv_DSHD.CurrentRow;
                if ((string)row.Cells[0].Value != null)
                {
                    dgv_ChiTietHD.DataSource = cthd.LoadDataFromIDSanPham(row.Cells[0].Value.ToString());
                }
            }
            catch
            {; }
        }

        private void datetime_tungay_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_nhap_TextChanged(object sender, EventArgs e)
        {
            if (cbb_chontimkiem.SelectedIndex == 0)
            {
                if (Check_ID(txt_nhap.Text.ToUpper()) == 1)
                    dgv_DSHD.DataSource = hd.FindDataFromIDHD(txt_nhap.Text);
                else if (Check_ID(txt_nhap.Text) == 2)
                    dgv_DSHD.DataSource = hd.FindDataFromIDNV(txt_nhap.Text);
                else
                    dgv_DSHD.DataSource = hd.FindDataFromIDKH(txt_nhap.Text);
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            frm_hoadonbanhang hdbh = new frm_hoadonbanhang();
            hdbh.ShowDialog();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_DSHD.CurrentRow;
            chitiethd.MaHD = row.Cells[0].Value.ToString();
            chitiethd.Ngaylap = Convert.ToDateTime(row.Cells[1].Value.ToString());
            chitiethd.Tennv = row.Cells[2].Value.ToString();
            chitiethd.TenKH = row.Cells[3].Value.ToString();
            chitiethd.DiachiKH = row.Cells[4].Value.ToString();
            chitiethd.SdtKH = row.Cells[5].Value.ToString();
            BUS_SanPham sp = new BUS_SanPham();
            List<CTHD> cthd1 = new List<CTHD> { };
            for (int i = 0; i < dgv_ChiTietHD.RowCount - 1; i++)
            {
                {
                    CTHD hd = new CTHD();
                    hd.Masp = dgv_ChiTietHD.Rows[i].Cells[3].Value.ToString();
                    hd.Tenloai = dgv_ChiTietHD.Rows[i].Cells[1].Value.ToString();
                    hd.Soluuong = int.Parse(dgv_ChiTietHD.Rows[i].Cells[4].Value.ToString());
                    hd.Dongia = float.Parse(dgv_ChiTietHD.Rows[i].Cells[5].Value.ToString());
                    hd.Thanhtien1 = float.Parse(dgv_ChiTietHD.Rows[i].Cells[6].Value.ToString());
                    dem++;
                    cthd1.Add(hd);
                }
            }
            using (frm_InHoaDon IHD = new frm_InHoaDon(Convert.ToDouble(row.Cells[6].Value.ToString())))
            {
                IHD.InHoaDon(chitiethd, cthd1);
                dem = 0;
                IHD.ShowDialog();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btninhoadon.Enabled = false;
            btnhuy.Enabled = false;
            btnthemmoi.Enabled = true;
            dgv_ChiTietHD.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
