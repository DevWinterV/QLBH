using QLBH_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frm_hethong : Form
    {
        public frm_hethong()
        {
            InitializeComponent();
        }
        CSDL_BUS bus = new CSDL_BUS();
        private void btn_saoluu_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
                saoluuFolder.Description = "Chọn thư mục lưu trữ file backup";
                if (saoluuFolder.ShowDialog() == DialogResult.OK)
                {
                    string sDuongDan = saoluuFolder.SelectedPath;
                    bus.SaoLuu(sDuongDan);
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void btn_phuchoi_Click(object sender, EventArgs e)
        {
            try
            {
                string fullPath;
                OpenFileDialog phuchoiFile = new OpenFileDialog();
                phuchoiFile.Filter = "*.bak|*.bak";
                phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
                if (phuchoiFile.ShowDialog() == DialogResult.OK &&
                phuchoiFile.CheckFileExists == true)
                {
                    if (MessageBox.Show("Bạn có thực sự muốn phục hồi dữ liệu từ file backup: " + phuchoiFile.FileName + " ?", "XÁC NHẬN PHỤC HỒI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sDuongDan = phuchoiFile.FileName;
                        fullPath = Path.GetFullPath(sDuongDan);
                            bus.PhucHoi(fullPath);
                        MessageBox.Show("Thành công");
                    }
                    else
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
