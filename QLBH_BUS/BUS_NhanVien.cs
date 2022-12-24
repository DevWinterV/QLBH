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
    public class BUS_NhanVien
    {
        DAL_NhanVien dal = new DAL_NhanVien();
        public void Add(NhanVien lh)
        {
            dal.Add(lh);
        }
        public void Update(NhanVien lh)
        {
            dal.Update(lh);
        }
        public void Delete(NhanVien lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }

        public string Getvalue(string query)
        {
            return dal.GetValue(query);
        }
    }
}
