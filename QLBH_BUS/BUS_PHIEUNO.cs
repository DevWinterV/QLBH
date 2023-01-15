using QLBH_DAL;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_BUS
{
    public class BUS_PHIEUNO
    {
        DAL_PHIEUNO dal = new DAL_PHIEUNO();
        public void Add(PHIEUNO lh)
        {
            dal.Add(lh);
        }
        public void Update_SauKhiTraNo(PHIEUNO lh, SqlMoney TienTra, string ghichu)
        {
            dal.Update_SauKhiTraNo(lh, TienTra, ghichu);
        }
        public void Delete(PHIEUNO lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string makh)
        {
            return dal.LoadDuLieu(makh);
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
