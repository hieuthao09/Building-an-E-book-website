using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bll;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using dto;

namespace hehe
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        NhanVien_bll nv_bll = new NhanVien_bll();
        ChucVu_bll cv_bll = new ChucVu_bll();
        void loadCBCV()
        {

            List<ChucVu_dto> dscv = cv_bll.select();
            foreach (ChucVu_dto t in dscv)
            {

                // Thêm BarButtonItem vào RibbonPageGroup
                BarButtonItem barButtonItem1 = new BarButtonItem();
                barButtonItem1.Caption = t.TenCV;
                barButtonItem1.Name = t.MaCV;
                barButtonItem1.ItemClick += BarButtonItem1_ItemClick;
                this.NTT.ItemLinks.Add(barButtonItem1);
            }
        }
        string cvhientai = "";
        private void BarButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadTT(e.Item.Name);
            cvhientai = e.Item.Name;
        }
        void loadTT(string macv)
        {
            loaddsSach(nv_bll.select_MaCV(macv));

        }
        void loaddsSach(List<NhanVien_dto> dss)
        {
            foreach (var item in dss)
            {
                if (item.HinhAnh != null)
                {
                    string resourcesFolderPath = Path.Combine(Application.StartupPath, "Resources");
                    string imagePath = Path.Combine(resourcesFolderPath, item.HinhAnh);
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
                                item.AnhNV = resizedImage;
                            }
                        }
                        catch
                        {


                        }
                    }
                }

            }
            gc_NV.DataSource = dss;

        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            
            loadCBCV();
            loaddsSach(nv_bll.select());

        }

        private void btn_Xem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue = gridView1.GetRowCellValue(rowIndex, gridColumn);
                if (cellValue != null)
                {
                    NhanVien_dto nv  = nv_bll.select().FirstOrDefault(t => t.MaNV.Equals(cellValue.ToString()));
                    ThongTinCaNhan.nhanvien = nv;
                    ThongTinCaNhan f = new ThongTinCaNhan();
                    ThongTinCaNhan.hide = true;
                    f.Visible= true;
                    f.ShowDialog();
                    loaddsSach(nv_bll.select());

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

        private void btn_ThemNT_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadCBCV();
            loaddsSach(nv_bll.select());
        }

        private void btn_TaiLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            loaddsSach(nv_bll.select());
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinCaNhan.them = true;
            ThongTinCaNhan.hide = false;
            ThongTinCaNhan f = new ThongTinCaNhan();
            f.ShowDialog();
        }

        private void btn_chinhsuacv_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            ThemChucVu f = new ThemChucVu();
            f.ShowDialog();
        }

        private void btn_XoaTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                int rowIndex = gridView1.FocusedRowHandle;
                GridColumn gridColumn = gridView1.FocusedColumn;
                object cellValue = gridView1.GetRowCellValue(rowIndex, "MaNV");
                if(cellValue != null)
                {
                    string manv = cellValue.ToString();
                    if (nv_bll.delete(manv)==1)
                    {
                        loaddsSach(nv_bll.select());
                        ThongBao.ThongBaoThongTin("Cập nhật thành công");
                    }
                    else
                        ThongBao.Loi("Cập nhật thất bại");
                }    
                
            }
            else
            {
                ThongBao.ThongBaoThongTin("Không chọn được hàng nào");
            }
        }
    }
}
