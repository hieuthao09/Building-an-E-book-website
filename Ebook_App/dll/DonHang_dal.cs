using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class DonHang_dal
    {
        public DonHang_dal() { }
        public List<DonHang_dto> select()
        {
            List<DonHang_dto> resultList = Main._db.DONHANGs.Select(t => new DonHang_dto { MaDH = t.MADH, NgayDat =(DateTime) t.NGAYDAT, PTThanhToan = (byte)t.PTTHANHTOAN, MaKH = t.MAKH }).ToList();
            return resultList;

        }
        public int insert(DonHang_dto ha)
        {
            try
            {
                DONHANG t = new DONHANG { MADH = ha.MaDH, NGAYDAT = ha.NgayDat, PTTHANHTOAN = ha.PTThanhToan, MAKH = ha.MaKH };
                Main._db.DONHANGs.InsertOnSubmit(t);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
        public int delete(string maDH)
        {
            try
            {
                DONHANG DONHANG = Main._db.DONHANGs.SingleOrDefault(t => t.MADH == maDH);
                Main._db.DONHANGs.DeleteOnSubmit(DONHANG);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(DonHang_dto cv)
        {
            try
            {
                DONHANG DONHANG = new DONHANG();
                DONHANG entityToUpdate = Main._db.DONHANGs.SingleOrDefault(e => e.MADH == cv.MaDH);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MADH = cv.MaDH;
                    entityToUpdate.PTTHANHTOAN = cv.PTThanhToan;
                    entityToUpdate.NGAYDAT = cv.NgayDat;
                    entityToUpdate.MAKH = cv.MaKH;
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
