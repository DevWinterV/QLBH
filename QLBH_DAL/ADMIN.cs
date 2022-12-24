using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class ADMIN
    {
        KetNoi db = new KetNoi();
        public void Add(Admin sp)
        {
            db.ExecuteNonQuery("insert into ADMINN values('" + sp.User + "','" + sp.Password + "','ADMIN')");
        }
        public void Update(Admin sp)
        {
            db.ExecuteNonQuery("update ADMINN set username ='" + sp.User + "',pass = '" + sp.Password + "', phanquyen  ='ADMIN' where username = '" + sp.User + "'");
        }
        public void Delete(Admin sp)
        {
            db.ExecuteNonQuery("delete ADMINN where username = '" + sp.User + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from ADMINN " + DieuKien);
        }
        public string GetValue(string query)
        {
            return db.GetValue(query);
        }
        public int Check_LogIn(string ussername, string pass)
        {
            return db.Check_LogIn("select count(username) from adminn where username = '" + ussername + "' and pass = '" + pass + "'");
        }
    }
}
