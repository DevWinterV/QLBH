using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_DONVITINH
    {
        KetNoi db = new KetNoi();
        public void Add(DONVITINH sp)
        {
            db.ExecuteNonQuery("insert into dvt values('DV' + cast (next value for  MADV_TU_TANG as varchar(5)) , N'" + sp.Tendvt + "')");
        }
        public void Update(DONVITINH sp)
        {
            db.ExecuteNonQuery("update dvt set  madvt = '" + sp.Madvt + "',tendvt =N'" + sp.Tendvt + "'  where madvt = '" + sp.Madvt + "'");
        }
        public void Delete(DONVITINH sp)
        {
            db.ExecuteNonQuery("delete dvt where madvt = '" + sp.Madvt + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from dvt " + DieuKien);
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
