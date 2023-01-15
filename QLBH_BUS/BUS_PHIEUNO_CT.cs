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
    public class BUS_PHIEUNO_CT
    {
        DAL_PHIEUNO_CT dal = new DAL_PHIEUNO_CT();
        public void Add(PHIEUNO_CT lh)
        {
            dal.Add(lh);
        }
        public DataTable LoadDuLieu(string maKH)
        {
            return dal.LoadDuLieu(maKH);
        }
    }
}
