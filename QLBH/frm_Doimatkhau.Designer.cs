namespace QLBH
{
    partial class frm_Doimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.txt_pass_HT = new System.Windows.Forms.TextBox();
            this.txt_pass_moi = new System.Windows.Forms.TextBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.check_mk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu hiện tại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu mới :";
            // 
            // txt_tentk
            // 
            this.txt_tentk.Location = new System.Drawing.Point(170, 59);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(238, 26);
            this.txt_tentk.TabIndex = 2;
            // 
            // txt_pass_HT
            // 
            this.txt_pass_HT.Location = new System.Drawing.Point(170, 99);
            this.txt_pass_HT.Name = "txt_pass_HT";
            this.txt_pass_HT.PasswordChar = '*';
            this.txt_pass_HT.Size = new System.Drawing.Size(238, 26);
            this.txt_pass_HT.TabIndex = 2;
            // 
            // txt_pass_moi
            // 
            this.txt_pass_moi.Location = new System.Drawing.Point(170, 141);
            this.txt_pass_moi.Name = "txt_pass_moi";
            this.txt_pass_moi.PasswordChar = '*';
            this.txt_pass_moi.Size = new System.Drawing.Size(238, 26);
            this.txt_pass_moi.TabIndex = 2;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Lime;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_luu.Location = new System.Drawing.Point(83, 209);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(126, 38);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu thay đổi";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(252, 210);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 38);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // check_mk
            // 
            this.check_mk.AutoSize = true;
            this.check_mk.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_mk.Location = new System.Drawing.Point(153, 179);
            this.check_mk.Name = "check_mk";
            this.check_mk.Size = new System.Drawing.Size(149, 25);
            this.check_mk.TabIndex = 4;
            this.check_mk.Text = "Hiện mật khẩu";
            this.check_mk.UseVisualStyleBackColor = true;
            this.check_mk.CheckedChanged += new System.EventHandler(this.check_mk_CheckedChanged);
            // 
            // frm_Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 256);
            this.Controls.Add(this.check_mk);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_pass_moi);
            this.Controls.Add(this.txt_pass_HT);
            this.Controls.Add(this.txt_tentk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_Doimatkhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.TextBox txt_pass_HT;
        private System.Windows.Forms.TextBox txt_pass_moi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.CheckBox check_mk;
    }
}