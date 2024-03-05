using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class ChucVu_dal
    {
        public ChucVu_dal() { }
        public List<ChucVu_dto> select()
        {
            List<ChucVu_dto> resultList = (from item in Main._db.CHUCVUs
                                             select new ChucVu_dto
                                             {
                                                 TenCV = item.TenCV,
                                                 MaCV = item.MaCV,
                                             }).ToList();
            return resultList;
        }
        public int insert(ChucVu_dto cv)
        {
            try
            {
                CHUCVU cHUCVU = new CHUCVU();
                cHUCVU.MaCV = cv.MaCV;
                cHUCVU.TenCV = cv.TenCV;
                Main._db.CHUCVUs.InsertOnSubmit(cHUCVU);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string macv)
        {
            try
            {
                CHUCVU CHUCVU = Main._db.CHUCVUs.SingleOrDefault(t => t.MaCV == macv);
                Main._db.CHUCVUs.DeleteOnSubmit(CHUCVU);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(ChucVu_dto cv)
        {
            try
            {
                CHUCVU CHUCVU = new CHUCVU();
                CHUCVU entityToUpdate = Main._db.CHUCVUs.SingleOrDefault(e => e.MaCV == cv.MaCV);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MaCV = cv.MaCV;
                    entityToUpdate.TenCV = cv.TenCV;
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

