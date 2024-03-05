using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public  class DonHang_dto
    {
        public DonHang_dto() { }

        public DonHang_dto(string maDH, DateTime ngayDat, byte pTThanhToan, string maKH)
        {
            MaDH = maDH ?? throw new ArgumentNullException(nameof(maDH));
            NgayDat = ngayDat;
            PTThanhToan = pTThanhToan;
            MaKH = maKH ?? throw new ArgumentNullException(nameof(maKH));
        }

        string maDH;
        DateTime ngayDat;
        byte pTThanhToan;
        string maKH;

        

        

        public string MaDH { get => maDH; set => maDH = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public byte PTThanhToan { get => pTThanhToan; set => pTThanhToan = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
