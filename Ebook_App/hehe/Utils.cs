using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public class Utils
    {
        static public void loadCbb(GridLookUpEdit cbb, List<Object> list, string display, string value)
        {
            cbb.Properties.DataSource = list;
            cbb.Properties.DisplayMember = display;
            cbb.Properties.ValueMember = value;

        }
        static public void loadGridView(GridControl gr, List<Object> list)
        {
            gr.DataSource = list;
        }
        static public void LoadImages(PictureBox pc, string anh, string path)
        {
            string resourcesFolderPath = Path.Combine(Application.StartupPath, path);
            string imagePath = Path.Combine(resourcesFolderPath, anh);
            pc.Image = Image.FromFile(imagePath);
            pc.SizeMode = PictureBoxSizeMode.Zoom;
            pc.Size = new Size(500, 500);
        }
        static public string taianh(PictureBox pc, string path)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Lấy đường dẫn tệp hình ảnh được chọn
                        string imagePath = openFileDialog.FileName;

                        // Đọc hình ảnh từ đường dẫn tệp
                        Image selectedImage = Image.FromFile(imagePath);
                        string nameImage = Path.GetFileName(imagePath);
                        // Lưu hình ảnh vào thư mục "Resources"
                        string destinationPath = Path.Combine(Application.StartupPath, path, nameImage);
                       
                            selectedImage.Save(destinationPath);
                            Utils.LoadImages(pc, nameImage, path);
                            ThongBao.ThongBaoThongTin("Tải thành công");
                            return nameImage;

                       

                    }
                    catch (Exception ex)
                    {
                        ThongBao.Loi($"Lỗi: {ex.Message}"); 
                        return null;
                    }
                }
                return null;
            }
        }
        public static void ExportToExcel(string filePath, GridView gridView)
        {
            // Tạo đối tượng XlsxExportOptions để cấu hình xuất Excel
            XlsxExportOptions options = new XlsxExportOptions();

            // Thiết lập đường dẫn tệp Excel
            options.ExportMode = XlsxExportMode.SingleFile;
            options.SheetName = "Sheet1"; // Tên sheet trong Excel

            // Xuất dữ liệu từ GridView sang tệp Excel
            gridView.ExportToXlsx(filePath, options);

            // Mở tệp Excel sau khi xuất
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
