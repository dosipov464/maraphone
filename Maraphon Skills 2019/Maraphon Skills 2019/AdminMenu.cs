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
    public partial class AdminMenu : Form
    {
        DateTime voteTime = new DateTime(2020, 11, 24, 6, 0, 0);
        public AdminMenu()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authoriz at = new Authoriz();
            at.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            time2.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов и " + TimeRemaining.Minutes + " минут до старта марафона!";
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
