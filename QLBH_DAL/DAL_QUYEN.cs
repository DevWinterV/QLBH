using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_QUYEN
    {
        KetNoi db = new KetNoi();
        public void Add(Quyen lh)
        {
            db.ExecuteNonQuery("insert into QUYEN VALUES(N'"+lh.TenQuyen+"')");
        }
        public void Update(Quyen lh)
        {
            db.ExecuteNonQuery("update quyen set tenquyen = N'" + lh.TenQuyen + "' where ma_quyen = '" + lh.Id + "'");
        }
        public void Delete(Quyen lh)
        {
            db.ExecuteNonQuery("delete nguoidung where ma_quyen = '" + lh.Id + "' delete queyn where ma_quyen =  '" + lh.Id + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from quyen " + DieuKien);
        }

        public string GetDulieu(string TruyVan)
        {
            return (string)db.GetValue(TruyVan);
        }
    }
}
