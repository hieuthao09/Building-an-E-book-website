using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class YeuThich_dto
    {
        public YeuThich_dto() { }

        public YeuThich_dto(string maSach, string maKH)
        {
            MaSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
            MaKH = maKH ?? throw new ArgumentNullException(nameof(maKH));
        }

        string maSach;
        string maKH;
        string tenSach;
        int soluong;
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}
