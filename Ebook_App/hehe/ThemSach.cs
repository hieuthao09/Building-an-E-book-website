using bll;
using DevExpress.CodeParser;
using dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class ThemSach : Form
    {
        static public SachHinhAnh_dto sha = new SachHinhAnh_dto();
        public ThemSach()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TheLoai_bll tl_bll = new TheLoai_bll();
        NhaXuatBan_bll nxb_bll = new NhaXuatBan_bll();
        void loadCBTL()
        {
            Utils.loadCbb(cbb_TL, tl_bll.select().ToList<Object>(), "TenTL", "MaTL");
            cbb_TL.EditValue = tl_bll.select()[0].MaTL;
        }
        void loadCBNCB()
        {
            Utils.loadCbb(cbb_NXB, nxb_bll.select().ToList<Object>(), "TenNXB", "MaNXB");
            cbb_NXB.EditValue = nxb_bll.select()[0].MaNXB;
        }
        HinhAnh_bll ha_bll = new HinhAnh_bll();
        private void btn_taihinhanh_Click(object sender, EventArgs e)
        {
            ha.TenFileHinh = Utils.taianh(pictureBox1, "Resources\\Image_Book");

        }
        HinhAnh_dto ha = new HinhAnh_dto();
        Sach_dto s = new Sach_dto();
        Sach_bll s_bll = new Sach_bll();
        bool loadTT()
        {
            try
            {
                txt_MaSach.ReadOnly = true;
                txt_GiaBan.Text = sha.GiaBan.ToString();
                txt_mota.Text = sha.MoTa;
                txt_MaSach.Text = sha.MaSach;
                txt_TenSach.Text = sha.TenSach;
                txt_NgayDangTai.EditValue = sha.NgayDangTai;
                cbb_TL.EditValue = sha.MaTL;
                cbb_NXB.EditValue = sha.MaNXB;
                Utils.LoadImages(pictureBox1, sha.TenFileHinh, "Resources\\Image_Book");
                return true;
            }
            catch
            {
                return false;
            }


        }
        Boolean layTT()
        {
            try
            {
                s.MaSach = "S0000" + (s_bll.select().Count + 1).ToString();
                s.MaTL = cbb_TL.EditValue.ToString();
                s.MaNXB = cbb_NXB.EditValue.ToString();
                s.MoTa = txt_mota.Text;
                s.TenSach = txt_TenSach.Text;
                s.GiaBan = decimal.Parse(txt_GiaBan.Text);
                s.NgayDangTai = (DateTime)txt_NgayDangTai.EditValue;
                ha.MaHA = "HA0000" + ha_bll.select().Count + 1;
                ha.MaSach = s.MaSach;
                return true;
            }
            catch
            {
                return false;
            }
           
        }
        Boolean layTTCN()
        {
            try
            {
                s.MaSach = txt_MaSach.Text;
                s.MaTL = cbb_TL.EditValue.ToString();
                s.MaNXB = cbb_NXB.EditValue.ToString();
                s.MoTa = txt_mota.Text;
                s.TenSach = txt_TenSach.Text;
                s.GiaBan = decimal.Parse(txt_GiaBan.Text);
                s.NgayDangTai = (DateTime)txt_NgayDangTai.EditValue;
                ha.MaHA = "HA0000" + ha_bll.select().Count + 1;
                ha.MaSach = s.MaSach;
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(!capnhat)
            {
                if (layTT())
                {
                    if (s_bll.insert(s) == 1)
                    {
                        if (ha_bll.insert(ha) == 1)
                        {
                            ThongBao.ThongBaoThongTin("Thêm thành công");
                        }
                    }
                    else
                    {
                        ThongBao.ThongBaoThongTin("Thất bại");
                    }
                }
            }
            else
            {
                if (layTTCN())
                {
                    if (s_bll.update(s) == 1)
                    {
                        if (ha_bll.update(ha) == 1)
                        {
                            ThongBao.ThongBaoThongTin("Cập nhật thành công");
                        }
                    }
                    else
                    {
                        ThongBao.ThongBaoThongTin("Thất bại");
                    }
                }
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(ThongBao.CauHoi("Bạn chắc chắn muốn thoát chứ"))
            {
                this.Close();
            }    
        }
        bool capnhat;
        private void ThemSach_Load(object sender, EventArgs e)
        {
            txt_MaSach.ReadOnly = true;
            loadCBTL();
            loadCBNCB();
            if(sha!=null)
            {
                loadTT();
                capnhat = true;
            }    
           
        }
    }
}
