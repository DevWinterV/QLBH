using DevExpress.Xpo.DB.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frm_chonxcuatbarcode : Form
    {
        private string barcode;
        public frm_chonxcuatbarcode(string barcode)
        {
            InitializeComponent();
            this.barcode = barcode; 
        }

        private void frm_chonxcuatbarcode_Load(object sender, EventArgs e)
        {
            txtbarcode.Text = barcode;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();
            Image img = barcode.Encode(BarcodeLib.TYPE.CODE39, txtbarcode.Text.Trim(), Color.Black, Color.White, 120, 40);
            img_barcode.Image = img;
            this.dataSet11.Clear();
            using(MemoryStream ms =new MemoryStream())
            {
                img.Save(ms,ImageFormat.Png);
                for(int i  =0; i <numersoluongxuat.Value; i++)
                {
                    this.dataSet11.Barcode.AddBarcodeRow(txtbarcode.Text, ms.ToArray());
                }
            }
            using (frm_xuatbarcodesanpham frm = new frm_xuatbarcodesanpham(this.dataSet11.Barcode))
            {
                frm.ShowDialog();
            }
        }
    }
}
