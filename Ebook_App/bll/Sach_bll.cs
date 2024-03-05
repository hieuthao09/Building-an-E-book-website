using dll;
using dto;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Sach_bll

    {
        Sach_dal dal = new Sach_dal();
        public Sach_bll() { }
       
        public List<Sach_dto> select()
        {
            return dal.select();
        }
        public List<Sach_AI> select_model()
        {
            return dal.select_model();
        }
        public List<SachHinhAnh_dto> select_Sach_HinhAnh()
        {
            return dal.select_Sach_HinhAnh();
        }
        public int insert(Sach_dto tt)
        {
            return dal.insert(tt);
        }
        public int update(Sach_dto tt)
        {
            return dal.update(tt);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
    }
}
