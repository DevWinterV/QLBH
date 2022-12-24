using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class Admin
    {
       private string _user;
        private string _password;
        private string _phanquyen;
        public Admin(string user, string password)
        {
            _user = user;
            _password = password;
        }
        public Admin()
        {
        }

        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
        public string Phanquyen { get => _phanquyen; set => _phanquyen = value; }
    }
}
