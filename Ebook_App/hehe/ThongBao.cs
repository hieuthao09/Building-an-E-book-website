using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehe
{
    public class ThongBao
    {
        static public void CanhCao(string message)
        {
            // Hiển thị hộp thoại thông báo cảnh báo
            XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        static public void ThongBaoThongTin(string message)
        {
            // Hiển thị hộp thoại thông báo thông tin
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static public void Loi(string message)
        {
            // Hiển thị hộp thoại thông báo Lỗi
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static public bool CauHoi(string message)
        {
            DialogResult result = XtraMessageBox.Show(message, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
