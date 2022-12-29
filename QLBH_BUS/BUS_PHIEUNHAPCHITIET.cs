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
    public class BUS_PHIEUNHAPCHITIET
    {
        DAL_PHIEUNHAPCHITIET dal = new DAL_PHIEUNHAPCHITIET();
        public void Add(PHIEUNHAP_CHITIET lh)
        {
            dal.Add(lh);
        }
        public void Update(PHIEUNHAP_CHITIET lh)
        {
            dal.Update(lh);
        }
        public void Delete(PHIEUNHAP_CHITIET lh)
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
        public DataTable LoadData_From_IDPN(string ID)
        {
            return dal.LoadData_From_IDPN(ID);
        }

    }
}
