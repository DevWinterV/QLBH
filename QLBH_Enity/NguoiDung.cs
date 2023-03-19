using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class NguoiDung
    {
       private string _manv;
       private string _username;
       private string _pass;
       private string _maquyen;
        public NguoiDung() { }
        public NguoiDung(string manv, string username, string pass, string phanquyen)
        {
            _manv = manv;
            _username = username;
            _pass = pass;
            _maquyen = phanquyen;
        }

        public string Manv { get => _manv; set => _manv = value; }
        public string Username { get => _username; set => _username = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Phanquyen { get => _maquyen; set => _maquyen = value; }
    }
}
