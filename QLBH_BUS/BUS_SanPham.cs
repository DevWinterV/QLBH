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
        public void Update_DonGiaNhap(SanPham lh)
        {
            dal.Update_DongiaNhap(lh);
        }
        public void Update_DonGiaBan(SanPham lh)
        {
            dal.Update_DongiaBan(lh);
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
        public DataTable GetData_SP_LSP()
        {
            return dal.GetData_SP_LSP();
        }
        public DataTable GetData_SP_LSP(string id)
        {
            return dal.GetData_SP_LSP( id);
        }

        public DataTable GetData_SP_NCC(string id)
        {
            return dal.GetData_SP_NCC(id);
        }
        public DataTable GetData_SP_DVT(string id)
        {
            return dal.GetData_SP_DVT(id);
        }
    }
}
