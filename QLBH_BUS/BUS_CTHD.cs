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
    public class BUS_CTHD
    {
        DAL_CTHD dal = new DAL_CTHD();
        public void Add(CTHD lh)
        {
            dal.Add(lh);
        }
        public void Update(CTHD lh)
        {
            dal.Update(lh);
        }
        public void Delete(CTHD lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu()
        {
            return dal.LoadDuLieu();
        }
        public DataTable LoadDataFromIDSanPham(string ID)
        {
            return dal.LoadData_From_IDSanPham(ID);
        }

    }
}
