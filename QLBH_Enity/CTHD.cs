using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class CTHD
    {
        private string _maHD;
        private string _masp;
        private int _soluuong;
        private string _tenloai;
        private string _dvt;
        private float _thanhtien;
        private DateTime _ngaylap;
        private string _Tennv;
        private string _TenKH;
        private string _diachiKH;
        private string _sdtKH;
        private SqlMoney _dongia;
        private float dongia_hd;


        public CTHD() { }


        public CTHD(string maHD, string masp, int soluuong, string tenloai, string dvt, float thanhtien, DateTime ngaylap, string tennv, string tenKH, string diachiKH, string sdtKH, SqlMoney dongia)
        {
            _maHD = maHD;
            _masp = masp;
            _soluuong = soluuong;
            _tenloai = tenloai;
            _dvt = dvt;
            _thanhtien = thanhtien;
            _ngaylap = ngaylap;
            _Tennv = tennv;
            _TenKH = tenKH;
            _diachiKH = diachiKH;
            _sdtKH = sdtKH;
            _dongia = dongia;
        }

        public string MaHD { get => _maHD; set => _maHD = value; }
        public string Masp { get => _masp; set => _masp = value; }
        public int Soluuong { get => _soluuong; set => _soluuong = value; }
        public string Tenloai { get => _tenloai; set => _tenloai = value; }
        public string Dvt { get => _dvt; set => _dvt = value; }
        public DateTime Ngaylap { get => _ngaylap; set => _ngaylap = value; }
        public string Tennv { get => _Tennv; set => _Tennv = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string DiachiKH { get => _diachiKH; set => _diachiKH = value; }
        public string SdtKH { get => _sdtKH; set => _sdtKH = value; }
        public float Thanhtien1 { get => _thanhtien; set => _thanhtien = value; }
        public SqlMoney Dongia { get => _dongia; set => _dongia = value; }
        public float Dongia_hd { get => dongia_hd; set => dongia_hd = value; }
    }
}
