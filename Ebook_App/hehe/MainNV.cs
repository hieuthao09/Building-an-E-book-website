using dto;
using LibCustomWinform;
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
    public partial class MainNV : Form
    {
        public MainNV()
        {
            InitializeComponent();
        }
        static public NhanVien_dto nhanvien = new NhanVien_dto();
        Form f;

        private void Thongtincanhan_Click(object sender, EventArgs e)
        {
            f = new ThongTinCaNhan();
            ThongTinCaNhan.nhanvien = nhanvien;
            ThongTinCaNhan.hide = false;
            ThongTinCaNhan.them = false;
            LibDashboard.loadFormInsidePanel(pnl_main, f);

        }

        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            f = new DoiMatKhau();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void Tintuc_Click(object sender, EventArgs e)
        {
            f = new TinTuc();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }
       
        private void Khachhang_Click(object sender, EventArgs e)
        {
            f = new KhachHang();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void DonHang_Click(object sender, EventArgs e)
        {
            f = new DonHang();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            f = new Sach();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.login.Visible = true;
            Program.login.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            f = new GoiYSachTheoNoiDung();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void MainNV_Load(object sender, EventArgs e)
        {
            f = new Dashboard();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }
    }
}
