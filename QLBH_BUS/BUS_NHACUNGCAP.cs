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
    public class BUS_NHACUNGCAP
    {
        DAL_NHACUNGCAP dal = new DAL_NHACUNGCAP();
        public void Add(NHACUNGCAP lh)
        {
            dal.Add(lh);
        }
        public void Update(NHACUNGCAP lh)
        {
            dal.Update(lh);
        }
        public void Delete(NHACUNGCAP lh)
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
    }
}
