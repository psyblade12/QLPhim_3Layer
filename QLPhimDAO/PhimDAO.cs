using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhimBDO;
using System.Data.Entity.Core.Objects;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using QLPhimDAO;

namespace QLPhimDAL
{
    public class PhimDAO
    {
        QLPhimEntities db = new QLPhimEntities();
        public List<PhimBDO> DocTatCa()
        {
            List<PhimBDO> kq = db.Phims.Select(x => new PhimBDO { PhimID = x.PhimID, Ten = x.Ten, DaoDien = x.DaoDien, DoDai = x.DoDai, DienVien = x.DienVien, GioiThieu = x.GioiThieu, HangPhim = x.HangPhim, NuocSanXuat = x.NuocSanXuat, PDF = x.Pdf, PhienBan = x.PhienBan, Poster = x.Poster, TheLoai = x.TheLoai, Trailer = x.Trailer }).ToList();
            return kq;
        }
        public PhimBDO DocTheoMa(int Ma)
        {
            PhimBDO kq = db.Phims.Where(x => x.PhimID == Ma).Select(x => new PhimBDO { PhimID = x.PhimID, Ten = x.Ten, DaoDien = x.DaoDien, DoDai = x.DoDai, DienVien = x.DienVien, GioiThieu = x.GioiThieu, HangPhim = x.HangPhim, NuocSanXuat = x.NuocSanXuat, PDF = x.Pdf, PhienBan = x.PhienBan, Poster = x.Poster, TheLoai = x.TheLoai, Trailer = x.Trailer }).FirstOrDefault();
            return kq;
        }
        public List<PhimBDO> TimTheoTheLoai(string theloai)
        {
            List<PhimBDO> kq = db.Phims.Where(x => x.TheLoai.Contains(theloai)).Select(x => new PhimBDO { PhimID = x.PhimID, Ten = x.Ten, DaoDien = x.DaoDien, DoDai = x.DoDai, DienVien = x.DienVien, GioiThieu = x.GioiThieu, HangPhim = x.HangPhim, NuocSanXuat = x.NuocSanXuat, PDF = x.Pdf, PhienBan = x.PhienBan, Poster = x.Poster, TheLoai = x.TheLoai, Trailer = x.Trailer }).ToList();
            return kq;
        }
        public List<PhimBDO> DocPhimMoi(int soluongphimmoimuonlay)
        {
            List<PhimBDO> kq = db.Phims.OrderByDescending(x => x.PhimID).Select(x => new PhimBDO { PhimID = x.PhimID, Ten = x.Ten, DaoDien = x.DaoDien, DoDai = x.DoDai, DienVien = x.DienVien, GioiThieu = x.GioiThieu, HangPhim = x.HangPhim, NuocSanXuat = x.NuocSanXuat, PDF = x.Pdf, PhienBan = x.PhienBan, Poster = x.Poster, TheLoai = x.TheLoai, Trailer = x.Trailer }).Take(soluongphimmoimuonlay).ToList();
            return kq;
        }
        public List<string> DocTheLoai()
        {
            List<string> kq = db.Phims.Where(x => x.TheLoai != null && x.TheLoai != "").Select(x => x.TheLoai).Distinct().ToList();
            return kq;
        }

        public string Them(PhimBDO phim)
        {
            try
            {
                Phim tim = db.Phims.Where(x => x.Ten == phim.Ten).FirstOrDefault();
                if (tim == null)
                {
                    Phim phimsethem = new Phim() { Ten = phim.Ten, DaoDien = phim.DaoDien, DienVien = phim.DienVien, DoDai = phim.DoDai, GioiThieu = phim.GioiThieu, HangPhim = phim.HangPhim, NuocSanXuat = phim.NuocSanXuat, Pdf = phim.PDF, PhienBan = phim.PhienBan, Poster = phim.Poster, TheLoai = phim.TheLoai, Trailer = phim.Trailer };
                    db.Phims.Add(phimsethem);
                    db.SaveChanges();
                    return "Thêm thành công";
                }
                else
                {
                    return "Đã có phim này";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }

        public string Sua(PhimBDO phim)
        {
            try
            {
                Phim tim = db.Phims.Where(x => x.PhimID == phim.PhimID).FirstOrDefault();
                if(tim != null)
                {
                    tim.Ten = phim.Ten;
                    tim.DaoDien = phim.DaoDien;
                    tim.DienVien = phim.DienVien;
                    tim.DoDai = phim.DoDai;
                    tim.GioiThieu = phim.GioiThieu;
                    tim.HangPhim = phim.HangPhim;
                    tim.NuocSanXuat = phim.NuocSanXuat;
                    tim.Pdf = phim.PDF;
                    tim.PhienBan = phim.PhienBan;
                    tim.Poster = phim.Poster;
                    tim.TheLoai = phim.TheLoai;
                    tim.Trailer = phim.Trailer;
                    db.SaveChanges();
                    return "Sửa thành công";
                }
                else
                {
                    return "Không có phim này";
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
                Phim tim = db.Phims.Where(x => x.PhimID == ma).FirstOrDefault();
                if (tim != null)
                {
                    db.Phims.Remove(tim);
                    db.SaveChanges();
                    return "Xóa thành công";
                }
                else
                {
                    return "Không có phim này";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
       }
        //public void ChuyenDBOthanhEntity(ref PhimBDO phimbdo, ref Phim phimentity)
        //{
        //    phimentity.PhimID = phimbdo.PhimID;
        //    phimentity.Ten = phimbdo.Ten;
        //    phimentity.DaoDien = phimbdo.DaoDien;
        //    phimentity.DienVien = phimbdo.DienVien;
        //    phimentity.DoDai = phimbdo.DoDai;
        //    phimentity.GioiThieu = phimbdo.GioiThieu;
        //    phimentity.HangPhim = phimbdo.HangPhim;
        //    phimentity.NuocSanXuat = phimbdo.NuocSanXuat;
        //    phimentity.Pdf = phimbdo.PDF;
        //    phimentity.PhienBan = phimbdo.PhienBan;
        //    phimentity.Poster = phimbdo.Poster;
        //    phimentity.TheLoai = phimbdo.TheLoai;
        //    phimentity.Trailer = phimbdo.Trailer;
        //}
    }
}
