using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimDAL;
using QLPhimBDO;

namespace QLPhimLogic
{
    public class NguoiDungLogic
    {
        NguoiDungDAO NguoiDungDAO = new NguoiDungDAO();
        public List<NguoiDungBDO> DocTatCa()
        {
            List<NguoiDungBDO> kq = NguoiDungDAO.LayTatCa();
            return kq;
        }

        public string ThemNguoiDung(NguoiDungBDO nguoidung)
        {
            string ketqua = NguoiDungDAO.Them(nguoidung);
            return ketqua;
        }

        public string SuaNguoiDung(NguoiDungBDO nguoidung)
        {
            string ketqua = NguoiDungDAO.Sua(nguoidung);
            return ketqua;
        }

        public string XoaNguoiDung(int ma)
        {
            string ketqua = NguoiDungDAO.Xoa(ma);
            return ketqua;
        }

        public bool DangNhap(string ten, string ma)
        {
            bool ketqua = NguoiDungDAO.DangNhap(ten, ma);
            return ketqua;
        }
    }
}
