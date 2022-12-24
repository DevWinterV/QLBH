namespace QLBH
{
    partial class frmHOADON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOADON));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btntimkiemngay = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txt_nhap = new System.Windows.Forms.TextBox();
            this.cbb_chontimkiem = new System.Windows.Forms.ComboBox();
            this.datetime_den = new System.Windows.Forms.DateTimePicker();
            this.datetime_tungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemmoi = new DevExpress.XtraEditors.SimpleButton();
            this.btninhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_DSHD = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nggd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            this.colMaHD_CTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.btntimkiemngay);
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.txt_nhap);
            this.groupControl1.Controls.Add(this.cbb_chontimkiem);
            this.groupControl1.Controls.Add(this.datetime_den);
            this.groupControl1.Controls.Add(this.datetime_tungay);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(45, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 147);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chức năng tìm kiếm";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btntimkiemngay
            // 
            this.btntimkiemngay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiemngay.ImageOptions.Image")));
            this.btntimkiemngay.Location = new System.Drawing.Point(600, 96);
            this.btntimkiemngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimkiemngay.Name = "btntimkiemngay";
            this.btntimkiemngay.Size = new System.Drawing.Size(133, 39);
            this.btntimkiemngay.TabIndex = 5;
            this.btntimkiemngay.Text = "Tìm Kiếm";
            this.btntimkiemngay.Click += new System.EventHandler(this.btntimkiemngay_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(600, 49);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 38);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txt_nhap
            // 
            this.txt_nhap.Location = new System.Drawing.Point(400, 47);
            this.txt_nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nhap.Name = "txt_nhap";
            this.txt_nhap.Size = new System.Drawing.Size(192, 27);
            this.txt_nhap.TabIndex = 4;
            this.txt_nhap.TextChanged += new System.EventHandler(this.txt_nhap_TextChanged);
            // 
            // cbb_chontimkiem
            // 
            this.cbb_chontimkiem.FormattingEnabled = true;
            this.cbb_chontimkiem.Items.AddRange(new object[] {
            "Mã (HD, NV, KH)",
            "Ngày giao dịch"});
            this.cbb_chontimkiem.Location = new System.Drawing.Point(162, 49);
            this.cbb_chontimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_chontimkiem.Name = "cbb_chontimkiem";
            this.cbb_chontimkiem.Size = new System.Drawing.Size(154, 27);
            this.cbb_chontimkiem.TabIndex = 3;
            this.cbb_chontimkiem.SelectedIndexChanged += new System.EventHandler(this.cbb_chontimkiem_SelectedIndexChanged);
            // 
            // datetime_den
            // 
            this.datetime_den.CustomFormat = "dd/MM/yyyy";
            this.datetime_den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_den.Location = new System.Drawing.Point(407, 83);
            this.datetime_den.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetime_den.Name = "datetime_den";
            this.datetime_den.Size = new System.Drawing.Size(185, 27);
            this.datetime_den.TabIndex = 2;
            // 
            // datetime_tungay
            // 
            this.datetime_tungay.CustomFormat = "dd/MM/yyyy";
            this.datetime_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_tungay.Location = new System.Drawing.Point(162, 84);
            this.datetime_tungay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetime_tungay.Name = "datetime_tungay";
            this.datetime_tungay.Size = new System.Drawing.Size(154, 27);
            this.datetime_tungay.TabIndex = 2;
            this.datetime_tungay.ValueChanged += new System.EventHandler(this.datetime_tungay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm theo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(41, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1122, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Chọn 1 dòng trong danh sách hóa đơn để xem chi tiết.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl2.Controls.Add(this.btnthoat);
            this.groupControl2.Controls.Add(this.btnhuy);
            this.groupControl2.Controls.Add(this.btnthemmoi);
            this.groupControl2.Controls.Add(this.btninhoadon);
            this.groupControl2.Location = new System.Drawing.Point(833, 13);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(326, 147);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "In Hóa Đơn";
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(175, 42);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(137, 43);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(175, 99);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(137, 46);
            this.btnhuy.TabIndex = 0;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.ImageOptions.Image")));
            this.btnthemmoi.Location = new System.Drawing.Point(12, 42);
            this.btnthemmoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(146, 43);
            this.btnthemmoi.TabIndex = 1;
            this.btnthemmoi.Text = "Thêm HĐ mới";
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // btninhoadon
            // 
            this.btninhoadon.Enabled = false;
            this.btninhoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btninhoadon.ImageOptions.Image")));
            this.btninhoadon.Location = new System.Drawing.Point(12, 101);
            this.btninhoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(146, 43);
            this.btninhoadon.TabIndex = 0;
            this.btninhoadon.Text = "In Hóa Đơn";
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgv_DSHD);
            this.groupBox1.Location = new System.Drawing.Point(3, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgv_DSHD
            // 
            this.dgv_DSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSHD.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.nggd,
            this.tennv,
            this.tenKH,
            this.dchi,
            this.sdt,
            this.thanhtien});
            this.dgv_DSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DSHD.Location = new System.Drawing.Point(3, 22);
            this.dgv_DSHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_DSHD.Name = "dgv_DSHD";
            this.dgv_DSHD.ReadOnly = true;
            this.dgv_DSHD.RowHeadersWidth = 62;
            this.dgv_DSHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DSHD.Size = new System.Drawing.Size(646, 461);
            this.dgv_DSHD.TabIndex = 1;
            this.dgv_DSHD.Click += new System.EventHandler(this.dgv_DSHD_Click);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "mahd";
            this.mahd.HeaderText = "Mã HĐ";
            this.mahd.MinimumWidth = 8;
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // nggd
            // 
            this.nggd.DataPropertyName = "ngaygd";
            this.nggd.HeaderText = "Ngày DG";
            this.nggd.MinimumWidth = 8;
            this.nggd.Name = "nggd";
            this.nggd.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "hoten";
            this.tennv.HeaderText = "Tên NV";
            this.tennv.MinimumWidth = 8;
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "hoten1";
            this.tenKH.HeaderText = "Tên KH";
            this.tenKH.MinimumWidth = 8;
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            // 
            // dchi
            // 
            this.dchi.DataPropertyName = "dchi";
            this.dchi.HeaderText = "Địa chỉ";
            this.dchi.MinimumWidth = 8;
            this.dchi.Name = "dchi";
            this.dchi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 8;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle1;
            this.thanhtien.HeaderText = "Tổng cộng";
            this.thanhtien.MinimumWidth = 8;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_ChiTietHD);
            this.groupBox2.Location = new System.Drawing.Point(661, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 483);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHD.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD_CTHD,
            this.coltenloai,
            this.colMaSp,
            this.coltensp,
            this.colSoluong,
            this.oldongia,
            this.colthanhtien});
            this.dgv_ChiTietHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietHD.Enabled = false;
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(3, 22);
            this.dgv_ChiTietHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.ReadOnly = true;
            this.dgv_ChiTietHD.RowHeadersWidth = 62;
            this.dgv_ChiTietHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(535, 458);
            this.dgv_ChiTietHD.TabIndex = 1;
            // 
            // colMaHD_CTHD
            // 
            this.colMaHD_CTHD.DataPropertyName = "mahd";
            this.colMaHD_CTHD.HeaderText = "Mã hóa đơn";
            this.colMaHD_CTHD.MinimumWidth = 8;
            this.colMaHD_CTHD.Name = "colMaHD_CTHD";
            this.colMaHD_CTHD.ReadOnly = true;
            // 
            // coltenloai
            // 
            this.coltenloai.DataPropertyName = "tenloai";
            this.coltenloai.HeaderText = "Loại SP";
            this.coltenloai.MinimumWidth = 8;
            this.coltenloai.Name = "coltenloai";
            this.coltenloai.ReadOnly = true;
            // 
            // colMaSp
            // 
            this.colMaSp.DataPropertyName = "masp";
            this.colMaSp.HeaderText = "Mã SP";
            this.colMaSp.MinimumWidth = 8;
            this.colMaSp.Name = "colMaSp";
            this.colMaSp.ReadOnly = true;
            // 
            // coltensp
            // 
            this.coltensp.DataPropertyName = "tensp";
            this.coltensp.HeaderText = "Tên SP";
            this.coltensp.MinimumWidth = 8;
            this.coltensp.Name = "coltensp";
            this.coltensp.ReadOnly = true;
            // 
            // colSoluong
            // 
            this.colSoluong.DataPropertyName = "soluong";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colSoluong.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSoluong.HeaderText = "Số lượng";
            this.colSoluong.MinimumWidth = 8;
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.ReadOnly = true;
            // 
            // oldongia
            // 
            this.oldongia.DataPropertyName = "dongia";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.oldongia.DefaultCellStyle = dataGridViewCellStyle3;
            this.oldongia.HeaderText = "Đơn giá";
            this.oldongia.MinimumWidth = 8;
            this.oldongia.Name = "oldongia";
            this.oldongia.ReadOnly = true;
            // 
            // colthanhtien
            // 
            this.colthanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colthanhtien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colthanhtien.HeaderText = "Thành tiền";
            this.colthanhtien.MinimumWidth = 8;
            this.colthanhtien.Name = "colthanhtien";
            this.colthanhtien.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "frmHOADON";
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetime_tungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime_den;
        private System.Windows.Forms.ComboBox cbb_chontimkiem;
        private System.Windows.Forms.TextBox txt_nhap;
        private DevExpress.XtraEditors.SimpleButton btntimkiemngay;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private DevExpress.XtraEditors.SimpleButton btninhoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nggd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD_CTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthanhtien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnthemmoi;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
    }
}