using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class HinhAnh_bll
    {
        HinhAnh_dal dal = new HinhAnh_dal();
        public List<HinhAnh_dto> select()
        {
            return dal.select();
        }
       
        public int insert(HinhAnh_dto ha)
        {
            return dal.insert(ha);
        }
        public int update(HinhAnh_dto ha)
        {
            return dal.update(ha);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
    }
}
