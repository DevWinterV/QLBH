namespace QLBH
{
    partial class from_scanBarCode
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
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(4, 8);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(147, 22);
            this.comboBox_camera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(163, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐƯA MÃ VẠCH VÀO GẦN CAMERA ĐỂ SCAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(151, 7);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(354, 7);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(100, 20);
            this.txt_kq.TabIndex = 4;
            this.txt_kq.TextChanged += new System.EventHandler(this.txt_kq_TextChanged);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Check.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(469, 6);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "MÃ SP:";
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(226, 7);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // from_scanBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_camera);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "from_scanBarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÉT MÃ SẢN PHẨM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.from_scanBarCode_FormClosing);
            this.Load += new System.EventHandler(this.from_scanBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}