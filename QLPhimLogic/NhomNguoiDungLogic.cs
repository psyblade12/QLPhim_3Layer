using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimDAL;
using QLPhimBDO;

namespace QLPhimLogic
{
    public class NhomNguoiDungLogic
    {
        NhomNguoiDungDAO NhomNguoiDungDAO = new NhomNguoiDungDAO();
        public List<NhomNguoiDungDBO> LayNhomNguoiDung()
        {
            List<NhomNguoiDungDBO> kq = NhomNguoiDungDAO.LayTatCa();
            return kq;
        }
    }
}
