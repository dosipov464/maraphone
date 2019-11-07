using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon_Skills_2019
{
    public partial class sponsor_confirm : Form
    {
        DateTime voteTime = new DateTime(2019, 11, 24, 6, 0, 0);
        public sponsor_confirm()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            time2.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов и " + TimeRemaining.Minutes + " минут до старта марафона!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sponsor sp_form = new sponsor();
            sp_form.Show();
        }

        private void sponsor_confirm_Load(object sender, EventArgs e)
        {
            label4.Text = Program.name_uch;
            label_money.Text = Program.don + "$";
        }
    }
}
