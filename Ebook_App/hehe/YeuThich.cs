using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using bll;

namespace hehe
{
    public partial class YeuThich : Form
    {
        public YeuThich()
        {
            InitializeComponent();
            
        }
        YeuThich_bll yt_bll = new YeuThich_bll();
        void load()
        {
            gc_yeuthich.DataSource = yt_bll.select();


        }

      

        private void YeuThich_Load(object sender, EventArgs e)
        {
            load();
        }
    }
    
}
