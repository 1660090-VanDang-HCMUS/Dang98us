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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //
            frm1 f = new frm1();
            f.ShowDialog();

        }

        private void lbl_Click(object sender, EventArgs e)
        {
            hd c = new hd();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click cái bên phải nào!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn rất nghe lời, click tiếp nào!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ngoan nào, click tiếp đi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muốn tăng độ khó cho game thì click cái dưới đừng sợ! chơi nào!");

        }
    }
}
