using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
using System.Data.SqlTypes;

namespace QLBH_DAL
{
    public class DAL_SanPham
    {
        KetNoi db = new KetNoi();
        public void Add(SanPham sp)
        {
            db.ExecuteNonQuery("insert into sanphamDGD values('" + sp.Maloai + "','SP' + cast (next value for  MASP_TU_TANG as varchar(7)) ,N'" + sp.Tensp + "','" + sp.Dongia1 + "', 0 ,'"+sp.Mancc.ToUpper().Trim()+"','"+sp.Tinhtrang+"','"+sp.NgayUpdate1+"','"+sp.DongiaNhap+"','"+sp.Stringdonvitinh+"')");
        }
        public void Update(SanPham sp)
        {
            db.ExecuteNonQuery("update sanphamDGD set madvt = '"+sp.Stringdonvitinh+"' ,maloai = '" + sp.Maloai + "',masp ='" + sp.Masp.Trim().ToUpper() + "',tensp = N'" + sp.Tensp + "',dongia ='" + sp.Dongia1 + "',Sluong = "+sp.SLuong+", mancc ='"+sp.Mancc.ToUpper().Trim()+"' , tinhtrang= N'"+sp.Tinhtrang+ "', DONGIANHAP= N'"+sp.DongiaNhap+"', NGAY_UPDATE= N'"+sp.NgayUpdate1+"' where masp = '" + sp.Masp + "'");
        }
        public void Update_SauKhiMua(SanPham sp)
        {
            db.ExecuteNonQuery("update sanphamDGD set   Sluong = Sluong - " + sp.SLuong + "  where masp = '" + sp.Masp.Trim().ToUpper() + "'");
        }
        public void Update_SauKhiNhapHang(SanPham sp)
        {
            db.ExecuteNonQuery("update sanphamDGD set  ngay_update = '"+DateTime.Now+"', Sluong = Sluong + " + sp.SLuong + "  where masp = '" + sp.Masp.Trim().ToUpper() + "'");
        }
        public void Update_DongiaNhap(SanPham sp)
        {
            db.ExecuteNonQuery("update sanphamDGD set  ngay_update = '" + DateTime.Now + "', dongianhap = " + sp.DongiaNhap + "  where masp = '" + sp.Masp.Trim().ToUpper() + "'");
        }
        public void Update_DongiaBan(SanPham sp)
        {
            db.ExecuteNonQuery("update sanphamDGD set  ngay_update = '" + DateTime.Now + "', dongia = " + sp.Dongia1 + "  where masp = '" + sp.Masp.Trim().ToUpper() + "'");
        }

        public void Delete(SanPham sp)
        {
            db.ExecuteNonQuery("delete chitietHD where masp = '" + sp.Masp  + "'  delete sanphamDGD where masp = '" + sp.Masp  + "'");
        }
        public DataTable LoadDuLieu()
        {
            return db.GetDataTable("select loai.tenloai, nc.tenncc, sp.masp, sp.tensp, DV.TENDVT, sp.dongia,sp.dongianhap, sp.sluong, sp.tinhtrang ,sp.ngay_update from DVT DV,ncc nc, sanphamDGD sp , loaispdgd loai where sp.maloai = loai.maloai and sp.mancc = nc.mancc AND DV.MADVT = SP.MADVT");
        }
        public DataTable LoadDuLieu_DieuKien(string DieuKien)
        {
            return db.GetDataTable("select loai.tenloai, nc.tenncc, sp.masp, sp.tensp, dv.tendvt, sp.dongia, sp.dongianhap,sp.sluong, sp.tinhtrang,sp.ngay_update from dvt dv, ncc nc, sanphamDGD sp , loaispdgd loai where sp.maloai = loai.maloai and sp.mancc = nc.mancc AND DV.MADVT = SP.MADVT and " + DieuKien);
        }
        public DataTable LoadDuLieu_CTHD(string query)
        {
            return db.GetDataTable(query);
        }
        public DataTable GetData(string query)
        {
            return db.GetDataTable(query);
        }
        public string GetDuLieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }
    }
}
