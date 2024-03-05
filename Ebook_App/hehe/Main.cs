using DesignControl;
using DevExpress.XtraBars;
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
    public partial class TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        static public NhanVien_dto nhanvien = new NhanVien_dto();
        private void TrangChu_Load(object sender, EventArgs e)
        {
            f = new Dashboard();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }
        Form f;

        private void Tintuc_Click(object sender, EventArgs e)
        {
            f = new TinTuc();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Program.login.Visible = true;
            Program.login.Show();

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void Thongtincanhan_Click(object sender, EventArgs e)
        {
            
            f = new ThongTinCaNhan();
            ThongTinCaNhan.nhanvien = nhanvien;
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void DoiMatKhau_Click(object sender, EventArgs e)
        {
            f = new DoiMatKhau();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void Nhanvien_Click(object sender, EventArgs e)
        {
            f = new NhanVien();
            LibDashboard.loadFormInsidePanel(pnl_main, f);

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            f= new ThongKeDoanhThu();
            LibDashboard.loadFormInsidePanel(pnl_main, f);
        }

        private void phanquyen_Click(object sender, EventArgs e)
        {

        }
    }
}