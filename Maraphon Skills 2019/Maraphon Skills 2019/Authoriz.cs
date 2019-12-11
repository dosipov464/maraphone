using System;
using System.Data.SqlClient;
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
    public partial class Authoriz : Form
    {
        DateTime voteTime = new DateTime(2020, 11, 24, 6, 0, 0);
        public Authoriz()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Authoriz_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            time2.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов и " + TimeRemaining.Minutes + " минут до старта марафона!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wantobegun waut = new Wantobegun();
            waut.Show();
        }

        private void Authoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string email = textBox1.Text;
                string connectionString = null;
                SqlCommand cmd;
                SqlConnection con;

                connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Osipov_Koryagin;User ID=student;Password=student");
                con = new SqlConnection(connectionString);
                con.Open();
                string conn;
                conn = "select Email, Password ,RoleID  From [User] where Email='" + email + "'";
                cmd = new SqlCommand(conn, con);


                string password = "";
                string role = "";

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    password = reader[1].ToString();
                    role = reader[2].ToString();
                }
                reader.Close();

                if (textBox2.Text == password)
                {
                    if (role == "R")
                    {
                       this.Hide();
                       Runnermenu mn_r = new Runnermenu();
                       mn_r.Show();
                    }
                    if (role == "C")
                    {
                        this.Hide();
                        CoordMenu cr_m = new CoordMenu();
                        cr_m.Show();
                    }
                    if (role == "A")
                    {
                        this.Hide();
                        AdminMenu ad_m = new AdminMenu();
                        ad_m.Show();
                    }
                } else MessageBox.Show("Неверный логин или пароль");

            }
            else MessageBox.Show("Данные не введены");
        }
    }
}
