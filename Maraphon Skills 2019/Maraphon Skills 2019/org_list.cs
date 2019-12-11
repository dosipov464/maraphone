using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maraphon_Skills_2019
{
    public partial class org_list : Form
    {
        DateTime voteTime = new DateTime(2020, 11, 24, 6, 0, 0);
        public org_list()
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void org_list_Load(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlCommand cmd;
            SqlConnection con;

            connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Osipov_Koryagin;User ID=student;Password=student");
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("SELECT CharityName ,CharityDescription ,CharityLogo FROM Charity", con);
         
            List<string[]> data = new List<string[]>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString(); 
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();
            
            int lg = data.Count;
            for (int i = 0; i < lg; i++)
            {
                int j = 0;
                UserControl1 ctl = new UserControl1();
                ctl.setup(data[i][j + 2], data[i][j], data[i][j + 1]);
                flowLayoutPanel1.Controls.Add(ctl);
            }
        }
    }
}
