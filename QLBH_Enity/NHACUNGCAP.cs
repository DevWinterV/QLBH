using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class NHACUNGCAP
    {
        private string _mancc,
            _tenncc,
            _tenbietdanh,
            _diachi, 
            _sdt,
            _email,
            _masothue,
            hinhanh,
            ghichu;
        private string _tinhtrang;
        private float _latitude;
        private float _longitude;
        private int _id_tinh;
        private int _id_huyen;
        private int _id_xa;

        public string Mancc { get => _mancc; set => _mancc = value; }
        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }
        public float Latitude { get => _latitude; set => _latitude = value; }
        public float Longitude { get => _longitude; set => _longitude = value; }
        public int Id_tinh { get => _id_tinh; set => _id_tinh = value; }
        public int Id_huyen { get => _id_huyen; set => _id_huyen = value; }
        public int Id_xa { get => _id_xa; set => _id_xa = value; }
        public string Email { get => _email; set => _email = value; }
        public string Masothue { get => _masothue; set => _masothue = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Tenbietdanh { get => _tenbietdanh; set => _tenbietdanh = value; }
    }
}
