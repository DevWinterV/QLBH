using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_DAL
{
    public class CSDL_DAL
    {
        KetNoi db = new KetNoi();
        public  void SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = @"\QLBH(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = @"BACKUP DATABASE QLBH TO DISK = N'" + sDuongDan +
            sTen + "'";
            db.ExecuteNonQuery(sql);
        }
        public void PhucHoiDuLieu(string sDuongDan)
        {
            string sql = @"USE master ALTER DATABASE QLBH SET SINGLE_USER WITH ROLLBACK IMMEDIATE  RESTORE DATABASE QLBH FROM disk = N'" + sDuongDan + "' WITH REPLACE ";
            db.ExecuteNonQuery(sql);
        }
    }
}
