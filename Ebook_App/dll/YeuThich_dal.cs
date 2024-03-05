using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class YeuThich_dal
    {
        public YeuThich_dal() { }
        public List<YeuThich_dto> select()
        {
            List<YeuThich_dto> resultList = (from item in Main._db.YEUTHICHes
                                            select new YeuThich_dto
                                            {
                                                MaSach = item.MaSach,
                                                Soluong = Main._db.YEUTHICHes.Count(t=>t.MaSach.Equals(item.MaSach)),
                                                TenSach = item.SACH.TENSACH,
                                            }).ToList();
            return resultList;
        }
        public int insert(YeuThich_dto cv)
        {
            try
            {
                YEUTHICH YEUTHICH = new YEUTHICH();
                YEUTHICH.MaSach = cv.MaSach;
                YEUTHICH.MaKH = cv.MaKH;
                Main._db.YEUTHICHes.InsertOnSubmit(YEUTHICH);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string Mas, string makh)
        {
            try
            {
                YEUTHICH YEUTHICH = Main._db.YEUTHICHes.SingleOrDefault(t => t.MaKH.Equals(makh)&& t.MaSach.Equals(Mas));
                Main._db.YEUTHICHes.DeleteOnSubmit(YEUTHICH);
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
