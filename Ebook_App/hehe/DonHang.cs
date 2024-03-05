using bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace hehe
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();

            
        }
        Sach_DonHang_bll s_dh_bll = new Sach_DonHang_bll();
        private void DonHang_Load(object sender, EventArgs e)
        {
            gc_donhang.DataSource = s_dh_bll.select().Where(t => t.NgayDat.Equals(cbb_ThoiGian.EditValue));
        }

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_donhang.DataSource = s_dh_bll.select().Where(t => t.NgayDat.Equals(cbb_ThoiGian.EditValue));
        }

        private void btn_Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utils.ExportToExcel("D:\\DanhSachDonHang.xlsx", gridView2);
        }

        private void cbb_ThoiGian_EditValueChanged(object sender, EventArgs e)
        {
            gc_donhang.DataSource = s_dh_bll.select().Where(t => t.NgayDat.Equals(cbb_ThoiGian.EditValue));
        }
    }
}
