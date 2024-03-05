using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dll
{
    public class Sach_dal
    {
        public List<Sach_dto> select()
        {
            List<Sach_dto> result = Main._db.SACHes.Select(
                t => new Sach_dto { 
                    MaSach = t.MASACH, 
                    MaNXB = t.MANXB,
                    TenSach = t.TENSACH,
                    GiaBan = decimal.Parse(t.GIABAN.ToString()),
                    TenFileSach = t.TENFILESACH,
                    MoTa = t.MOTA,
                    NgayDangTai =(DateTime) t.NGAYDANGTAI,
                    MaTL = t.MATL,
                }).ToList();
            return result;
        }
        public List<Sach_AI> select_model()
        {
            List<Sach_AI> result = Main._db.SACHes.Select(
                t => new Sach_AI
                {
                    TenSach = t.TENSACH,
                    MoTa = t.MOTA,
                }).ToList();
            return result;
        }
        public List<SachHinhAnh_dto> select_Sach_HinhAnh()
        {
            List<SachHinhAnh_dto> result = Main._db.SACHes.Select(
                t => new SachHinhAnh_dto
                {
                    MaSach = t.MASACH,
                    MaNXB = t.MANXB,
                    MaHA = t.HINHANHs.SingleOrDefault(e => e.MASACH.Equals(t.MASACH)).MAHA,
                    MaTL = t.MATL,
                    TenFileHinh = t.HINHANHs.SingleOrDefault(e => e.MASACH.Equals(t.MASACH)).TENFILEHINH,
                    TenSach = t.TENSACH,
                    MoTa = t.MOTA,
                    NgayDangTai = (DateTime)t.NGAYDANGTAI,
                    GiaBan = (decimal)t.GIABAN,
                    TenFileSach = t.TENFILESACH,
                    
                }
                ).ToList();

            return result;
        }
        public int  insert(Sach_dto s)
        {
            try
            {
                SACH SACH = new SACH();
                SACH.MASACH = s.MaSach;
                SACH.MANXB = s.MaNXB;
                SACH.TENSACH = s.TenSach;
                SACH.GIABAN = s.GiaBan;
                SACH.TENFILESACH = s.TenFileSach;
                SACH.MOTA = s.MoTa;
                SACH.NGAYDANGTAI = s.NgayDangTai;
                SACH.MATL = s.MaTL;
                Main._db.SACHes.InsertOnSubmit(SACH);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(Sach_dto s)
        {
            try
            {
                SACH SACH = Main._db.SACHes.SingleOrDefault(e => e.MASACH == s.MaSach);
                if (SACH != null)
                {
                    SACH.MASACH = s.MaSach;
                    SACH.MANXB = s.MaNXB;
                    SACH.TENSACH = s.TenSach;
                    SACH.GIABAN = s.GiaBan;
                    SACH.TENFILESACH = s.TenFileSach;
                    SACH.MOTA = s.MoTa;
                    SACH.NGAYDANGTAI = s.NgayDangTai;
                    SACH.MATL = s.MaTL;
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
        public int delete(string masach)
        {
            try
            {
                SACH SACH = Main._db.SACHes.SingleOrDefault(t => t.MASACH == masach);
                Main._db.SACHes.DeleteOnSubmit(SACH);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }    
    }
}
