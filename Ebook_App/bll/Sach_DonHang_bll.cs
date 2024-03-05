using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public  class Sach_DonHang_bll
    {
        Sach_DonHang_dal dal = new Sach_DonHang_dal();
        public Sach_DonHang_bll() { }
        public List<Sach_DonHang_dto> select()
        {
            return dal.select();
        }
        public List<Sach_DonHang_dto> ThongKe()
        {
            return dal.thongKe();
        }
        public int insert(Sach_DonHang_dto ctdh)
        {
            return dal.insert(ctdh);
        }
        public int update(Sach_DonHang_dto ctdh)
        {
            return dal.update(ctdh);
        }
        public int delete(string maDH)
        {
            return dal.delete(maDH);
        }
    }
}
