using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class PHIEUNO_CT
    {
        private int _STT;
        private string _maPN;
        private SqlMoney _TienTra;
        private DateTime _ngaytra;

        public int STT { get => _STT; set => _STT = value; }
        public string MaPN { get => _maPN; set => _maPN = value; }
        public SqlMoney TienTra { get => _TienTra; set => _TienTra = value; }
        public DateTime Ngaytra { get => _ngaytra; set => _ngaytra = value; }
    }
}
