namespace QLBH
{
    partial class frm_ChinhSuaSoluongNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChinhSuaSoluongNhap));
            this.txt_soluong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnhuy = new DevExpress.XtraEditors.SimpleButton();
            this.lb_tongtien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(241, 141);
            this.txt_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_soluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ReadOnly = true;
            this.txt_soluong.Size = new System.Drawing.Size(84, 26);
            this.txt_soluong.TabIndex = 33;
            this.txt_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_soluong.ValueChanged += new System.EventHandler(this.txt_soluong_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số lượng đã có trong hóa đơn:  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Đơn giá:";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.Location = new System.Drawing.Point(145, 110);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(114, 20);
            this.lb_dongia.TabIndex = 23;
            this.lb_dongia.Text = "Tên sản phẩm:";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.Location = new System.Drawing.Point(145, 78);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(114, 20);
            this.lb_tensp.TabIndex = 24;
            this.lb_tensp.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_capnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhat.ImageOptions.Image")));
            this.btn_capnhat.Location = new System.Drawing.Point(36, 223);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(125, 48);
            this.btn_capnhat.TabIndex = 34;
            this.btn_capnhat.Text = "CẬP NHẬT";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnhuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.ImageOptions.Image")));
            this.btnhuy.Location = new System.Drawing.Point(194, 223);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(96, 48);
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtien.ForeColor = System.Drawing.Color.Red;
            this.lb_tongtien.Location = new System.Drawing.Point(145, 176);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(21, 22);
            this.lb_tongtien.TabIndex = 35;
            this.lb_tongtien.Text = "0";
            this.lb_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_ChinhSuaSoluongNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(346, 307);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_dongia);
            this.Controls.Add(this.lb_tensp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ChinhSuaSoluongNhap";
            this.Text = "CHỈNH SỬA SỐ LƯỢNG HÀNG HÓA";
            this.Load += new System.EventHandler(this.frm_ChinhSuaSoluongNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txt_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_capnhat;
        private DevExpress.XtraEditors.SimpleButton btnhuy;
        private System.Windows.Forms.Label lb_tongtien;
    }
}