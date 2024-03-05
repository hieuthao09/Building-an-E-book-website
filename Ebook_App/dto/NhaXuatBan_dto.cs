using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class NhaXuatBan_dto
    {
        public NhaXuatBan_dto()
        {

        }

        public NhaXuatBan_dto(string maNXB,string tenNXB)
        {
            MaNXB = tenNXB ?? throw new ArgumentNullException(nameof(maNXB));
            TenNXB = tenNXB ?? throw new ArgumentNullException(nameof(tenNXB));
        }

        string maNXB;
        string tenNXB;

        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string TenNXB { get => tenNXB; set => tenNXB = value; }
    }
}
