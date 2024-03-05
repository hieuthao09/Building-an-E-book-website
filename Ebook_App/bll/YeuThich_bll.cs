using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class YeuThich_bll
    {
        YeuThich_dal dal = new YeuThich_dal();
        public YeuThich_bll() { }
        public List<YeuThich_dto> select()
        {
            return dal.select();
        }
        public int insert(YeuThich_dto tl)
        {
            return dal.insert(tl);
        }
       
        public int delete(string masach, string makh)
        {
            return dal.delete(masach, makh);
        }
    }
}
