using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_NHACUNGCAP
    {
        KetNoi db = new KetNoi();
        public void Add(NHACUNGCAP sp)
        {
            db.ExecuteNonQuery("insert into ncc values('CC' + cast (next value for  MANCC_TU_TANG as varchar(5)), N'" + sp.Tenncc + "','" + sp.Sdt + "',N'" + sp.Diachi + "','"+sp.Tinhtrang+"')");
        }
        public void Update(NHACUNGCAP sp)
        {
            db.ExecuteNonQuery("update ncc set  mancc = '" + sp.Mancc + "',tenncc =N'" + sp.Tenncc + "',sdt = '" + sp.Sdt + "',diachi = N'" + sp.Diachi + "', tinhtrang ='"+sp.Tinhtrang+"'  where mancc = '" + sp.Mancc + "'");
        }
        public void Delete(NHACUNGCAP sp)
        {
            db.ExecuteNonQuery("delete ncc where mancc = '" + sp.Mancc + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from ncc "+DieuKien);
        }
        public DataTable LoadDuLieuTimKiem(string query)
        {
            return db.GetDataTable(query);
        }

        public string GetDuLieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }

    }
}
