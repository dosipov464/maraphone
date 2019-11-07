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
    public partial class sponsor : Form
    {
        DateTime voteTime = new DateTime(2019, 11, 24, 6, 0, 0);
        string mou;
        string years;
        public sponsor()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            
        }
        void textBox1_Validated(object sender, EventArgs e)
        {
        }


        private void sponsor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_Osipov_KoryaginDataSet1.runnerview' table. You can move, or remove it, as needed.
            this.runnerviewTableAdapter.Fill(this.g464_Osipov_KoryaginDataSet1.runnerview);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void time1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan TimeRemaining = voteTime - DateTime.Now;
            time2.Text = TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов и " + TimeRemaining.Minutes + " минут до старта марафона!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = int.Parse(pay_but.Text);
            pay_but.Text = (t + 10).ToString();
            label7.Text = (int.Parse(label7.Text) + 10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "" || maskedTextBox4.Text == "")
            {
                MessageBox.Show("Поля не заполнены!");
            } else try
                {
                    int sum = Convert.ToInt32(maskedTextBox3.Text);
                    int sum2 = Convert.ToInt32(maskedTextBox2.Text);
                    if (Convert.ToDouble(label7.Text) > 0 && Convert.ToInt32(maskedTextBox2.Text) >= Convert.ToInt32(mou) && Convert.ToInt32(maskedTextBox3.Text) >= Convert.ToInt32(years))
                    {
                        string connectionString = null;
                        SqlCommand cmd;
                        SqlConnection con;

                        connectionString = ("Data Source=127.0.0.1;Initial Catalog=g464_Osipov_Koryagin;User ID=student;Password=student");
                        con = new SqlConnection(connectionString);
                        con.Open();
                        cmd = new SqlCommand("Insert INTO Sponsorship(SponsorName, RegistrationId, Amount) values(@name,@id,@amount)", con);

                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@amount", label7.Text);


                        cmd.ExecuteNonQuery();

                        Program.don = label7.Text;
                        Program.name_uch = comboBox1.Text;

                        this.Hide();
                        sponsor_confirm sponsor_confi = new sponsor_confirm();
                        sponsor_confi.Show();
                    }
                    else { MessageBox.Show("Данные введены неверно!"); }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка данных!");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int t = int.Parse(pay_but.Text);
            pay_but.Text = (t - 10).ToString();
            label7.Text = (int.Parse(label7.Text) - 10).ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
