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
        private int soluong;
        private SqlMoney Dongia;
        private string _mancc;
        public PHIEUNHAP_CHITIET()
        {

        }
        public PHIEUNHAP_CHITIET(string soPN, string masp, int soluong, SqlMoney dongia)
        {
            SoPN = soPN;
            Masp = masp;
            this.Soluong = soluong;
            Dongia1 = dongia;
        }

        public string SoPN { get => _soPN; set => _soPN = value; }
        public string Masp { get => _masp; set => _masp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public SqlMoney Dongia1 { get => Dongia; set => Dongia = value; }
        public string Mancc { get => _mancc; set => _mancc = value; }
    }
}
