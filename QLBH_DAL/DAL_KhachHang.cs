using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
namespace QLBH_DAL
{
    public class DAL_KhachHang
    {
        KetNoi db = new KetNoi();
        public void Add(KhachHang kh)
        {
            db.ExecuteNonQuery("insert into khachhang values('KH' + cast (next value for MAKH_TU_TANG as varchar(5)), N'" + kh.Hoten + "', N'" + kh.Dchi+ "', '" + kh.Sodt + "', " + kh.Latidue +", "+ kh.Longitude +", "+ kh.ManhomKh + ", N'" + kh.Tenbietdanh +"')");
        }
        public void Update(KhachHang kh)
        {
            db.ExecuteNonQuery("update khachhang set " +
               // "makh = '" + kh.MaKH + "'," +
                "hoten =N'" + kh.Hoten + "'," +
                "dchi = N'" + kh.Dchi + "'," +
                "sodt = '" + kh.Sodt+ "'," +
                "latitude = " + kh.Latidue + "," +
                "longitude = " + kh.Longitude + "," +
                "ma_nhomkh = " + kh.ManhomKh + "," +
                "tenbietdanh = N'" + kh.Tenbietdanh + "'" +
                "where makh = '" + kh.MaKH+"'");
        }
        public void Delete(KhachHang kh)
        {
            db.ExecuteNonQuery(@"delete ct
                                from KHACHHANG kh, HOADON hd, chitietHD ct
                                where kh.maKH = '"+kh.MaKH+"' and ct.maHD = hd.maHD delete HOADON where maKH = '" + kh.MaKH+"' delete KHACHHANG where makh = '" + kh.MaKH+"'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select KHACHHANG.maKH, KHACHHANG.hoten, KHACHHANG.dchi, KHACHHANG.sodt, KHACHHANG.latitude, KHACHHANG.longitude, NHOMKHACHHANG.TEN_NHOMKH, KHACHHANG.tenbietdanh from KHACHHANG, NHOMKHACHHANG where KHACHHANG.MA_NHOMKH = NHOMKHACHHANG.MA_NHOMKH " + DieuKien);
        }
        public DataTable LoadDulieuNhomKh(string DieuKien)
        {
            return db.GetDataTable("select * from nhomkhachhang " + DieuKien);
        }
        
        public DataTable Load_DSKHNO()
        {
            return db.GetDataTable("select * from KHACHHANG kh where maKH in (select kh.makh from PHIEUNO pn, HOADON hd, KHACHHANG kh where pn.maHD = hd.maHD and hd.maKH = kh.makh )");
        }

        public string GetValue(string DieuKien)
        {
            return db.GetValue(DieuKien);
        }
    }
}
