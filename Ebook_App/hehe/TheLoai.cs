using bll;
using DevExpress.XtraGrid.Columns;
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
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (ThongBao.CauHoi("Bạn có muốn thoát không"))
            {
                this.Close();
            }
        }
        TheLoai_bll tl_bll = new TheLoai_bll();
        TheLoai_dto tl = new TheLoai_dto();
        bool layTT()
        {
            tl.MaTL = "TL" + DateTime.Now.Year.ToString().Substring(2) + (tl_bll.select().Count() + 1).ToString();
            if (txt_tentl.Text == string.Empty || txt_tentl.Text == "")
                return false;
            else
            {
                tl.TenTL = txt_tentl.Text;
            }
            return true;
        }
        List<TheLoai_dto> dstl = new List<TheLoai_dto>();
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (layTT())
            {
                if (rdo_Them.Checked)
                {
                    if (tl_bll.insert(tl) == 1)
                    {
                        gc_theloai.DataSource = tl_bll.select();
                        ThongBao.ThongBaoThongTin("Thêm thành công");
                    }
                    else
                    {
                        ThongBao.CanhCao("Thất bại");
                    }

                }
                else
                {
                    if (tl_bll.update(tl) == 2)
                    {
                        gc_theloai.DataSource = tl_bll.select();
                        ThongBao.ThongBaoThongTin("Thêm thành công");
                    }
                    else
                    {
                        ThongBao.CanhCao("Thất bại");
                    }
                }

            }
            else
            {
                ThongBao.CanhCao("Bạn chưa nhập tên thể loại");
            }

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            GridColumn gridColumn = gridView1.FocusedColumn;
            txt_matl.Text = gridView1.GetRowCellValue(rowIndex, "MaTL").ToString();
            txt_tentl.Text = gridView1.GetRowCellValue(rowIndex, "TenTL").ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            GridColumn gridColumn = gridView1.FocusedColumn;
            txt_matl.Text = gridView1.GetRowCellValue(rowIndex, "MaTL").ToString();
            txt_tentl.Text = gridView1.GetRowCellValue(rowIndex, "TenTL").ToString();
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            gc_theloai.DataSource = tl_bll.select();
            dstl = tl_bll.select();
        }

        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (txt_matl.Text != null)
            {

                if (tl_bll.delete(txt_matl.Text) == 1)
                {
                    gc_theloai.DataSource = tl_bll.select();
                    ThongBao.ThongBaoThongTin("Xóa thành công");
                }
                else
                {
                    ThongBao.CanhCao("Thất bại");
                }
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            GridColumn gridColumn = gridView1.FocusedColumn;
            txt_matl.Text = gridView1.GetRowCellValue(rowIndex, "MaTL").ToString();
            txt_tentl.Text = gridView1.GetRowCellValue(rowIndex, "TenTL").ToString();
        }
    }
}
