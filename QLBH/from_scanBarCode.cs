using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using ZXing;
using System.Globalization;
using DevExpress.XtraDiagram.Base;
using QLBH_BUS;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace QLBH
{
    public partial class from_scanBarCode : Form
    {
        BUS_SanPham sp = new BUS_SanPham();
        FilterInfoCollection filterInfo;
        VideoCaptureDevice videoCaptureDevice;
        public DataGridView Dgv { get; set; }
        public DataGridView Dgv_Sp { get; set; }

        frm_hoadonbanhang hdbh;

        public from_scanBarCode()
        {
            InitializeComponent();
        }
        public from_scanBarCode(frm_hoadonbanhang bh)
        {
            InitializeComponent();this.hdbh = bh;
        }

        private void from_scanBarCode_Load(object sender, EventArgs e)
        {
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfo)
            {
                comboBox_camera.Items.Add(device.Name);
            }
            comboBox_camera.SelectedIndex = 0;
      
        }
        public void onePing()
        {
            Console.Beep(500, 500);
        }
        private void CaptureDevie_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txt_kq.Invoke(new MethodInvoker(delegate ()
                {
                    txt_kq.Text = result.ToString().ToUpper().Trim();

                    if (txt_kq.Text.Substring(0, 2) == "SP")
                    {
                        if (sp.GetDulieu("select count(masp) from sanphamdgd where masp = '"+ result.ToString().ToUpper().Trim() + "'") == "1")
                        {
                            if (hdbh.check_masp(result.ToString()))
                            {
                                onePing();
                                frm_NhapSoLuong nsl = new frm_NhapSoLuong(result.ToString(), true, hdbh);
                                nsl.Dgv = this.Dgv;
                                nsl.ShowDialog();
                            }
                            else
                            {
                                frm_NHapSoLuongCapNhat nsl = new frm_NHapSoLuongCapNhat(result.ToString(), true, hdbh);
                                nsl.Dgv = this.Dgv;
                                nsl.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã barcode này không tồn tại trong hệ thống bán hàng.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng quét lại.");
                    }    
                }));
                
            }
            pictureBox1.Image = bitmap;

        }

        private void Enable_Button(bool t)
        {
            btn_start.Enabled = !t;
            btn_stop.Enabled = t;
       
        }    
        private void btn_start_Click(object sender, EventArgs e)
        {
            Enable_Button(true);
            videoCaptureDevice = new VideoCaptureDevice(filterInfo[comboBox_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += CaptureDevie_NewFrame;
            videoCaptureDevice.Start();
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Stop", "SCAN BARCODE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (btn_stop.Enabled == true)
                {
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                }
                else
                {
                }
            }
            else
            {

            }    
        }

        private void from_scanBarCode_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure, you want to exit", "SCAN BARCODE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (btn_stop.Enabled == true)
                {
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else
            { e.Cancel = true; }


        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if(txt_kq.Text!="")
            {
                if (txt_kq.Text.Substring(0, 2) == "SP")
                {
                    if (sp.GetDulieu("select count(masp) from sanphamdgd where masp = '" + txt_kq.Text.ToUpper().Trim() + "'") == "1")
                    {
                        if (hdbh.check_masp(txt_kq.Text.ToUpper().Trim()))
                        {
                            onePing();
                            frm_NhapSoLuong nsl = new frm_NhapSoLuong(txt_kq.Text.ToUpper().Trim(), true, hdbh);
                            nsl.Dgv = this.Dgv;
                            nsl.ShowDialog();
                        }
                        else
                        {
                            frm_NHapSoLuongCapNhat nsl = new frm_NHapSoLuongCapNhat(txt_kq.Text.ToUpper().Trim(), true, hdbh);
                            nsl.Dgv = this.Dgv;
                            nsl.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã barcode này không tồn tại trong hệ thống bán hàng.");
                    }
                }
                else
                {
                    txt_kq.Focus();
                    errorProvider1.SetError(txt_kq, "Mã BARCODE không đúng định dạng (SP10000)");
                }
            }
            else
            {
                errorProvider1.SetError(txt_kq, "Vui lòng nhập Mã SP");
                txt_kq.Focus();
            }
        }

        private void txt_kq_TextChanged(object sender, EventArgs e)
        {
            if(txt_kq.Text.Length>1)
            {
                errorProvider1.Clear();
            }    
        }
    }
}
