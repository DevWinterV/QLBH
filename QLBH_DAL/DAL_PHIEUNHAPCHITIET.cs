using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_PHIEUNHAPCHITIET
    {

        KetNoi db = new KetNoi();
        public void Add(PHIEUNHAP_CHITIET sp)
        {
            db.ExecuteNonQuery("insert into Nhapkho_CT values( '"+sp.SoPN+"','" + sp.Masp + "','" + sp.Soluong + "','" + sp.Dongia1 + "')");
        }
        public void Update(PHIEUNHAP_CHITIET sp)
        {
            db.ExecuteNonQuery("update Nhapkho_CT set  sophieuN = '" + sp.SoPN + "',masp ='" + sp.Masp + "',soluongnhap = '" + sp.Soluong + "',Dgianhap = '" + sp.Dongia1 + "'  where sophieuN = '" + sp.SoPN + "'");
        }
        public void Delete(PHIEUNHAP_CHITIET sp)
        {
            db.ExecuteNonQuery("delete Nhapkho_CT where sophieuN = '" + sp.SoPN + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from Nhapkho_CT where " + DieuKien);
        }
        public string GetDulieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }
        public DataTable GetData(string query)
        {
            return db.GetDataTable(query);
        }
        public DataTable LoadData_From_IDPN(string ID)
        {
            return db.GetDataTable("select ctpn.sophieuN,loai.tenloai,ctpn.masp ,sp.tensp, ctpn.SoluongNhap, ctpn.dgianhap ,ctpn.dgianhap *ctpn.soluongNHAP as thanhtien from nhapkho_CT ctpn , LoaiSPDGD loai , sanphamDGD sp where ctpn.masp = sp.masp and loai.maloai = sp.maloai and ctpn.sophieuN = '"+ID+"'");
        }
    }
}
