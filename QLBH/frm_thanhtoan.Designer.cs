namespace QLBH
{
    partial class frm_thanhtoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thanhtoan));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTT = new DevExpress.XtraEditors.SimpleButton();
            this.btnInHD = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "BẠN HÃY XÁC NHẬN THANH TOÁN HAY IN HÓA ĐƠN ";
            // 
            // btnTT
            // 
            this.btnTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTT.ImageOptions.Image")));
            this.btnTT.Location = new System.Drawing.Point(12, 38);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(109, 29);
            this.btnTT.TabIndex = 1;
            this.btnTT.Text = "THANH TOÁN";
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.ImageOptions.Image")));
            this.btnInHD.Location = new System.Drawing.Point(146, 38);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(121, 29);
            this.btnInHD.TabIndex = 2;
            this.btnInHD.Text = "IN HÓA ĐƠN";
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(289, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 76);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XÁC NHẬN THANH TOÁN";
            this.Load += new System.EventHandler(this.frm_thanhtoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTT;
        private DevExpress.XtraEditors.SimpleButton btnInHD;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}