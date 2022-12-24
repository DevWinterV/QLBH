using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_DAL;
using QLBH_Enity;
namespace QLBH_BUS
{
    public class BUS_LoaiHang
    {
        DAL_LoaiHang dal = new DAL_LoaiHang();
        public void Add(LoaiHang lh)
        {
            dal.Add(lh);
        }
        public void Update(LoaiHang lh)
        {
            dal.Update(lh);
        }
        public void Delete(LoaiHang lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }


        public string GetValue(string DieuKien)
        {
            return dal.GetDulieu(DieuKien);
        }

    }
}
