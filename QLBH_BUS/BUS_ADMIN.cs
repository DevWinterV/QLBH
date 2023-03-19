using QLBH_DAL;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_BUS
{
    public class BUS_ADMIN
    {

        ADMIN admin = new ADMIN();
        public void Add(Admin sp)
        {
             admin.Add(sp);
        }
        public void Update(Admin sp)
        {
            admin.Update(sp);
        }
        public void Delete(Admin sp)
        {
            admin.Delete(sp);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return admin.LoadDuLieu(DieuKien);
        }
        public int Check_logIn(string user, string pass)
        {
            return admin.Check_LogIn(user, pass);
        }
        public string GetValue(string query)
        {
            return admin.GetValue(query);    
        }
    }
}
