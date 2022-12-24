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
    public class BUS_PHIEUNHAP
    {
        DAL_PHIEUNHAP dal = new DAL_PHIEUNHAP();
        public void Add(PHIEUNHAP lh)
        {
            dal.Add(lh);
        }
        public void Update(PHIEUNHAP lh)
        {
            dal.Update(lh);
        }
        public void Delete(PHIEUNHAP lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }
        public DataTable GetData(string query)
        {
            return dal.GetData(query);
        }
        public string GetValue(string DieuKien)
        {
            return dal.GetDulieu(DieuKien);
        }
    }
}
