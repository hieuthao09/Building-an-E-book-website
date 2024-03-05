using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class Sach_dto
    {
        public Sach_dto() { }

        public Sach_dto(string maSach, string tenSach, string moTa, decimal giaBan, string tenFileSach, DateTime ngayDangTai, string maTL, string maNXB)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.moTa = moTa;
            this.giaBan = giaBan;
            this.tenFileSach = tenFileSach;
            this.ngayDangTai = ngayDangTai;
            this.maTL = maTL;
            this.maNXB = maNXB;
        }
        public Sach_dto(string tenSach, string moTa, decimal giaBan, string tenFileSach, DateTime ngayDangTai, string maTL, string maNXB)
        {
            this.tenSach = tenSach;
            this.moTa = moTa;
            this.giaBan = giaBan;
            this.tenFileSach = tenFileSach;
            this.ngayDangTai = ngayDangTai;
            this.maTL = maTL;
            this.maNXB = maNXB;
        }
        String maSach;
        String tenSach;
        String moTa;
        decimal giaBan;
        String tenFileSach;
        DateTime ngayDangTai;
        String maTL;
        String maNXB;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public string TenFileSach { get => tenFileSach; set => tenFileSach = value; }
        public DateTime NgayDangTai { get => ngayDangTai; set => ngayDangTai = value; }
        public string MaTL { get => maTL; set => maTL = value; }
        public string MaNXB { get => maNXB; set => maNXB = value; }
    }
}
