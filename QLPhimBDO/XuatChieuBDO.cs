using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhimBDO
{
    public class XuatChieuBDO
    {
        public int XuatChieuID { get; set; }
        public System.DateTime Ngay { get; set; }
        public int LichChieuID { get; set; }
        public int CaChieuID { get; set; }
        public int PhongID { get; set; }
        public int PhimID { get; set; }
    }
}
