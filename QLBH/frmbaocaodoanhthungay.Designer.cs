namespace QLBH
{
    partial class frmbaocaodoanhthungay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbaocaodoanhthungay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_ngaychon = new System.Windows.Forms.DateTimePicker();
            this.bt_load = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.date_ngaychon);
            this.panel1.Controls.Add(this.bt_load);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 72);
            this.panel1.TabIndex = 4;
            // 
            // date_ngaychon
            // 
            this.date_ngaychon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_ngaychon.CustomFormat = "dd/MM/yyyy";
            this.date_ngaychon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaychon.Location = new System.Drawing.Point(465, 23);
            this.date_ngaychon.Name = "date_ngaychon";
            this.date_ngaychon.Size = new System.Drawing.Size(200, 26);
            this.date_ngaychon.TabIndex = 3;
            // 
            // bt_load
            // 
            this.bt_load.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_load.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_load.ImageOptions.Image")));
            this.bt_load.Location = new System.Drawing.Point(681, 13);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(202, 47);
            this.bt_load.TabIndex = 2;
            this.bt_load.Text = "LOAD";
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày (Tháng/Ngày/Năm) :";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(12, 90);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1123, 490);
            this.reportViewer1.TabIndex = 5;
            // 
            // frmbaocaodoanhthungay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1147, 592);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmbaocaodoanhthungay";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÁO CÁO DOANH THU NGÀY";
            this.Load += new System.EventHandler(this.frmbaocao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date_ngaychon;
        private DevExpress.XtraEditors.SimpleButton bt_load;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}