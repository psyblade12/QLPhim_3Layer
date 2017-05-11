using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimDAL;
using QLPhimBDO;

namespace QLPhimLogic
{
    public class XuatChieuLogic
    {
        XuatChieuDAO XuatChieuDAO = new XuatChieuDAO();

        public List<DateTime> DocNgay()
        {
            List<DateTime> kq = XuatChieuDAO.DocNgay();
            return kq;
        }

        public List<int> LayCaChieu()
        {
            List<int> kq = XuatChieuDAO.LayCaChieu();
            return kq;
        }
        public List<int> LayIDPhimTheoNgayVaGioBatDau(DateTime ngay, int giobatdau)
        {
            List<int> kq = XuatChieuDAO.LayIDPhimTheoNgayVaGioBatDau(ngay, giobatdau);
            return kq;
        }
    }
}
