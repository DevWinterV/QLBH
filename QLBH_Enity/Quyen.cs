using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_Enity
{
    public class Quyen
    {
        private int _id;
        private string _tenQuyen;

        public int Id { get => _id; set => _id = value; }
        public string TenQuyen { get => _tenQuyen; set => _tenQuyen = value; }
    }
}
