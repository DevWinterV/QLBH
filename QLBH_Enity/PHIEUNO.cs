using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class PHIEUNO
    {
        private DateTime ngayno;
        private string maPN, maHD, ghichu;
        private SqlMoney TienNo;
        private string _manv;
        public DateTime Ngayno { get => ngayno; set => ngayno = value; }
        public string MaPN { get => maPN; set => maPN = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public SqlMoney TienNo1 { get => TienNo; set => TienNo = value; }
        public string Manv { get => _manv; set => _manv = value; }
    }
}
