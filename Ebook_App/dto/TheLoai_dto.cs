using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class TheLoai_dto
    {
        public TheLoai_dto() { }

        public TheLoai_dto(string maTL,string tenTL)
        {
            MaTL = maTL;
            TenTL = tenTL;
        }

        string maTL;
        string tenTL;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTL { get => tenTL; set => tenTL = value; }
    }
}
