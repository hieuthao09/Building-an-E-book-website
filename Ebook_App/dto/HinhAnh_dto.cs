using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public  class HinhAnh_dto
    {
        public HinhAnh_dto() { }

        public HinhAnh_dto(string maHA,string maSach, string tenFileHinh)
        {
            MaHA = maHA ?? throw new ArgumentNullException(nameof(maHA));
            MaSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
            TenFileHinh = tenFileHinh ?? throw new ArgumentNullException(nameof(tenFileHinh));
        }

        string maHA;
        string maSach;
        string tenFileHinh;


        public string MaHA { get => maHA; set => maHA = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenFileHinh { get => tenFileHinh; set => tenFileHinh = value; }
    }
}
