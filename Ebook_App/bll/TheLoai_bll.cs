using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class TheLoai_bll
    {
        TheLoai_dal dal = new TheLoai_dal();
        public TheLoai_bll() { }    
        public List<TheLoai_dto> select()
        {
            return dal.select();
        }
        public int insert(TheLoai_dto tl)
        {
            return dal.insert(tl);
        }
        public int update(TheLoai_dto tl)
        {
            return dal.update(tl);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
    }
}
