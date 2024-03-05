using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public  class KhachHang_dal
    {
        public KhachHang_dal() { }
        public List<KhachHang_dto> select()
        {
            List<KhachHang_dto> resultList = (from item in Main._db.KHACHHANGs
                                             select new KhachHang_dto
                                             {
                                                 MaKH = item.MAKH,
                                                 Sdt = item.SDT,
                                                 TenKH = item.TENKH,
                                                 MatKhau = item.MATKHAU,
                                                 DiaChi = item.DIACHI,
                                                 Email = item.EMAIL

                                             }).ToList();
            return resultList;
        }
        public int insert(KhachHang_dto kh)
        {
            try
            {
                KHACHHANG KHACHHANG = new KHACHHANG();
                KHACHHANG.MAKH = kh.MaKH;
                KHACHHANG.TENKH = kh.TenKH;
                KHACHHANG.MATKHAU = kh.MatKhau;
                KHACHHANG.EMAIL = kh.Email;
                KHACHHANG.SDT = kh.Sdt;
                KHACHHANG.SDT = kh.DiaChi;
                Main._db.KHACHHANGs.InsertOnSubmit(KHACHHANG);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string MaKH)
        {
            try
            {
                KHACHHANG KHACHHANG = Main._db.KHACHHANGs.SingleOrDefault(t => t.MAKH == MaKH);
                Main._db.KHACHHANGs.DeleteOnSubmit(KHACHHANG);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(KhachHang_dto kh)
        {
            try
            {
                KHACHHANG KHACHHANG = Main._db.KHACHHANGs.SingleOrDefault(e => e.MAKH == kh.MaKH);
                if (KHACHHANG != null)
                {
                    KHACHHANG.MAKH = kh.MaKH;
                    KHACHHANG.TENKH = kh.TenKH;
                    KHACHHANG.MATKHAU = kh.MatKhau;
                    KHACHHANG.EMAIL = kh.Email;
                    KHACHHANG.SDT = kh.Sdt;
                    KHACHHANG.SDT = kh.DiaChi;
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
