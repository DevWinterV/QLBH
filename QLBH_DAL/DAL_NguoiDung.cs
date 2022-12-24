using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
namespace QLBH_DAL
{
    public class DAL_NguoiDung
    {
        KetNoi db = new KetNoi();
        public void Add(NguoiDung sp)
        {
            db.ExecuteNonQuery("insert into nguoidung values('" + sp.Manv + "','" + sp.Username + "','" + sp.Pass + "','" + sp.Phanquyen + "')");
        }
        public void Update(NguoiDung sp)
        {
            db.ExecuteNonQuery("update nguoidung set  manv = '" + sp.Manv + "', username ='" + sp.Username + "', pass = '" + sp.Pass + "', phanquyen  = N'" + sp.Phanquyen + "' where username = '" + sp.Username + "'");
        }
        public void Delete(NguoiDung sp)
        {
            db.ExecuteNonQuery("delete nguoidung where username = '" + sp.Username + "'");
        }
        public DataTable LoadDuLieu(string dieukien)
        {
            return db.GetDataTable("select nv.hoten, ng.* from nguoidung ng, nhanvien nv where nv.manv = ng.manv "+dieukien);
        }
        public DataTable LoadDuLieu_Nguoidung()
        {
            return db.GetDataTable("select nv.hoten, nd.username, nd.pass, nd.phanquyen from nguoidung nd, nhanvien nv where ng.manv = nv.manv");
        }
        public string GetValue(string query)
        {
            return db.GetValue(query);
        }


        public int Check_LogIn(string user, string password)
        {
            return db.Check_LogIn("select count(username) from nguoidung where username = '"+user+"' and pass = '"+password+"'");
        }
    }
}
