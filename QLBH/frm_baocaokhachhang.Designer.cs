namespace QLBH
{
    partial class frm_baocaokhachhang
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLBHDataSet = new QLBH.QLBHDataSet();
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KHACHHANGTableAdapter = new QLBH.QLBHDataSetTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLBH.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLBHDataSet
            // 
            this.QLBHDataSet.DataSetName = "QLBHDataSet";
            this.QLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.QLBHDataSet;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frm_baocaokhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_baocaokhachhang";
            this.Text = "DANH SÁCH KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frm_baocaokhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private QLBHDataSet QLBHDataSet;
        private QLBHDataSetTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
    }
}