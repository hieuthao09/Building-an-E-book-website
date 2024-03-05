using bll;
using DevExpress.CodeParser.VB.Preprocessor;
using DevExpress.XtraPrinting.Native.Properties;
using dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            InitializeTimer();
          
        }
        static public Boolean qmk = false;
        NhanVien_bll nv_bll = new NhanVien_bll();
        NhanVien_dto nv = TrangChu.nhanvien;
        static public Boolean dmk = false; 
        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if( txt_matkhaumoi.Text.Equals(txt_matkhaunhaplai.Text))
            {
                 int kq = nv_bll.isCheckLogin(nv.UserName, txt_matkhaucu.Text, nv.MaCV.Contains("CV2310001")? 1: 0 );
                if (kq  == 1)
                    
                {
                    if(myObject.otpCode.Equals(txt_OTP.Text))
                    {
                        nv.MatKhau = txt_matkhaumoi.Text;
                        if (nv_bll.update_DoiMatKhau(nv) == 1)
                        {
                            ThongBao.ThongBaoThongTin("Đổi mật khẩu thành công");
                            if(Program.main != null)
                            {
                                Program.main.Visible = false;
                                DoiMatKhau.dmk = true;
                                Program.login.Visible = true;
                            }
                            else
                            {
                                Program.main_nv.Visible = false;
                                DoiMatKhau.dmk = true;
                                Program.login.Visible = true;
                            }
                          
                        }
                    }
                    else
                    {
                        nv.MatKhau = txt_matkhaumoi.Text;
                        ThongBao.CanhCao("Mã OTP chưa chính xác.");
                    }  
                    

                    }
                }
        }
        private void InitializeTimer()
        {
            timer_OTP.Interval = 1000; // Đặt interval là 1 giây
            timer_OTP.Tick += timer_OTP_Tick;
        }
        private int remainingTimeInSeconds = 60; // Thời gian đếm ngược ban đầu là 60 giây
        private void timer_OTP_Tick(object sender, EventArgs e)
        {
            remainingTimeInSeconds--;

            if (remainingTimeInSeconds >= 0)
            {
                // Hiển thị thời gian đếm ngược trong một Label (hoặc nơi khác)
                btn_guiOTP.Text = TimeSpan.FromSeconds(remainingTimeInSeconds).ToString(@"mm\:ss");
            }
            else
            {
                // Đã hết thời gian đếm ngược, thực hiện các hành động cần thiết ở đây
                timer_OTP.Stop();
                MessageBox.Show("Đã hết thời gian đếm ngược!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        CallAPI aPI = new CallAPI();
        Object OTP = "";
        async void GuiPT()
        {
            string urlapi = $"/api/Util/sendOTPToMail?toEmail={nv.Email}";
             OTP = await aPI.GetApiDataAsync(urlapi);
        }
        OTPEmail myObject;
        private void btn_guiOTP_ClickAsync(object sender, EventArgs e)
        {
                GuiPT();
                     myObject = (OTPEmail)OTP;
                    long totalSeconds = myObject.ExpiresTime;
                    TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
                    TimeSpan t = timeSpan - DateTime.Now.TimeOfDay;
                    remainingTimeInSeconds = (int)t.TotalSeconds;
                    timer_OTP.Start();
            
           
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_matkhaucu_Properties_Click(object sender, EventArgs e)
        {
            string tagAction = txt_matkhaucu.Tag.ToString();
            if (tagAction == "hide")
            {
                txt_matkhaucu.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[1];
                txt_matkhaucu.Properties.UseSystemPasswordChar = false;
                txt_matkhaucu.Properties.PasswordChar = '\0' ;
                txt_matkhaucu.Tag = "show";
            }
            else
            {
                txt_matkhaucu.Properties.Buttons[0].ImageOptions.Image = imageCollection1.Images[0];
                txt_matkhaucu.Properties.UseSystemPasswordChar = true;
                txt_matkhaucu.Properties.PasswordChar = '*';
                txt_matkhaucu.Tag = "hide";
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

        private void txt_matkhaunhaplai_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
