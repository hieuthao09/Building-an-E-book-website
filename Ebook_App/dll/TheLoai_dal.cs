using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public  class TheLoai_dal
    {
        public TheLoai_dal() { }
        public List<TheLoai_dto> select()
        {
            List<TheLoai_dto> resultList = (from item in Main._db.THELOAIs
                                           select new TheLoai_dto
                                           {
                                               TenTL = item.TENTL,
                                               MaTL = item.MATL,
                                           }).ToList();
            return resultList;
        }
        public int insert(TheLoai_dto cv)
        {
            try
            {
                THELOAI THELOAI = new THELOAI();
                THELOAI.MATL = cv.MaTL;
                THELOAI.TENTL = cv.TenTL;
                Main._db.THELOAIs.InsertOnSubmit(THELOAI);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string MaTL)
        {
            try
            {
                THELOAI THELOAI = Main._db.THELOAIs.SingleOrDefault(t => t.MATL == MaTL);
                Main._db.THELOAIs.DeleteOnSubmit(THELOAI);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(TheLoai_dto cv)
        {
            try
            {
                THELOAI THELOAI = new THELOAI();
                THELOAI entityToUpdate = Main._db.THELOAIs.SingleOrDefault(e => e.MATL == cv.MaTL);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MATL = cv.MaTL;
                    entityToUpdate.TENTL = cv.TenTL;
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
