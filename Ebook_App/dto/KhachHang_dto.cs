using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class KhachHang_dto
    {
        public KhachHang_dto() { }

        public KhachHang_dto(string makh, string tenKH, string sdt, string email, string matKhau, string diaChi)
        {
            MaKH = makh;
            TenKH = tenKH;
            Sdt = sdt;
            Email = email;
            MatKhau = matKhau;
            DiaChi = diaChi;
        }

        string maKH;
        string tenKH;
        string sdt;
        string email;
        string matKhau;
        string diaChi;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
