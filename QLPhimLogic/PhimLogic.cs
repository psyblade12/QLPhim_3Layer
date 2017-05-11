using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimDAL;
using QLPhimBDO;

namespace QLPhimLogic
{
    public class PhimLogic
    {
        PhimDAO PhimDAO = new PhimDAO();
        public List<PhimBDO> DocTatCa()
        {
            List<PhimBDO> kq = PhimDAO.DocTatCa();
            return kq;
        }
        public PhimBDO DocTheoMa(int Ma)
        {
            PhimBDO kq = PhimDAO.DocTheoMa(Ma);
            return kq;
        }
        public List<PhimBDO> TimTheoTheLoai(string theloai)
        {
            List<PhimBDO> kq = PhimDAO.TimTheoTheLoai(theloai);
            return kq;
        }
        public List<PhimBDO> DocPhimMoi(int soluongmuonlay)
        {
            List<PhimBDO> kq = PhimDAO.DocPhimMoi(soluongmuonlay);
            return kq;
        }
        public List<string> DocTheLoai()
        {
            List<string> kq = PhimDAO.DocTheLoai();
            return kq;
        }

        public string ThemPhim(PhimBDO phim)
        {
            if (phim.Ten.Length >200)
            {
                return "Tên phim không được quá 200";
            }
            if (phim.DoDai <0 || phim.DoDai >300)
            {
                return "Độ dài này không đúng";
            }
            else
            {
                string ketqua = PhimDAO.Them(phim);
                return ketqua;
            }
        }

        public string SuaPhim(PhimBDO phim)
        {
            if (phim.Ten.Length > 200)
            {
                return "Tên phim không được quá 200";
            }
            if (phim.DoDai < 0 || phim.DoDai > 300)
            {
                return "Độ dài này không đúng";
            }
            else
            {
                string ketqua = PhimDAO.Sua(phim);
                return ketqua;
            }
        }

        public string XoaPhim(int ma)
        {
            string ketqua = PhimDAO.Xoa(ma);
            return ketqua;
        }
    }
}
