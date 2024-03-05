using bll;
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
    public partial class GoiYSachTheoNoiDung : Form
    {
        public GoiYSachTheoNoiDung()
        {
            InitializeComponent();
        }
        BookRecommender gy = new BookRecommender("D:\\Sach.csv");
        Sach_bll s_bll = new Sach_bll();
        void goiy()
        {
            if(txt_mota.Text == null || txt_mota.Text.Length == 0)
            {
                ThongBao.CanhCao("Bạn cần nhập thông tin mô tả");
            }else
            {
                string ts = gy.Recommend(txt_mota.Text);
                try
                {
                    if (ts !=null)
                    {
                    
                            SachHinhAnh_dto sgy = s_bll.select_Sach_HinhAnh().SingleOrDefault(t => t.TenSach.Equals(ts));
                            if (sgy != null)
                            {
                                Utils.LoadImages(pictureBox1, sgy.TenFileHinh, "Resources\\Image_Book");
                                txt_tensach.Text = sgy.TenSach;
                   
                    
                    }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        txt_tensach.Text = "Không tìm thấy sách phù hợp";
                    }
                }
                catch(Exception ex)
                {
                    pictureBox1.Image = null;
                    txt_tensach.Text = "Không tìm thấy sách phù hợp";
                }
            }    
           
        }


        private void GoiYSachTheoNoiDung_Load(object sender, EventArgs e)
        {

        }

        private void btn_GoiY_Click(object sender, EventArgs e)
        {
            goiy();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_mota.Text = "";
            txt_tensach.Text = "";
            pictureBox1.Image = null;
        }
    }
}
