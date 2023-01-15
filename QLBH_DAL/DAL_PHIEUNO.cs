using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_PHIEUNO
    {
        KetNoi db = new KetNoi();
        public void Add(PHIEUNO sp)
        {
            db.ExecuteNonQuery("insert into PHIEUNO values('" + sp.Ngayno + "','PNO' + cast (next value for  MAPHIEUNO_TU_TANG as varchar(8)), '" + sp.MaHD + "','" + sp.Manv + "',N'" + sp.Ghichu + "'," + sp.TienNo1 + ")");
        }
        public void Update_SauKhiTraNo(PHIEUNO sp, SqlMoney TienTra, string ghichu)
        {
            db.ExecuteNonQuery("update PHIEUNO set TIENNO = TIENNO - " + TienTra + ", ghichu=N'"+ghichu+"' where maPN = '" + sp.MaPN + "'");
        }
        public void Delete(PHIEUNO sp)
        {
            db.ExecuteNonQuery("delete phieuno where mapn = '" + sp.MaPN + "'");
        }
        public DataTable LoadDuLieu(string maKH)
        {
            return db.GetDataTable("select PN.maPN, PN.maHD, HD.THANHTIEN, KH.hoten, PN.ngayNO, PN.TIENNO, PN.GHICHU from PHIEUNO PN, KHACHHANG KH, HOADON HD WHERE  PN.maHD = HD.maHD and hd.maKH = '"+maKH+"' and kh.maKH = '"+maKH+"'");
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
