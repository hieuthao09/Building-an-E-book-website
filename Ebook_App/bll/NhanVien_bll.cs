using dll;
using dto;
using System;
using System.Collections.Generic;


namespace bll
{
    public class NhanVien_bll
    {
        NhanVien_dal dal = new NhanVien_dal();
        public NhanVien_bll() { }
        public int isCheckLogin(string username, string password, int chucvu)
        {
            return dal.isCheckDangNhap(username, password, chucvu);
        }
        public Boolean SaveLoginCredentials (string username, string password)
        {
            return dal.SaveLoginCredentials(username, password);
        }
        public Boolean LoadLoginCredentials(ref string username, ref string password)
        {
            return dal.LoadLoginCredentials(ref username, ref password);
        }
        public List<NhanVien_dto> select()
        {
            return dal.select();
        }
        public NhanVien_dto select_Usename(string manv)
        {
            return dal.select_Usename(manv);
        }
        public List<NhanVien_dto> select_MaCV(string macv)
        {
            return dal.select_MaCV(macv);
        }
        public List<NhanVien_dto> select_MaNV_TenNV()
        {
            return dal.select_MaNV_TenNV();
        }
        public int insert(NhanVien_dto nv)
        {
            return dal.insert(nv);
        }
        public int update(NhanVien_dto nv)
        {
            return dal.update(nv);
        }
        public int delete(string maNT)
        {
            return dal.delete(maNT);
        }
        public int update_DoiMatKhau(NhanVien_dto nv)
        {
            return dal.update_DoiMatKhau( nv);
        }
    }
}
