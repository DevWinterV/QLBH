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
    public class BUS_HoaDon
    {
        DAL_HoaDon dal = new DAL_HoaDon();
        public void Add(HoaDon lh)
        {
            dal.Add(lh);
        }
        public void Update(HoaDon lh)
        {
            dal.Update(lh);
        }
        public void Delete(HoaDon lh)
        {
//...
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu()
        {
            return dal.LoadDuLieu();
        }
        public DataTable GetData(string query)
        {
            return dal.GetData(query);
        }
        public string GetValue(string DieuKien)
        {
            return dal.GetDulieu(DieuKien);
        }
        public DataTable FindDataFromIDHD(string ID)
        {
            return dal.FindDataFromIDHD(ID);
        }
        public DataTable FindDataFromIDKH(string ID)
        {
            return dal.FindDataFromIDKH(ID);
        }
        public DataTable FindDataFromIDNV(string ID)
        {
            return dal.FindDataFromIDNV(ID);
        }
        public DataTable FindDataFromDate(string t1, string t2)
        {
            return dal.FindDataFromDate(t1,t2);
        }
    }
}
