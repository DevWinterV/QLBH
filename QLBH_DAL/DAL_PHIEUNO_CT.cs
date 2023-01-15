using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_PHIEUNO_CT
    {
        KetNoi db = new KetNoi();
        public void Add(PHIEUNO_CT sp)
        {
            db.ExecuteNonQuery("insert into PHIEUNO_CT values('"+sp.MaPN+"',"+sp.TienTra+", '"+sp.Ngaytra+"')");
        }
        public void Update_SauKhiTraNo(PHIEUNO_CT sp, SqlMoney TienTra)
        {
            db.ExecuteNonQuery("update PHIEUNO set TIENNO = TIENNO - " + TienTra + " where maPN = '" + sp.MaPN + "'");
        }
        public void Delete(PHIEUNO_CT sp)
        {
            db.ExecuteNonQuery("delete phieuno where mapn = '" + sp.MaPN + "'");
        }
        public DataTable LoadDuLieu(string maKH)
        {
            return db.GetDataTable(" select pn.maPN, pn.maHD , kh.hoten, pnct.ngayTRA, pnct.TIENTRA from PHIEUNO pn, PHIEUNO_CT pnct, KHACHHANG kh, HOADON hd  where pn.maHD = hd.maHD and hd.maKH = '"+maKH+"' and kh.makh = '"+maKH+"'and pn.maPN = pnct.maPN");
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
