using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class ChucVu_bll
    {
        ChucVu_dal dal = new ChucVu_dal();
        public ChucVu_bll() { }
        public List<ChucVu_dto> select()
        {
            return dal.select();
        }
        public int insert(ChucVu_dto cv)
        {
            return dal.insert(cv);
        }
        public int update(ChucVu_dto cv)
        {
            return dal.update(cv);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
    }
}
