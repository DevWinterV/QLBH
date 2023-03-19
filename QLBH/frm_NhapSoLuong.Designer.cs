namespace QLBH
{
    partial class frm_NhapSoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhapSoLuong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.lb_tenloai = new System.Windows.Forms.Label();
            this.lb_tensp = new System.Windows.Forms.Label();
            this.lb_dongia = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thành tiền:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(129, 166);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(86, 20);
            this.txtsoluong.TabIndex = 0;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsoluong_KeyDown);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Enabled = false;
            this.txtthanhtien.ForeColor = System.Drawing.Color.Red;
            this.txtthanhtien.Location = new System.Drawing.Point(129, 200);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(109, 20);
            this.txtthanhtien.TabIndex = 1;
            // 
            // lb_tenloai
            // 
            this.lb_tenloai.AutoSize = true;
            this.lb_tenloai.ForeColor = System.Drawing.Color.Blue;
            this.lb_tenloai.Location = new System.Drawing.Point(143, 55);
            this.lb_tenloai.Name = "lb_tenloai";
            this.lb_tenloai.Size = new System.Drawing.Size(49, 14);
            this.lb_tenloai.TabIndex = 0;
            this.lb_tenloai.Text = "Tên loại:";
            // 
            // lb_tensp
            // 
            this.lb_tensp.AutoSize = true;
            this.lb_tensp.ForeColor = System.Drawing.Color.Blue;
            this.lb_tensp.Location = new System.Drawing.Point(140, 81);
            this.lb_tensp.Name = "lb_tensp";
            this.lb_tensp.Size = new System.Drawing.Size(76, 14);
            this.lb_tensp.TabIndex = 0;
            this.lb_tensp.Text = "Tên sản phẩm:";
            // 
            // lb_dongia
            // 
            this.lb_dongia.AutoSize = true;
            this.lb_dongia.ForeColor = System.Drawing.Color.Blue;
            this.lb_dongia.Location = new System.Drawing.Point(142, 110);
            this.lb_dongia.Name = "lb_dongia";
            this.lb_dongia.Size = new System.Drawing.Size(76, 14);
            this.lb_dongia.TabIndex = 0;
            this.lb_dongia.Text = "Tên sản phẩm:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "(VNĐ)";
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(163, 236);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(99, 29);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Cancel";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnok
            // 
            this.btnok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnok.ImageOptions.Image")));
            this.btnok.Location = new System.Drawing.Point(41, 236);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(92, 29);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng còn:";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.ForeColor = System.Drawing.Color.Red;
            this.lbsoluong.Location = new System.Drawing.Point(142, 138);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(46, 14);
            this.lbsoluong.TabIndex = 0;
            this.lbsoluong.Text = "số lượng";
            // 
            // frm_NhapSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtthanhtien);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbsoluong);
            this.Controls.Add(this.lb_dongia);
            this.Controls.Add(this.lb_tensp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_tenloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_NhapSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬP SỐ LƯỢNG SẢN PHẨM";
            this.Load += new System.EventHandler(this.frm_NhapSoLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtthanhtien;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private System.Windows.Forms.Label lb_tenloai;
        private System.Windows.Forms.Label lb_tensp;
        private System.Windows.Forms.Label lb_dongia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbsoluong;
    }
}