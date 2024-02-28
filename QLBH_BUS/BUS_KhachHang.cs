using QLBH_DAL;
using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
using QLBH_DAL;
namespace QLBH_BUS
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal = new DAL_KhachHang();
        public void Add(KhachHang lh)
        {
            dal.Add(lh);
        }
        public void Update(KhachHang lh)
        {
            dal.Update(lh);
        }
        public void Delete(KhachHang lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return dal.LoadDuLieu(DieuKien);
        }
        public DataTable LoadDulieuNhomKh(string DieuKien)
        {
            return dal.LoadDulieuNhomKh(DieuKien);
        }


        
        public DataTable Load_DSKHNO()
        {
            return dal.Load_DSKHNO();
        }

        public string GetValue(string DieuKien)
        {
            return dal.GetValue(DieuKien);
        }
    }
}
