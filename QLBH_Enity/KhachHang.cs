using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class KhachHang
    {
       private string _maKH;
       private string _hoten;
       private string _dchi;
       private string _sodt;
       private float? _latidue;
       private float? _longitude; 
       private int _manhomKh;
       private string _tenbietdanh;

        public KhachHang(string maKH, string hoten, string dchi, string sodt)
        {
            MaKH = maKH;
            Hoten = hoten;
            Dchi = dchi;
            Sodt = sodt;
        }
        public KhachHang() { }

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Dchi { get => _dchi; set => _dchi = value; }
        public string Sodt { get => _sodt; set => _sodt = value; }
        public float? Latidue { get => _latidue; set => _latidue = value; }
        public float? Longitude { get => _longitude; set => _longitude = value; }
        public int ManhomKh { get => _manhomKh; set => _manhomKh = value; }
        public string Tenbietdanh { get => _tenbietdanh; set => _tenbietdanh = value; }
    }
}
