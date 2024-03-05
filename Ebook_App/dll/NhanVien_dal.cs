using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Permissions;

namespace dll
{
    public class NhanVien_dal
    {
       private static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
        }       
        public int isCheckDangNhap(string username, string password, int chucvu)
        {
            NHANVIEN nv = new NHANVIEN();
            if (chucvu ==1)
                nv= Main._db.NHANVIENs.Where(t => t.UseName.Equals(username) && t.MaCV.Equals("CV2310001")).FirstOrDefault();
            else
                nv = Main._db.NHANVIENs.Where(t => t.UseName.Equals(username) && !t.MaCV.Equals("CV2310001")).FirstOrDefault();
            if (nv == null)
            {
                return 0;
            }
            else
            {
                string passnew = Hash(password);
                if (nv.MatKhau.Equals(passnew))
                    {
                        return 1;
                    }    
                    else
                    {
                        return -1;
                    }
                               
            }
        }
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public Boolean SaveLoginCredentials(string username, string password)
        {
            try
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
    
                return true;
            }
            catch (ConfigurationErrorsException)
            {
                return false;
            }
        }
        public Boolean LoadLoginCredentials(ref string username, ref string password)
        {
            try
            {

                username = Properties.Settings.Default.Username;
                password = Properties.Settings.Default.Password;
                return true;
               
            }
            catch (ConfigurationErrorsException)
            {
                return false;
            }
        }
        public List<NhanVien_dto> select()
        {
            List<NhanVien_dto> resultList = (from item in Main._db.NHANVIENs
                                           select new NhanVien_dto
                                           {
                                               MaNV = item.MaNV,
                                               MaCV = item.MaCV,
                                               TenNV = item.TenNV,
                                               MatKhau = item.MatKhau,
                                               UserName = item.UseName,
                                               Email = item.Email,
                                               HinhAnh = item.HinhAnh,
                                           }).ToList();
            return resultList;
        }
        public NhanVien_dto select_Usename(string Usename)
        {
            NhanVien_dto resultList = (from item in Main._db.NHANVIENs
                                             select new NhanVien_dto
                                             {
                                                 MaNV = item.MaNV,
                                                 MaCV = item.MaCV,
                                                 TenNV = item.TenNV,
                                                 MatKhau = item.MatKhau,
                                                 UserName = item.UseName,
                                                 Email = item.Email,
                                                 HinhAnh = item.HinhAnh,
                                             }).SingleOrDefault(t=>t.UserName == Usename);
            return resultList;
        }
        public List<NhanVien_dto> select_MaNV_TenNV()
        {
            List<NhanVien_dto> resultList = (from item in Main._db.NHANVIENs
                                             select new NhanVien_dto
                                             {
                                                 MaNV = item.MaNV,
                                                 TenNV = item.TenNV,
                                             }).ToList();
            return resultList;
        }
        public List<NhanVien_dto> select_MaCV(string maCV)
        {
            List<NhanVien_dto> resultList = (from item in Main._db.NHANVIENs
                                             select new NhanVien_dto
                                             {
                                                 MaNV = item.MaNV,
                                                 MaCV = item.MaCV,
                                                 TenNV = item.TenNV,
                                                 MatKhau = item.MatKhau,
                                                 UserName = item.UseName,
                                                 Email = item.Email,
                                                 HinhAnh = item.HinhAnh,
                                             }).Where(t => t.MaCV == maCV).ToList();
            return resultList;
        }
        public int insert(NhanVien_dto nv)
        {
            try
            {
                NHANVIEN NHANVIEN = new NHANVIEN();
                NHANVIEN.MaNV = nv.MaNV;
                NHANVIEN.MaCV = nv.MaNV;
                NHANVIEN.TenNV = nv.TenNV;
                NHANVIEN.Email = nv.Email;
                NHANVIEN.UseName = nv.UserName;
                NHANVIEN.HinhAnh = nv.HinhAnh;
                Main._db.NHANVIENs.InsertOnSubmit(NHANVIEN);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string manv)
        {
            try
            {
                NHANVIEN NHANVIEN = Main._db.NHANVIENs.SingleOrDefault(t => t.MaNV == manv);
                Main._db.NHANVIENs.DeleteOnSubmit(NHANVIEN);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(NhanVien_dto nv)
        {
            try
            {
                NHANVIEN NHANVIEN = new NHANVIEN();
                NHANVIEN entityToUpdate = Main._db.NHANVIENs.SingleOrDefault(e => e.MaNV == nv.MaNV);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MaNV = nv.MaNV;
                    entityToUpdate.MaCV = nv.MaCV;
                    entityToUpdate.TenNV = nv.TenNV;
                    entityToUpdate.Email = nv.Email;
                    entityToUpdate.UseName = nv.UserName;
                    entityToUpdate.HinhAnh = nv.HinhAnh;
                    Main._db.SubmitChanges();

                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update_DoiMatKhau(NhanVien_dto nv)
        {
            try
            {
                string passnew= Hash(nv.MatKhau);
                NHANVIEN NHANVIEN = new NHANVIEN();
                NHANVIEN entityToUpdate = Main._db.NHANVIENs.SingleOrDefault(e => e.MaNV == nv.MaNV);
                if (entityToUpdate != null)
                {  
                    entityToUpdate.MatKhau = passnew;
                    Main._db.SubmitChanges();
                    SaveLoginCredentials(nv.UserName, nv.MatKhau);
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
