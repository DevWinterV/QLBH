namespace QLBH
{
    partial class frm_chonxcuatbarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chonxcuatbarcode));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numersoluongxuat = new System.Windows.Forms.NumericUpDown();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.img_barcode = new System.Windows.Forms.PictureBox();
            this.dataSet11 = new QLBH.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.numersoluongxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng: ";
            // 
            // numersoluongxuat
            // 
            this.numersoluongxuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numersoluongxuat.Location = new System.Drawing.Point(119, 66);
            this.numersoluongxuat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numersoluongxuat.Name = "numersoluongxuat";
            this.numersoluongxuat.Size = new System.Drawing.Size(109, 20);
            this.numersoluongxuat.TabIndex = 2;
            this.numersoluongxuat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtbarcode
            // 
            this.txtbarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbarcode.Enabled = false;
            this.txtbarcode.Location = new System.Drawing.Point(119, 36);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(109, 20);
            this.txtbarcode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "XUẤT BAR CODE SẢN PHẨM";
            // 
            // btndong
            // 
            this.btndong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.Location = new System.Drawing.Point(149, 199);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 32);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnin
            // 
            this.btnin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnin.ImageOptions.Image")));
            this.btnin.Location = new System.Drawing.Point(59, 199);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 32);
            this.btnin.TabIndex = 4;
            this.btnin.Text = "In";
            this.btnin.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // img_barcode
            // 
            this.img_barcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.img_barcode.Location = new System.Drawing.Point(55, 91);
            this.img_barcode.Name = "img_barcode";
            this.img_barcode.Size = new System.Drawing.Size(172, 96);
            this.img_barcode.TabIndex = 5;
            this.img_barcode.TabStop = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_chonxcuatbarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.img_barcode);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.numersoluongxuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_chonxcuatbarcode";
            this.Text = "Xuất barcode sản phẩm";
            this.Load += new System.EventHandler(this.frm_chonxcuatbarcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numersoluongxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numersoluongxuat;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private System.Windows.Forms.PictureBox img_barcode;
        private DataSet1 dataSet11;
    }
}