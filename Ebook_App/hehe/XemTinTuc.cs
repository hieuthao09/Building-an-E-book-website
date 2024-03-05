using bll;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using dto;
using hehe.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public partial class XemTinTuc : Form
    {
        static public TinTuc_dto tt = new TinTuc_dto();
        public XemTinTuc()
        {
            InitializeComponent();
            txt_MaTT.ReadOnly = true;
        }
      
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if(!hide)
            {
                if (ThongBao.CauHoi("Bạn có muốn lưu không"))
                {
                    btn_Luu_Click(sender, e);
                }
                this.Visible = false;
                this.Close();
                tt = null;
            }
            else
            {
                if (ThongBao.CauHoi("Bạn có chắc chắn thoát không?"))
                {
                    this.Visible = false;
                    this.Close();
                    tt = null;
                }
                
            }
           
        }
        NhanVien_bll nv_bll = new NhanVien_bll();
        NhomTin_bll nt_bll = new NhomTin_bll();
        TinTuc_bll tt_bll = new TinTuc_bll();
        public static bool hide;

        void loadTT()
        {
            txt_MaTT.Text = tt.MaTT;
            txt_MoTa.Text = tt.MoTa;
            dt_date.DateTime = tt.ThoiGian;
            txt_TieuDe.Text = tt.TieuDe;
            string[] NoiDungTT = tt.NoiDungTT.Split(new string[] { "\\n" }, StringSplitOptions.None);
            memo_NoiDung.Lines = NoiDungTT;
            ck_hienthi.Checked = false;
            cb_khienthi.Checked = false;
            if (tt.TinhTrang)
            {
                ck_hienthi.Checked = true;
            }else
            {
                cb_khienthi.Checked = true;
            }

            Utils.loadCbb(cbb_NT, nt_bll.select().ToList<Object>(),  "TenNT","MaNT");
            Utils.loadCbb(cbb_NV, nv_bll.select_MaNV_TenNV().ToList<Object>(), "TenNV", "MaNV");
        }
        bool LayTT()
        {
            try
            {
                tt.MaTT = txt_MaTT.Text;
                tt.MoTa = txt_MoTa.Text;
                tt.ThoiGian = dt_date.DateTime;
                tt.TieuDe = txt_TieuDe.Text;
                tt.NoiDungTT = memo_NoiDung.Text;
                if (ck_hienthi.Checked)
                {
                    tt.TinhTrang = true;
                }
                else
                {
                    tt.TinhTrang = false;
                }
                tt.MaNT = cbb_NT.EditValue.ToString();
                tt.MaNV = cbb_NV.EditValue.ToString();
                return true;
            }catch (Exception ex) { return false; }
            
        }
        private void XemTinTuc_Load(object sender, EventArgs e)
        {
            if(!hide)
            {
                Utils.loadCbb(cbb_NT, nt_bll.select().ToList<Object>(), "TenNT", "MaNT");
                Utils.loadCbb(cbb_NV, nv_bll.select_MaNV_TenNV().ToList<Object>(), "TenNV", "MaNV");
                txt_MaTT.ReadOnly = false;
                cbb_NT.EditValue = tt.MaNT;
                cbb_NV.EditValue = tt.MaNV;
            }
            else
            {
                loadTT();
                LoadImages(tt.HinhAnh);
                cbb_NT.EditValue = tt.MaNT;
                cbb_NV.EditValue = tt.MaNV;
            }
           
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (LayTT())
            {
                TinTuc_dto tintuc = tt_bll.select().FirstOrDefault(t => t.MaTT == txt_MaTT.Text);
                if(tintuc != null)
                {
                    if (tt_bll.update(tt) == 1)
                    {

                        ThongBao.ThongBaoThongTin("Cập nhật thành công");


                    }
                    else
                        ThongBao.Loi("Cập nhật thất bại");
                }
                else
                {
                    if (tt_bll.insert(tt) == 1)
                    {

                        ThongBao.ThongBaoThongTin("Thêm thành công");


                    }
                    else
                        ThongBao.Loi("Thêm thất bại");
                }
                
            }
        }
        private void LoadImages(string anh)
        {
            string resourcesFolderPath = Path.Combine(Application.StartupPath, "Resources");
            string imagePath = Path.Combine(resourcesFolderPath,anh);

            picture_NT.Image = Image.FromFile(imagePath);// Thay thế đường dẫn và tên hình ảnh thực tế
            picture_NT.SizeMode = PictureBoxSizeMode.Zoom; // Thiết lập chế độ hiển thị hình ảnh
            picture_NT.Size = new Size(500, 500); // Thiết lập kích thước
        }
        private void cbb_NT_Properties_Popup(object sender, EventArgs e)
        {
            if (cbb_NT.EditValue != null)
                cbb_NT.Properties.View.FocusedRowHandle = 0;
        }

        private void cbb_NV_Properties_Popup(object sender, EventArgs e)
        {
            if (cbb_NV.EditValue != null)
                cbb_NV.Properties.View.FocusedRowHandle = 0;
        }

        private void btn_taihinhanh_Click(object sender, EventArgs e)
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
                        string destinationPath = Path.Combine(Application.StartupPath, "Resources", nameImage);
                        selectedImage.Save(destinationPath);
                        LoadImages(nameImage);
                        tt.HinhAnh = nameImage;
                        ThongBao.ThongBaoThongTin("Tải thành công");
                    }
                    catch (Exception ex)
                    {
                        ThongBao.Loi($"Lỗi: {ex.Message}");
                    }
                }
            }
        }

        private void XemTinTuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ck_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(ck_hienthi.Checked)
            {
                cb_khienthi.Checked = false;
            }
           
        }

        private void cb_khienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_khienthi.Checked)
            {
                ck_hienthi.Checked = false;
            }
        }
    }
}
