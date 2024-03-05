using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class TinTuc_bll
    {
        TinTuc_dal dal = new TinTuc_dal();
        public TinTuc_bll() { }
        public List<TinTuc_dto> select_NT(string maNT)
        {
            return dal.select_NT(maNT);

        }
        public List<TinTuc_dto> select()
        {
            return dal.select();
        }
        public int insert(TinTuc_dto tt)
        {
            return dal.insert(tt) ;
        }
        public int update(TinTuc_dto tt)
        {
            return dal.update(tt);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
        public int update_tinhtrang(string matt, bool tinhtrang)
        {
            return dal.update_tinhtrang(matt, tinhtrang);
        }
    }
}
