using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frm_BanHang;
using System.Globalization;
using System.Text.RegularExpressions;
using QLBH;

namespace frm_BanHang
{
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang kh = new BUS_KhachHang();
        KhachHang khachhang = new KhachHang();
        bool ThemKH = false;
        public void Load_DSKH()
        {
            dgv_DSKH.DataSource = kh.LoadDuLieu("");
        }
        private void Enable_Khachhang(bool t)
        {
            btnthem.Enabled = !t;
            btnsua.Enabled = !t;
            btnluu.Enabled = t;
            btnhuy.Enabled = t;
            txthoten.Enabled = t;
            txt_diachi.Enabled = t;
            txt_sdt.Enabled = t;
            txt_latitude.Enabled = t;   
            txt_longitude.Enabled = t;
            txt_bietdanh.Enabled = t;
            cbb_nhomkh.Enabled = t;
        }
        private void ClearText()
        {
            txthoten.Text= "";
            txt_diachi.Text = "";
            txt_sdt.Text ="";
            txtMakh.Text = "";
            txt_latitude.Text = "";
            txt_longitude.Text = "";
            txt_bietdanh.Text = "";
            cbb_nhomkh.Text = "";
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            Load_DSKH();
            LoadSoKh();
            Load_CbbNKH();

        }
        private void InitializeCustomAutoComplete()
        {
            cbb_nhomkh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_nhomkh.AutoCompleteMode = AutoCompleteMode.None;
            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();

            // Fetch data from database
            var dataTable = kh.LoadDulieuNhomKh("select * from nhomkhachang");

            // Populate the AutoCompleteStringCollection with data from the database
            foreach (DataRow row in dataTable.Rows)
            {
                autoCompleteSource.Add(row["tenloai"].ToString());
            }

            // Set up autocomplete for the ComboBox
            cbb_nhomkh.AutoCompleteCustomSource = autoCompleteSource;
            cbb_nhomkh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_nhomkh.AutoCompleteMode = AutoCompleteMode.None;
            cbb_nhomkh.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void Load_CbbNKH()
        {
            cbb_nhomkh.DataSource = kh.LoadDulieuNhomKh("select * from nhomkhachang");
            cbb_nhomkh.DisplayMember = "ten_nhomkh";
            cbb_nhomkh.ValueMember = "ma_nhomkh";
        }
        private void dgv_DSKH_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_DSKH.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null)
                {
                    txtMakh.Text = dr.Cells[0].Value.ToString();
                    txthoten.Text = dr.Cells[1].Value.ToString();
                    txt_diachi.Text = dr.Cells[2].Value.ToString();
                    txt_sdt.Text = dr.Cells[3].Value.ToString();
                    txt_latitude.Text = dr.Cells[4].Value.ToString();
                    txt_longitude.Text = dr.Cells[5].Value.ToString();
                    txt_bietdanh.Text = dr.Cells[7].Value.ToString();
                    cbb_nhomkh.Text = dr.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            ThemKH = true;
            Enable_Khachhang(true);
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMakh.Text != "")
                {
                    if (MessageBox.Show("Bạn có muốn Xóa không ? Các hóa đơn của khách hàng " + txtMakh.Text + " sẽ bị xóa vĩnh viễn!!", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        khachhang.MaKH = txtMakh.Text;
                        kh.Delete(khachhang);
                        Load_DSKH();
                        LoadSoKh();
                        ClearText();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể xóa", "Lỗi" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (dgv_DSKH.Rows.Count > 1)
                Enable_Khachhang(true);
            else
                MessageBox.Show("Danh sách khách hàng rỗng!", "Thông báo");
        }
        private string Replace_whitepace_FirstWord(string chuoi)
        {
            string newstring = chuoi.Trim();
            Regex trimer = new Regex(@"\s\s+");
            newstring = trimer.Replace(newstring, " ");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newstring.ToLower());
        }
        private int Check_NumberPhone()
        {
            return int.Parse(kh.GetValue("select count(sodt) from khachhang where sodt  ='" + txt_sdt.Text + "'"));
        }
        private bool Check_Infor()
        {
            if(txthoten.Text == "") { MessageBox.Show("Nhập họ tên", "Thông báo");txthoten.Focus();  return false; }
            if (txt_sdt.Text == "") { MessageBox.Show("Nhập số điện thoại", "Thông báo"); txt_sdt.Focus();  return false; }
            if (txt_sdt.Text.Length >10 || txt_sdt.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại", "Thông báo"); txt_sdt.Focus(); return false; }
            if(Check_NumberPhone() == 1) { MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống. Vui lòng kiểm tra lại số điện thoại", "Thông báo"); txt_sdt.Focus(); return false; }
            if (txt_sdt.Text == "") { MessageBox.Show("Nhập số điện thoại", "Thông báo"); txt_sdt.Focus(); return false; }
            if (cbb_nhomkh.Text == "") { MessageBox.Show("Vui lòng chọn nhóm khách hàng", "Thông báo"); cbb_nhomkh.Focus(); return false; }
            return true;
        }
        private bool Check_Infor_CapNhat()
        {
            if (txthoten.Text == "") { MessageBox.Show("Nhập họ tên", "Thông báo"); txthoten.Focus(); return false; }
            if (txt_sdt.Text == "") { MessageBox.Show("Nhập số điện thoại", "Thông báo"); txt_sdt.Focus(); return false; }
            if (txt_sdt.Text.Length > 11 || txt_sdt.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại phải là 10 đến 11", "Thông báo"); txt_sdt.Focus(); return false; }
            return true;
        }
            private void btnluu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ThemKH == true)
                {
                    if (Check_Infor())
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin khách hàng không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            khachhang.MaKH = txtMakh.Text;
                            khachhang.Hoten = Replace_whitepace_FirstWord(txthoten.Text);
                            khachhang.Sodt = txt_sdt.Text;
                            khachhang.Dchi = Replace_whitepace_FirstWord(txt_diachi.Text);
                            khachhang.Tenbietdanh = Replace_whitepace_FirstWord(txt_bietdanh.Text);
                            if (txt_latitude.Text != "")
                                khachhang.Latidue = float.Parse(txt_latitude.Text);
                            else
                                khachhang.Latidue = 0;
                            if (txt_longitude.Text != "")
                                khachhang.Longitude = float.Parse(txt_longitude.Text);
                            else
                                khachhang.Longitude = 0;
                            khachhang.ManhomKh = int.Parse(cbb_nhomkh.SelectedValue.ToString());
                            kh.Add(khachhang);
                            Load_DSKH();
                            LoadSoKh();
                            Enable_Khachhang(false);
                            ClearText();
                            ThemKH = false;
                        }
                    }
                }
                else
                {
                    if ((string)dgv_DSKH.CurrentRow.Cells[3].Value == txt_sdt.Text)
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            khachhang.MaKH = txtMakh.Text;
                            khachhang.Hoten = txthoten.Text;
                            khachhang.Sodt = txt_sdt.Text;
                            khachhang.Dchi = txt_diachi.Text;
                            khachhang.Tenbietdanh = Replace_whitepace_FirstWord(txt_bietdanh.Text);
                            if (txt_latitude.Text != "")
                                khachhang.Latidue = float.Parse(txt_latitude.Text);
                            else
                                khachhang.Latidue = 0;
                            if (txt_longitude.Text != "")
                                khachhang.Longitude = float.Parse(txt_longitude.Text);
                            else
                                khachhang.Longitude = 0;
                            khachhang.ManhomKh = int.Parse(cbb_nhomkh.SelectedValue.ToString());
                            kh.Update(khachhang);
                            Load_DSKH();
                            LoadSoKh();
                            Enable_Khachhang(false);
                            ClearText();
                        }
                    }
                    else
                    {
                        if (Check_Infor_CapNhat())
                        {
                            if (Check_NumberPhone() == 0)
                            {
                                if (MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    khachhang.MaKH = txtMakh.Text;
                                    khachhang.Hoten = txthoten.Text;
                                    khachhang.Sodt = txt_sdt.Text;
                                    khachhang.Dchi = txt_diachi.Text;
                                    khachhang.Tenbietdanh = Replace_whitepace_FirstWord(txt_bietdanh.Text);
                                    if (txt_latitude.Text != "")
                                        khachhang.Latidue = float.Parse(txt_latitude.Text);
                                    else
                                        khachhang.Latidue = null;
                                    if (txt_longitude.Text != "")
                                        khachhang.Longitude = float.Parse(txt_longitude.Text);
                                    else
                                        khachhang.Longitude = null;
                                    khachhang.ManhomKh = int.Parse(cbb_nhomkh.SelectedValue.ToString());
                                    kh.Update(khachhang);
                                    Load_DSKH();
                                    LoadSoKh();
                                    Enable_Khachhang(false);
                                    ClearText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống. Vui lòng kiểm tra lại số điện thoại", "Thông báo"); txt_sdt.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadSoKh()
        {
            lbtongkh.Text = (dgv_DSKH.Rows.Count-1).ToString();
        }
        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            Enable_Khachhang(false);
            ClearText();
            ThemKH = false;
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

            if (cbbChon.SelectedIndex == 1)
            {
                dgv_DSKH.DataSource = kh.LoadDuLieu("and KHACHHANG.makh like '%" + txttimkiem.Text.Trim() + "%'");
            }
            else if (cbbChon.SelectedIndex == 0)
            {
                dgv_DSKH.DataSource = kh.LoadDuLieu("and KHACHHANG.hoten like N'%" + txttimkiem.Text.Trim() +"%'");
            }
            else
                dgv_DSKH.DataSource = kh.LoadDuLieu("and KHACHHANG.sodt like '%" + txttimkiem.Text.Trim() + "%'");
            if (txttimkiem.TextLength == 0)
            {
                dgv_DSKH.DataSource = kh.LoadDuLieu("");
            }
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttimkiem.Enabled = true;
            txttimkiem.Focus();
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            frm_baocaokhachhang bckh = new frm_baocaokhachhang();
            bckh.ShowDialog();
        }


    }
}
