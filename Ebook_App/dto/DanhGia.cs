using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class DanhGia
    {
        public DanhGia() { }

        public DanhGia(string maKH, DateTime thoiGian, string noiDung, string soSao)
        {
           
            MaKH = maKH ?? throw new ArgumentNullException(nameof(maKH));
            ThoiGian = thoiGian;
            NoiDung = noiDung ?? throw new ArgumentNullException(nameof(noiDung));
            SoSao = soSao ?? throw new ArgumentNullException(nameof(soSao));
        }

        string maSach;
        string maKH;
        DateTime thoiGian;
        string noiDung;
        string soSao;

        public string MaSach { get => maSach; set => maSach = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string SoSao { get => soSao; set => soSao = value; }
    }
}
