using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class SanPham
    {
        private string _maloai;
        private string _masp;
        private string _tensp;
        private string _stringdonvitinh;
        private SqlMoney _dongia;
        private SqlMoney _dongiaNhap;
        private DateTime NgayUpdate;
        float _SLuong;
        //private string _mancc;
        private string _tinhtrang;
        private double _thanhtien;
        private DateTime? _hsd;

        public SanPham(string maloai, string masp, string tensp, string stringdonvitinh, SqlMoney dongia, float sLuong)
        {
            Maloai = maloai;
            Masp = masp;
            Tensp = tensp;
            Stringdonvitinh = stringdonvitinh;
            Dongia1 = dongia;
            SLuong = sLuong;
        }
        public SanPham()
        { }

        public string Maloai { get => _maloai; set => _maloai = value; }
        public string Masp { get => _masp; set => _masp = value; }
        public string Tensp { get => _tensp; set => _tensp = value; }
        public string Stringdonvitinh { get => _stringdonvitinh; set => _stringdonvitinh = value; }
        public float SLuong { get => _SLuong; set => _SLuong = value; }
        public SqlMoney Dongia1 { get => _dongia; set => _dongia = value; }
        //public string Mancc { get => _mancc; set => _mancc = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }
        public SqlMoney DongiaNhap { get => _dongiaNhap; set => _dongiaNhap = value; }
        public DateTime NgayUpdate1 { get => NgayUpdate; set => NgayUpdate = Convert.ToDateTime( DateTime.Now); }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
        public DateTime? Hsd { get => _hsd; set => _hsd = value; }
    }
}
