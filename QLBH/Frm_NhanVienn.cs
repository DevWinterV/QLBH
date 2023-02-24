using QLBH_BUS;
using QLBH_Enity;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Frm_NhanVienn : Form
    {
        public Frm_NhanVienn()
        {
            InitializeComponent();
        }
        BUS_NhanVien nv = new BUS_NhanVien();
        BUS_NguoiDung nd = new BUS_NguoiDung();
        NguoiDung nguoidung = new NguoiDung();
        NhanVien nhanvien = new NhanVien();
        bool ThemNV = false;
        bool ThemTK = false;
        private void LoadDSNV()
        {
            dgvDSNV.DataSource = nv.LoadDuLieu(" WHERE manv not like 'ADMIN'");
        }
        private void LoadDSTK()
        {
            DSTK.DataSource = nd.LoadDuLieu("");
        }
        private void Load_cbbtennv()
        {
            cbb_tennv.DataSource = nv.LoadDuLieu(" WHERE manv not like 'ADMIN'");
            cbb_tennv.DisplayMember = "hoten";
            cbb_tennv.ValueMember = "manv";
        }
        private void Enable_Nhanvien(bool t)
        {
            btnthem.Enabled = !t;
            btnsua.Enabled = !t;
            btnluu.Enabled = t;
            btnhuy.Enabled = t;
            txt_dichi.Enabled = t;
            txtHotenNV.Enabled = t;
            txtSDT.Enabled = t;
            datetime_NS.Enabled = t;
            rad_nam.Enabled = t;
            rad_nu.Enabled = t;

        }
        private void Enable_TK(bool t)
        {
            btnThemTK.Enabled = !t;
            btnSuaTK.Enabled = !t;
            btnLuuTK.Enabled = t;
            btnhuyTK.Enabled = t;
            cbb_tennv.Enabled = t;
            txt_matkhau_taikhoan.Enabled = t;
            rad_admin_tk.Enabled = t;
            rad_nhanvien_tk.Enabled = t;

        }
        
        private void ClearText_tk()
        {
            cbb_tennv.Text = "";
            txt_taikhoan_taikhoan.Text = "";
            txt_matkhau_taikhoan.Text = "";
            rad_nhanvien_tk.Checked = true;
            cbb_chonTK.SelectedIndex = 0;
        }
        private void ClearText()
        {
            txtmanv.Text = "";
            txtHotenNV.Text = "";
            txtSDT.Text = "";
            txt_dichi.Text = "";
            datetime_NS.Text = "01/01/1990";
        }
        private void LoadTongSoNV()
        {
            lb_tongnhanvien.Text = nv.Getvalue("select count(manv) from nhanvien ");
        }
        private void Frm_NhanVienn_Load(object sender, EventArgs e)
        {
            LoadDSTK();
            Load_cbbtennv();
            LoadDSNV();
            LoadTongSoNV();
            cbbChon.SelectedIndex = 0;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvDSNV_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgvDSNV.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[5].Value != null)
                {
                    txtmanv.Text = dr.Cells[0].Value.ToString();
                    txtHotenNV.Text = dr.Cells[1].Value.ToString();
                    txtSDT.Text = dr.Cells[2].Value.ToString();
                    txt_dichi.Text = dr.Cells[4].Value.ToString();
                    datetime_NS.Text = dr.Cells[3].Value.ToString();
                    if ((string)dr.Cells[5].Value == rad_nam.Text)
                        rad_nam.Checked = true;
                    else
                        rad_nu.Checked = true;
                    if ((string)dr.Cells[6].Value == check_tinhtrang.Text)
                        check_tinhtrang.Checked = true;
                    else
                        check_tinhtrang.Checked = false;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private string GioiTinh()
        {
            string sex = "";
            if (rad_nam.Checked == true)
                sex = rad_nam.Text;
            else
                sex = rad_nu.Text;
            return sex;
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
            return int.Parse(nv.Getvalue("select count(sodt) from nhanvien where sodt  ='" + txtSDT.Text + "'"));
        }
        private bool Check_Infor_TK()
        {
            if (txt_taikhoan_taikhoan.Text == "") { MessageBox.Show("Nhập tên tài khoản", "Thông báo"); txt_taikhoan_taikhoan.Focus(); return false; }
            if (txt_matkhau_taikhoan.Text == "") { MessageBox.Show("Nhập mật khẩu", "Thông báo"); txt_matkhau_taikhoan.Focus(); return false; }
            if(cbb_tennv.Text ==""){ MessageBox.Show("Chọn nhân viên", "Thông báo"); cbb_tennv.Focus(); return false; }
            if (rad_nhanvien_tk.Checked==false && rad_admin_tk.Checked == false) { MessageBox.Show("Bạn chưa chọn phân quyền", "Thông báo"); return false; }
            return true;
        }
        private bool Check_Infor()
        {
            if (txtHotenNV.Text == "") { MessageBox.Show("Nhập họ tên", "Thông báo"); txtHotenNV.Focus(); return false; }
            if (datetime_NS.Text == "") { MessageBox.Show("Nhập ngày sinh", "Thông báo"); datetime_NS.Focus(); return false; }
            if (DateTime.Parse(datetime_NS.Value.ToShortDateString()) == DateTime.Now) { MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại", "Thông báo"); datetime_NS.Focus(); return false; }
            if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại phải là 10", "Thông báo"); txtSDT.Focus(); return false; }
            if (Check_NumberPhone() == 1) { MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống. Vui lòng kiểm tra lại số điện thoại", "Thông báo"); txtSDT.Focus(); return false; }
            return true;
        }
        private bool Check_Infor_CapNhat()
        {

            if (txtHotenNV.Text == "") { MessageBox.Show("Nhập họ tên", "Thông báo"); txtHotenNV.Focus(); return false; }
            if (datetime_NS.Text == "") { MessageBox.Show("Nhập ngày sinh", "Thông báo"); datetime_NS.Focus(); return false; }
            if (DateTime.Parse(datetime_NS.Text) == DateTime.Now) { MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại", "Thông báo"); datetime_NS.Focus(); return false; }
            if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại phải là 10", "Thông báo"); txtSDT.Focus(); return false; }
            return true;
        }
        private string Gioitinh()
        {
            string gioitinh =" ";
            if (rad_nam.Checked == true)
                gioitinh = "Nam";
            if(rad_nu.Checked == true)
                gioitinh = "Nữ";
            return gioitinh;
        }
        private void btnluu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ThemNV == true)
                {
                    if (Check_Infor())
                    {
                        if (MessageBox.Show("Bạn có muốn lưu không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nhanvien.Manv = txtmanv.Text.Trim();
                            nhanvien.Hoten = Replace_whitepace_FirstWord(txtHotenNV.Text);
                            nhanvien.Sodt = txtSDT.Text;
                            nhanvien.Diachi = Replace_whitepace_FirstWord(txt_dichi.Text);
                            nhanvien.Phai = GioiTinh().ToString();
                            nhanvien.Ngaysinh = Convert.ToDateTime(datetime_NS.Text);
                            if (check_tinhtrang.Checked == true)
                            {
                                nhanvien.Tinhtrang = "CÒN LÀM";
                            }
                            else
                                nhanvien.Tinhtrang = "NGHỈ LÀM";
                            nv.Add(nhanvien);
                            LoadDSNV();
                            LoadTongSoNV();
                            Enable_Nhanvien(false);
                            ClearText();
                            ThemNV = false;
                            dgvDSNV.Enabled = true;
                        }
                    }
                }
                else
                {
                    if (Check_Infor_CapNhat())
                    {
                        if ((string)dgvDSNV.CurrentRow.Cells[2].Value == txtSDT.Text && (string)dgvDSNV.CurrentRow.Cells[2].Value != null)
                        {
                            if (MessageBox.Show("Bạn có muốn sửa không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                nhanvien.Manv = txtmanv.Text;
                                nhanvien.Hoten = Replace_whitepace_FirstWord(txtHotenNV.Text);
                                nhanvien.Sodt = txtSDT.Text;
                                nhanvien.Diachi = Replace_whitepace_FirstWord(txt_dichi.Text);
                                nhanvien.Ngaysinh = Convert.ToDateTime(datetime_NS.Text);
                                nhanvien.Phai = Gioitinh().ToString();
                                if (check_tinhtrang.Checked == true)
                                {
                                    nhanvien.Tinhtrang = "CÒN LÀM";
                                }
                                else
                                    nhanvien.Tinhtrang = "NGHỈ LÀM";
                                nv.Update(nhanvien);
                                LoadDSNV();
                                LoadDSNV();
                                Enable_Nhanvien(false);
                                ClearText();
                                dgvDSNV.Enabled = true;
                       }
                        }
                    else
                    {
                        if (Check_NumberPhone() == 0)
                        {
                            if (MessageBox.Show("Bạn có muốn sửa không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                nhanvien.Manv = txtmanv.Text;
                                nhanvien.Hoten = Replace_whitepace_FirstWord(txtHotenNV.Text);
                                nhanvien.Sodt = txtSDT.Text;
                                nhanvien.Diachi = Replace_whitepace_FirstWord(txt_dichi.Text);
                                nhanvien.Ngaysinh = Convert.ToDateTime(datetime_NS.Text);
                                nhanvien.Phai = Gioitinh().ToString();
                                    if (check_tinhtrang.Checked == true)
                                    {
                                        nhanvien.Tinhtrang = "CÒN LÀM";
                                    }
                                    else
                                        nhanvien.Tinhtrang = "NGHỈ LÀM";
                                    nv.Update(nhanvien);
                                LoadDSNV();
                                LoadDSNV();
                                Enable_Nhanvien(false);
                                ClearText(); dgvDSNV.Enabled = true;
                                }
                            }
                        else
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống. Vui lòng kiểm tra lại số điện thoại", "Thông báo"); txtSDT.Focus();
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

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (txtmanv.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn Xóa không ? Các hóa đơn được lập bởi nhân viên " + txtHotenNV.Text + " sẽ bị xóa vĩnh viễn!", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nhanvien.Manv = txtmanv.Text;
                    nv.Delete(nhanvien);
                    LoadDSNV();
                    LoadTongSoNV();
                    ClearText();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần xóa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            ThemNV = true;
            Enable_Nhanvien(true);
            ClearText();
            dgvDSNV.Enabled = false;
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (dgvDSNV.Rows.Count > 1)
            {
                Enable_Nhanvien(true);
                ClearText();
            }
            else
                MessageBox.Show("Danh sách nhân viên rỗng!", "Thông báo");
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            Enable_Nhanvien(false);
            ClearText();
            ThemNV = false;
            dgvDSNV.Enabled = true;

        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10)
            {
                dxErrorProvider1.SetError(txtSDT, "Độ dài số điện thoại phải bằng 10!");
            }
            else
                dxErrorProvider1.ClearErrors();
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttimkiem.Enabled = true;
            txttimkiem.Focus();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbChon.SelectedIndex == 1 && txttimkiem.Text !="Nhập để tìm kiếm")
            {
                dgvDSNV.DataSource = nv.LoadDuLieu("where manv like '%" + txttimkiem.Text.Trim() + "%' and manv not like 'ADMIN' ");
            }
            else if(cbbChon.SelectedIndex == 0 && txttimkiem.Text != "Nhập để tìm kiếm")
            {
                dgvDSNV.DataSource = nv.LoadDuLieu("where hoten like N'%" + txttimkiem.Text.Trim() + "%'  and manv not like 'ADMIN'");
            }
            else
                if (txttimkiem.Text != "Nhập để tìm kiếm")
                    dgvDSNV.DataSource = nv.LoadDuLieu("where sodt like '%" + txttimkiem.Text.Trim() + "%'  and manv not like 'ADMIN'");
            if ( txttimkiem.TextLength == 0)
            {
                LoadDSNV();
            }    
        }


        private void txt_dichi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            ThemTK = true;
            Enable_TK(true);
            ClearText_tk();
            DSTK.Enabled = false;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan_taikhoan.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn Xóa tài khoản nhân viên này không?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nguoidung.Username = txt_taikhoan_taikhoan.Text.Trim() ;
                    nd.Delete(nguoidung);
                    LoadDSTK();
                    ClearText_tk();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần xóa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            Enable_TK(true);
            ClearText_tk();
            cbb_tennv.Enabled = false;
        }
        private int check_IDnv()
        {
            return int.Parse(nd.GetValue("select count(username) from nguoidung where manv ='" + cbb_tennv.SelectedValue.ToString() + "'"));
        }
        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (ThemTK == true)
                {
                    if (Check_Infor_TK())
                    {
                        if (check_IDnv() == 0)
                        {
                            if (MessageBox.Show("Bạn có muốn lưu không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                nguoidung.Manv = cbb_tennv.SelectedValue.ToString().Trim();
                                nguoidung.Username = txt_taikhoan_taikhoan.Text.Trim();
                                nguoidung.Pass = txt_matkhau_taikhoan.Text.Trim();
                                if (rad_admin_tk.Checked == true)
                                {
                                    nguoidung.Phanquyen = rad_admin_tk.Text;
                                }
                                else
                                    nguoidung.Phanquyen = rad_nhanvien_tk.Text;
                                nd.Add(nguoidung);
                                LoadDSTK();
                                Enable_TK(false);
                                ClearText_tk();
                                ThemTK = false;
                                cbb_tennv.Enabled = true;
                                DSTK.Enabled = true;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Nhân viên này đã có tài khoản. Vui lòng chọn lại nhân viên.", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            cbb_tennv.Focus();
                        }
                    }
                }
                else
                {
                    if (Check_Infor_TK())
                    {
                        if (MessageBox.Show("Bạn có muốn sửa không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            nguoidung.Manv = cbb_tennv.SelectedValue.ToString().Trim();
                            nguoidung.Username = txt_taikhoan_taikhoan.Text.Trim();
                            nguoidung.Pass = txt_matkhau_taikhoan.Text.Trim();
                            if (rad_admin_tk.Checked == true)
                            {
                                nguoidung.Phanquyen = rad_admin_tk.Text;
                            }
                            else
                                nguoidung.Phanquyen = rad_nhanvien_tk.Text;
                            nd.Update(nguoidung);
                            LoadDSTK();
                            Enable_TK(false);
                            ClearText_tk();
                            ThemTK = false;
                            cbb_tennv.Enabled = true;
                            DSTK.Enabled = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnhuyTK_Click(object sender, EventArgs e)
        {
            Enable_TK(false);
            ClearText_tk();
            ThemTK = false;
            DSTK.Enabled = true;
            cbb_tennv.Enabled = true;
        }

        private void btndongTK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_Timkiemtaikhoan_TextChanged(object sender, EventArgs e)
        {
            if (cbb_chonTK.SelectedIndex == 1 && txt_Timkiemtaikhoan.Text != "Nhập để tìm kiếm")
            {
                DSTK.DataSource = nd.LoadDuLieu(" and ng.username like '%" + txt_Timkiemtaikhoan.Text.Trim() + "%'");
            }
            if (cbb_chonTK.SelectedIndex == 0 && txt_Timkiemtaikhoan.Text != "Nhập để tìm kiếm")
            {
                    DSTK.DataSource = nd.LoadDuLieu(" and nv.hoten like N'%" + txt_Timkiemtaikhoan.Text.Trim() + "%'");
            }
            if(txt_Timkiemtaikhoan.Text.Length ==0)
            { 
                LoadDSTK();
            }
        }

        private void DSTK_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = DSTK.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null )
                {
                    txt_taikhoan_taikhoan.Text = dr.Cells[1].Value.ToString();
                    cbb_tennv.Text = dr.Cells[0].Value.ToString();
                    txt_matkhau_taikhoan.Text = dr.Cells[2].Value.ToString();
                    txt_matkhau_taikhoan.Text = dr.Cells[3].Value.ToString();
                    if (dr.Cells[4].Value.ToString() == rad_admin_tk.Text)
                        rad_admin_tk.Checked = true;
                    else
                        rad_nhanvien_tk.Checked = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void cbb_tennv_DropDown(object sender, EventArgs e)
        {
            Load_cbbtennv();
        }

        private void cbb_tennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_taikhoan_taikhoan.Text = nv.Getvalue("select manv from nhanvien where hoten = N'" + cbb_tennv.Text.Trim() + "'");
        }

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
                txttimkiem.Text = "Nhập để tìm kiếm";
        }

        private void txt_Timkiemtaikhoan_Click(object sender, EventArgs e)
        {
            txt_Timkiemtaikhoan.Clear();
        }

        private void txt_Timkiemtaikhoan_Leave(object sender, EventArgs e)
        {
            if(txt_Timkiemtaikhoan.Text == "")
            {
                txt_Timkiemtaikhoan.Text = "Nhập để tìm kiếm";
            }    
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            frm_baocaonhanvien bcnv = new frm_baocaonhanvien();
            bcnv.ShowDialog();
        }
    }
}
