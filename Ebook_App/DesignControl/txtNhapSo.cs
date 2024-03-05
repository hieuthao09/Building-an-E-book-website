using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignControl
{
    public class txtNhapSo : DevExpress.XtraEditors.TextEdit
    {
        DXErrorProvider errorProvider;
        public txtNhapSo() {
            errorProvider = new DXErrorProvider();
            this.KeyPress += TxtNhapSo_KeyPress;
        }

        private void TxtNhapSo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                errorProvider.SetError(this, "Bạn chỉ được nhập số vào đây", ErrorType.Warning);
            }
        }
    }
}
