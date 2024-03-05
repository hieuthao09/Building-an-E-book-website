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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer_OTP.Interval = 1000; // Đặt interval là 1 giây
            timer_OTP.Tick += timer_OTP_Tick;
        }
        private int remainingTimeInSeconds = 60;
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
        static public NhanVien_dto nv;
        async void GuiPT()
        {
            nv = nv_bll.select().Single(t => t.Email.Equals(txt_Email.Text));
            if(nv != null)
            {
                string urlapi = $"/api/Util/sendOTPToMail?toEmail={nv.Email}";
                OTP = await aPI.GetApiDataAsync(urlapi);
            }
          
        }
        OTPEmail myObject;
        private void btn_guiOTP_Click(object sender, EventArgs e)
        {
            GuiPT();
            if(nv == null)
            {
                ThongBao.CanhCao("Email này chưa được tạo tài khoản");
            }
            else
            {
                myObject = (OTPEmail)OTP;
                long totalSeconds = myObject.ExpiresTime;
                TimeSpan timeSpan = TimeSpan.FromSeconds(totalSeconds);
                TimeSpan t = timeSpan - DateTime.Now.TimeOfDay;
                remainingTimeInSeconds = (int)t.TotalSeconds;
                timer_OTP.Start();
            }
            
        }
        NhanVien_bll nv_bll = new NhanVien_bll();
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
                if (myObject.otpCode.Equals(txt_OTP.Text))
                {
                    if (nv != null)
                    {
                        this.Close();
                        DoiMatKhau2.nv = nv;
                        DoiMatKhau2 f = new DoiMatKhau2();
                        f.ShowDialog();
                    
                    }    
                }
                else
                {
                   
                    ThongBao.CanhCao("Mã OTP chưa chính xác.");
                } 
        }
    }
    
}
