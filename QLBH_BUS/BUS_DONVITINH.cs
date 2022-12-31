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
    public class BUS_DONVITINH
    {
        DAL_DONVITINH dal = new DAL_DONVITINH();
        public void Add(DONVITINH lh)
        {
            dal.Add(lh);
        }
        public void Update(DONVITINH lh)
        {
            dal.Update(lh);
        }
        public void Delete(DONVITINH lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }
        public DataTable loadDuLieu_TimKIem(string query)
        {
            return dal.LoadDuLieuTimKiem(query);
        }
        public string GetValue(string ID)
        {
            return dal.GetDuLieu(ID);
        }
    }
}
