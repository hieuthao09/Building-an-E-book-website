using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DevExpress;
using DevExpress.DataAccess.Native.Sql.MasterDetail;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
namespace DesignControl
{
    public class ButtonMatKhau : DevExpress.XtraEditors.ButtonEdit
    {
        DXErrorProvider errorProvider;
        public ImageCollection imageCollection = new ImageCollection();
        public ButtonMatKhau(ImageCollection ic)
        {
            errorProvider = new DXErrorProvider();
            this.Leave += TxtMatKhau_Leave;
            this.Properties.PasswordChar = '*';
            
            this.KeyPress += ButtonMatKhau_KeyPress;
            this.Tag = "hide";
            this.Properties.UseSystemPasswordChar = true;
        }
        public ButtonMatKhau()
        {
            errorProvider = new DXErrorProvider();
            this.Leave += TxtMatKhau_Leave;
            this.Properties.PasswordChar = '*';
            this.KeyPress += ButtonMatKhau_KeyPress;
            this.Tag = "hide";
            this.Properties.UseSystemPasswordChar = true;
        }
        private void ButtonMatKhau_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            string tagAction = this.Tag.ToString();
           if(tagAction == "hide")
            {
                this.Properties.Buttons[0].ImageOptions.Image = imageCollection.Images[1];
                this.Tag = "show";
                this.Properties.UseSystemPasswordChar = false;

            }
            else
            {
                this.Properties.Buttons[0].ImageOptions.Image = imageCollection.Images[0];
                this.Tag = "hide";
                this.Properties.UseSystemPasswordChar = true;
            }
        }

        public bool thoadk { get; private set; }

        private void TxtMatKhau_Leave(object sender, EventArgs e)
        {
            if (this.Text.Length >= 6 && this.Text.Count(c => char.IsLetterOrDigit(c)) > 0 && this.Text.Count(c => char.IsUpper(c)) > 0)
            {
                errorProvider.ClearErrors();
                thoadk = true;
            }
            else
            {
                errorProvider.SetError(this, "Mật khẩu phải có độ dài lớn hơn 6 và không chứa ký tự đặt biệt", ErrorType.Critical);
            }
        }

     
    }
}
