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
    public class NguoiDungDAO
    {
        QLPhimEntities db = new QLPhimEntities();
        public List<NguoiDungBDO> LayTatCa()
        {
            List<NguoiDungBDO> kq = db.NguoiDungs.Select(x => new NguoiDungBDO { NguoiDungID = x.NguoiDungID, Ten = x.Ten, MatKhau = x.MatKhau, NhomNguoiDungID = x.NhomNguoiDungID }).ToList();
            return kq;
        }
        public string Them(NguoiDungBDO nguoidung)
        {
            try
            {
                NguoiDung tim = db.NguoiDungs.Where(x => x.Ten == nguoidung.Ten).FirstOrDefault();
                if (tim == null)
                {
                    NguoiDung nguoidungsethem = new NguoiDung() { Ten = nguoidung.Ten, MatKhau = nguoidung.MatKhau, NhomNguoiDungID = nguoidung.NhomNguoiDungID };
                    db.NguoiDungs.Add(nguoidungsethem);
                    db.SaveChanges();
                    return "Thêm thành công";
                }
                else
                {
                    return "Đã có người dùng này";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }

        public string Sua(NguoiDungBDO nguoidung)
        {
            try
            {
                NguoiDung tim = db.NguoiDungs.Where(x => x.NguoiDungID == nguoidung.NguoiDungID).FirstOrDefault();
                if (tim != null)
                {
                    tim.Ten = nguoidung.Ten;
                    tim.MatKhau = nguoidung.MatKhau;
                    tim.NhomNguoiDungID = nguoidung.NhomNguoiDungID;
                    db.SaveChanges();
                    return "Sửa thành công";
                }
                else
                {
                    return "Không có người dùng này";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }
        public string Xoa(int ma)
        {
            try
            {
                NguoiDung tim = db.NguoiDungs.Where(x => x.NguoiDungID == ma).FirstOrDefault();
                if (tim != null)
                {
                    db.NguoiDungs.Remove(tim);
                    db.SaveChanges();
                    return "Xóa thành công";
                }
                else
                {
                    return "Không có người dùng này";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }

        public bool DangNhap(string ten, string matkhau)
        {
            try
            {
                NguoiDung tim = db.NguoiDungs.Where(x => x.Ten == ten).FirstOrDefault();
                if (tim != null)
                {
                    if (tim.MatKhau == matkhau)
                        return true;
                    else
                        return false;
                }
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }
    }
}
