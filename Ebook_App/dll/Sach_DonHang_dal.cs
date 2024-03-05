using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dll
{
    public class Sach_DonHang_dal
    {
        public Sach_DonHang_dal()
        {

        }
        public List<Sach_DonHang_dto> select()
        {
            List<Sach_DonHang_dto> resultList = Main._db.SACH_DONHANGs.Select(
                t => new Sach_DonHang_dto { 
                    MaDH = t.MADH,
                    MaSach = t.MASACH,
                    SoLuong = (byte)t.SOLUONG,
                    TongTien = (decimal)t.SOLUONG * (Decimal)t.SACH.GIABAN,
                    TenKH = t.DONHANG.KHACHHANG.TENKH,
                    MaKH = t.DONHANG.MAKH,
                    TenSach = t.SACH.TENSACH,
                    NgayDat = (DateTime)t.DONHANG.NGAYDAT,
                    Thang = t.DONHANG.NGAYDAT.Value.Month,
                    Nam = t.DONHANG.NGAYDAT.Value.Year,
                }).ToList();
            return resultList;

        }
        public List<Sach_DonHang_dto> thongKe()
        {

            var list = (from dh in Main._db.DONHANGs
                        join sdh in Main._db.SACH_DONHANGs on dh.MADH equals sdh.MADH
                        join s in Main._db.SACHes on sdh.MASACH equals s.MASACH
                        group new { dh, sdh, s } by new { Month = dh.NGAYDAT.Value.Month, Year = dh.NGAYDAT.Value.Year } into g
                        select new Sach_DonHang_dto
                        {
                            TongTien = (decimal) g.Sum(x => x.s.GIABAN * x.sdh.SOLUONG),
                            SoLuong = (byte) g.Count(),
                            Thang = g.Key.Month,
                            Nam = g.Key.Year
                        }).ToList();
            return list.ToList<Sach_DonHang_dto>();

        }
        public int insert(Sach_DonHang_dto ha)
        {
            try
            {
                SACH_DONHANG t = new SACH_DONHANG { MADH = ha.MaDH, MASACH = ha.MaSach, SOLUONG = ha.SoLuong };
                Main._db.SACH_DONHANGs.InsertOnSubmit(t);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
        public int delete(string madh)
        {
            try
            {
                SACH_DONHANG SACH_DONHANG = Main._db.SACH_DONHANGs.SingleOrDefault(t => t.MADH == madh);
                Main._db.SACH_DONHANGs.DeleteOnSubmit(SACH_DONHANG);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(Sach_DonHang_dto cv)
        {
            try
            {
                SACH_DONHANG SACH_DONHANG = new SACH_DONHANG();
                SACH_DONHANG entityToUpdate = Main._db.SACH_DONHANGs.SingleOrDefault(e => e.MADH == cv.MaDH && e.MASACH.Equals(cv.MaSach));
                if (entityToUpdate != null)
                {
                    entityToUpdate.MADH = cv.MaDH;
                    entityToUpdate.SOLUONG = cv.SoLuong;
                    entityToUpdate.MASACH = cv.MaSach;
                    Main._db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
