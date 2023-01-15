using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
        private string tennhanvien, manv;
        public frmHOADON(string tennv, string manv)
        {
            InitializeComponent();
            this.tennhanvien = tennv;
            this.manv = manv;
        }
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD cthd = new BUS_CTHD();
        BUS_PHIEUNHAP phieunhap = new BUS_PHIEUNHAP();
        BUS_PHIEUNHAPCHITIET pnct = new BUS_PHIEUNHAPCHITIET();
        CTHD chitiethd = new CTHD();
        PHIEUNHAP_CHITIET phieunhan_ct = new PHIEUNHAP_CHITIET();
        private int dem = 0;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgv_ChiTietHD.DataSource = null;
            dgv_DSHD.DataSource = hd.LoadDuLieu();
            txt_nhap.Clear();
            Enable_DSHD();
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
        private int Check_ID_FindPhieuNhap(string id)
        {
            try
            {
                int so;
                if (id.Substring(0, 2) == "PN" || id.Substring(0, 2) == "pn")
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
        private void LOad_DSPN()
        {
            dgv_DSPN.DataSource = phieunhap.LoadDuLieu();
        }

        private void btntimkiemngay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chontimkiem.SelectedIndex == 1)
                {

                    if (Check_Date1(Convert.ToDateTime(datetime_tungay.Text), Convert.ToDateTime(datetime_den.Text)))
                        dgv_DSHD.DataSource = hd.FindDataFromDate(datetime_tungay.Text, datetime_den.Text);
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
        private void Enable_DSPN()
        {
            if (dgv_DSPN.Rows.Count - 1 == 0)
            {
                dgv_DSPN.Enabled = false;
            }
            else
                dgv_DSPN.Enabled = true; ;

        }

        private void frmHOADON_Load(object sender, EventArgs e)
        {
            LOad_DSHD();
            LOad_DSPN();
            cbb_chontimkiem.SelectedIndex = 0;
            Enable_DSHD();
            Enable_DSPN();
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
                if (row != null)
                {
                    if ((string)row.Cells[0].Value != null)
                    {
                        dgv_ChiTietHD.DataSource = cthd.LoadDataFromIDSanPham(row.Cells[0].Value.ToString());
                    }
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
            frm_hoadonbanhang hdbh = new frm_hoadonbanhang(tennhanvien,manv);
            hdbh.Show();
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
            chitiethd.Thanhtien1 = float.Parse(row.Cells[6].Value.ToString());
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
            frm_inHD inHD = new frm_inHD(chitiethd.MaHD, chitiethd.Tennv, chitiethd.TenKH, chitiethd.SdtKH, "( " + XTL.Utils.NumberToText(chitiethd.Thanhtien1) + " )", "0", "0", chitiethd.Ngaylap, "0", "0", cthd1);
            inHD.ShowDialog();
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frm_Nhapsanpham nsp = new frm_Nhapsanpham(tennhanvien,manv);
            nsp.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            btn_inpn.Enabled = false;
            btnhuypn.Enabled = false;
            btn_themmoiPN.Enabled = true;
            dgv_CTPN.Enabled = false;
            dgv_CTPN.DataSource = null; 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dgv_ChiTietHD.DataSource = null;
            txt_tiemkiem.Clear();
            Enable_DSPN();
            dgv_CTPN.DataSource = null;
            LOad_DSPN();
        }

        private void dgv_DSPN_Click(object sender, EventArgs e)
        {
            try
            {
                btn_inpn.Enabled = true;
                btnhuypn.Enabled = true;
                btn_themmoiPN.Enabled = false;
                dgv_ChiTietHD.Enabled = true;
                DataGridViewRow row = dgv_DSPN.CurrentRow;
                if (dgv_DSPN.Rows.Count -1 > 0)
                {
                    if ((string)row.Cells[0].Value != null)
                    {
                        dgv_CTPN.DataSource = pnct.LoadData_From_IDPN(row.Cells[0].Value.ToString());
                    }
                }
            }
            catch
            {; }
        }

        private void btntimkiemPN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chontimkiem_PN.SelectedIndex == 1)
                {

                    if (Check_Date1(Convert.ToDateTime(datetime_tungya.Text), Convert.ToDateTime(datetime_denngay.Text)))
                    {
                        dgv_DSPN.DataSource = phieunhap.FinDataFromDate(datetime_tungya.Text,datetime_denngay.Text);
                    }
                    else
                    {
                        errorProvider1.SetError(datetime_tungya, "Ngày không được lớn hơn!");
                        datetime_tungya.Focus();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(datetime_den, ex.Message);
                txt_nhap.Focus();
            }
        }

        private void cbb_chontimkiem_PN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chontimkiem_PN.SelectedIndex == 0)
            {
                txt_tiemkiem.Enabled = true;
                txt_tiemkiem.Focus();
                datetime_denngay.Enabled = false;
                datetime_tungya.Enabled = false;
                btntimkiemPN.Enabled = false;
            }
            else if (cbb_chontimkiem_PN.SelectedIndex == 1)
            {

                txt_tiemkiem.Enabled = false;
                datetime_tungya.Enabled = true;
                datetime_denngay.Enabled = true;
                btntimkiemPN.Enabled = true;
            }
            else
            {
                txt_nhap.Enabled = true;
                datetime_tungay.Enabled = true;
                datetime_den.Enabled = true;
                btntimkiemngay.Enabled = false;
            }
        }

        private void txt_tiemkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_chontimkiem_PN.SelectedIndex == 0)
            {
                if (Check_ID_FindPhieuNhap(txt_tiemkiem.Text.ToUpper()) == 1)
                    dgv_DSPN.DataSource = phieunhap.FindDataFromIDPN(txt_tiemkiem.Text);
                else if (Check_ID(txt_nhap.Text) == 2)
                    dgv_DSPN.DataSource = phieunhap.FindDataFromIDNV(txt_tiemkiem.Text);
                else
                    dgv_DSPN.DataSource = phieunhap.FindDataFromIDNCC(txt_tiemkiem.Text);
            }
            if(txt_tiemkiem.Text.Length == 0)
            {
                LOad_DSPN();
            }    
        }


        private void btn_inpn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_DSPN.CurrentRow;

            List<PHIEUNHAP_CHITIET> PNCT1 = new List<PHIEUNHAP_CHITIET> { };
            for (int i = 0; i < dgv_CTPN.RowCount - 1; i++)
            {
                {
                    PHIEUNHAP_CHITIET pnctt = new PHIEUNHAP_CHITIET();
                    pnctt.Tenloai = dgv_CTPN.Rows[i].Cells[1].Value.ToString();
                    pnctt.Masp = dgv_CTPN.Rows[i].Cells[2].Value.ToString();
                    pnctt.Tensanpham = dgv_CTPN.Rows[i].Cells[3].Value.ToString();
                    pnctt.Dongia1 = SqlMoney.Parse( dgv_CTPN.Rows[i].Cells[5].Value.ToString());
                    pnctt.Soluong = int.Parse( dgv_CTPN.Rows[i].Cells[4].Value.ToString());
                    pnctt.Thanhtien = double.Parse(dgv_CTPN.Rows[i].Cells[6].Value.ToString());
                    PNCT1.Add(pnctt);
                }
            }
            frm_inphieunhapkho inphieunhap = new frm_inphieunhapkho(row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString() , row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString(),PNCT1);
            inphieunhap.ShowDialog();
        }
    }
}
