using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class LoaiHang
    {
        private string _maloai;
        private string _tenhang;
        private string _tinhtrang;
        public string Tenhang { get => _tenhang; set => _tenhang = value; }
        public string Maloai { get => _maloai; set => _maloai = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }

        public LoaiHang(string maloai, string tenhang)
        {
            _maloai = maloai;
            _tenhang = tenhang;
        }
        public LoaiHang()
        {

        }
    }
}
