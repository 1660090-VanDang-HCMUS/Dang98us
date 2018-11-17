using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video2
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        void rt(string cmd)
        {
            System.Diagnostics.Process.Start("shutdown", cmd);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            rt("-r ");
            MessageBox.Show("Chúc mừng bạn đã chiến thắng! giờ thì tắt nó đi và tập trung nhìn vào màn hình nè!");
            frm3 f = new frm3();
            f.ShowDialog();
            
        }
    }
}
