using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_PHIEUNHAP
    {

        KetNoi db = new KetNoi();
        public void Add(PHIEUNHAP sp)
        {
            db.ExecuteNonQuery("insert into Nhapkho values('PN' + cast (next value for MAPN_TU_TANG as varchar(6)), '"+sp.TenNCC+"','" + sp.NgayNhap+ "','" + sp.Manv1 + "','" + sp.TongCong + "', N'" + sp.Ghichu + "')");
        }
        public void Update(PHIEUNHAP sp)
        {
            db.ExecuteNonQuery("update Nhapkho set  ngaynhap = '" + sp.NgayNhap + "',sophieuN ='" + sp.SoPN1 + "',manv = '" + sp.Manv1 + "',tongcong = '" + sp.TongCong + "', ghichu = N'"+sp.Ghichu+ "' , mancc = '"+sp.TenNCC+"' where sophieuN = '" + sp.SoPN1 + "'");
        }
        public void Delete(PHIEUNHAP sp)
        {
            db.ExecuteNonQuery("delete Nhapkho where sophieuN = '" + sp.SoPN1 + "'");
        }
        public DataTable LoadDuLieu()
        {
            return db.GetDataTable("select nk.sophieuN, nk.ngaynhap, nc.tenncc ,nv.hoten, nk.tongcong ,nk.ghichu from nhapkho nk, nhanvien nv, NCC nc where nv.manv = nk.manv and nc.mancc = nk.mancc\r\n");
        }
        public string GetDulieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }
        public DataTable GetData(string query)
        {
            return db.GetDataTable(query);
        }
        public DataTable FindDataFromDate(string t1, string t2)
        {
            return db.GetDataTable("select nk.sophieuN, nk.ngaynhap, nc.tenncc, nv.hoten, nk.tongcong, nk.ghichu from nhapkho nk, nhanvien nv, NCC nc where nv.manv = nk.manv and nc.mancc = nk.mancc and  nk.ngaynhap BETWEEN '"+t1+" 00:00:00' AND '"+t2+" 23:59:59'");
        }
        public DataTable FindDataFromIDPN(string ID)
        {
            return db.GetDataTable("select nk.sophieuN, nk.ngaynhap, nc.tenncc, nv.hoten, nk.tongcong, nk.ghichu from nhapkho nk, nhanvien nv, NCC nc where nv.manv = nk.manv and nc.mancc = nk.mancc and nk.sophieuN like '%"+ID.ToUpper()+"%'");
        }
        public DataTable FindDataFromIDNV(string ID)
        {
            return db.GetDataTable("select nk.sophieuN, nk.ngaynhap, nc.tenncc, nv.hoten, nk.tongcong, nk.ghichu from nhapkho nk, nhanvien nv, NCC nc where nv.manv like '%"+ID.ToUpper()+"%' and nc.mancc = nk.mancc ");
        }
        public DataTable FindDataFromIDNCC(string ID)
        {
            return db.GetDataTable("select nk.sophieuN, nk.ngaynhap, nc.tenncc, nv.hoten, nk.tongcong, nk.ghichu from nhapkho nk, nhanvien nv, NCC nc where nv.manv = nk.manv and nk.mancc like '%"+ID.ToUpper() +"%'");
        }
    }
}
