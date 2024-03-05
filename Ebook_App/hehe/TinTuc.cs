using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bll;
using DevExpress.PivotGrid.DataBinding;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using dto;

namespace hehe
{
    public partial class TinTuc : Form
    {
        public TinTuc()
        {
            InitializeComponent();
        }
        TinTuc_bll tt_bll = new TinTuc_bll();
        NhomTin_bll nt_bll = new NhomTin_bll();
        void loadCBNT()
        {
            this.NTT.ItemLinks.Clear();
            List<NhomTin_dto> dsnt = nt_bll.select();
            foreach (NhomTin_dto t in dsnt)
            {

                // Thêm BarButtonItem vào RibbonPageGroup
                BarButtonItem barButtonItem1 = new BarButtonItem();
                barButtonItem1.Caption = t.TenNT;
                barButtonItem1.Name = t.MaNT;
                barButtonItem1.ItemClick += BarButtonItem1_ItemClick;
                this.NTT.ItemLinks.Add(barButtonItem1);
            }    
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadTT(e.Item.Name);
        }
        private void initGridView()
        {
            GridColumn checkBoxColumn = gridView1.Columns["TinhTrang"];
            RepositoryItemCheckEdit riCheckEdit = new RepositoryItemCheckEdit();
            gc_TT.RepositoryItems.Add(riCheckEdit);
            gridView1.Columns["TinhTrang"].ColumnEdit = riCheckEdit;
            checkBoxColumn.ColumnEdit = riCheckEdit; // Gán RepositoryItemCheckEdit
            riCheckEdit.ValueChecked = true;
            checkBoxColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            checkBoxColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
        }
        void loadTT(string mant)
        {
            gc_TT.DataSource = tt_bll.select_NT(mant);
            
        }
        private void TinTuc_Load(object sender, EventArgs e)
        {
            loadCBNT();
            loadTT(nt_bll.select()[0].MaNT);

        }

        private void btn_Xem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue = gridView1.GetRowCellValue(rowIndex, "MaTT");
                if(cellValue != null)
                {
                    TinTuc_dto tinTuc = tt_bll.select().FirstOrDefault(t => t.MaTT.Equals(cellValue.ToString()));
                    XemTinTuc.hide = true;
                    XemTinTuc.tt = tinTuc;
                    XemTinTuc xemTinTuc = new XemTinTuc();
                    xemTinTuc.Visible = true;
                    xemTinTuc.Show();
                }
                else
                {
                   
                }
               
            }
            else
            {
                ThongBao.ThongBaoThongTin("Không chọn được hàng nào");
            }
        }

        private void btnchinhsua_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
           XemTinTuc.hide = false;
           XemTinTuc f = new XemTinTuc();           
           f.Show();
        }

        private void btn_XoaTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue = gridView1.GetRowCellValue(rowIndex, gridColumn);
                if (ThongBao.CauHoi("Bạn chắn chắn muốn xóa tin tức" + cellValue.ToString() + " này chứ?"))
                {
                    if(tt_bll.delete(cellValue.ToString())==1)
                    {
                        loadTT(nt_bll.select()[0].MaNT);
                        ThongBao.ThongBaoThongTin("Cập nhật thành công");
                    }
                    else
                        ThongBao.Loi("Cập nhật thất bại");
                }
         }
        }

        private void btn_TaiLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadCBNT();
            loadTT(nt_bll.select()[0].MaNT);
        }

        private void Duyet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue1 = gridView1.GetRowCellValue(rowIndex, "MaTT");
                object cellValue2 = gridView1.GetRowCellValue(rowIndex, "TinhTrang");
                    if (tt_bll.update_tinhtrang(cellValue1.ToString(), (bool) cellValue2 ) == 1)
                    {
                        loadTT(cellValue1.ToString());
                        ThongBao.ThongBaoThongTin("Cập nhật thành công");
                    }
                    else
                        ThongBao.Loi("Cập nhật thất bại");
            }
        }
    }
}
