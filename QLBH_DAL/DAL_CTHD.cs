using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
namespace QLBH_DAL
{
    public  class DAL_CTHD
    {
        KetNoi db = new KetNoi();
        public void Add(CTHD sp)
        {
            db.ExecuteNonQuery("insert into chitietHD values('"+sp.MaHD+"','" + sp.Masp + "','" + sp.Soluuong + "')");
        }
        public void Update(CTHD sp)
        {
            db.ExecuteNonQuery("update chitietHD set  mahd = '" + sp.MaHD + "',masp ='" + sp.Masp + "',soluong = '" + sp.Soluuong+ "' where mahd = '" + sp.MaHD + "' and masp = '"+sp.Masp+"'");
        }
        public void Delete(CTHD sp)
        {
            db.ExecuteNonQuery("delete chitietHD where mahd = '" + sp.MaHD + "' and masp = '"+sp.Masp+"'");
        }
        public DataTable LoadDuLieu()
        {
            return db.GetDataTable("select cthd.maHD,loai.tenloai,cthd.masp ,sp.tensp, cthd.soluong, sp.dongia , sp.dongia *cthd.soluong as thanhtien from chitietHD cthd , LoaiSPDGD loai , sanphamDGD sp where cthd.masp = sp.masp and loai.maloai = sp.maloai");
        }
        public int KiemTra(string mahd, string masp)
        {
            return int.Parse(db.GetValue("select count(*)  from chitietHD where mahd = '" + mahd + "' and masp = '" + masp + "'"));
        }
        public DataTable LoadData_From_IDSanPham(string ID)
        {
            return db.GetDataTable("select cthd.maHD,loai.tenloai,cthd.masp ,sp.tensp, cthd.soluong, sp.dongia , sp.dongia *cthd.soluong as thanhtien from chitietHD cthd , LoaiSPDGD loai , sanphamDGD sp where cthd.masp = sp.masp and loai.maloai = sp.maloai and cthd.maHD = '"+ID+"'");
        }

    }
}
