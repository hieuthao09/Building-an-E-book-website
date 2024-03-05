using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class KhachHang_bll
    {
        KhachHang_dal dal = new KhachHang_dal();
        public KhachHang_bll() { }

        public List<KhachHang_dto> select()
        {
            return dal.select();
        }
        public int insert(KhachHang_dto kh)
        {
            return dal.insert(kh);
        }
        public int update(KhachHang_dto kh)
        {
            return dal.update(kh);
        }
        public int delete(string makh)
        {
            return dal.delete(makh);
        }
    }
}
