using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public  class NhaXuatBan_dal
    {
        public NhaXuatBan_dal() { }
        public List<NhaXuatBan_dto> select()
        {
            List<NhaXuatBan_dto> resultList = (from item in Main._db.NHAXUATBANs
                                           select new NhaXuatBan_dto
                                           {
                                               TenNXB = item.TENNXB,
                                               MaNXB = item.MANXB,
                                           }).ToList();
            return resultList;
        }
        public int insert(NhaXuatBan_dto cv)
        {
            try
            {
                NHAXUATBAN NHAXUATBAN = new NHAXUATBAN();
                NHAXUATBAN.MANXB = cv.MaNXB;
                NHAXUATBAN.TENNXB = cv.TenNXB;
                Main._db.NHAXUATBANs.InsertOnSubmit(NHAXUATBAN);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string MaNXB)
        {
            try
            {
                NHAXUATBAN NHAXUATBAN = Main._db.NHAXUATBANs.SingleOrDefault(t => t.MANXB == MaNXB);
                Main._db.NHAXUATBANs.DeleteOnSubmit(NHAXUATBAN);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(NhaXuatBan_dto cv)
        {
            try
            {
                NHAXUATBAN NHAXUATBAN = new NHAXUATBAN();
                NHAXUATBAN entityToUpdate = Main._db.NHAXUATBANs.SingleOrDefault(e => e.MANXB == cv.MaNXB);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MANXB = cv.MaNXB;
                    entityToUpdate.TENNXB = cv.TenNXB;
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
