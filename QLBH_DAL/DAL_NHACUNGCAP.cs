using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class DAL_NHACUNGCAP
    {
        KetNoi db = new KetNoi();
        public void Add(NHACUNGCAP sp)
        {
            db.ExecuteNonQuery("insert into ncc values('CC' + cast (next value for  MANCC_TU_TANG as varchar(5)), N'" + sp.Tenncc + "', N'" + sp.Tenbietdanh + "','" + sp.Sdt + "',N'" + sp.Diachi + "', N'" + sp.Email + "', N'" + sp.Masothue + "', " + sp.Latitude + ", " + sp.Longitude + ", N'" + sp.Hinhanh + "',  N'" + sp.Ghichu + "',   " + sp.Id_tinh + ",  " + sp.Id_huyen + ",  " + sp.Id_xa + ",'"+sp.Tinhtrang+"')");
        }


        public void Update(NHACUNGCAP sp)
        {
            string query = "UPDATE NCC SET " +
                           "tenncc = N'" + sp.Tenncc + "'," +
                           "tenbietdanh = N'" + sp.Tenbietdanh + "'," +
                           "sdt = '" + sp.Sdt + "'," +
                           "diachi = N'" + sp.Diachi + "'," +
                           "tinhtrang = '" + sp.Tinhtrang + "'," +
                           "email = N'" + sp.Email + "'," +
                           "masothue = N'" + sp.Masothue + "'," +
                           "latitude = " + sp.Latitude.ToString().Replace(',', '.') + "," +
                           "longitude = " + sp.Longitude.ToString().Replace(',', '.') + "," +
                           "hinhanh = N'" + sp.Hinhanh + "'," +
                           "ghichu = N'" + sp.Ghichu + "'," +
                           "id_tinh = " + sp.Id_tinh + "," +
                           "id_huyen = " + sp.Id_huyen + "," +
                           "id_xa = " + sp.Id_xa +
                           " WHERE mancc = '" + sp.Mancc + "'";

            db.ExecuteNonQuery(query);
        }

        public void Delete(NHACUNGCAP sp)
        {
            db.ExecuteNonQuery("delete ncc where mancc = '" + sp.Mancc + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from ncc "+DieuKien);
        }


        public DataTable LoadDuLieuTimKiem(string query)
        {
            return db.GetDataTable(query);
        }

        public string GetDuLieu(string dieukien)
        {
            return (string)db.GetValue(dieukien);
        }

    }
}
