using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class TinTuc_dto
    {
       public TinTuc_dto() { }

        public TinTuc_dto( string tieuDe, string noiDungTT, DateTime thoiGian, string moTa, string hinhAnh, bool tinhTrang, string maNV, string maNT)
        {
            TieuDe = tieuDe ?? throw new ArgumentNullException(nameof(tieuDe));
            NoiDungTT = noiDungTT ?? throw new ArgumentNullException(nameof(noiDungTT));
            ThoiGian = thoiGian;
            MoTa = moTa ?? throw new ArgumentNullException(nameof(moTa));
            HinhAnh = hinhAnh ?? throw new ArgumentNullException(nameof(hinhAnh));
            TinhTrang = tinhTrang;
            MaNV = maNV ?? throw new ArgumentNullException(nameof(maNV));
            MaNT = maNT ?? throw new ArgumentNullException(nameof(maNT));
        }

        String maTT;
        String tieuDe;
        String noiDungTT;
        DateTime thoiGian;
        String moTa;
        String hinhAnh;
        bool tinhTrang;
        String maNV;
        String maNT;

        public string MaTT { get => maTT; set => maTT = value;  }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDungTT { get => noiDungTT; set => noiDungTT = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNT { get => maNT; set => maNT = value; }
    }
}
