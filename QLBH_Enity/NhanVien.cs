using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class NhanVien
    {
        private string _manv;
        private string _hoten;
        private string _sodt;
        private string _email;
        private DateTime _ngaysinh;
        private string diachi;
        private string _phai;
        private string _tinhtrang;

        public NhanVien(string manv, string hoten, string sodt, string email, DateTime ngaysinh, string phai)
        {
            Manv = manv;
            Hoten = hoten;
            Sodt = sodt;
            Email = email;
            Ngaysinh = ngaysinh;
            _phai = phai;
        }
        public NhanVien()
        {

        }
        public string Manv { get => _manv; set => _manv = value; }
        public string Hoten { get => _hoten; set => _hoten = value; }
        public string Sodt { get => _sodt; set => _sodt = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }
        public string Phai { get => _phai; set => _phai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }
    }
}
