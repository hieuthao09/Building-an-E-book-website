using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class DonHang_bll
    {
        DonHang_dal dal = new DonHang_dal();
        public DonHang_bll() { }
        public List<DonHang_dto> select()
        {
            return dal.select();
        }
        public int insert(DonHang_dto dh)
        {
            return dal.insert(dh);
        }
        public int update(DonHang_dto dh)
        {
            return dal.update(dh);
        }
        public int delete(string maDH)
        {
            return dal.delete(maDH);
        }
    }
}
