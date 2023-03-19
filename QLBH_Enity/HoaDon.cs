using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class HoaDon
    {
        private DateTime _ngayGD;
        private string _maHD;
        private string _maKH;
        private string _manv;
        private SqlMoney _thanhtien;
        private string _trangthai;

        public HoaDon(DateTime ngayGD, string maHD, string maKH, string manv, SqlMoney thanhtien)
        {
            _ngayGD = ngayGD;
            _maHD = maHD;
            _maKH = maKH;
            _manv = manv;
            Thanhtien1 = thanhtien;
        }
        public HoaDon() { }
        public DateTime NgayGD { get => _ngayGD; set => _ngayGD = value; }
        public string MaHD { get => _maHD; set => _maHD = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public string Manv { get => _manv; set => _manv = value; }
        public SqlMoney Thanhtien1 { get => _thanhtien; set => _thanhtien = value; }
        public string Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
