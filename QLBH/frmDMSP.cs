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
using QLBH_Enity;
using System.Data.SqlTypes;
using DevExpress.Utils.Svg;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Text.RegularExpressions;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Fields;
using System.IO;

namespace QLBH
{
    public partial class frmDMSP : Form
    {
        BUS_SanPham sp = new BUS_SanPham();
        BUS_LoaiHang lh = new BUS_LoaiHang();
        BUS_NHACUNGCAP ncc = new BUS_NHACUNGCAP();
        NHACUNGCAP nhacungcap = new NHACUNGCAP();
        LoaiHang loaiHang = new LoaiHang();
        SanPham sanPham = new SanPham();
        DONVITINH dvt = new DONVITINH();
        BUS_DONVITINH  DONVITINH = new BUS_DONVITINH();
        

        bool Them = false;
        bool ThemLSP = false;
        bool themNCC = false;
        bool themDVT = false;
        public frmDMSP()
        {
            InitializeComponent();
        }
        public void Load_DSSP()
        {
            DS_SP_SP.DataSource = sp.LoadDuLieu();
        }
        public void Load_DSLSP()
        {
            dataGridView1.DataSource = lh.LoadDuLieu("");
        }
        public void Load_DSNCC()
        {
            dgv_DS_NCC.DataSource = sp.GetData("select NCC.mancc, NCC.tenncc, NCC.sdt, NCC.diachi, NCC.tinhtrang, NCC.email, TINH.TEN_TINH, HUYEN.TEN_HUYEN, XA.TEN_XA, NCC.masothue, NCC.longitude, ncc.latitude, hinhanh, ncc.ghichu, ncc.tenbietdanh from NCC, TINH, HUYEN, XA WHERE NCC.id_tinh = TINH.ID_TINH and  NCC.id_huyen = huyen.ID_HUYEN and  NCC.id_xa = xa.ID_XA");
        }
        public void Load_DSDVT()
        {
            dgv_DSDVT.DataSource = DONVITINH.LoadDuLieu("");
        }
        public void LoadCbb_loaihang()
        {
            cbb_maloai_sp.DataSource = lh.LoadDuLieu(" WHERE TINHTRANG =N'Còn bán'");
            cbb_maloai_sp.DisplayMember = "tenloai";
            cbb_maloai_sp.ValueMember = "maloai";
        }


        public void Load_CbbDVT()
        {
            cbb_Dvt_SP.DataSource = sp.GetData("select * from dvt");
            cbb_Dvt_SP.DisplayMember = "tendvt";
            cbb_Dvt_SP.ValueMember = "madvt";
        }

        public void Load_Tinh()
        {
            cbb_tinh.DataSource = sp.GetData("select * from tinh");
            cbb_tinh.DisplayMember = "ten_tinh";
            cbb_tinh.ValueMember = "id_tinh";

        }
        public void Load_Huyen()
        {
            cbb_huyen.DataSource = sp.GetData("select * from huyen");
            cbb_huyen.DisplayMember = "ten_huyen";
            cbb_huyen.ValueMember = "id_huyen";

        }
        public void Load_Xa()
        {
            cbb_xa.DataSource = sp.GetData("select * from xa");
            cbb_xa.DisplayMember = "ten_xa";
            cbb_xa.ValueMember = "id_xa";

        }
        private void Load_NCC()
        {
            cbb_ncc.DataSource = ncc.LoadDuLieu("where tinhtrang =1");
            cbb_ncc.DisplayMember = "tenncc";
            cbb_ncc.ValueMember = "mancc";
        }
        private int Load_Tong_SoSP()
        {
           return (int)DS_SP_SP.Rows.Count - 1;
        }
        private int Load_Tong_SoLSP()
        {
            return (int)dataGridView1.RowCount - 1;
        }
        private int Load_Tong_SoNCC()
        {
            return (int)dgv_DS_NCC.RowCount - 1;
        }

