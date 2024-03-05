using bll;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pnl_login.BackColor = Color.FromArgb(230, 255, 255, 255);
            string username = String.Empty;
            string password = String.Empty;
            if (nv_Bll.LoadLoginCredentials(ref username, ref password))
            {
                if (!username.Equals("0") && !password.Equals("0"))
                {
                    txtTenDangNhap1.Text = username;
                    txt_MatKhau.Text = password;
                }
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }
        NhanVien_bll nv_Bll = new NhanVien_bll();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = String.Empty;
            string password = String.Empty;
            if(nv_Bll.LoadLoginCredentials(ref username, ref password))
            {
                if(!username.Equals("0") && !password.Equals("0") && DoiMatKhau.dmk)
                {
                    if(username.Equals(txtTenDangNhap1.Text))
                    {
                        txtTenDangNhap1.Text = username;
                        txt_MatKhau.Text = password;
                        thoadkmk = true;
                        txtTenDangNhap1.thoadk = true;
                    }
                }
                else
                {
                    if (username.Equals(txtTenDangNhap1.Text))
                    {
                        txtTenDangNhap1.Text = username;
                        thoadkmk = true;
                        txtTenDangNhap1.thoadk = true;
                    }
                }
            }
            if (thoadkmk = true  && txtTenDangNhap1.thoadk == true)
            {
               
                int chucvu = ckb_DangNhapQuanLy.Checked ? 1 : 0;
                int kq = nv_Bll.isCheckLogin(txtTenDangNhap1.Text, txt_MatKhau.Text,  chucvu);
                if (kq  == 1)
                {
                    if(chucvu ==1)
                    {
                        if (ckb_luudangnhap.Checked)
                        {
                            nv_Bll.SaveLoginCredentials(txtTenDangNhap1.Text, txt_MatKhau.Text);
                        }
                        NhanVien_dto nv = nv_Bll.select_Usename(txtTenDangNhap1.Text);
                        if (nv != null)
                        {
                            TrangChu.nhanvien = nv;
                            DoiMatKhau.dmk = false;
                            Program.main = new TrangChu();
                            Program.main.Visible = true;
                            this.Visible = false;
                        }
                    }
                    else
                    {

                        if (ckb_luudangnhap.Checked)
                        {
                            nv_Bll.SaveLoginCredentials(txtTenDangNhap1.Text, txt_MatKhau.Text);
                        }
                        NhanVien_dto nv = nv_Bll.select_Usename(txtTenDangNhap1.Text);
                        if (nv != null)
                        {
                            MainNV.nhanvien = nv;
                            Program.main_nv = new MainNV();
                            Program.main_nv.Visible = true;
                            this.Visible = false;
                        }
                    }  
                    
                   
                }
                else
                {
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Tài khoản không tồn tại","Confirmation", MessageBoxButtons.OK);
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu của bạn chưa đúng", "Confirmation", MessageBoxButtons.OK);
                    }
                }
            }
           

        }

        private void txt_MatKhau_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string tagAction = txt_MatKhau.Tag.ToString();
            if (tagAction == "hide")
            {
                txt_MatKhau.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                txt_MatKhau.Tag = "show";
                txt_MatKhau.Properties.UseSystemPasswordChar = false;

            }
            else
            {
                txt_MatKhau.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                txt_MatKhau.Tag = "hide";
                txt_MatKhau.Properties.UseSystemPasswordChar = true;
            }
        }
        Boolean thoadkmk = false;
        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text.Length >= 3 && txt_MatKhau.Text.Count(c => char.IsLetterOrDigit(c)) > 0 && txt_MatKhau.Text.Count(c => char.IsUpper(c)) > 0)
            {
                dxErrorProvider1.ClearErrors();
                thoadkmk = true;
            }
            else
            {
                dxErrorProvider1.SetError(txt_MatKhau, "Mật khẩu phải có độ dài lớn hơn 6 và không chứa ký tự đặt biệt", ErrorType.Critical);
                thoadkmk = false;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau f = new QuenMatKhau();
            f.ShowDialog();
        }
    }
}
