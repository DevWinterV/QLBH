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
            db.ExecuteNonQuery("insert into Nhapkho values('PN' + cast (next value for MAPN_TU_TANG as varchar(6)),'" + sp.NgayNhap+ "','" + sp.Manv1 + "','" + sp.TongCong + "', N'" + sp.Ghichu + "')");
        }
        public void Update(PHIEUNHAP sp)
        {
            db.ExecuteNonQuery("update Nhapkho set  ngaynhap = '" + sp.NgayNhap + "',sophieuN ='" + sp.SoPN1 + "',manv = '" + sp.Manv1 + "',tongcong = '" + sp.TongCong + "', ghichu = N'"+sp.Ghichu+"'  where sophieuN = '" + sp.SoPN1 + "'");
        }
        public void Delete(PHIEUNHAP sp)
        {
            db.ExecuteNonQuery("delete Nhapkho where sophieuN = '" + sp.SoPN1 + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from Nhapkho where "+DieuKien);
        }
        public string GetDulieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }
        public DataTable GetData(string query)
        {
            return db.GetDataTable(query);
        }
    }
}
