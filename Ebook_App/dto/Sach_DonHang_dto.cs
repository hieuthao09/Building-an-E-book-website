using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class Sach_DonHang_dto
    {
        public Sach_DonHang_dto() { }

        public Sach_DonHang_dto(string maSach, string maDH, byte soLuong)
        {
            MaSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
            MaDH = maDH ?? throw new ArgumentNullException(nameof(maDH));
            SoLuong = soLuong;
        }

        string maSach;
        string maDH;
        byte soLuong;
        decimal tongTien;
        decimal giaBan;
        string tenSach;
        string maKH;
        string tenKH;
        DateTime ngayDat;
        int thang;
        int nam;
        public string MaSach { get => maSach; set => maSach = value; }
        public string MaDH { get => maDH; set => maDH = value; }
        public byte SoLuong { get => soLuong; set => soLuong = value; }
        public decimal TongTien { get => tongTien; set => tongTien = value; }
        public decimal GiaBan { get => giaBan; set => giaBan = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
    }
}
