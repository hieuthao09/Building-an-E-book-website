using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class NhomTin_dto
    {
        public NhomTin_dto() { }
        string maNT;
        string tenNT;

        public string MaNT { get => maNT; set => maNT = value; }
        public string TenNT { get => tenNT; set => tenNT = value; }

        public NhomTin_dto(string tenNT)
        {
            TenNT = tenNT ?? throw new ArgumentNullException(nameof(tenNT));
        }
    }
}
