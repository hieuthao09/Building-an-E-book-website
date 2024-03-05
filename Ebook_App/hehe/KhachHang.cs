using bll;
using DevExpress.XtraEditors;
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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
          
        }
        KhachHang_bll khachHang_bll = new KhachHang_bll();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            gc_kh.DataSource = khachHang_bll.select();
        }

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc_kh.DataSource = khachHang_bll.select();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            object cellValue2 = gridView1.GetRowCellValue(rowIndex, "MaKH");
            if(cellValue2 != null)
            {
                if(khachHang_bll.delete(cellValue2.ToString())==1)
                {
                    ThongBao.ThongBaoThongTin("Cập nhật thành công");
                }
                else
                    ThongBao.Loi("Cập nhật thất bại");
            }
        }

        private void btn_Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utils.ExportToExcel("D:\\DSKhachHang.xlsx", gridView1);
        }
    }
}
