using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_Enity;
namespace QLBH_DAL
{
    public class DAL_LoaiHang
    {
        KetNoi db = new KetNoi();
        public void Add(LoaiHang lh)
        {
            db.ExecuteNonQuery("insert into LoaiSPDGD values('LSP' + cast (next value for  MALSP_TU_TANG as varchar(8)),N'" + lh.Tenhang+"',N'"+lh.Tinhtrang+"')");
        }
        public void Update(LoaiHang lh)
        {
            db.ExecuteNonQuery("update LoaiSPDGD set maloai = '" + lh.Maloai + "',tenloai = N'" + lh.Tenhang + "',TINHTRANG = N'" + lh.Tinhtrang + "' where maloai = '" + lh.Maloai + "'");
        }
        public void Delete(LoaiHang lh)
        {
            db.ExecuteNonQuery(" delete sanphamDGD where maloai =  '" + lh.Maloai + "' delete LoaiSPDGD where maloai = '" + lh.Maloai + "'");
        }
        public DataTable LoadDuLieu(string DieuKien)
        {
            return db.GetDataTable("select * from LoaiSPDGD "+ DieuKien);           
        }

        public string GetDulieu(string DieuKien)
        {
            return (string)db.GetValue(DieuKien);
        }
    }
}
