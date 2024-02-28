namespace QLBH
{
    partial class frm_hethong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hethong));
            this.btn_saoluu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_phuchoi = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_saoluu.ImageOptions.Image")));
            this.btn_saoluu.Location = new System.Drawing.Point(30, 8);
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.Size = new System.Drawing.Size(123, 31);
            this.btn_saoluu.TabIndex = 0;
            this.btn_saoluu.Text = "Sao lữu dữ liệu";
            this.btn_saoluu.Click += new System.EventHandler(this.btn_saoluu_Click);
            // 
            // btn_phuchoi
            // 
            this.btn_phuchoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_phuchoi.ImageOptions.SvgImage")));
            this.btn_phuchoi.Location = new System.Drawing.Point(169, 8);
            this.btn_phuchoi.Name = "btn_phuchoi";
            this.btn_phuchoi.Size = new System.Drawing.Size(122, 31);
            this.btn_phuchoi.TabIndex = 0;
            this.btn_phuchoi.Text = "Phục hồi dữ liệu";
            this.btn_phuchoi.Click += new System.EventHandler(this.btn_phuchoi_Click);
            // 
            // frm_hethong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 46);
            this.Controls.Add(this.btn_phuchoi);
            this.Controls.Add(this.btn_saoluu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_hethong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sao lưu và khôi phục dữ liệu";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_saoluu;
        private DevExpress.XtraEditors.SimpleButton btn_phuchoi;
    }
}