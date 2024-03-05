using bll;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class TinTuc : DevExpress.XtraEditors.DirectXForm
    {
        public TinTuc()
        {
            InitializeComponent();
            
        }
        TinTuc_bll tt_bll = new TinTuc_bll();
        NhomTin_bll nt_bll = new NhomTin_bll();
        void loadCBBNT()
        {
            cbb_NhomTinTuc.Properties.DataSource = nt_bll.select();
            cbb_NhomTinTuc.Properties.DisplayMember = "TenNT";
            cbb_NhomTinTuc.Properties.ValueMember = "MaNT";
            cbb_NhomTinTuc.EditValue = 0;

            cbb_NhomTinTuc.Properties.TextEditStyle = TextEditStyles.Standard;
            cbb_NhomTinTuc.Properties.AcceptEditorTextAsNewValue = DefaultBoolean.True;
        }
       void loadDSTinTuc()
        {
            gc_TinTuc.DataSource = tt_bll.select(cbb_NhomTinTuc.EditValue.ToString());
        }

        private void TinTuc_Load(object sender, EventArgs e)
        {
            loadCBBNT();
            loadDSTinTuc();
        }
        private void cbb_NhomTinTuc_EditValueChanged(object sender, EventArgs e)
        {
            loadDSTinTuc();
        }

        private void cbb_NhomTinTuc_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
        {
            if ((string)e.DisplayValue == String.Empty) return;
            List<NhomTin> dataSource = (sender as LookUpEdit).Properties.DataSource as List<NhomTin>;
            dataSource.Add(new NhomTin() { TenNT = (string)e.DisplayValue });
            e.Handled = true;
        }

        private void cbb_NhomTinTuc_Enter(object sender, EventArgs e)
        {
        }
    }
}