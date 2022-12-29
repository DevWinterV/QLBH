namespace QLBH
{
    partial class frm_Nhapsanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nhapsanpham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themtensp = new System.Windows.Forms.Button();
            this.btn_ThemNCC = new System.Windows.Forms.Button();
            this.txt_SL = new System.Windows.Forms.NumericUpDown();
            this.cb_tenSP = new System.Windows.Forms.ComboBox();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.txt_DgiaN = new System.Windows.Forms.TextBox();
            this._ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_taoMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Huybo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoPN = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_Nhap = new System.Windows.Forms.DataGridView();
            this.colMSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_thongtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP KHO SẢN PHẨM";
            // 
            // btn_themtensp
            // 
            this.btn_themtensp.BackColor = System.Drawing.Color.Lime;
            this.btn_themtensp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themtensp.Location = new System.Drawing.Point(195, 87);
            this.btn_themtensp.Margin = new System.Windows.Forms.Padding(6);
            this.btn_themtensp.Name = "btn_themtensp";
            this.btn_themtensp.Size = new System.Drawing.Size(31, 21);
            this.btn_themtensp.TabIndex = 6;
            this.btn_themtensp.Text = "+";
            this.btn_themtensp.UseVisualStyleBackColor = false;
            this.btn_themtensp.Click += new System.EventHandler(this.btn_themtensp_Click);
            // 
            // btn_ThemNCC
            // 
            this.btn_ThemNCC.BackColor = System.Drawing.Color.Lime;
            this.btn_ThemNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemNCC.Location = new System.Drawing.Point(195, 38);
            this.btn_ThemNCC.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ThemNCC.Name = "btn_ThemNCC";
            this.btn_ThemNCC.Size = new System.Drawing.Size(31, 21);
            this.btn_ThemNCC.TabIndex = 6;
            this.btn_ThemNCC.Text = "+";
            this.btn_ThemNCC.UseVisualStyleBackColor = false;
            this.btn_ThemNCC.Click += new System.EventHandler(this.btn_ThemNCC_Click);
            // 
            // txt_SL
            // 
            this.txt_SL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(87, 122);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(6);
            this.txt_SL.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_SL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(47, 20);
            this.txt_SL.TabIndex = 4;
            this.txt_SL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_tenSP
            // 
            this.cb_tenSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_tenSP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tenSP.FormattingEnabled = true;
            this.cb_tenSP.Location = new System.Drawing.Point(23, 88);
            this.cb_tenSP.Margin = new System.Windows.Forms.Padding(6);
            this.cb_tenSP.Name = "cb_tenSP";
            this.cb_tenSP.Size = new System.Drawing.Size(168, 21);
            this.cb_tenSP.TabIndex = 3;
            this.cb_tenSP.DropDown += new System.EventHandler(this.cb_tenSP_DropDown);
            this.cb_tenSP.SelectedIndexChanged += new System.EventHandler(this.cb_tenSP_SelectedIndexChanged);
            this.cb_tenSP.SelectedValueChanged += new System.EventHandler(this.cb_tenSP_SelectedValueChanged);
            // 
            // cb_NCC
            // 
            this.cb_NCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(23, 38);
            this.cb_NCC.Margin = new System.Windows.Forms.Padding(6);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(168, 21);
            this.cb_NCC.TabIndex = 3;
            this.cb_NCC.DropDown += new System.EventHandler(this.cb_NCC_DropDown);
            this.cb_NCC.SelectedValueChanged += new System.EventHandler(this.cb_NCC_SelectedValueChanged);
            // 
            // txt_DgiaN
            // 
            this.txt_DgiaN.Enabled = false;
            this.txt_DgiaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DgiaN.Location = new System.Drawing.Point(87, 148);
            this.txt_DgiaN.Margin = new System.Windows.Forms.Padding(6);
            this.txt_DgiaN.Name = "txt_DgiaN";
            this.txt_DgiaN.Size = new System.Drawing.Size(141, 20);
            this.txt_DgiaN.TabIndex = 2;
            // 
            // _ngaynhap
            // 
            this._ngaynhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._ngaynhap.Location = new System.Drawing.Point(554, 24);
            this._ngaynhap.Margin = new System.Windows.Forms.Padding(6);
            this._ngaynhap.Name = "_ngaynhap";
            this._ngaynhap.Size = new System.Drawing.Size(140, 20);
            this._ngaynhap.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NGÀY NHẬP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_taoMoi);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Huybo);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 71);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_taoMoi
            // 
            this.btn_taoMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_taoMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_taoMoi.ImageOptions.Image")));
            this.btn_taoMoi.Location = new System.Drawing.Point(18, 6);
            this.btn_taoMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_taoMoi.Name = "btn_taoMoi";
            this.btn_taoMoi.Size = new System.Drawing.Size(102, 24);
            this.btn_taoMoi.TabIndex = 6;
            this.btn_taoMoi.Text = "Tạo Mới";
            this.btn_taoMoi.Click += new System.EventHandler(this.btn_taoMoi_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Enabled = false;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(124, 6);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 24);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Huybo
            // 
            this.btn_Huybo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huybo.Enabled = false;
            this.btn_Huybo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huybo.ImageOptions.Image")));
            this.btn_Huybo.Location = new System.Drawing.Point(18, 37);
            this.btn_Huybo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Huybo.Name = "btn_Huybo";
            this.btn_Huybo.Size = new System.Drawing.Size(102, 24);
            this.btn_Huybo.TabIndex = 5;
            this.btn_Huybo.Text = "Hủy bỏ";
            this.btn_Huybo.Click += new System.EventHandler(this.btn_Huybo_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.Location = new System.Drawing.Point(124, 37);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(105, 24);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemSP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemSP.ImageOptions.Image")));
            this.btn_ThemSP.Location = new System.Drawing.Point(20, 173);
            this.btn_ThemSP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(207, 24);
            this.btn_ThemSP.TabIndex = 5;
            this.btn_ThemSP.Text = "Thêm SP vào chi tiết nhập hàng >>";
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "CHỨC NĂNG :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(482, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "SỐ PHIẾU NHẬP HÀNG";
            // 
            // txt_SoPN
            // 
            this.txt_SoPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SoPN.Enabled = false;
            this.txt_SoPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoPN.Location = new System.Drawing.Point(610, 3);
            this.txt_SoPN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoPN.Name = "txt_SoPN";
            this.txt_SoPN.Size = new System.Drawing.Size(84, 20);
            this.txt_SoPN.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dgv_Nhap);
            this.groupControl2.Location = new System.Drawing.Point(267, 122);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(9);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(425, 306);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "CHI TIẾT NHẬP HÀNG";
            // 
            // dgv_Nhap
            // 
            this.dgv_Nhap.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Nhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Nhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Nhap.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Nhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Nhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_Nhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Nhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Nhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSp,
            this.colTensp,
            this.colSL,
            this.colDongianhap,
            this.colThanhtien,
            this.colXoa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Nhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Nhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Nhap.EnableHeadersVisualStyles = false;
            this.dgv_Nhap.Location = new System.Drawing.Point(2, 23);
            this.dgv_Nhap.Margin = new System.Windows.Forms.Padding(9);
            this.dgv_Nhap.Name = "dgv_Nhap";
            this.dgv_Nhap.ReadOnly = true;
            this.dgv_Nhap.RowHeadersVisible = false;
            this.dgv_Nhap.RowHeadersWidth = 62;
            this.dgv_Nhap.RowTemplate.Height = 28;
            this.dgv_Nhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Nhap.Size = new System.Drawing.Size(421, 281);
            this.dgv_Nhap.TabIndex = 0;
            this.dgv_Nhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Nhap_CellContentClick);
            this.dgv_Nhap.DoubleClick += new System.EventHandler(this.dgv_Nhap_DoubleClick);
            // 
            // colMSp
            // 
            this.colMSp.DataPropertyName = "masp";
            this.colMSp.FillWeight = 105.7484F;
            this.colMSp.HeaderText = "Mã SP";
            this.colMSp.MinimumWidth = 8;
            this.colMSp.Name = "colMSp";
            this.colMSp.ReadOnly = true;
            // 
            // colTensp
            // 
            this.colTensp.DataPropertyName = "tensp";
            this.colTensp.FillWeight = 105.7484F;
            this.colTensp.HeaderText = "Tên SP";
            this.colTensp.MinimumWidth = 8;
            this.colTensp.Name = "colTensp";
            this.colTensp.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "soluong";
            this.colSL.FillWeight = 105.7484F;
            this.colSL.HeaderText = "Số Lượng";
            this.colSL.MinimumWidth = 8;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colDongianhap
            // 
            this.colDongianhap.DataPropertyName = "dongia";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colDongianhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDongianhap.FillWeight = 105.7484F;
            this.colDongianhap.HeaderText = "Đơn giá";
            this.colDongianhap.MinimumWidth = 8;
            this.colDongianhap.Name = "colDongianhap";
            this.colDongianhap.ReadOnly = true;
            // 
            // colThanhtien
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colThanhtien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colThanhtien.HeaderText = "Thành Tiền";
            this.colThanhtien.MinimumWidth = 8;
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.ReadOnly = true;
            // 
            // colXoa
            // 
            this.colXoa.FillWeight = 79.54546F;
            this.colXoa.HeaderText = "XÓA";
            this.colXoa.Image = global::QLBH.Properties.Resources.Exit2;
            this.colXoa.MinimumWidth = 8;
            this.colXoa.Name = "colXoa";
            this.colXoa.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GHI CHÚ:";
            // 
            // txtghichu
            // 
            this.txtghichu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtghichu.Location = new System.Drawing.Point(266, 77);
            this.txtghichu.Margin = new System.Windows.Forms.Padding(2);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtghichu.Size = new System.Drawing.Size(250, 41);
            this.txtghichu.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_thongtien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(519, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 50);
            this.panel2.TabIndex = 7;
            // 
            // lb_thongtien
            // 
            this.lb_thongtien.AutoSize = true;
            this.lb_thongtien.BackColor = System.Drawing.Color.Yellow;
            this.lb_thongtien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_thongtien.Enabled = false;
            this.lb_thongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_thongtien.Location = new System.Drawing.Point(16, 26);
            this.lb_thongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thongtien.Name = "lb_thongtien";
            this.lb_thongtien.Size = new System.Drawing.Size(16, 15);
            this.lb_thongtien.TabIndex = 6;
            this.lb_thongtien.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TỔNG TIỀN:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_themtensp);
            this.groupBox1.Controls.Add(this.btn_ThemSP);
            this.groupBox1.Controls.Add(this.btn_ThemNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cb_tenSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_NCC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_DgiaN);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "NHÂN VIÊN";
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tennhanvien.Enabled = false;
            this.txt_tennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennhanvien.Location = new System.Drawing.Point(554, 44);
            this.txt_tennhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(140, 20);
            this.txt_tennhanvien.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 79.54546F;
            this.dataGridViewImageColumn1.HeaderText = "XÓA";
            this.dataGridViewImageColumn1.Image = global::QLBH.Properties.Resources.Exit2;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 97;
            // 
            // frm_Nhapsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.txt_SoPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._ngaynhap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Nhapsanpham";
            this.Text = "NHẬP KHO SẢN PHẨM";
            this.Load += new System.EventHandler(this.frm_Nhapsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_SL)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.TextBox txt_DgiaN;
        private System.Windows.Forms.DateTimePicker _ngaynhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txt_SL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.SimpleButton btn_ThemSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SoPN;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgv_Nhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_themtensp;
        private System.Windows.Forms.Button btn_ThemNCC;
        private DevExpress.XtraEditors.SimpleButton btn_Huybo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_thongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhtien;
        private System.Windows.Forms.DataGridViewImageColumn colXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private DevExpress.XtraEditors.SimpleButton btn_taoMoi;
    }
}