using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Enity;
namespace QLBH_DAL
{
    public class DAL_HoaDon
    {
        KetNoi db = new KetNoi();
        public void Add(HoaDon sp)
        {
            db.ExecuteNonQuery("insert into HoaDon values('" + sp.NgayGD + "','HD' + cast (next value for MAHD_TU_TANG as varchar(8)),'" + sp.MaKH + "','" + sp.Manv + "','" + sp.Thanhtien1 + "','',N'ĐÃ THANH TOÁN', NULL)");
        }
        public void Update(HoaDon sp)
        {
            db.ExecuteNonQuery("update HoaDon set  trangthai =N'"+sp.Trangthai+"' where mahd = '" +sp.MaHD+"'");
        }
        public void Delete(HoaDon sp)
        {
            db.ExecuteNonQuery("delete HoaDon where mahd = '" + sp.MaHD + "'");
        }
        public DataTable LoadDuLieu()
        {
            return db.GetDataTable("select hd.mahd, hd.ngayGD,nv.hoten, kh.hoten ,kh.dchi, kh.sodt, hd.thanhtien, hd.trangthai from HOADON hd, nhanvien nv, khachhang kh where hd.makh = kh.maKH and nv.manv = hd.manv");
        }
        public string GetDulieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }
        public DataTable GetData(string query)
        {
            return db.GetDataTable(query);
        }
        public DataTable FindDataFromIDKH(string ID)
        {
            return db.GetDataTable("select hd.mahd, hd.ngayGD, nv.hoten, kh.hoten, kh.dchi, kh.sodt, hd.thanhtien, hd.trangthai  from HOADON hd, nhanvien nv, khachhang kh where hd.makh = kh.maKH and nv.manv = hd.manv  and hd.makh like  '%" + ID + "%'");
        }
        public DataTable FindDataFromIDHD(string ID)
        {
            return db.GetDataTable("select hd.mahd, hd.ngayGD, nv.hoten, kh.hoten, kh.dchi, kh.sodt, hd.thanhtien, hd.trangthai  from HOADON hd, nhanvien nv, khachhang kh where hd.makh = kh.maKH and nv.manv = hd.manv  and hd.mahd like  '%" + ID + "%'");
        }
        public DataTable FindDataFromIDNV(string ID)
        {
            return db.GetDataTable("select hd.mahd, hd.ngayGD, nv.hoten, kh.hoten, kh.dchi, kh.sodt, hd.thanhtien, hd.trangthai  from HOADON hd, nhanvien nv, khachhang kh where hd.makh = kh.maKH and nv.manv = hd.manv  and hd.manv like  '%" + ID + "%'");
        }
        public DataTable FindDataFromDate(string t1 , string t2)
        {
            return db.GetDataTable("select hd.mahd, hd.ngayGD,nv.hoten , kh.hoten ,kh.dchi, kh.sodt, hd.thanhtien, hd.trangthai  from HOADON hd, nhanvien nv, khachhang kh where hd.makh = kh.maKH and nv.manv = hd.manv  and hd.ngayGD BETWEEN '" + t1 + " 00:00:00' AND '" + t2 + " 23:59:59'");
        }
    }
}
