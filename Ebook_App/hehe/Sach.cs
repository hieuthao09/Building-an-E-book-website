using bll;
using DevExpress.DataAccess.Native.Json;
using DevExpress.Dialogs.Core.Base.Structures;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraLayout;
using DevExpress.XtraRichEdit.Painters;
using dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
           

        }
        void loaddsSach(List<SachHinhAnh_dto> dss)
        {
            foreach (var item in dss)
            {
                if(item.TenFileHinh !=null)
                {
                    string resourcesFolderPath = Path.Combine(Application.StartupPath, "Resources\\Image_Book");
                    string imagePath = Path.Combine(resourcesFolderPath, item.TenFileHinh);
                    // Kiểm tra xem đường dẫn ảnh có tồn tại không
                    if (System.IO.File.Exists(imagePath))
                    {
                        // Vẽ hình ảnh
                        Image resizedImage;
                        try
                        {
                            using (Image image = Image.FromFile(imagePath))
                            {
                                int newWidth = 70;  // Thay đổi kích thước tùy thuộc vào yêu cầu của bạn
                                int newHeight = 80; // Thay đổi kích thước tùy thuộc vào yêu cầu của bạn

                                // Tạo hình ảnh mới với kích thước đã chỉ định
                                resizedImage = new Bitmap(image, newWidth, newHeight);
                                item.HinhAnh = resizedImage;
                            }
                        }
                        catch
                        {


                        }
                    }
                }    
                
            }
            gc_sach.DataSource = dss;

        }
        TheLoai_bll tl_bll = new TheLoai_bll();
        NhaXuatBan_bll nxb_bll = new NhaXuatBan_bll();
        void loadCBTL()
        {
            this.barSubItem_NXB.ItemLinks.Clear();
            List<TheLoai_dto> dsnt = tl_bll.select();
            foreach (TheLoai_dto t in dsnt)
            {

                // Thêm BarButtonItem vào RibbonPageGroup
                BarButtonItem barButtonItem1 = new BarButtonItem();
                barButtonItem1.Caption = t.TenTL;
                barButtonItem1.Name = t.MaTL;
                barButtonItem1.ItemClick += BarButtonItem1_ItemClick;
                this.barSubItemTL.ItemLinks.Add(barButtonItem1);
            }
        }
        string tl = "";
        void loadCBNXB()
        {
            this.barSubItem_NXB.ItemLinks.Clear();
            List<NhaXuatBan_dto> dsnt = nxb_bll.select();
            foreach (NhaXuatBan_dto t in dsnt)
            {

                // Thêm BarButtonItem vào RibbonPageGroup
                BarButtonItem barButtonItem1 = new BarButtonItem();
                barButtonItem1.Caption = t.TenNXB;
                barButtonItem1.Name = t.MaNXB;
                barButtonItem1.ItemClick += BarButtonItem2_ItemClick;
                this.barSubItem_NXB.ItemLinks.Add(barButtonItem1);
            }
        }
        private void BarButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            loaddsSach(sach_Bll.select_Sach_HinhAnh().Where(t => t.MaNXB.Equals(e.Item.Name.ToString())).ToList<SachHinhAnh_dto>());
        }

        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            tl = e.Item.Name.ToString();
            loaddsSach(sach_Bll.select_Sach_HinhAnh().Where(t => t.MaTL.Equals(e.Item.Name.ToString())).ToList<SachHinhAnh_dto>());
        }

        private void btn_TaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadCBTL();
            loadCBNXB();
            tl = this.barSubItemTL.ItemLinks[0].Item.Name;
            loaddsSach(sach_Bll.select_Sach_HinhAnh());
            

        }
        Sach_bll sach_Bll = new Sach_bll();
        HinhAnh_bll ha_bll = new HinhAnh_bll();
        
        private void Sach_Load(object sender, EventArgs e)
        {
            loadCBTL();
            loadCBNXB();
            tl = this.barSubItemTL.ItemLinks[0].Item.Name;
            loaddsSach(sach_Bll.select_Sach_HinhAnh());
        }
        int i = 0;
        private void cardView1_CustomDrawCardCaption(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventArgs e)
        {
            e.CardCaption = "Sách" ;
        }

        

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }
        private void btn_XoaTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue = gridView1.GetRowCellValue(rowIndex, "MaSach");
                object cellValue2 = gridView1.GetRowCellValue(rowIndex, "MaHA");
                if (cellValue != null)
                {
                    string masach = cellValue.ToString();
                    if(ha_bll.delete(cellValue2.ToString())==1)
                     {
                        if (sach_Bll.delete(masach) == 1)
                        {
                            ThongBao.ThongBaoThongTin("Cập nhật thành công");
                        }
                        else
                            ThongBao.Loi("Cập nhật thất bại");
                    }
                    else
                    {
                        ThongBao.Loi("Thêm ảnh thất bại");
                    }
                   
                }

            }
            else
            {
                ThongBao.ThongBaoThongTin("Không chọn được hàng nào");
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemSach f = new ThemSach();
            f.ShowDialog();
        }

        private void btn_chinhsuacv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TheLoai f = new TheLoai();
            f.ShowDialog();
        }

        private void btn_Export_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utils.ExportToExcel("D:\\Sach.xlsx", gridView1);

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Utils.ExportToExcel("D:\\Sach.xlsx", gridView1);
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int rowIndex = gridView1.FocusedRowHandle;
            object cellValue2 = gridView1.GetRowCellValue(rowIndex, "MaSach");
            SachHinhAnh_dto shaa = sach_Bll.select_Sach_HinhAnh().SingleOrDefault(t => t.MaSach.Equals(cellValue2.ToString()));
            ThemSach.sha = shaa;
            ThemSach f = new ThemSach();
            f.ShowDialog();
        }

        private void YeuThich_ItemClick(object sender, ItemClickEventArgs e)
        {
            YeuThich f = new YeuThich();
            f.ShowDialog();
        }
    }
}
