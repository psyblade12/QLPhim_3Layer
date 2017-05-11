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
    public class NhomNguoiDungDAO
    {
        QLPhimEntities db = new QLPhimEntities();
        public List<NhomNguoiDungDBO> LayTatCa()
        {
            List<NhomNguoiDungDBO> kq = db.NhomNguoiDungs.Select(x => new NhomNguoiDungDBO { NhomNguoiDungID = x.NhomNguoiDungID, MaSo = x.MaSo, Ten = x.Ten }).ToList();
            return kq;
        }
    }
}
