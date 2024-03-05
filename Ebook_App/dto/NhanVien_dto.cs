using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class NhanVien_dto
    {
        public NhanVien_dto() { }

        public NhanVien_dto(string maNV, string tenNV, string userName, string email1, string matKhau1, string hinhAnh, string maCV)
        {
            MaNV = maNV;
            TenNV = tenNV;
            UserName = userName;
            Email = email1;
            MatKhau = matKhau1;
            HinhAnh = hinhAnh;
            MaCV = maCV;
        }

        string maNV;
        string tenNV;
        string userName;
        string email;
        string matKhau;
        string hinhAnh;
        string maCV;
        Image anhNV;
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public Image AnhNV { get => anhNV; set => anhNV = value; }
    }
}
