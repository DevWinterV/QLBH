namespace QLBH
{
    partial class frm_report_SP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_report_SP));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.btn_xemDSSP = new DevExpress.XtraEditors.SimpleButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbb_DS = new System.Windows.Forms.ComboBox();
            this.SANPHAM_LOAISANPHAM_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBHDataSet_SP = new QLBH.QLBHDataSet_SP();
            this.SANPHAM_LOAISANPHAM_TableAdapter = new QLBH.QLBHDataSet_SPTableAdapters.SANPHAM_LOAISANPHAM_TableAdapter();
            this.btn_xemall = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAM_LOAISANPHAM_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet_SP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN MỤC CẦN REPORT:";
            // 
            // cbb_chon
            // 
            this.cbb_chon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_chon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "LOẠI SẢN PHẨM",
            "DVT",
            "NHÀ CUNG CẤP"});
            this.cbb_chon.Location = new System.Drawing.Point(224, 11);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(121, 21);
            this.cbb_chon.TabIndex = 1;
            this.cbb_chon.SelectedIndexChanged += new System.EventHandler(this.cbb_chon_SelectedIndexChanged);
            // 
            // btn_xemDSSP
            // 
            this.btn_xemDSSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xemDSSP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_xemDSSP.Location = new System.Drawing.Point(529, 2);
            this.btn_xemDSSP.Name = "btn_xemDSSP";
            this.btn_xemDSSP.Size = new System.Drawing.Size(96, 32);
            this.btn_xemDSSP.TabIndex = 2;
            this.btn_xemDSSP.Text = "XEM DS";
            this.btn_xemDSSP.Click += new System.EventHandler(this.btn_xemDSSP_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SANPHAM_LOAISANPHAM_BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBH.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 409);
            this.reportViewer1.TabIndex = 3;
            // 
            // cbb_DS
            // 
            this.cbb_DS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_DS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_DS.FormattingEnabled = true;
            this.cbb_DS.Location = new System.Drawing.Point(352, 11);
            this.cbb_DS.Name = "cbb_DS";
            this.cbb_DS.Size = new System.Drawing.Size(170, 21);
            this.cbb_DS.TabIndex = 4;
            // 
            // SANPHAM_LOAISANPHAM_BindingSource
            // 
            this.SANPHAM_LOAISANPHAM_BindingSource.DataMember = "SANPHAM_LOAISANPHAM ";
            this.SANPHAM_LOAISANPHAM_BindingSource.DataSource = this.QLBHDataSet_SP;
            // 
            // QLBHDataSet_SP
            // 
            this.QLBHDataSet_SP.DataSetName = "QLBHDataSet_SP";
            this.QLBHDataSet_SP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SANPHAM_LOAISANPHAM_TableAdapter
            // 
            this.SANPHAM_LOAISANPHAM_TableAdapter.ClearBeforeFill = true;
            // 
            // btn_xemall
            // 
            this.btn_xemall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xemall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_xemall.Location = new System.Drawing.Point(631, 2);
            this.btn_xemall.Name = "btn_xemall";
            this.btn_xemall.Size = new System.Drawing.Size(105, 32);
            this.btn_xemall.TabIndex = 5;
            this.btn_xemall.Text = "XEM TẤT CẢ";
            this.btn_xemall.Click += new System.EventHandler(this.btn_xemall_Click);
            // 
            // frm_report_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_xemall);
            this.Controls.Add(this.cbb_DS);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_xemDSSP);
            this.Controls.Add(this.cbb_chon);
            this.Controls.Add(this.label1);
            this.Name = "frm_report_SP";
            this.Text = "XUẤT FILE SẢN PHẨM";
            this.Load += new System.EventHandler(this.frm_report_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAM_LOAISANPHAM_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet_SP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_chon;
        private DevExpress.XtraEditors.SimpleButton btn_xemDSSP;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbb_DS;
        private System.Windows.Forms.BindingSource SANPHAM_LOAISANPHAM_BindingSource;
        private QLBHDataSet_SP QLBHDataSet_SP;
        private QLBHDataSet_SPTableAdapters.SANPHAM_LOAISANPHAM_TableAdapter SANPHAM_LOAISANPHAM_TableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_xemall;
    }
}