using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon_Skills_2019
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void setup(String fn, string t1, string t2)
        {
            pictureBox1.Image = new Bitmap(fn);
            label1.Text = t1;
            label2.Text = t2;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
