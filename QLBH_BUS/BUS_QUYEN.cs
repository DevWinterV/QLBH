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
    public class BUS_QUYEN
    {

        DAL_QUYEN admin = new DAL_QUYEN();
        public void Add(Quyen sp)
        {
            admin.Add(sp);
        }
        public void Update(Quyen sp)
        {
            admin.Update(sp);
        }
        public void Delete(Quyen sp)
        {
            admin.Delete(sp);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return admin.LoadDuLieu(DieuKien);
        }

        public string GetValue(string query)
        {
            return admin.GetDulieu(query);
        }
    }
}
