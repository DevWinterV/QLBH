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
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dal = new DAL_NguoiDung();
        public void Add(NguoiDung lh)
        {
            dal.Add(lh);
        }
        public void Update(NguoiDung lh)
        {
            dal.Update(lh);
        }
        public void Delete(NguoiDung lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }
        public string GetValue(string query)
        {
            return dal.GetValue(query);
        }
        public int Check_LogIn(string userName, string pass)
        {
            return dal.Check_LogIn(userName,pass);
        }
        public DataTable LoadDuLieu_NguoiDung()
        {
            return dal.LoadDuLieu_Nguoidung();
        }

    }
}
