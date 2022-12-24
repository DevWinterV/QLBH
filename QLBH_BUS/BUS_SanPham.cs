using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
using QLBH_DAL;
using System.Data;

namespace QLBH_BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dal = new DAL_SanPham();
        public void Add(SanPham lh)
        {
            dal.Add(lh);
        }
        public void Update(SanPham lh)
        {
            dal.Update(lh);
        }
        public void Update_SaukhiMua(SanPham lh)
        {
            dal.Update_SauKhiMua(lh);
        }
        public void Update_SaukhiNhapKho(SanPham lh)
        {
            dal.Update_SauKhiNhapHang(lh);
        }

        public void Delete(SanPham lh)
        {
            dal.Delete(lh);
        }
        public DataTable LoadDuLieu()
        {
            return dal.LoadDuLieu();
        }
        public DataTable LoadDuLieu_DieuKien(string DieuKien)
        {
            return dal.LoadDuLieu_DieuKien(DieuKien);
        }
        public DataTable LoadDuLieu_CTHD(string query)
        {
            return dal.LoadDuLieu_CTHD(query);
        }
        public DataTable GetData(string query)
        {
            return dal.GetData(query);
        }
        public string GetDulieu(string DieuKien)
        {
            return (string)dal.GetDuLieu(DieuKien);
        }
    }
}
