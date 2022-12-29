using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class PHIEUNHAP_CHITIET
    {
        private string _soPN;
        private string _masp;
        private string _tenloai;
        private string _tensanpham;
        private int soluong;
        private SqlMoney Dongia;
        private double _thanhtien;

        public PHIEUNHAP_CHITIET()
        {

        }

        public PHIEUNHAP_CHITIET(string soPN, string masp, string tenloai, string tensanpham, int soluong, SqlMoney dongia, double thanhtien)
        {
            _soPN = soPN;
            _masp = masp;
            _tenloai = tenloai;
            _tensanpham = tensanpham;
            this.soluong = soluong;
            Dongia = dongia;
            _thanhtien = thanhtien;
        }

        public string SoPN { get => _soPN; set => _soPN = value; }
        public string Masp { get => _masp; set => _masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Tenloai { get => _tenloai; set => _tenloai = value; }
        public string Tensanpham { get => _tensanpham; set => _tensanpham = value; }
        public SqlMoney Dongia1 { get => Dongia; set => Dongia = value; }
        public double Thanhtien { get => _thanhtien; set => _thanhtien = value; }
    }
}
