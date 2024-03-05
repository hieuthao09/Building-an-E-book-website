using bll;
using dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class ThongTinCaNhan : Form
    {
        static public NhanVien_dto nhanvien;
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        ChucVu_bll cv_bll = new ChucVu_bll();
        NhanVien_bll nv_bll = new NhanVien_bll();

        void loadTT()
        {

            txt_HoTen.Text = nhanvien.TenNV;
            txt_MaNV.Text = nhanvien.MaNV;
            txt_TenDangNhap.Text = nhanvien.UserName;
            txt_Email.Text = nhanvien.Email;
            Utils.loadCbb(cbb_ChucVu, cv_bll.select().ToList<Object>(), "TenCV","MaCV");
            cbb_ChucVu.EditValue = nhanvien.MaCV;
            try
            {
                Utils.LoadImages(pc_nv, nhanvien.HinhAnh, "Resources");
            }catch(Exception ex) { }
            
        }
        string namehinhanh ="";
        bool layTT()
        {
            try
            {
                nhanvien.MaCV = cbb_ChucVu.EditValue.ToString();
                nhanvien.TenNV = txt_HoTen.Text;
                nhanvien.Email = txt_Email.Text;
                nhanvien.UserName = txt_TenDangNhap.Text;
                nhanvien.HinhAnh = namehinhanh;
                return true;
            }catch (Exception ex) { return false; }
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
           
            if(them)
            {
                Utils.loadCbb(cbb_ChucVu, cv_bll.select().ToList<Object>(), "TenCV", "MaCV");
            }
            else
            {
                if (hide)
                {
                    loadTT();
                    namehinhanh = nhanvien.HinhAnh;
                    btnLuu.Enabled = false;
                    btn_TaiHinh.Enabled = false;
                }
                else
                {
                    if(them)
                    {
                        btnLuu.Enabled = true;
                        btn_TaiHinh.Enabled = true;
                    }
                    else
                    {
                        loadTT();
                        btnLuu.Enabled = true;
                        btn_TaiHinh.Enabled = true;
                    }
                   
                }
            }
            


        }
        static public bool hide = false;
        static public bool them = false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them)
            {
                if (layTT())
                {
                    if (nv_bll.update(nhanvien) == 1)
                    {
                        ThongBao.ThongBaoThongTin("Cập nhật thành công");
                    }
                    else
                    {
                        ThongBao.Loi("Cập nhật thất bại");
                    }
                }
            }
            else
            {
                if (layTT())
                {
                    if (nv_bll.update(nhanvien) == 1)
                    {
                        ThongBao.ThongBaoThongTin("Cập nhật thành công");
                        TrangChu.nhanvien = nv_bll.select().SingleOrDefault(t => t.MaNV == nhanvien.MaNV);
                    }
                    else
                    {
                        ThongBao.Loi("Cập nhật thất bại");
                    }
                }
            }    
           
        }

        private void btn_TaiHinh_Click(object sender, EventArgs e)
        {
            namehinhanh = Utils.taianh(pc_nv, "Resources");
             Utils.LoadImages(pc_nv, namehinhanh, "Resources");
        }
    }
}
