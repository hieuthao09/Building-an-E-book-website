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
    public partial class Chart_thongke : Form
    {
        public Chart_thongke()
        {
            InitializeComponent();
            
        }
        static public decimal thang;

        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            if(ThongBao.CauHoi("Bạn chắc chắn thao tác này chứ"))
            {
                this.Close();
            }    
        }

        private void Chart_thongke_Load(object sender, EventArgs e)
        {
           
        }
    }
}
