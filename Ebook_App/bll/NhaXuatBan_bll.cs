using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class NhaXuatBan_bll
    {

        NhaXuatBan_dal dal = new NhaXuatBan_dal();
        public NhaXuatBan_bll() { }

        public List<NhaXuatBan_dto> select()
        {
            return dal.select();
        }
        public int insert(NhaXuatBan_dto nxb)
        {
            return dal.insert(nxb);
        }
        public int update(NhaXuatBan_dto nxb)
        {
            return dal.update(nxb);
        }
        public int delete(string maXB)
        {
            return dal.delete(maXB);
        }
    }
}
