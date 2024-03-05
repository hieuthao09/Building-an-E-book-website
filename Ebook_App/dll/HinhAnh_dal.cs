using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class HinhAnh_dal
    {
        public List<HinhAnh_dto> select()
        {
            List<HinhAnh_dto> resultList = Main._db.HINHANHs.Select(t => new HinhAnh_dto { MaHA = t.MAHA, MaSach = t.MASACH , TenFileHinh = t.TENFILEHINH}).ToList();
            return resultList;

        }
        public int insert(HinhAnh_dto ha)
        {
            try
            {
                HINHANH t = new HINHANH { MAHA = ha.MaHA, MASACH = ha.MaSach, TENFILEHINH = ha.TenFileHinh};
                Main._db.HINHANHs.InsertOnSubmit(t);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
        public int delete(string maha)
        {
            try
            {
                HINHANH HINHANH = Main._db.HINHANHs.SingleOrDefault(t => t.MAHA == maha);
                Main._db.HINHANHs.DeleteOnSubmit(HINHANH);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(HinhAnh_dto cv)
        {
            try
            {
                HINHANH HINHANH = new HINHANH();
                HINHANH entityToUpdate = Main._db.HINHANHs.SingleOrDefault(e => e.MAHA == cv.MaHA);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MAHA = cv.MaHA;
                    entityToUpdate.TENFILEHINH = cv.TenFileHinh;
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
