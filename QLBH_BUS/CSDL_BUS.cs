using QLBH_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_BUS
{
    public class CSDL_BUS
    {
        CSDL_DAL CSDL_DAL = new CSDL_DAL(); 
        public void SaoLuu(string sDuongDan)
        {
            CSDL_DAL.SaoLuuDuLieu(sDuongDan);
        }
        public void PhucHoi(string sDuongDan)
        {
            CSDL_DAL.PhucHoiDuLieu(sDuongDan);
        }
    }
}
