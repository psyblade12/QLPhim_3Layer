using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimBDO;
using System.Data.Entity;
using QLPhimDAO;

namespace QLPhimDAL
{
    public class XuatChieuDAO
    {
        QLPhimEntities db = new QLPhimEntities();
        public List<DateTime> DocNgay()
        {
            List<DateTime> kq = db.XuatChieux.Select(x => x.Ngay).Distinct().ToList();
            return kq;
        }

        public List<int> LayCaChieu()
        {
            List<int> kq = db.XuatChieux.Select(x => x.CaChieu.GioBatDau).Distinct().ToList();
            return kq;
        }

        public List<int> LayIDPhimTheoNgayVaGioBatDau(DateTime ngay, int giobatdau)
        {
            List<int> kq = db.XuatChieux.Where(x => x.Ngay == ngay && x.CaChieu.GioBatDau == giobatdau).Select(x=>x.PhimID).Distinct().ToList();
            return kq;
        }
    }
}
