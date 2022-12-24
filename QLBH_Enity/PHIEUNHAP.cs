using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class PHIEUNHAP
    {
        private string _soPN;
        private string _manv;
        private DateTime ngayNhap;
        private string _TenNCC;
        private SqlMoney _TongCong;
        private string _ghichu;
        public PHIEUNHAP()
        {

        }
        public PHIEUNHAP(string soPN, string manv, DateTime ngayNhap, string tenNCC, SqlMoney tongCong, string ghichu)
        {
            _soPN = soPN;
            _manv = manv;
            this.ngayNhap = ngayNhap;
            _TenNCC = tenNCC;
            _TongCong = tongCong;
            _ghichu = ghichu;
        }

        public DateTime NgayNhap { get => NgayNhap1; set => NgayNhap1 = value; }
        public string SoPN1 { get => _soPN; set => _soPN = value; }
        public string Manv1 { get => _manv; set => _manv = value; }
        public DateTime NgayNhap1 { get => ngayNhap; set => ngayNhap = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public SqlMoney TongCong { get => _TongCong; set => _TongCong = value; }
        public string Ghichu { get => _ghichu; set => _ghichu = value; }
    }
}
