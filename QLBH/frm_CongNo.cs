using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frm_CongNo : Form
    {
        public frm_CongNo()
        {
            InitializeComponent();
        }
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_PHIEUNO pn = new BUS_PHIEUNO();
        BUS_PHIEUNO_CT pnct = new BUS_PHIEUNO_CT();
        PHIEUNO phieuno = new PHIEUNO();
        PHIEUNO_CT phieunoct = new PHIEUNO_CT();
        BUS_HoaDon hd = new BUS_HoaDon();
        HoaDon hoadon = new HoaDon();
        public  double Tienkhachtra;
        public void Load_DSKHNO()
        {
            dgv_DSKHno.DataSource = kh.Load_DSKHNO();
        }
        public void Load_DSHDNO(string MAKH)
        {
            dgv_dshdno.DataSource = pn.LoadDuLieu(MAKH);
        }
        public void Load_cbbKHNO()
        {
            cbb_tenkh.DataSource = kh.Load_DSKHNO();
            cbb_tenkh.DisplayMember = "hoten";
            cbb_tenkh.ValueMember = "makh";
        }
        public void Load_LICHSUTHANHTOAN(string MAKH)
        {
            dgv_lichsu.DataSource = pnct.LoadDuLieu(MAKH);
        }
        private void frm_CongNo_Load(object sender, EventArgs e)
        {
            Load_cbbKHNO();
            if (cbb_tenkh.Items.Count > 0)
            {
                Load_LICHSUTHANHTOAN(cbb_tenkh.SelectedValue.ToString());
                Load_DSHDNO(cbb_tenkh.SelectedValue.ToString());
                Load_DSKHNO();
                txtdiachi.Text = kh.GetValue("select dchi from khachhang where makh ='"+ cbb_tenkh.SelectedValue.ToString()+"'");
                txtsdt.Text = kh.GetValue("select sodt from khachhang where makh ='" + cbb_tenkh.SelectedValue.ToString() + "'");
              
            }
            if (dgv_DSKHno.Rows.Count - 1 > 0)
                lb_tongno.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + dgv_DSKHno.CurrentRow.Cells[0].Value.ToString() + "' and hd.maHD = pn.mahd")).ToString("c", new CultureInfo("vi-VN"));
        }

        private void dgv_DSKHno_Click(object sender, EventArgs e)
        {
            dgv_chitietno.Rows.Clear();
            if (dgv_DSKHno.Rows.Count -1  > 0)
            {
                    string makh = dgv_DSKHno.CurrentRow.Cells[0].Value.ToString();

                    double nodau =0, muatrongky =0, tratrongky = 0, nocuoi = 0;
                    try
                    {
                        nodau = double.Parse(pn.GetValue("select SUM(PN.TIENNO) from PHIEUNO PN , HOADON HD WHERE PN.ngayNO < '" + dateTime_tungay.Text + " 00:00:00' and PN.maHD = HD.maHD AND HD.maKH ='" + makh + "'"));
                    }
                    catch
                    {
                        nodau = 0;
                    }
                    try
                    {
                        muatrongky = double.Parse(pn.GetValue("select SUM(hd.thanhtien) \r\nfrom HOADON hd \r\nWHERE hd.maKH = '" + makh + "' and hd.ngayGD between '" + dateTime_tungay.Text + " 00:00:00' and '" + dateTime_denngay.Text + " 23:59:59'"));
                    }
                    catch
                    {
                        muatrongky = 0;
                    }
                    try
                    {
                        if (muatrongky > 0)
                        {
                           // double tienno = double.Parse(pn.GetValue("select SUM(pnct.TIENTRA) \r\nfrom PHIEUNO_CT pnct , PHIEUNO pn, HOADON hd\r\nWHERE pnct.maPN = pn.maPN and hd.maKH='" + makh + "'and hd.maHD = pn.mahd and pnct.ngayTRA between '" + dateTime_tungay.Text + " 00:00:00' and '" + dateTime_denngay.Text + " 23:59:59'"));
                            double tienno = double.Parse(pn.GetValue("select SUM(PN.TIENNO) from PHIEUNO PN , HOADON HD WHERE PN.ngayNO between '" + dateTime_tungay.Text + " 00:00:00' and '"+dateTime_denngay.Text+" 23:59:59' and PN.maHD = HD.maHD AND HD.maKH ='" + makh + "'"));
                             tratrongky = muatrongky - tienno;
                        }
                    }
                    catch
                    {
                        tratrongky = 0;
                    }
                    try
                    {
                        nocuoi = (nodau + muatrongky) - tratrongky;
                    }
                    catch
                    {
                        nocuoi = 0;
                    }
                    dgv_chitietno.Rows.Add(nodau, muatrongky, tratrongky, nocuoi);
                    dgv_chitietno.Update();
                    if(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + dgv_DSKHno.CurrentRow.Cells[0].Value.ToString() + "' and hd.maHD = pn.mahd") !="")
                        lb_tongno.Text = double.Parse(pn.GetValue("select SUM(pn.TIENNO) from PHIEUNO pn, HOADON hd WHERE hd.maKH = '" + dgv_DSKHno.CurrentRow.Cells[0].Value.ToString() + "' and hd.maHD = pn.mahd")).ToString("c", new CultureInfo("vi-VN"));
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dshdno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    if (dgv_dshdno.Rows.Count > 0)
                    {
                        DataGridViewRow rowToMove = dgv_dshdno.CurrentRow;
                        frm_TraNoKhachhang trano = new frm_TraNoKhachhang(rowToMove.Cells[4].Value.ToString(), rowToMove.Cells[2].Value.ToString(), rowToMove.Cells[6].Value.ToString());
                        if (rowToMove.Cells[6].Value.ToString() != "0.0000")
                        {
                            trano.ShowDialog();
                            if (trano.Trangthai == 1)
                            {
                                if (rowToMove.Cells[1].Value.ToString() != "")
                                {
                                    phieunoct.MaPN = (string)rowToMove.Cells[1].Value;
                                    phieunoct.Ngaytra = DateTime.Now;
                                    phieunoct.TienTra = SqlMoney.Parse(trano.Tienkhachtra);
                                    pnct.Add(phieunoct);// cập nhật lại số tiền trả nợ
                                    phieuno.MaPN = (string)rowToMove.Cells[1].Value;
                                    pn.Update_SauKhiTraNo(phieuno, SqlMoney.Parse(trano.Tienkhachtra), trano.Ghichu);
                                    hoadon.MaHD = phieunoct.MaPN = (string)rowToMove.Cells[2].Value;
                                    hoadon.Trangthai = trano.Ghichu;
                                    hd.Update(hoadon);
                                    if (cbb_tenkh.Items.Count > 0)
                                    {
                                        Load_DSHDNO(cbb_tenkh.SelectedValue.ToString());
                                        Load_LICHSUTHANHTOAN(cbb_tenkh.SelectedValue.ToString());
                                    }
                                }
                            }
                        } 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void cbb_tenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdiachi.Text = kh.GetValue("select dchi from khachhang where makh ='" + cbb_tenkh.SelectedValue.ToString() + "'");
            txtsdt.Text = kh.GetValue("select sodt from khachhang where makh ='" + cbb_tenkh.SelectedValue.ToString() + "'");
            if (cbb_tenkh.Items.Count > 0)
            {
                Load_DSHDNO(cbb_tenkh.SelectedValue.ToString());
                Load_LICHSUTHANHTOAN(cbb_tenkh.SelectedValue.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_CongNo_Load(sender, e);
        }

        private void txttiemkiemkh_TextChanged(object sender, EventArgs e)
        {
            if (cbbChon.SelectedIndex == 0)
            {
                dgv_DSKHno.DataSource = kh.LoadDuLieu("where makh like '%" + txttiemkiemkh.Text.Trim() + "%' and maKH in(select kh.makh from PHIEUNO pn, HOADON hd, KHACHHANG kh where pn.maHD = hd.maHD and hd.maKH = kh.makh)");
            }
            else if (cbbChon.SelectedIndex == 1)
            {
                dgv_DSKHno.DataSource = kh.LoadDuLieu("where hoten like N'%" + txttiemkiemkh.Text.Trim() + "%' and maKH in(select kh.makh from PHIEUNO pn, HOADON hd, KHACHHANG kh where pn.maHD = hd.maHD and hd.maKH = kh.makh)");
            }
            else
                dgv_DSKHno.DataSource = kh.LoadDuLieu("where sodt like '%" + txttiemkiemkh.Text.Trim() + "%' and maKH  in(select kh.makh from PHIEUNO pn, HOADON hd, KHACHHANG kh where pn.maHD = hd.maHD and hd.maKH = kh.makh)");
            if (txttiemkiemkh.TextLength == 0)
            {
                dgv_DSKHno.DataSource = kh.LoadDuLieu("WHERE maKH  in(select kh.makh from PHIEUNO pn, HOADON hd, KHACHHANG kh where pn.maHD = hd.maHD and hd.maKH = kh.makh )");
            }
          
                
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            frm_CongNo_Load(sender, e);
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

    }
}
