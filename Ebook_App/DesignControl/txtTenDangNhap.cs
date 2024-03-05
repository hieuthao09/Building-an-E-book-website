using DevExpress.Drawing.Internal.Fonts.Interop;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignControl
{
    public class txtTenDangNhap : DevExpress.XtraEditors.TextEdit
    {
        DXErrorProvider errorProvider;

        public txtTenDangNhap()
        {
            this.Leave += TxtTenDangNhap_Leave;
            errorProvider = new DXErrorProvider();
        }

        public bool thoadk { get;  set; }

        private void TxtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                errorProvider.ClearErrors();
                thoadk = true;
            }
            else
            {
                errorProvider.SetError(this, "Bạn cần nhập tên đăng nhập", ErrorType.Critical);
            }
        }
    }
}
