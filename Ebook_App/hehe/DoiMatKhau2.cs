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
    public partial class DoiMatKhau2 : Form
    {
        public DoiMatKhau2()
        {
            InitializeComponent();
        }

        private void txt_matkhaunhaplai_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void txt_matkhaunhaplai_Properties_Click(object sender, EventArgs e)
        {
            string tagAction = txt_matkhaunhaplai.Tag.ToString();
            if (tagAction == "hide")
            {
                txt_matkhaunhaplai.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                txt_matkhaunhaplai.Properties.UseSystemPasswordChar = false;
                txt_matkhaunhaplai.Properties.PasswordChar = '\0';
                txt_matkhaunhaplai.Tag = "show";
            }
            else
            {
                txt_matkhaunhaplai.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                txt_matkhaunhaplai.Properties.UseSystemPasswordChar = true;
                txt_matkhaunhaplai.Properties.PasswordChar = '*';
                txt_matkhaunhaplai.Tag = "hide";
            }
        }

        private void txt_matkhaumoi_Properties_Click(object sender, EventArgs e)
        {
            string tagAction = txt_matkhaumoi.Tag.ToString();
            if (tagAction == "hide")
            {
                txt_matkhaumoi.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                txt_matkhaumoi.Properties.UseSystemPasswordChar = false;
                txt_matkhaumoi.Properties.PasswordChar = '\0';
                txt_matkhaumoi.Tag = "show";
            }
            else
            {
                txt_matkhaumoi.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                txt_matkhaumoi.Properties.UseSystemPasswordChar = true;
                txt_matkhaumoi.Properties.PasswordChar = '*';
                txt_matkhaumoi.Tag = "hide";
            }
        }
        NhanVien_bll nv_bll = new NhanVien_bll();
        static public NhanVien_dto nv;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txt_matkhaumoi.Text.Equals(txt_matkhaunhaplai.Text))
            {
                if(nv.Email!=null)
                {
                    nv.MatKhau = txt_matkhaumoi.Text;

                    if (nv_bll.update_DoiMatKhau(nv) == 1)
                    {
                        ThongBao.ThongBaoThongTin("Đổi mật khẩu thành công");
                        Program.login.Visible = true;
                        Program.login.Visible = true;
                    }
                }    
                
                     

            }
            else
            {
                ThongBao.CanhCao("Bạn nhập 2 mật khẩu chưa khớp");
            }
        }

        private void DoiMatKhau2_Load(object sender, EventArgs e)
        {

        }
    }
}
