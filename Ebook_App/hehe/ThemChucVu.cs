using bll;
using DesignControl;
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
    public partial class ThemChucVu : Form
    {
        public ThemChucVu()
        {
            InitializeComponent();
        }

        ChucVu_bll cv_bll   =   new ChucVu_bll();
        void loadTT()
        {
           
            foreach(ChucVu_dto obj in cv_bll.select())
            {
                cbb_ChucVu.Properties.Items.Add(obj.MaCV);
              
            }
            cbb_ChucVu.SelectedIndex = 0;
            txt_MaNT.Text = cv_bll.select().SingleOrDefault(t=>t.MaCV.Equals(cbb_ChucVu.Text)).TenCV.ToString();

        }
        private void ThemChucVu_Load(object sender, EventArgs e)
        {
            loadTT();
        }

        private void cbb_ChucVu_EditValueChanged(object sender, EventArgs e)
        {
            txt_MaNT.Text = cv_bll.select().SingleOrDefault(t => t.MaCV.Equals(cbb_ChucVu.Text)).TenCV.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if(ThongBao.CauHoi("Bạn có chắc chắn thoát không?"))
            {
                this.Close();
            }    
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            ChucVu_dto cv = cv_bll.select().SingleOrDefault(t => t.MaCV.Equals(cbb_ChucVu.Text)) ;
            if (cv== null) 
            {
                cv = new ChucVu_dto() { MaCV = cbb_ChucVu.Text, TenCV = txt_MaNT.Text };
                cv_bll.insert(cv);
            }
            else
            {
                cv = new ChucVu_dto() { MaCV = cbb_ChucVu.Text, TenCV = txt_MaNT.Text };
                cv_bll.update(cv);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cv_bll.delete(cbb_ChucVu.Text);
            }
            catch
            {
                ThongBao.Loi("Xóa thất bại");
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
