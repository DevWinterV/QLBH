﻿namespace QLBH
{
    partial class frmDangNhap
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnpass = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnXempass = new System.Windows.Forms.PictureBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXempass)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAnpass);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.btnXempass);
            this.panel1.Controls.Add(this.txtTaikhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(182, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 242);
            this.panel1.TabIndex = 4;
            // 
            // btnAnpass
            // 
            this.btnAnpass.BackgroundImage = global::QLBH.Properties.Resources.Mắt_nhắm;
            this.btnAnpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAnpass.Location = new System.Drawing.Point(282, 188);
            this.btnAnpass.Name = "btnAnpass";
            this.btnAnpass.Size = new System.Drawing.Size(37, 31);
            this.btnAnpass.TabIndex = 22;
            this.btnAnpass.TabStop = false;
            this.btnAnpass.Click += new System.EventHandler(this.btnAnpass_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(72, 189);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(210, 26);
            this.txtpass.TabIndex = 21;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged_1);
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // btnXempass
            // 
            this.btnXempass.BackgroundImage = global::QLBH.Properties.Resources.Mắt_mở;
            this.btnXempass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXempass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnXempass.Location = new System.Drawing.Point(281, 187);
            this.btnXempass.Name = "btnXempass";
            this.btnXempass.Size = new System.Drawing.Size(37, 31);
            this.btnXempass.TabIndex = 23;
            this.btnXempass.TabStop = false;
            this.btnXempass.Click += new System.EventHandler(this.btnXempass_Click_1);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(72, 127);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(245, 26);
            this.txtTaikhoan.TabIndex = 20;
            this.txtTaikhoan.TextChanged += new System.EventHandler(this.txtTaikhoan_TextChanged_1);
            this.txtTaikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaikhoan_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(69, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mật Khẩu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(68, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên Đăng Nhập :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-1, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(126, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnExit.BackgroundImage = global::QLBH.Properties.Resources.Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(676, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.White;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(290, 415);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(158, 60);
            this.btnDangNhap.TabIndex = 22;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLBH.Properties.Resources.hóa_đơn__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 477);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXempass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAnpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox btnXempass;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

