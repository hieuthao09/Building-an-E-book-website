using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class NhomTin_dal
    {
        public List<NhomTin_dto> select()
        {
            List<NhomTin_dto> resultList = Main._db.NHOMTINs.Select(t => new NhomTin_dto { MaNT = t.MaNT, TenNT = t.TenNT}).ToList();
            return resultList;

        }
        public Boolean insert(NhomTin_dto nt)
        {
            try
            {
                NHOMTIN t = new NHOMTIN { MaNT = nt.MaNT, TenNT = nt.TenNT };
                Main._db.NHOMTINs.InsertOnSubmit(t);
                Main._db.SubmitChanges();
                return true;
            }catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public int delete(string MaNT)
        {
            try
            {
                NHOMTIN NHOMTIN = Main._db.NHOMTINs.SingleOrDefault(t => t.MaNT == MaNT);
                Main._db.NHOMTINs.DeleteOnSubmit(NHOMTIN);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(NhomTin_dto nt)
        {
            try
            {
                NHOMTIN NHOMTIN = new NHOMTIN();
                NHOMTIN entityToUpdate = Main._db.NHOMTINs.SingleOrDefault(e => e.MaNT == nt.MaNT);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MaNT = nt.MaNT;
                    entityToUpdate.TenNT = nt.TenNT;
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
