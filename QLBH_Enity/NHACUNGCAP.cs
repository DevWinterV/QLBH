using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class NHACUNGCAP
    {
        private string _mancc, _tenncc, _diachi, _sdt;
        private string _tinhtrang;

        public string Mancc { get => _mancc; set => _mancc = value; }
        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }
    }
}
