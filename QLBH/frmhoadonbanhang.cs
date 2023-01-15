using DevExpress.CodeParser;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Cms;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraRichEdit.Layout;
using frm_BanHang;
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
    public partial class frm_hoadonbanhang : Form
    {
        public frm_hoadonbanhang()
        {
            InitializeComponent();
        }
        private string tennv, manv;
        private int soluong;
        string chapnhan;
        private int vitri;

        public frm_hoadonbanhang(string tennv, string manv)
        {
            this.tennv = tennv;
            this.manv = manv;
            InitializeComponent();
        }
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;

        public void Load_DSSP()// load dữ liệu bảng sản phẩm
        {
            try {
                DS_SP_SP.DataSource = sp.LoadDuLieu_CTHD("select  loai.tenloai, sp.masp, sp.tensp, sp.dongia, sp.sluong from loaispdgd loai, sanphamDGD sp where sp.tinhtrang = N'CÒN BÁN' and sp.maloai = loai.maloai");
            }
            catch { }
        }

        private void LoadcbbKH()// load dữ liệu của khách hàng vào combobox
        {
            try
            {
                cbb_tenkhachhang.DataSource = kh.LoadDuLieu("");
                cbb_tenkhachhang.DisplayMember = "hoten";
                cbb_tenkhachhang.ValueMember = "makh";
            }
            catch {; }
        }

        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_CTHD cthd = new BUS_CTHD();
        BUS_LoaiHang lh = new BUS_LoaiHang();
        BUS_SanPham sp = new BUS_SanPham();
        BUS_KhachHang kh = new BUS_KhachHang();
        HoaDon hoadon = new HoaDon();
        CTHD chitiethd = new CTHD();
        SanPham sanPham = new SanPham();
        BUS_PHIEUNO pn = new BUS_PHIEUNO();
        PHIEUNO phieuno = new PHIEUNO();
        PHIEUNO_CT phieunoct = new PHIEUNO_CT();
        BUS_PHIEUNO_CT pnct = new BUS_PHIEUNO_CT();

        public int Soluong { get => soluong; set => soluong = value; }

        private void Enable_chucnang(bool t)
        {
            cbb_tenkhachhang.Enabled = t;
            btnhuyhd.Enabled = t;
            btntaomoi.Enabled = !t;
            group_DSSP.Enabled = t;
            DS_SP_SP.Enabled = t;
            dgv_CTHD.Enabled = t;
        }
        private void btnthemhd_Click(object sender, EventArgs e)
        {
            Enable_chucnang(true);
        }
        private void ClearText()
        {
            cbb_tenkhachhang.SelectedIndex = 0;
            dgv_CTHD.DataSource = null;
        }
        private void Update_SL_SauKhiXoa()
        {
            try
            {
                foreach (DataGridViewRow rowcthd in dgv_CTHD.Rows)
                {
                    if (rowcthd.Cells[0].Value != null && rowcthd.Cells[1].Value != null && rowcthd.Cells[2].Value != null && rowcthd.Cells[3].Value != null && rowcthd.Cells[4].Value != null &&  rowcthd.Cells[5].Value != null)
                    {
                        foreach (DataGridViewRow rowdssp in DS_SP_SP.Rows)
                        {
                            if ((string)rowcthd.Cells[1].Value == (string)rowdssp.Cells[1].Value)
                            {
                                rowdssp.Cells[4].Value = (int.Parse(rowdssp.Cells[4].Value.ToString()) + int.Parse(rowcthd.Cells[4].Value.ToString())).ToString();
                            }
                        }
                    }
                }
            }
            catch {; }
        }
        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn hủy hóa đơn ?", "Thông báo hủy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnthanhtoan.Enabled = false;
                btnhuyhd.Enabled = false;
                btntaomoi.Enabled = true;
                dgv_CTHD.Rows.Clear();
                Enable_DGVCTHD();
                Load_DSSP();  
                Enable_chucnang(false);
                lb_tongtien.Text = TongTien().ToString("c",new CultureInfo("vi-Vn"));
                txt_sdt.Clear();
                txt_diachi.Clear();
                cbb_tenkhachhang.Text = "";txt_tienkhachtra.Clear();
                lb_tientholai.Text = "";
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frm_hoadonbanhang_Load(object sender, EventArgs e)
        {
            LoadcbbKH();
            Load_DSSP();
            txt_manv.Text = manv;
            txt_tennv.Text = tennv;
            cbb_tenkhachhang.Text = "";
            lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
            toolTip1.Active = true;
            toolTip1.AutoPopDelay = 4000;
            toolTip1.InitialDelay = 600;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(btn_lammoi, "Cập nhật lại danh sách hàng hóa sau khi nhập kho.");
        }
        private bool check_masp(string id)
        {
            if (dgv_CTHD.Rows.Count -1 > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_CTHD.RowCount - 1; i++)
                    {
                        if (id == (string)dgv_CTHD.Rows[i].Cells[1].Value)
                        {
                            vitri = i;
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            return true;
        }

        private void Update_Data(string Soluong)
        {
            try
            {
                DataGridViewRow row = dgv_CTHD.Rows[vitri];
                row.Cells[0].Value = row.Cells[0].Value.ToString();
                row.Cells[1].Value = row.Cells[1].Value.ToString();
                row.Cells[2].Value = row.Cells[2].Value.ToString();
                row.Cells[4].Value = Soluong;
                row.Cells[3].Value = row.Cells[3].Value.ToString();
                row.Cells[5].Value = ThanhTien(double.Parse(Soluong), double.Parse(row.Cells[3].Value.ToString()));
                dgv_CTHD.Update();
            }
            catch
            {
                MessageBox.Show("Chọn vào dòng sản phẩm cần cập nhật!", "Lỗi", MessageBoxButtons.OK);
            }
        }
        private void Enable_DGVCTHD()
        {
            if (dgv_CTHD.Rows.Count -1 ==0)
            {
               // btnthanhtoan.Enabled = false;
                dgv_CTHD.Enabled = false;
               // txt_chietkhau.Enabled = false; 
                txt_tienkhachtra.Enabled = false;
            }
            if (dgv_CTHD.Rows.Count -1 > 0)
            {
                //btnthanhtoan.Enabled = true;
               // txt_chietkhau.Enabled = true;
                dgv_CTHD.Enabled = true;
                txt_tienkhachtra.Enabled = true;
            }
        }

        private void DS_SP_SP_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                    {
                        DragDropEffects dropEffect = DS_SP_SP.DoDragDrop(DS_SP_SP.Rows[rowIndexFromMouseDown], DragDropEffects.Copy);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại."+ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void DS_SP_SP_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                rowIndexFromMouseDown = DS_SP_SP.HitTest(e.X, e.Y).RowIndex;
                if (rowIndexFromMouseDown != -1)
                {
                    Size dragSize = SystemInformation.DragSize;
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
                else
                    dragBoxFromMouseDown = Rectangle.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message,"Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void dgv_CTHD_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                e.Effect = DragDropEffects.Copy;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
                                        
        private void dgv_CTHD_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                DataGridViewRow rowToMove = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow)); // Lấy dữ liệu dòng dssp
                if ((string)rowToMove.Cells[1].Value != null && (string)rowToMove.Cells[2].Value != null && (string)rowToMove.Cells[0].Value != null && rowToMove.Cells[3].Value != null && rowToMove.Cells[4].Value != null)// nếu tất cả các cell khác null
                {
                    frm_NhapSoLuong nsl = new frm_NhapSoLuong(rowToMove.Cells[3].Value.ToString(), rowToMove.Cells[0].Value.ToString(), rowToMove.Cells[2].Value.ToString(), int.Parse(rowToMove.Cells[4].Value.ToString()));// truyền tham số vào form nhập số lượng
                    if (check_masp((string)rowToMove.Cells[1].Value))// kiểm tra Id sản phẩm có tồn tại trong ds mua hàng hay không.
                    {
                        if (int.Parse(rowToMove.Cells[4].Value.ToString()) > 0)// kiểm tra số lượng còn đủ bán hay không
                        {
                            nsl.ShowDialog();// mở form
                            if (nsl.Chapnhan == 1)// nếu chọn Ok 
                            {
                                Soluong = nsl.Soluong;
                                dgv_CTHD.Rows.Add(rowToMove.Cells[0].Value, rowToMove.Cells[1].Value, rowToMove.Cells[2].Value, rowToMove.Cells[3].Value, Soluong, ThanhTien(Convert.ToDouble(Soluong), double.Parse(rowToMove.Cells[3].Value.ToString())).ToString());//  thêm sản phẩm vào danh sách mua
                                Enable_DGVCTHD();
                                DS_SP_SP.Rows[rowIndexFromMouseDown].Cells[4].Value = (int.Parse(DS_SP_SP.Rows[rowIndexFromMouseDown].Cells[4].Value.ToString()) - Soluong).ToString();// Cập nhật lại số lượng danh sách sản phẩm
                                lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));// tính tổng tiền hóa đơn
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm hết số lượng!", "Thông báo hết số lượng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else// sản phẩm tồn tại trong dah sách mua
                    {
                        if (int.Parse(rowToMove.Cells[4].Value.ToString()) > 0) //nếu số lượng còn >0
                        {
                            if (MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn! Bạn có muốn thay đổi số lượng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (rowToMove.Cells[2].Value != null && (string)rowToMove.Cells[1].Value != null && rowToMove.Cells[3].Value != null && (string)rowToMove.Cells[0].Value != null && dgv_CTHD.Rows[dgv_CTHD.CurrentRow.Index].Cells[4].Value != null)
                                {
                                    frm_NHapSoLuongCapNhat nslcn = new frm_NHapSoLuongCapNhat(rowToMove.Cells[3].Value.ToString(), rowToMove.Cells[0].Value.ToString(), rowToMove.Cells[2].Value.ToString(), int.Parse(dgv_CTHD.Rows[dgv_CTHD.CurrentRow.Index].Cells[4].Value.ToString()), int.Parse(rowToMove.Cells[4].Value.ToString()));
                                    nslcn.ShowDialog();
                                    if (nslcn.Chapnhan == 1)// nếu đồng ý
                                    {
                                        Soluong = nslcn.SoluongcapNHat;
                                        Update_Data(Soluong.ToString());// cập nhật lại số lượng sản phẩm trong danh sách mua hàng
                                        DS_SP_SP.Rows[rowIndexFromMouseDown].Cells[4].Value = (int.Parse(DS_SP_SP.Rows[rowIndexFromMouseDown].Cells[4].Value.ToString()) - nslcn.Soluongtru).ToString();// cập nhật lại số lượng trong danh sách sản phẩm
                                        Enable_DGVCTHD();
                                        lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
                                    }
                                    dgv_CTHD.Rows[vitri].Selected = true;
                                }
                                else
                                    dgv_CTHD.Rows[vitri].Selected = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sản phẩm hết số lượng!", "Thông báo hết số lượng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        private double ThanhTien(double soluong, double dongia)// tính thành tiền của mỗi sản phẩm
        {
            return soluong * dongia;
        }
        private void ThanhToanHD()
        {
            if (cbb_tenkhachhang.Text != "")
            {
                if (check_ngayhientai.Checked == true)
                {
                    hoadon.NgayGD = DateTime.Now;
                }
                else
                {
                    hoadon.NgayGD = DateTime.Parse(DT_ngaylap.Text);
                } 
                hoadon.Thanhtien1 = SqlMoney.Parse(TongTien().ToString());
                hoadon.Manv = txt_manv.Text;
                hoadon.MaKH = cbb_tenkhachhang.SelectedValue.ToString();
                hd.Add(hoadon);
                btntaomoi.Enabled = true;
                string mahd = "HD" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");// truy vấn mã hóa đơn
                if (dgv_CTHD.Rows.Count > 0)
                {
                    try
                    {
                        for (int i = 0; i < dgv_CTHD.RowCount - 1; i++)
                        {
                            {
                                chitiethd.MaHD = mahd;
                                chitiethd.Masp = dgv_CTHD.Rows[i].Cells[1].Value.ToString();
                                chitiethd.Tenloai = dgv_CTHD.Rows[i].Cells[0].Value.ToString();
                                sanPham.Masp = dgv_CTHD.Rows[i].Cells[1].Value.ToString();
                                chitiethd.Soluuong = int.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString());
                                sanPham.SLuong = int.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString());
                                cthd.Add(chitiethd);
                                sp.Update_SaukhiMua(sanPham);// Cập nhật lại số lượng sản phẩm sau khi mua hàng thành công
                           
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi không lưu thành công !" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long chọn tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbb_tenkhachhang.Focus();
            }
        }
        private void Clear()
        {
            Enable_DGVCTHD();
            lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
            txt_tienkhachtra.Clear();
            lb_tientholai.Text = "";
            btnhuyhd.Enabled = false;
            txt_tienkhachtra.Enabled = false;
            txt_chietkhau.Clear();
            txt_chietkhau.Enabled = false;
        }
        private void InHD()
        {
                if (check_tienmat.Checked == false)
                {
                    chitiethd.MaHD = "HD" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");
                    chitiethd.Ngaylap = Convert.ToDateTime(DT_ngaylap.Value);
                    chitiethd.Tennv = txt_tennv.Text;
                    chitiethd.TenKH = cbb_tenkhachhang.Text;
                    chitiethd.DiachiKH = txt_diachi.Text;
                    chitiethd.SdtKH = txt_sdt.Text;
                    chitiethd.Tenloai = "";
                    BUS_SanPham sp = new BUS_SanPham();
                    List<CTHD> cthd1 = new List<CTHD> { };
                    for (int i = 0; i < dgv_CTHD.RowCount - 1; i++)
                    {
                        {
                            CTHD hd = new CTHD();
                            hd.Masp = dgv_CTHD.Rows[i].Cells[2].Value.ToString();
                            hd.Tenloai = dgv_CTHD.Rows[i].Cells[0].Value.ToString();
                            hd.Soluuong = int.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString());
                            hd.Dongia = float.Parse(dgv_CTHD.Rows[i].Cells[3].Value.ToString());
                            hd.Thanhtien1 = float.Parse(dgv_CTHD.Rows[i].Cells[5].Value.ToString());
                            cthd1.Add(hd);
                        }
                    }
                frm_inHD inHD = new frm_inHD(chitiethd.MaHD, chitiethd.Tennv, chitiethd.TenKH, chitiethd.SdtKH, "( " + XTL.Utils.NumberToText(TongTien()) + " )", "0", "0", chitiethd.Ngaylap, "0", "0", cthd1);
                inHD.ShowDialog();
            } 
        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            frm_thanhtoan frmtt = new frm_thanhtoan();
            frmtt.ShowDialog();
            if(frmtt.Trangthai ==1)
            {
                /*
                ThanhToanHD();
                dgv_CTHD.Rows.Clear();
                Load_DSSP();
                Clear();
                MessageBox.Show("Lưu hóa đơn thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnthanhtoan.Enabled = false;*/
                if (txt_tienkhachtra.Text != "")
                {
                    if (double.Parse(txt_tienkhachtra.Text) >= TongTien())
                    {
                        ThanhToanHD();
                        InhoaDon();
                        dgv_CTHD.Rows.Clear();
                        Load_DSSP();
                        Clear();
                        MessageBox.Show("Lưu hóa đơn thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnthanhtoan.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Khách chưa trả đủ tiền thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_tienkhachtra.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tiền khách trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_tenkhachhang.Focus();
                }
            }    
            if(frmtt.Trangthai ==2)
            {
                if (cbb_tenkhachhang.Text != "")
                {
                    if (check_tienmat.Checked == true)
                    {

                        if (txt_tienkhachtra.Text != "")
                        {
                            if (double.Parse(txt_tienkhachtra.Text) >= TongTien()  )
                            {
                                ThanhToanHD();
                                InhoaDon();
                                dgv_CTHD.Rows.Clear();
                                Load_DSSP();
                                Clear();
                                btnthanhtoan.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Khách chưa trả đủ tiền thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_tienkhachtra.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập tiền khách trả.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbb_tenkhachhang.Focus();
                        }
                    }
                    else if (check_tienmat.Checked == false && txt_tienkhachtra.Text == "")
                    {
                        ThanhToanHD();
                        InHD();
                        dgv_CTHD.Rows.Clear();
                        Load_DSSP();
                        Clear();
                        btnthanhtoan.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_tenkhachhang.Focus();
                }
            }    
        }
        private double TongTien()// tính tổng tiền tự động của hóa đơn
        {
            double tongtien = 0;
            double chietkhau = 0;
            if (dgv_CTHD.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < dgv_CTHD.RowCount; i++)
                    {
                        {
                            tongtien += Convert.ToDouble(dgv_CTHD.Rows[i].Cells[5].Value);
                        }
                    }
                    if (txt_chietkhau.Text.Length > 0)
                    {
                        chietkhau = tongtien * (double.Parse(txt_chietkhau.Text) / 100);
                        tongtien -= chietkhau;
                    }
                    else
                    {
                        return tongtien;
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                tongtien = 0;
            return tongtien;
        }

        private void cbb_tenkhachhang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbb_tenkhachhang.Text != "")
            {
                txt_sdt.Text = sp.GetDulieu("select sodt from khachhang where makh = '" + cbb_tenkhachhang.SelectedValue.ToString() + "'");
                txt_diachi.Text = sp.GetDulieu("select dchi from khachhang where makh = '" + cbb_tenkhachhang.SelectedValue.ToString() + "'");
            }
            else
            {
                txt_sdt.Clear();
                txt_diachi.Clear();
            }
        }

        private void dgv_CTHD_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgv_CTHD.Rows.Count - 1 > 0)
                {
                    DataGridViewRow rowToMove = dgv_CTHD.CurrentRow;
                    if (rowToMove.Cells[0].Value != null && rowToMove.Cells[1].Value != null && rowToMove.Cells[2].Value != null && rowToMove.Cells[3].Value != null && rowToMove.Cells[4].Value != null)
                    {
                        foreach (DataGridViewRow row in DS_SP_SP.Rows)
                        {
                            if ((string)row.Cells[1].Value == (string)rowToMove.Cells[1].Value)
                            {
                                frm_NHapSoLuongCapNhat nslcn = new frm_NHapSoLuongCapNhat(rowToMove.Cells[3].Value.ToString(), rowToMove.Cells[0].Value.ToString(), rowToMove.Cells[2].Value.ToString(), int.Parse(rowToMove.Cells[4].Value.ToString()), int.Parse(row.Cells[4].Value.ToString()));
                                nslcn.ShowDialog();
                                if (nslcn.Chapnhan == 1)// nếu đồng ý sửa
                                {
                                    vitri = rowToMove.Index; // lấy vị trí của dòng cần cập nhật
                                    Soluong = nslcn.SoluongcapNHat;
                                    Update_Data(Soluong.ToString());// cập nhật lại số lượng danh sách mua
                                    row.Cells[4].Value = (int.Parse(row.Cells[4].Value.ToString()) - nslcn.Soluongtru).ToString();// cập nhật số lượng dnah sách sản phẩm
                                    Enable_DGVCTHD();
                                    lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
                                }
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

        private void dgv_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                    e.RowIndex >= 0)
                {
                try
                {
                    if (dgv_CTHD.Rows.Count - 1 > 0)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa chọn sản phẩm không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            DataGridViewRow rowToMove = dgv_CTHD.CurrentRow;
                            if (rowToMove.Cells[0].Value != null && rowToMove.Cells[1].Value != null && rowToMove.Cells[2].Value != null && rowToMove.Cells[3].Value != null && rowToMove.Cells[4].Value != null)
                            {
                                int soluongsaukhixoa;
                                foreach (DataGridViewRow row in DS_SP_SP.Rows)
                                {
                                    soluongsaukhixoa = 0;
                                    if ((string)row.Cells[1].Value == (string)dgv_CTHD.Rows[dgv_CTHD.CurrentRow.Index].Cells[1].Value)
                                    {
                                        soluongsaukhixoa = int.Parse(row.Cells[4].Value.ToString()) + int.Parse(dgv_CTHD.Rows[dgv_CTHD.CurrentRow.Index].Cells[4].Value.ToString());
                                        dgv_CTHD.Rows.Remove(dgv_CTHD.CurrentRow);
                                        if (dgv_CTHD.Rows.Count - 1 == 0)
                                        {
                                            btnthanhtoan.Enabled = false;
                                            txt_tienkhachtra.Clear();
                                            lb_tientholai.Text = "";
                                            txt_tienkhachtra.Enabled = false;
                                        }
                                        row.Cells[4].Value = soluongsaukhixoa.ToString().Trim();
                                        lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thao quá nhanh. Vui lòng thử lại." + ex.Message, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_KhachHang kh = new frm_KhachHang();
            kh.ShowDialog();
        }

        private void cbb_tenkhachhang_DropDown(object sender, EventArgs e)
        {
            LoadcbbKH();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "Tìm kiếm tên sản phẩm")
            {
                DS_SP_SP.DataSource = sp.LoadDuLieu_CTHD("select loai.tenloai, sp.masp, sp.tensp, sp.dongia, sp.sluong from sanphamDGD sp, loaispdgd loai where loai.maloai = sp.maloai and  sp.tensp like N'%" + txt_timkiem.Text.Trim() + "%' and sp.tinhtrang =N'CÒN BÁN'");
                CapNhatSauKhiLoad_DS_SP();
            }
            
        }


        private void btntaomoi_Click(object sender, EventArgs e)
        {
            Enable_chucnang(true);
            dgv_CTHD.Rows.Clear();
            cbb_tenkhachhang.Text = "";
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Clear();
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_timkiem.Text == "")
                {
                    txt_timkiem.Text = "Tìm kiếm tên sản phẩm";
                    Load_DSSP();
                    CapNhatSauKhiLoad_DS_SP();
                }
                else
                {
                    if (txt_timkiem.Text != "Tìm kiếm tên sản phẩm")
                    {
                        DS_SP_SP.DataSource = sp.LoadDuLieu_CTHD("select loai.tenloai, sp.masp, sp.tensp, sp.dongia, sp.sluong from sanphamDGD sp, loaispdgd loai where loai.maloai = sp.maloai and  sp.tensp like N'%" + txt_timkiem.Text.Trim() + "%' and sp.tinhtrang =N'CÒN BÁN'");
                        CapNhatSauKhiLoad_DS_SP();
                    }
                }
            }
            catch {; }
            
        }
        private void dgv_CTHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (DS_SP_SP.Rows.Count > 0 && dgv_CTHD.Rows.Count -1 > 0)
                    foreach (DataGridViewRow row in DS_SP_SP.Rows)
                    {

                        if ((string)row.Cells[1].Value == (string)dgv_CTHD.CurrentRow.Cells[1].Value )
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DS_SP_SP_Click(object sender, EventArgs e)
        {
            try
            {
                if (DS_SP_SP.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_CTHD.Rows)
                    {
                        if ((string)row.Cells[1].Value == (string)DS_SP_SP.Rows[DS_SP_SP.CurrentRow.Index].Cells[1].Value && (string)DS_SP_SP.Rows[DS_SP_SP.CurrentRow.Index].Cells[1].Value != null)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch {; }
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.dxErrorProvider1.SetError(control, "This is not a valid number");

                }
                else
                    this.dxErrorProvider1.ClearErrors();

            }
            catch (Exception ex)
            {

            }
        }

        private void CapNhatSauKhiLoad_DS_SP()
        {
            if (dgv_CTHD.Rows.Count - 1 > 0)
            {
                foreach (DataGridViewRow row_dsSP in DS_SP_SP.Rows)
                {
                    foreach (DataGridViewRow row_DSCTHD in dgv_CTHD.Rows)
                    {
                        if (row_dsSP != null && row_DSCTHD != null)
                        {
                            if ((string)row_dsSP.Cells[1].Value == (string)row_DSCTHD.Cells[1].Value)
                            {
                                row_dsSP.Cells[4].Value = int.Parse(row_dsSP.Cells[4].Value.ToString()) - int.Parse(row_DSCTHD.Cells[4].Value.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void cbb_loaihang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void InhoaDon()
        {
            chitiethd.MaHD = "HD" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");
            chitiethd.Ngaylap = Convert.ToDateTime(DT_ngaylap.Value.ToString());
            chitiethd.Tennv = txt_tennv.Text;
            chitiethd.TenKH = cbb_tenkhachhang.Text;
            chitiethd.DiachiKH = txt_diachi.Text;
            chitiethd.SdtKH = txt_sdt.Text;
            chitiethd.Tenloai = "";
            BUS_SanPham sp = new BUS_SanPham();
            List<CTHD> cthd1 = new List<CTHD> { };
            for (int i = 0; i < dgv_CTHD.RowCount - 1; i++)
            {
                {
                    CTHD hd = new CTHD();
                    hd.Masp = dgv_CTHD.Rows[i].Cells[2].Value.ToString();
                    hd.Tenloai = dgv_CTHD.Rows[i].Cells[0].Value.ToString();
                    hd.Soluuong = int.Parse(dgv_CTHD.Rows[i].Cells[4].Value.ToString());
                    hd.Dongia = float.Parse(dgv_CTHD.Rows[i].Cells[3].Value.ToString());
                    hd.Thanhtien1 = float.Parse(dgv_CTHD.Rows[i].Cells[5].Value.ToString());
                    cthd1.Add(hd);
                }
            }
            if (txt_chietkhau.Text == "")
            {
                frm_inHD inHD = new frm_inHD(chitiethd.MaHD, chitiethd.Tennv, chitiethd.TenKH, chitiethd.SdtKH, "( " + XTL.Utils.NumberToText(TongTien()) + " )", txt_tienkhachtra.Text, lb_tientholai.Text, chitiethd.Ngaylap, "0", lb_tongtien.Text, cthd1);
                inHD.ShowDialog();
            }
            else
            {
                frm_inHD inHD = new frm_inHD(chitiethd.MaHD, chitiethd.Tennv, chitiethd.TenKH, chitiethd.SdtKH, "( " + XTL.Utils.NumberToText(TongTien()) + " )", txt_tienkhachtra.Text, lb_tientholai.Text, chitiethd.Ngaylap, txt_chietkhau.Text, lb_tongtien.Text, cthd1);
                inHD.ShowDialog();
            }    
        }

        private void check_tienmat_CheckedChanged(object sender, EventArgs e)
        {
            if (check_tienmat.Checked == true)
            {
                txt_tienkhachtra.Enabled = true;
                lb_tientholai.Text = "";
                txt_tienkhachtra.Clear();
            }
            else
            {
                txt_tienkhachtra.Enabled = false;
                lb_tientholai.Text = "";
                txt_tienkhachtra.Clear();
            }
        }

        private void txt_tienkhachtra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_tienkhachtra.Text.Length == 0)
                {
                    lb_tientholai.Text = "";
                }    
                if (double.Parse(txt_tienkhachtra.Text) >= TongTien() && txt_tienkhachtra.Text.Length > 0)
                {
                    lb_tientholai.Text = (double.Parse(txt_tienkhachtra.Text) - TongTien()).ToString();
                    btnthanhtoan.Enabled = true;
                    btnghino.Enabled = false;

                }
                else if (double.Parse(txt_tienkhachtra.Text) < TongTien())
                {
                    lb_tientholai.Text ="Nợ " + (double.Parse(txt_tienkhachtra.Text) - TongTien()).ToString(); ;
                    btnthanhtoan.Enabled = false;
                    btnghino.Enabled = true;
                }
                else
                {
                    btnthanhtoan.Enabled = false;
                    lb_tientholai.Text = "0";
                    btnghino.Enabled = true;

                }

            }
            catch(Exception ex)
            {
                dxErrorProvider1.SetError(txt_tienkhachtra, ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Load_DSSP();
            CapNhatSauKhiLoad_DS_SP();
        }

        private void check_ngayhientai_Click(object sender, EventArgs e)
        {
            if(tennv !="ADMIN")
            {
                check_ngayhientai.Checked = true;
                MessageBox.Show("Bạn không được phép!", "Thông báo");
            }    
        }

        private void btnghino_Click(object sender, EventArgs e)
        {
            if (txt_tienkhachtra.Text != "")
            {
                if (cbb_tenkhachhang.Items.Count > 0)
                {
                    if (MessageBox.Show("Bạn có muốn áp dụng ghi nợ cho khách hàng không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frm_XacNhanGhiNo frm_XacNhanGhiNo = new frm_XacNhanGhiNo(cbb_tenkhachhang.SelectedValue.ToString(), cbb_tenkhachhang.Text, txt_sdt.Text, txt_diachi.Text, TongTien(), double.Parse(txt_tienkhachtra.Text));
                        frm_XacNhanGhiNo.ShowDialog();
                        if (frm_XacNhanGhiNo.TrangThai == 1)
                        {
                            ThanhToanHD();
                            phieuno.MaHD = "HD" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAHD_TU_TANG'");
                            phieuno.Ngayno = DateTime.Now;
                            phieuno.Manv = txt_manv.Text;
                            phieuno.Ghichu = frm_XacNhanGhiNo.Ghichu;
                            double Tienno = TongTien() - double.Parse(txt_tienkhachtra.Text);
                            phieuno.TienNo1 = (SqlMoney)Tienno;
                            pn.Add(phieuno);
                            phieunoct.MaPN = "PNO" + hd.GetValue("SELECT current_value FROM sys.sequences WHERE name = 'MAPHIEUNO_TU_TANG'"); ;
                            phieunoct.Ngaytra = DateTime.Now;
                            phieunoct.TienTra = SqlMoney.Parse(txt_tienkhachtra.Text);
                            pnct.Add(phieunoct);// cập nhật lại số tiền trả nợ]
                            dgv_CTHD.Rows.Clear();
                            Load_DSSP();
                            Clear();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền khách trả trước!(Có thể là 0)", "Thông báo");
                txt_tienkhachtra.Focus();
            }    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lb_tongtien.Text = TongTien().ToString("c", new CultureInfo("vi-VN"));// tính tổng tiền hóa đơn
                Control control = (Control)sender;
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                    txt_chietkhau.Clear();
                }
                else
                {
                    this.errorProvider1.Clear();
                }

            }
            catch (Exception ex)
            {
                this.errorProvider1.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(check_ngayhientai.Checked == true)
            {
                DT_ngaylap.Enabled = false;
            }  
            else
                DT_ngaylap.Enabled = true;

        }
       
    }
}
