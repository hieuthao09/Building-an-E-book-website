using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class SachHinhAnh_dto
    {
        String maSach;
        String tenSach;
        String moTa;
        decimal giaBan;
        String tenFileSach;
        DateTime ngayDangTai;
        String maTL;
        String maNXB;
        string maHA;
        string tenFileHinh;
        Image hinhAnh;

        public SachHinhAnh_dto()
        {

        }
        public SachHinhAnh_dto(string maSach, string tenSach, string moTa, decimal giaBan, string tenFileSach, DateTime ngayDangTai, string maTL, string maNXB, string maHA, string tenFileHinh)
        {
            MaSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
            TenSach = tenSach ?? throw new ArgumentNullException(nameof(tenSach));
            MoTa = moTa ?? throw new ArgumentNullException(nameof(moTa));
            GiaBan = giaBan;
            TenFileSach = tenFileSach ?? throw new ArgumentNullException(nameof(tenFileSach));
            NgayDangTai = ngayDangTai;
            MaTL = maTL ?? throw new ArgumentNullException(nameof(maTL));
            MaNXB = maNXB ?? throw new ArgumentNullException(nameof(maNXB));
            MaHA = maHA ?? throw new ArgumentNullException(nameof(maHA));
            TenFileHinh = tenFileHinh ?? throw new ArgumentNullException(nameof(tenFileHinh));
        }

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public string TenFileSach { get => tenFileSach; set => tenFileSach = value; }
        public DateTime NgayDangTai { get => ngayDangTai; set => ngayDangTai = value; }
        public string MaTL { get => maTL; set => maTL = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
        public string MaHA { get => maHA; set => maHA = value; }
        public string TenFileHinh { get => tenFileHinh; set => tenFileHinh = value; }
        public Image HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