        private void InitializeCustomAutoComplete()
        {
            cbb_maloai_sp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_maloai_sp.AutoCompleteMode = AutoCompleteMode.None;
            AutoCompleteStringCollection autoCompleteSource = new AutoCompleteStringCollection();

            // Fetch data from database
            var dataTable = lh.LoadDuLieu("");

            // Populate the AutoCompleteStringCollection with data from the database
            foreach (DataRow row in dataTable.Rows)
            {
                autoCompleteSource.Add(row["tenloai"].ToString());
            }

            // Set up autocomplete for the ComboBox
            cbb_maloai_sp.AutoCompleteCustomSource = autoCompleteSource;
            cbb_maloai_sp.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_maloai_sp.AutoCompleteMode = AutoCompleteMode.None;
            cbb_maloai_sp.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void frmDMSP_Load(object sender, EventArgs e)
        {
            pictureNCC.SizeMode = PictureBoxSizeMode.StretchImage;
            Load_DSSP();
            Load_DSLSP();
            InitializeCustomAutoComplete();
            LoadCbb_loaihang();
            Load_DSNCC();
            Load_NCC();
            Load_CbbDVT();
            Load_DSDVT();
            Load_Tinh();
            Load_Xa();
            Load_Huyen();
            lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
            lb_tongslLSP.Text = Load_Tong_SoLSP().ToString();
            lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
        }
        private void Enable_Sanpham(bool t)
        {
            btn_them_sp.Enabled = !t;
            btn_sua_sp.Enabled = !t;
            btn_luu_sp.Enabled = t;
            btn_quaylai_sp.Enabled = t;
            txt_Dongia_SP.Enabled = t;
            txt_TenSP_SP.Enabled = t;
            cbb_Dvt_SP.Enabled = t;
            cbb_ncc.Enabled = t;
            rad_conban.Enabled = t;
            rad_dungban.Enabled = t;
            txtdongianhap.Enabled = t;
            cbb_maloai_sp.Enabled = t;
            check_HSD.Enabled = t;
            date_HSD.Enabled = t;
        }
        private void ClearText()
        {
            txt_MaSP_SP.Clear();
            txt_SL_SP.Clear();
            txt_Dongia_SP.Clear();
            txt_TenSP_SP.Clear();
            cbb_Dvt_SP.Text = " ";
            cbb_maloai_sp.Text = "";
            rad_conban.Checked = true;
            txtdongianhap.Clear();
        }

   


        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>

        private void Enable_LoaiSanpham(bool t)
        {
            btn_them_loaisp.Enabled = !t;
            btn_sua_loaisp.Enabled = !t;
            btn_luu_loaisp.Enabled = t;
            btn_quaylai_loaisp.Enabled = t;
            txt_tenloaisp_loaisp.Enabled = t;
            rad_TT_LSP.Enabled = t;
            rad_TT_DUNG_LSP.Enabled = t;
        }
        private void ClearTextLSP()
        {
            txt_tenloaisp_loaisp.Clear();
            txt_maloai_Loaisp.Clear();
            rad_TT_LSP.Checked = true;
        }

        private void btn_exit_loaisp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_them_loaisp_Click(object sender, EventArgs e)
        {
            ThemLSP = true;
            Enable_LoaiSanpham(true);
            dataGridView1.Enabled = false;
        }

        private void btn_sua_loaisp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                Enable_LoaiSanpham(true);
                ThemLSP = false;
                txt_maloai_Loaisp.Enabled = false;
            }
            else
                MessageBox.Show("Danh sách loại sản phẩm trống!", "Thông báo");
        }
        private bool Check_Info_LoaiSP()
        {
            if (txt_tenloaisp_loaisp.Text == "") { MessageBox.Show("Tên loại sản phẩm không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_tenloaisp_loaisp.Focus(); return false; }
            if (rad_TT_LSP.Checked == false && rad_TT_DUNG_LSP.Checked == false) { MessageBox.Show("Chọn tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
        private bool Check_Dongia(string dongia)
        {
            foreach (char txt in dongia)
            {
                if (!Char.IsDigit(txt))
                {
                    return false;
                }    
            }
            return true;
        }
        private bool Check_Info_SP()
        {
            if (cbb_maloai_sp.Text == "") { MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); cbb_maloai_sp.Focus(); return false; }
            if (txt_TenSP_SP.Text == "") { MessageBox.Show("Nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_TenSP_SP.Focus(); return false; }            
           // if (txtdongianhap.Text == "") { MessageBox.Show("Đơn giá nhập không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txtdongianhap.Focus(); return false; }
          //  if (txt_Dongia_SP.Text == "") { MessageBox.Show("Nhập đơn giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_Dongia_SP.Focus(); return false; }
            if(check_HSD.Checked == true)
            {
                if(DateTime.Parse(date_HSD.Text) <= DateTime.Now)
                { 
                    MessageBox.Show("Hạn sử dụng phải lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); check_HSD.Focus(); return false;
                }
            }
            if (rad_conban.Checked == false && rad_dungban.Checked == false) { MessageBox.Show("Chọn tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if(txtdongianhap.Text != "")
                if (Check_Dongia(txtdongianhap.Text) == false)
                {
                    // this.errorProvider1.SetError(txt_Dongia_SP, "Bạn phải nhập vào là số tiền"); return false;
                    MessageBox.Show("Bạn phải nhập là số tiền!", "Chú ý");txtdongianhap.Focus(); return false;
                }
            if (txt_Dongia_SP.Text != "")
                if (Check_Dongia(txt_Dongia_SP.Text) == false)
                {
                   // this.errorProvider1.SetError(txt_Dongia_SP, "Bạn phải nhập vào là số tiền"); return false;
                    MessageBox.Show("Bạn phải nhập là số tiền!", "Chú ý");txt_Dongia_SP.Focus(); return false;
                }
            /*
            if(int.Parse(txt_Dongia_SP.Text) < int.Parse(txtdongianhap.Text))
            {
                MessageBox.Show("Đơn giá bán không được nhỏ hơn đơn giá nhập!","Chú ý"); txt_Dongia_SP.Focus(); return false;
            }*/
            if (cbb_Dvt_SP.Text == "") { MessageBox.Show("Chọn đơn vị tính cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); cbb_Dvt_SP.Focus(); return false; }
            return true;
        }


        private bool Check_Info_SP_Update()
        {
            if (cbb_maloai_sp.Text == "") { MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); cbb_maloai_sp.Focus(); return false; }
            if (txt_TenSP_SP.Text == "") { MessageBox.Show("Nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_TenSP_SP.Focus(); return false; }
            if (txtdongianhap.Text == "") { MessageBox.Show("Đơn giá nhập không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txtdongianhap.Focus(); return false; }
            if (txt_Dongia_SP.Text == "") { MessageBox.Show("Nhập đơn giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_Dongia_SP.Focus(); return false; }
            if (rad_conban.Checked == false && rad_dungban.Checked == false) { MessageBox.Show("Chọn tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (txtdongianhap.Text != "")
                if (Check_Dongia(txtdongianhap.Text) == false)
                {
                    // this.errorProvider1.SetError(txt_Dongia_SP, "Bạn phải nhập vào là số tiền"); return false;
                    MessageBox.Show("Bạn phải nhập là số tiền!", "Chú ý"); txtdongianhap.Focus(); return false;
                }
            if (txt_Dongia_SP.Text != "")
                if (Check_Dongia(txt_Dongia_SP.Text) == false)
                {
                    // this.errorProvider1.SetError(txt_Dongia_SP, "Bạn phải nhập vào là số tiền"); return false;
                    MessageBox.Show("Bạn phải nhập là số tiền!", "Chú ý"); txt_Dongia_SP.Focus(); return false;
                }
            
            if(int.Parse(txt_Dongia_SP.Text) < int.Parse(txtdongianhap.Text))
            {
                MessageBox.Show("Đơn giá bán không được nhỏ hơn đơn giá nhập!","Chú ý"); txt_Dongia_SP.Focus(); return false;
            }
            if (cbb_Dvt_SP.Text == "") { MessageBox.Show("Chọn đơn vị tính cho sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); cbb_Dvt_SP.Focus(); return false; }
            return true;
        }

        private void btn_luu_loaisp_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Info_LoaiSP())
                {
                    if (ThemLSP == true)
                    {
                        if (CheckTenLoai(Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text)))
                        {
                            if (MessageBox.Show("Bạn có muốn lưu không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                loaiHang.Tenhang = Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text);
                                if (rad_TT_LSP.Checked == true)
                                    loaiHang.Tinhtrang = "Còn bán";
                                else
                                    loaiHang.Tinhtrang = "Dừng bán";
                                lh.Add(loaiHang);
                                Load_DSLSP();
                                lb_tongSLSP.Text = Load_Tong_SoLSP().ToString();
                                LoadCbb_loaihang();
                                Enable_LoaiSanpham(false);
                                ClearTextLSP();
                                ThemLSP = false;
                                dataGridView1.Enabled = true;
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Loại sản phẩm " + Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text) + " đã tồn tại trên hệ thống. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_tenloaisp_loaisp.Focus();
                        }
                    }
                    else
                    {
                        if (dataGridView1.Rows.Count > 1)
                        {
                            if (Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text) == (string)dataGridView1.CurrentRow.Cells[1].Value)
                            {
                                if (MessageBox.Show("Bạn có muốn cập nhật không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    loaiHang.Maloai = txt_maloai_Loaisp.Text;
                                    loaiHang.Tenhang = Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text);
                                    if (rad_TT_LSP.Checked == true)
                                        loaiHang.Tinhtrang = "Còn bán";
                                    else
                                        loaiHang.Tinhtrang = "Dừng bán";
                                    lh.Update(loaiHang);
                                    Load_DSLSP();
                                    lb_tongSLSP.Text = Load_Tong_SoLSP().ToString();
                                    LoadCbb_loaihang();
                                    Enable_LoaiSanpham(false);
                                    ClearTextLSP();
                                    ClearText();
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                if (CheckTenLoai(Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text)))
                                {
                                    if (MessageBox.Show("Bạn có muốn cập nhật không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        loaiHang.Maloai = txt_maloai_Loaisp.Text;
                                        loaiHang.Tenhang = Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text);
                                        if (rad_TT_LSP.Checked == true)
                                            loaiHang.Tinhtrang = "Còn bán";
                                        else
                                            loaiHang.Tinhtrang = "Dừng bán";
                                        lh.Update(loaiHang);
                                        Load_DSLSP();
                                        lb_tongSLSP.Text = Load_Tong_SoLSP().ToString();
                                        LoadCbb_loaihang();
                                        Enable_LoaiSanpham(false);
                                        ClearTextLSP();
                                        ClearText();
                                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Loại sản phẩm " + Replace_whitepace_UPPER(txt_tenloaisp_loaisp.Text) + " đã tồn tại trên hệ thống. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txt_tenloaisp_loaisp.Focus();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Danh sách loại sản phẩm trống!", "Thông báo");
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string Replace_whitepace_UPPER(string chuoi)
        {
            string newstring = chuoi.Trim();
            Regex trimer = new Regex(@"\s\s+");
            newstring = trimer.Replace(newstring, " ");
            return newstring.ToUpper();
        }
        private string Replace_whitepace(string chuoi)
        {
            string newstring = chuoi.Trim();
            Regex trimer = new Regex(@"\s\s+");
            newstring = trimer.Replace(newstring, " ");
            return newstring;
        }


        private void btn_quaylai_loaisp_Click(object sender, EventArgs e)
        {
            Enable_LoaiSanpham(false);
            ClearTextLSP();
            ThemLSP=false;
            dataGridView1.Enabled = true;
        }


        private void btn_hienthi_loaisp_Click(object sender, EventArgs e)
        {
            Load_DSLSP();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                {
                    txt_maloai_Loaisp.Text = dr.Cells[0].Value.ToString();
                    txt_tenloaisp_loaisp.Text = dr.Cells[1].Value.ToString();
                    if(dr.Cells[2].Value.ToString() == rad_TT_LSP.Text)
                    {
                        rad_TT_LSP.Checked = true;
                    }    
                    else
                        rad_TT_DUNG_LSP.Checked = true;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void DS_SP_SP_Click(object sender, EventArgs e)
        {
            try
            {
                    DataGridViewRow dr = DS_SP_SP.SelectedRows[0];
                    if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null && dr.Cells[4].Value != null && dr.Cells[5].Value != null && dr.Cells[6].Value != null && dr.Cells[7].Value != null)
                    {
                        cbb_maloai_sp.Text = dr.Cells[0].Value.ToString();
                        if (dr.Cells[1].Value.ToString() != "")
                        {
                            date_HSD.Value = DateTime.Parse(dr.Cells[1].Value.ToString());
                            if (date_HSD.Value != null)
                                check_HSD.Checked = true;
                            else
                                check_HSD.Checked = false;
                        }
                        txt_MaSP_SP.Text = dr.Cells[2].Value.ToString();
                        txt_TenSP_SP.Text = dr.Cells[3].Value.ToString();
                        cbb_Dvt_SP.Text = dr.Cells[4].Value.ToString();
                        txt_Dongia_SP.Text = double.Parse(dr.Cells[5].Value.ToString()).ToString();
                        txtdongianhap.Text = double.Parse(dr.Cells[6].Value.ToString()).ToString();
                        txt_SL_SP.Text = dr.Cells[7].Value.ToString();
                        if (dr.Cells[8].Value.ToString() == rad_conban.Text)
                        {
                            rad_conban.Checked = true;
                        }
                        else
                            rad_dungban.Checked = true;
                }    
            }
            catch (Exception ex)
            {
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txttimkiem.Text != "Nhập để tìm kiếm")
                {
                    if (cbbChon.SelectedIndex == 0)
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu_DieuKien("tenloai like N'%" + txttimkiem.Text.Trim() + "%'");
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                    }
                    else if (cbbChon.SelectedIndex == 1)
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu_DieuKien("tensp like N'%" + txttimkiem.Text.Trim() + "%'");
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                    }
                    else if (cbbChon.SelectedIndex == 3)
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu_DieuKien("dongia like '%" + txttimkiem.Text.Trim() + "%'");
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                    }
                    else if (cbbChon.SelectedIndex == 2)
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu_DieuKien("donvitinh like N'%" + txttimkiem.Text.Trim() + "%'");
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                    }
                    else
                    {
                      /*  DS_SP_SP.DataSource = sp.LoadDuLieu_DieuKien("nc.tenncc like N'%" + txttimkiem.Text.Trim() + "%'");
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();*/
                    }
                    if (txttimkiem.TextLength == 0)
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu();
                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void cbbChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttimkiem.Enabled = true;
            txttimkiem.Focus();
        }

        private void btn_them_sp_Click_1(object sender, EventArgs e)
        {
            Them = true;
            Enable_Sanpham(true);
            btn_them_sp.Enabled = true;
            ClearText();
            DS_SP_SP.Enabled = false;
        }

        private void btn_sua_sp_Click_1(object sender, EventArgs e)
        {
            if (DS_SP_SP.Rows.Count > 1)
            {
                Enable_Sanpham(true);
                txt_SL_SP.Enabled = false;
                btn_sua_sp.Enabled = true;
                txt_MaSP_SP.Enabled = false;
                ClearText();
            }
            else
                MessageBox.Show("Danh sách sản phẩm trống!", "Thông báo");
        }

        private void btn_luu_sp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Check_Info_SP())
                {

                    if (Them == true)
                    {
                        if (CheckTenSP(Replace_whitepace(txt_TenSP_SP.Text)))
                        {
                            try
                            {
                                if (MessageBox.Show("Bạn có muốn lưu không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    sanPham.Maloai = cbb_maloai_sp.SelectedValue.ToString();
                                    sanPham.Tensp = Replace_whitepace_UPPER(txt_TenSP_SP.Text);
                                    sanPham.Hsd = DateTime.Parse(date_HSD.Text);
                                    if(txt_Dongia_SP.Text != "")
                                        sanPham.Dongia1 = SqlMoney.Parse(txt_Dongia_SP.Text.Trim());
                                    else
                                        sanPham.Dongia1 = SqlMoney.Parse("0");
                                    sanPham.Stringdonvitinh = cbb_Dvt_SP.SelectedValue.ToString();
                                   // sanPham.Mancc = cbb_ncc.SelectedValue.ToString().ToUpper();
                                    if (txtdongianhap.Text != "")
                                        sanPham.DongiaNhap = SqlMoney.Parse(txtdongianhap.Text.Trim());
                                    else
                                        sanPham.DongiaNhap = SqlMoney.Parse("0");
                                    sanPham.NgayUpdate1 = DateTime.Now;
                                    if (rad_conban.Checked == true)
                                    {
                                        sanPham.Tinhtrang = "Còn bán";
                                    }
                                    else
                                        sanPham.Tinhtrang = "Dừng bán";
                                    sp.Add(sanPham);
                                    Load_DSSP();
                                    lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                                    Enable_Sanpham(false);
                                    ClearText();
                                    Them = false;
                                    DS_SP_SP.Enabled = true;
                                    frm_hoadonbanhang hdbh = new frm_hoadonbanhang();
                                    hdbh.simpleButton2_Click(sender, e);
                                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm " + Replace_whitepace_UPPER(txt_TenSP_SP.Text) + " thuộc loại hàng " + cbb_maloai_sp.Text + " của nhà cung cấp " + cbb_ncc.Text + " đã tồn tại trên hệ thống, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_TenSP_SP.Focus();
                        }
                    }
                    else
                    {
                        if (Check_Info_SP_Update())
                        {
                            if (DS_SP_SP.Rows.Count > 1)
                            {
                                if (Replace_whitepace_UPPER(txt_TenSP_SP.Text) == (string)DS_SP_SP.CurrentRow.Cells[3].Value)
                                {

                                    if (MessageBox.Show("Bạn có muốn cập nhật không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        sanPham.Maloai = cbb_maloai_sp.SelectedValue.ToString();
                                        sanPham.Masp = txt_MaSP_SP.Text;
                                        sanPham.Tensp = Replace_whitepace_UPPER(txt_TenSP_SP.Text);
                                        sanPham.Dongia1 = SqlMoney.Parse(txt_Dongia_SP.Text.Trim());
                                        sanPham.SLuong = int.Parse(txt_SL_SP.Text);
                                        sanPham.Stringdonvitinh = cbb_Dvt_SP.SelectedValue.ToString();
                                        if(check_HSD.Checked)
                                        {
                                            sanPham.Hsd = DateTime.Parse(date_HSD.Text);
                                        }
                                        else
                                        {
                                            sanPham.Hsd = null; // sử dụng kiểu dữ liệu nullable DateTime?
                                        }
                                        //sanPham.Mancc = cbb_ncc.SelectedValue.ToString().ToUpper();
                                        sanPham.DongiaNhap = SqlMoney.Parse(txtdongianhap.Text.Trim());
                                        sanPham.NgayUpdate1 = DateTime.Now;
                                        if (rad_conban.Checked == true)
                                        {
                                            sanPham.Tinhtrang = "Còn bán";
                                        }
                                        else
                                            sanPham.Tinhtrang = "Dừng bán";

                                        sp.Update(sanPham);
                                        Load_DSSP();
                                        lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                                        Enable_Sanpham(false);
                                        ClearText();
                                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    if (CheckTenSP(Replace_whitepace_UPPER(txt_TenSP_SP.Text)))
                                    {
                                        if (MessageBox.Show("Bạn có muốn cập nhật không ?", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            sanPham.Maloai = cbb_maloai_sp.SelectedValue.ToString();
                                            sanPham.Masp = txt_MaSP_SP.Text;
                                            sanPham.Tensp = Replace_whitepace_UPPER(txt_TenSP_SP.Text);
                                            sanPham.Dongia1 = SqlMoney.Parse(txt_Dongia_SP.Text.Trim());
                                            sanPham.SLuong = int.Parse(txt_SL_SP.Text);
                                            sanPham.Stringdonvitinh = cbb_Dvt_SP.SelectedValue.ToString();
                                            if (check_HSD.Checked)
                                            {
                                                sanPham.Hsd = DateTime.Parse(date_HSD.Text);
                                            }
                                            else
                                            {
                                                sanPham.Hsd = null; // sử dụng kiểu dữ liệu nullable DateTime?
                                            }                                            // sanPham.Mancc = cbb_ncc.SelectedValue.ToString().ToUpper();
                                            sanPham.DongiaNhap = SqlMoney.Parse(txtdongianhap.Text.Trim());
                                            sanPham.NgayUpdate1 = DateTime.Now;
                                            if (rad_conban.Checked == true)
                                            {
                                                sanPham.Tinhtrang = "Còn bán";
                                            }
                                            else
                                                sanPham.Tinhtrang = "Dừng bán";

                                            sp.Update(sanPham);
                                            Load_DSSP();
                                            lb_tongSLSP.Text = Load_Tong_SoSP().ToString();
                                            Enable_Sanpham(false);
                                            ClearText();
                                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sản phẩm " + Replace_whitepace_UPPER(txt_TenSP_SP.Text) + " thuộc loại hàng " + cbb_maloai_sp.Text + " của nhà cung cấp " + cbb_ncc.Text + " đã tồn tại trên hệ thống, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Danh sách sản phẩm trống!", "Thông báo");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_quaylai_sp_Click_1(object sender, EventArgs e)
        {
            Enable_Sanpham(false);
            ClearText();
            Them = false;
            DS_SP_SP.Enabled = true;
        }

        private void btn_exit_sp_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question )== DialogResult.OK)
            {
                this.Close();
            }    
        }

        private void Enable_LUUHUY_NCC( bool t)
        {
            btnhuy.Enabled = t;
            btnluu.Enabled = t;
            btnsua.Enabled = !t;
            btnthem.Enabled = !t;
            txtdiachincc.Enabled = t;
            txtsdtncc.Enabled = t;
            txt_emailNCC.Enabled = t;
            txttencc.Enabled = t;
            txt_bietdanhNCC.Enabled = t;
            txt_emailNCC.Enabled = t;
            txt_masothueNCC.Enabled = t;
            txt_kinhdoNCC.Enabled = t;
            txt_vidoNCC.Enabled = t;
            txt_ghichu.Enabled = t;
            rad_khong.Enabled = t;
            rad_con.Enabled = t;
            cbb_tinh.Enabled = t;   
            cbb_xa.Enabled = t;
            cbb_huyen.Enabled = t;
        }
        private void Enable_LUUHUY_DVT(bool t)
        {
            btn_quaylai.Enabled = t;
            btn_luu.Enabled = t;
            btn_sua.Enabled = !t;
            btn_them.Enabled = !t;
            txt_tendvt.Enabled = t;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Enable_LUUHUY_NCC(true);
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            themNCC = true;
            dgv_DS_NCC.Enabled = false;
        }
        private void clear_text()
        {
            txt_emailNCC.Clear();
            txtsdtncc.Clear();
            txttencc.Clear();
            txt_mancc.Clear();
            txtdiachincc.Clear();
            txt_masothueNCC.Clear();
            txt_kinhdoNCC.Clear();
            txt_vidoNCC.Clear();
            txt_ghichu.Clear();
            cbb_tinh.Text = "";
            cbb_huyen.Text ="";
            cbb_xa.Text = "";
            rad_con.Checked = true;
        }
        private void clear_text_DVT()
        {
            txt_madvt.Clear();
            txt_tendvt.Clear();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Enable_LUUHUY_NCC(false);
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            themNCC = false;
            clear_text();
            dgv_DS_NCC.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgv_DS_NCC.Rows.Count > 1)
            {
                Enable_LUUHUY_NCC(true);
                btnthem.Enabled = false;
                btnsua.Enabled = true;
                themNCC = false;
            }
            else
                MessageBox.Show("Danh sách Nhà cung cấp trống!", "Thông báo");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Close();
            }    
        }
        private int Check_NumberPhone()
        {
            return int.Parse(lh.GetValue("select count(sdt) from ncc where sdt  ='" + txtsdtncc.Text + "'"));

        }
        private bool Check_Ifor_NCC()
        { 
            if (txttencc.Text == "") { MessageBox.Show("Tên nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txttencc.Focus(); return false; }
            if (txtsdtncc.Text == "") { MessageBox.Show("SĐT nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txtsdtncc.Focus(); return false; }
            if (txt_emailNCC.Text == "") { MessageBox.Show("Địa chỉ nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_emailNCC.Focus(); return false; }
            if (txtsdtncc.Text.Length > 10 || txtsdtncc.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại phải là 10", "Thông báo"); txtsdtncc.Focus(); return false; }
            if (Check_NumberPhone() > 0) { MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống. Vui lòng kiểm tra lại số điện thoại", "Thông báo"); txtsdtncc.Focus(); return false; }
            if (rad_con.Checked == false && rad_khong.Checked == false) { MessageBox.Show("Chọn tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
        private bool Check_Ifor_NCC_CAPNHAT()
        {
            if (txttencc.Text == "") { MessageBox.Show("Tên nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txttencc.Focus(); return false; }
            if (txtsdtncc.Text == "") { MessageBox.Show("SĐT nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txtsdtncc.Focus(); return false; }
            if (txt_emailNCC.Text == "") { MessageBox.Show("Địa chỉ nhà cung cấp không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_emailNCC.Focus(); return false; }
            if (txtsdtncc.Text.Length > 10 || txtsdtncc.Text.Length < 10) { MessageBox.Show("Độ dài số điện thoại phải là 10", "Thông báo"); txtsdtncc.Focus(); return false; }
            if (rad_con.Checked == false && rad_khong.Checked == false) { MessageBox.Show("Chọn tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
        private bool Check_Ifor_DVT()
        {
            if (txt_tendvt.Text == "") { MessageBox.Show("Tên đơn vị tính không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); txt_tendvt.Focus(); return false; }
                 return true;
        }
        private bool CheckTenNCC(string NAme)
        {
            if (ncc.GetValue("select count(tenncc) from ncc where tenncc = N'"+NAme+"'") == "0")
                return true;
            else
                return false;
        }
        private bool CheckTenLoai(string NAme)
        {
            if (lh.GetValue("select count(tenloai) from loaispdgd where tenloai = N'" + NAme + "'") == "0")
                return true;
            else
                return false;
        }
        private bool CheckTenSP(string NAme)
        {
            if (sp.GetDulieu("select count(sp.tensp) from sanphamdgd sp, loaispdgd loai where sp.tensp = N'" + NAme + "' and sp.maloai = '"+cbb_maloai_sp.SelectedValue.ToString()+"'") != "0")
                return false;
            else
                return true;
        }


        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (themNCC == true)
                {
                    if (Check_Ifor_NCC())
                    {
                        if (CheckTenNCC(Replace_whitepace_UPPER(txttencc.Text.Trim())) == true)
                        {
                            nhacungcap.Mancc = txt_mancc.Text.Trim().ToUpper();
                            nhacungcap.Tenncc = Replace_whitepace(txttencc.Text.Trim());
                            nhacungcap.Tenbietdanh = Replace_whitepace(txt_bietdanhNCC.Text.Trim());
                            nhacungcap.Sdt = Replace_whitepace(txtsdtncc.Text.Trim());
                            nhacungcap.Diachi = Replace_whitepace(txtdiachincc.Text.Trim());
                            nhacungcap.Email = Replace_whitepace(txt_emailNCC.Text.Trim());
                            nhacungcap.Masothue = Replace_whitepace(txt_masothueNCC.Text.Trim());
                            nhacungcap.Latitude = float.Parse(Replace_whitepace(txt_vidoNCC.Text.Trim()));
                            nhacungcap.Longitude = float.Parse(Replace_whitepace(txt_kinhdoNCC.Text.Trim()));
                            nhacungcap.Ghichu = Replace_whitepace(txt_ghichu.Text.Trim());
                            nhacungcap.Id_tinh = int.Parse(cbb_tinh.SelectedValue.ToString());
                            nhacungcap.Id_huyen = int.Parse(cbb_huyen.SelectedValue.ToString());
                            nhacungcap.Id_xa = int.Parse(cbb_xa.SelectedValue.ToString());
                            if (rad_con.Checked == true)
                            {
                                nhacungcap.Tinhtrang = "1";
                            }
                            else
                                nhacungcap.Tinhtrang = "0";
                            ncc.Add(nhacungcap);
                            Load_DSNCC();
                            clear_text();
                            lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
                            dgv_DS_NCC.Enabled = true;
                            pictureNCC.Image = null;
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nhà cung cấp " + Replace_whitepace(txttencc.Text.Trim()) + " đã có trên hệ thống, vui lòng kiếm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txttencc.Focus();
                        }
                    }
                }
                else
                {
                    if (Check_Ifor_NCC_CAPNHAT())
                    {
                        if ((string)dgv_DS_NCC.CurrentRow.Cells[1].Value == Replace_whitepace(txttencc.Text.Trim()))
                        {
                            if (txtsdtncc.Text == (string)dgv_DS_NCC.CurrentRow.Cells[2].Value)
                            {
                                nhacungcap.Mancc = txt_mancc.Text.Trim().ToUpper();
                                nhacungcap.Tenncc = Replace_whitepace(txttencc.Text.Trim());
                                nhacungcap.Tenbietdanh = Replace_whitepace(txt_bietdanhNCC.Text.Trim());
                                nhacungcap.Sdt = Replace_whitepace(txtsdtncc.Text.Trim());
                                nhacungcap.Diachi = Replace_whitepace(txtdiachincc.Text.Trim());
                                nhacungcap.Email = Replace_whitepace(txt_emailNCC.Text.Trim());
                                nhacungcap.Masothue = Replace_whitepace(txt_masothueNCC.Text.Trim());
                                nhacungcap.Latitude = float.Parse(Replace_whitepace(txt_vidoNCC.Text.Trim()));
                                nhacungcap.Longitude = float.Parse(Replace_whitepace(txt_kinhdoNCC.Text.Trim()));
                                nhacungcap.Ghichu = Replace_whitepace(txt_ghichu.Text.Trim());
                                nhacungcap.Id_tinh = int.Parse(cbb_tinh.SelectedValue.ToString());
                                nhacungcap.Id_huyen = int.Parse(cbb_huyen.SelectedValue.ToString());
                                nhacungcap.Id_xa = int.Parse(cbb_xa.SelectedValue.ToString());
                                if (rad_con.Checked == true)
                                {
                                    nhacungcap.Tinhtrang = "1";
                                }
                                else
                                    nhacungcap.Tinhtrang = "0";
                                ncc.Update(nhacungcap);
                                Load_DSNCC();
                                clear_text();
                                lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
                                dgv_DS_NCC.Enabled = true;
                                Enable_LUUHUY_NCC(false);
                                pictureNCC.Image = null;
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            else
                            {
                                if (Check_NumberPhone() == 0)
                                {
                                    nhacungcap.Mancc = txt_mancc.Text.Trim().ToUpper();
                                    nhacungcap.Tenncc = Replace_whitepace(txttencc.Text.Trim());
                                    nhacungcap.Tenbietdanh = Replace_whitepace(txt_bietdanhNCC.Text.Trim());
                                    nhacungcap.Sdt = Replace_whitepace(txtsdtncc.Text.Trim());
                                    nhacungcap.Diachi = Replace_whitepace(txtdiachincc.Text.Trim());
                                    nhacungcap.Email = Replace_whitepace(txt_emailNCC.Text.Trim());
                                    nhacungcap.Masothue = Replace_whitepace(txt_masothueNCC.Text.Trim());
                                    nhacungcap.Latitude = float.Parse(Replace_whitepace(txt_vidoNCC.Text.Trim()));
                                    nhacungcap.Longitude = float.Parse(Replace_whitepace(txt_kinhdoNCC.Text.Trim()));
                                    nhacungcap.Ghichu = Replace_whitepace(txt_ghichu.Text.Trim());
                                    nhacungcap.Id_tinh = int.Parse(cbb_tinh.SelectedValue.ToString());
                                    nhacungcap.Id_huyen = int.Parse(cbb_huyen.SelectedValue.ToString());
                                    nhacungcap.Id_xa = int.Parse(cbb_xa.SelectedValue.ToString());
                                    if (rad_con.Checked == true)
                                    {
                                        nhacungcap.Tinhtrang = "1";
                                    }
                                    else
                                        nhacungcap.Tinhtrang = "0";
                                    ncc.Update(nhacungcap);
                                    Load_DSNCC();
                                    clear_text();
                                    lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
                                    dgv_DS_NCC.Enabled = true;
                                    Enable_LUUHUY_NCC(false);
                                    pictureNCC.Image = null;
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtsdtncc.Focus();

                                }
                            }
                        }
                        else
                        {
                            string ten = Replace_whitepace(txttencc.Text.Trim());
                            if (CheckTenNCC(ten) == true)
                            {
                                if (txtsdtncc.Text == (string)dgv_DS_NCC.CurrentRow.Cells[2].Value)
                                {
                                    nhacungcap.Mancc = txt_mancc.Text.Trim().ToUpper();
                                    nhacungcap.Tenncc = Replace_whitepace(txttencc.Text.Trim());
                                    nhacungcap.Tenbietdanh = Replace_whitepace(txt_bietdanhNCC.Text.Trim());
                                    nhacungcap.Sdt = Replace_whitepace(txtsdtncc.Text.Trim());
                                    nhacungcap.Diachi = Replace_whitepace(txtdiachincc.Text.Trim());
                                    nhacungcap.Email = Replace_whitepace(txt_emailNCC.Text.Trim());
                                    nhacungcap.Masothue = Replace_whitepace(txt_masothueNCC.Text.Trim());
                                    nhacungcap.Latitude = float.Parse(Replace_whitepace(txt_vidoNCC.Text.Trim()));
                                    nhacungcap.Longitude = float.Parse(Replace_whitepace(txt_kinhdoNCC.Text.Trim()));
                                    nhacungcap.Ghichu = Replace_whitepace(txt_ghichu.Text.Trim());
                                    nhacungcap.Id_tinh = int.Parse(cbb_tinh.SelectedValue.ToString());
                                    nhacungcap.Id_huyen = int.Parse(cbb_huyen.SelectedValue.ToString());
                                    nhacungcap.Id_xa = int.Parse(cbb_xa.SelectedValue.ToString());
                                    if (rad_con.Checked == true)
                                    {
                                        nhacungcap.Tinhtrang = "1";
                                    }
                                    else
                                        nhacungcap.Tinhtrang = "0";
                                    ncc.Update(nhacungcap);
                                    Load_DSNCC();
                                    clear_text();
                                    lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
                                    dgv_DS_NCC.Enabled = true;
                                    Enable_LUUHUY_NCC(false);
                                    pictureNCC.Image = null;
                                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    if (Check_NumberPhone() == 0)
                                    {
                                        nhacungcap.Mancc = txt_mancc.Text.Trim().ToUpper();
                                        nhacungcap.Tenncc = Replace_whitepace(txttencc.Text.Trim());
                                        nhacungcap.Tenbietdanh = Replace_whitepace(txt_bietdanhNCC.Text.Trim());
                                        nhacungcap.Sdt = Replace_whitepace(txtsdtncc.Text.Trim());
                                        nhacungcap.Diachi = Replace_whitepace(txtdiachincc.Text.Trim());
                                        nhacungcap.Email = Replace_whitepace(txt_emailNCC.Text.Trim());
                                        nhacungcap.Masothue = Replace_whitepace(txt_masothueNCC.Text.Trim());
                                        nhacungcap.Latitude = float.Parse(Replace_whitepace(txt_vidoNCC.Text.Trim()));
                                        nhacungcap.Longitude = float.Parse(Replace_whitepace(txt_kinhdoNCC.Text.Trim()));
                                        //nhacungcap.Hinhanh = "";
                                        nhacungcap.Ghichu = Replace_whitepace(txt_ghichu.Text.Trim());
                                        nhacungcap.Id_tinh = int.Parse(cbb_tinh.SelectedValue.ToString());
                                        nhacungcap.Id_huyen = int.Parse(cbb_huyen.SelectedValue.ToString());
                                        nhacungcap.Id_xa = int.Parse(cbb_xa.SelectedValue.ToString());
                                        if (rad_con.Checked == true)
                                        {
                                            nhacungcap.Tinhtrang = "1";
                                        }
                                        else
                                            nhacungcap.Tinhtrang = "0";
                                        ncc.Update(nhacungcap);
                                        Load_DSNCC();
                                        clear_text();
                                        lb_tongSLNCC.Text = Load_Tong_SoNCC().ToString();
                                        dgv_DS_NCC.Enabled = true;
                                        Enable_LUUHUY_NCC(false);
                                        pictureNCC.Image = null;
                                        MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Số điện thoại đã tồn tại trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtsdtncc.Focus();

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nhà cung cấp " + Replace_whitepace(txttencc.Text.Trim()) + " đã có trên hệ thống, vui lòng kiếm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txttencc.Focus();
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

        private void txttimkiem_Click(object sender, EventArgs e)
        {
            txttimkiem.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiem_ncc.Text != "Nhập để tìm kiếm")
            {
                if (txttimkiem_ncc.Text.Length > 0)
                    dgv_DS_NCC.DataSource = ncc.loadDuLieu_TimKIem("select NCC.mancc, NCC.tenncc, NCC.sdt, NCC.diachi, NCC.tinhtrang, NCC.email, TINH.TEN_TINH, HUYEN.TEN_HUYEN, XA.TEN_XA, NCC.masothue, NCC.longitude, ncc.latitude, hinhanh, ncc.ghichu, ncc.tenbietdanh" +
                        " from NCC, TINH, HUYEN, XA WHERE NCC.id_tinh = TINH.ID_TINH and  NCC.id_huyen = huyen.ID_HUYEN and  NCC.id_xa = xa.ID_XA" +
                        " and ncc.tenncc like N'%" + txttimkiem_ncc.Text.Trim() + "%'" +
                        " or ncc.tenbietdanh like N'%" + txttimkiem_ncc.Text.Trim() + "%'" +
                        " or ncc.sdt like '%" + txttimkiem_ncc.Text.Trim() + "%'" +
                        " or ncc.email like '%" + txttimkiem_ncc.Text.Trim() + "%'");
                else
                    Load_DSNCC();
            }
        }

        private void dgv_DS_NCC_Click(object sender, EventArgs e)
        {
            pictureNCC.Image = null;
            try
            {
                DataGridViewRow dr = dgv_DS_NCC.SelectedRows[0];
                if(dr != null)
                {
                    txt_mancc.Text = dr.Cells[0].Value.ToString();
                    txttencc.Text = dr.Cells[1].Value.ToString();
                    txtsdtncc.Text = dr.Cells[2].Value.ToString();
                    txtdiachincc.Text = dr.Cells[3].Value.ToString();
                    if (dr.Cells[4].Value.ToString() == "1")
                    {
                        rad_con.Checked = true;
                    }
                    else
                        rad_khong.Checked = true;

                    txt_bietdanhNCC.Text = dr.Cells[14].Value.ToString();
                    cbb_tinh.Text = dr.Cells[6].Value.ToString();
                    cbb_huyen.Text = dr.Cells[7].Value.ToString();
                    cbb_xa.Text = dr.Cells[8].Value.ToString();
                    txt_emailNCC.Text = dr.Cells[5].Value.ToString();
                    txt_masothueNCC.Text = dr.Cells[9].Value.ToString();
                    txt_kinhdoNCC.Text = dr.Cells[10].Value.ToString();
                    txt_vidoNCC.Text = dr.Cells[11].Value.ToString();
                    txt_ghichu.Text = dr.Cells[13].Value.ToString();
                    if (dr.Cells[12].Value != null)
                        pictureNCC.Image = Image.FromFile(dr.Cells[12].Value.ToString());
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if(txttimkiem.Text ==" ")
            txttimkiem.Text = "Nhập để tìm kiếm";
        }


        private void txttiemkiem_loáip_TextChanged(object sender, EventArgs e)
        {
            if (txttiemkiem_loáip.Text != "Nhập để tìm kiếm")
            {
                if (txttiemkiem_loáip.Text.Length > 0)
                {
                    dataGridView1.DataSource = lh.LoadDuLieu("where tenloai like N'%" + txttiemkiem_loáip.Text.Trim() + "%'");
                }
                else
                {
                    Load_DSLSP();
                }
                }
            }

        private void txttiemkiem_loáip_Click(object sender, EventArgs e)
        {
            txttiemkiem_loáip.Clear();
        }

        private void txttiemkiem_loáip_Leave(object sender, EventArgs e)
        {
            if(txttiemkiem_loáip.Text =="")
            txttiemkiem_loáip.Text = "Nhập để tìm kiếm";
        }

        private void txttimkiem_ncc_Click(object sender, EventArgs e)
        {
            txttimkiem_ncc.Clear();
        }

        private void txttimkiem_ncc_Leave(object sender, EventArgs e)
        {
            if(txttimkiem_ncc.Text =="")
            txttimkiem_ncc.Text = "Nhập để tìm kiếm";
        }

        private void cbb_maloai_sp_DropDown(object sender, EventArgs e)
        {
            LoadCbb_loaihang();
        }

        private void cbb_ncc_DropDown(object sender, EventArgs e)
        {
            Load_NCC();
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Enable_LUUHUY_DVT(true);
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            themDVT = true;
            dgv_DSDVT.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_DSDVT.Rows.Count > 1)
            {
                Enable_LUUHUY_DVT(true);
                btn_them.Enabled = false;
                btn_sua.Enabled = true;
                themDVT = false;
            }
            else
                MessageBox.Show("Danh sách DVT trống!", "Thông báo");
        }
        private bool CheckTenDVT(string NAme)
        {
            if (DONVITINH.GetValue("select count(tendvt) from DVT where tendvt = N'" + NAme + "'") == "0")
                return true;
            return false;  
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Ifor_DVT())
                {

                    if (themDVT == true)
                    {
                        if (CheckTenDVT(Replace_whitepace_UPPER(txt_tendvt.Text.ToUpper())))
                        {
                            dvt.Madvt = txt_madvt.Text.Trim().ToUpper();
                            dvt.Tendvt = Replace_whitepace_UPPER(txt_tendvt.Text.ToUpper());
                            DONVITINH.Add(dvt);
                            Load_DSDVT();
                            clear_text_DVT();
                            dgv_DSDVT.Enabled = true;
                            Enable_LUUHUY_DVT(false);
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Đơn vị tính này đã có trên hệ thống, vui lòng kiếm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if ((string)dgv_DSDVT.CurrentRow.Cells[1].Value == txt_tendvt.Text)
                        {
                            dvt.Madvt = txt_madvt.Text.Trim().ToUpper();
                            dvt.Tendvt = Replace_whitepace_UPPER(txt_tendvt.Text.ToUpper());
                            DONVITINH.Update(dvt);
                            Load_DSDVT();
                            clear_text_DVT();
                            dgv_DSDVT.Enabled = true;
                            Enable_LUUHUY_DVT(false);

                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (CheckTenDVT(Replace_whitepace_UPPER(txt_tendvt.Text.ToUpper())))
                            {
                                dvt.Madvt = txt_madvt.Text.Trim().ToUpper();
                                dvt.Tendvt = Replace_whitepace_UPPER(txt_tendvt.Text.ToUpper());
                                DONVITINH.Update(dvt);
                                Load_DSDVT();
                                clear_text_DVT();
                                dgv_DSDVT.Enabled = true;
                                Enable_LUUHUY_DVT(false);

                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("Đơn vị tính này đã có trên hệ thống, vui lòng kiếm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    }
                                   
            }
            catch(Exception ex)
            {

            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            Enable_LUUHUY_DVT(false);
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            themDVT = false;
            clear_text_DVT();
            dgv_DSDVT.Enabled = true;
        }

        private void txttimkiemDVT_TextChanged(object sender, EventArgs e)
        {
            if (txttimkiemDVT.Text != "Nhập để tìm kiếm")
            {
                if (txttimkiemDVT.Text.Length > 0)
                    dgv_DSDVT.DataSource = DONVITINH.loadDuLieu_TimKIem("select * from DVT where tendvt like N'%" + txttimkiemDVT.Text.Trim() + "%'");
                else
                    dgv_DSDVT.DataSource = DONVITINH.LoadDuLieu("");
            }
        }

        private void txttimkiemDVT_Click(object sender, EventArgs e)
        {
            txttimkiemDVT.Clear();
        }

        private void txttimkiemDVT_Leave(object sender, EventArgs e)
        {
            if (txttimkiemDVT.Text == "")
                txttimkiemDVT.Text = "Nhập để tìm kiếm";
        }

        private void dgv_DSDVT_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_DSDVT.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null )
                {
                    txt_madvt.Text = dr.Cells[0].Value.ToString();
                    txt_tendvt.Text = dr.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void txtdongianhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                    txtdongianhap.Focus();
                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_Dongia_SP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                    txt_Dongia_SP.Focus();
                }
                else
                    this.errorProvider1.Clear();
                if(int.Parse(txt_Dongia_SP.Text)< int.Parse(txtdongianhap.Text))
                {
                    this.errorProvider1.SetError(control, "Đơn giá bán không được nhỏ hơn đơn giá nhập!");
                    txt_Dongia_SP.Focus();
                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtsdtncc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                    txtsdtncc.Clear();
                }
                else
                    this.errorProvider1.Clear();

            }
            catch (Exception ex)
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            Load_DSSP();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
                frm_report_SP rp = new frm_report_SP();
                rp.ShowDialog();
        }

        private void btnxuat_barcode_Click(object sender, EventArgs e)
        {
            if (txt_MaSP_SP.Text!= "")
            {
                frm_chonxcuatbarcode chonxcuatbarcode = new frm_chonxcuatbarcode(txt_MaSP_SP.Text.ToUpper().Trim());
                chonxcuatbarcode.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm cần xuất barcode!");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void btn_chonhinhanhNCC_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của hộp thoại mở tập tin
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Tập tin ảnh|*.jpg;*.jpeg;*.png;*.gif|Tất cả các tệp|*.*";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tập tin
            // Mở hộp thoại mở tập tin và xử lý kết quả
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu của tập tin ảnh thành một mảng byte
                    //byte[] imageData = File.ReadAllBytes(selectedFilePath);
                    string selectedFilePath = openFileDialog.FileName;
                    // Gán dữ liệu ảnh cho thuộc tính Hinhanh của đối tượng nhacungcap
                    nhacungcap.Hinhanh = selectedFilePath;
                    // Hiển thị hình ảnh được chọn lên PictureBox (nếu cần)
                    pictureNCC.Image = Image.FromFile(selectedFilePath);
                    btn_bochonanh.Visible = true;
                }
                catch (Exception ex)
                {
                    // Xử lý các ngoại lệ nếu có
                    MessageBox.Show("Đã xảy ra lỗi khi đọc tập tin ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_bochonanh_Click(object sender, EventArgs e)
        {
            pictureNCC.Image = null;
            nhacungcap.Hinhanh = "";
            btn_bochonanh.Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(check_HSD.Checked == true)
            {
                date_HSD.Visible = true;
            }
            else
            {
                date_HSD.Visible = false;
            }
        }
    }

}
