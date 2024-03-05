using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignControl
{
    public class txtNhapChu : DevExpress.XtraEditors.TextEdit
    {
        DXErrorProvider errorProvider;
        public txtNhapChu() {
            errorProvider = new DXErrorProvider();
            this.KeyPress += TxtNhapChu_KeyPress;
        }

        private void TxtNhapChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                errorProvider.SetError(this, "Bạn chỉ được nhập chữ vào đây", ErrorType.Warning);
            }
        }
    }
}
