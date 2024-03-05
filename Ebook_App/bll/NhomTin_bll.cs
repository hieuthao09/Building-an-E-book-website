using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class NhomTin_bll
    {
        NhomTin_dal dal = new NhomTin_dal();
        public NhomTin_bll() { }
        public List<NhomTin_dto> select()
        {
            return dal.select();
        }
        public bool insert(NhomTin_dto nt)
        {
            return dal.insert(nt);
        }
        public int update(NhomTin_dto nt)
        {
            return dal.update(nt);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
    }
}
