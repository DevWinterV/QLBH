using QLBH_Enity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_Enity;
namespace QLBH_DAL
{
    public class DAL_NhanVien
    {
        KetNoi db = new KetNoi();
        public void Add(NhanVien sp)
        {
            db.ExecuteNonQuery("insert into nhanvien values('NV' + cast (next value for  MANV_TU_TANG as varchar(5)),N'" + sp.Hoten + "','" + sp.Sodt + "','" + sp.Ngaysinh + "','" + sp.Diachi + "','" + sp.Phai+ "', N'"+sp.Tinhtrang+"')");
        }
        public void Update(NhanVien sp)
        {
            db.ExecuteNonQuery("update nhanvien set  manv = '" + sp.Manv + "',hoten =N'" + sp.Hoten + "',Sodt = '" + sp.Sodt + "', dchi  =N'"+sp.Diachi+ "',gioitinh = N'"+sp.Phai+"',TINHTRANG =N'"+sp.Tinhtrang+"' where manv = '" + sp.Manv + "'");
        }
        public void Delete(NhanVien sp)
        {
            db.ExecuteNonQuery(@"delete ct
from nhanvien kh, HOADON hd, chitietHD ct
where kh.manv = '"+sp.Manv+"' and ct.maHD = hd.maHD  delete HOADON where manv = '"+sp.Manv+"' delete nhanvien where manv = '"+sp.Manv+"'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from nhanvien " + DieuKien);
        }
        public string GetValue(string query )
        {
            return db.GetValue(query);
        }
    }
}
