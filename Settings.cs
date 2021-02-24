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
using Travel_agency.Singleton_pattern;
using System.Media;


namespace Travel_agency
{
    public partial class Settings : Form
    {
        int num = 1;
        string form;
        bool active;
        bool beach;
        int step;
        int stars_count = 0;
        int add_budget = 0;

        SoundPlayer sndPlayer = new SoundPlayer(@"D:\OOP\Music.wav");

        SqlConnection sql_connection = new SqlConnection();
        public Settings(string form)
        {            
            sndPlayer.Play();
            InitializeComponent();
            this.form = form;
            if(Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
            }
            else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        public Settings(string form, bool active, bool beach)
        {
            InitializeComponent();
            this.form = form;
            this.active = active;
            this.beach = beach;
            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
            }
            else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        public Settings(string form, bool active, bool beach, int step)
        {
            InitializeComponent();
            this.form = form;
            this.active = active;
            this.beach = beach;
            this.step = step;
            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
            }
            else
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                stars_count = 1;
                num++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                stars_count = 2;
                num++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                stars_count = 3;
                num++;
            }
        }

        private async void Settings_Load(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OOP\Travel_agency\Database.mdf;Integrated Security=True";
            sql_connection = new SqlConnection(connection_string);
            await sql_connection.OpenAsync();
            SqlDataReader sql_reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Info] WHERE [login] = @login", sql_connection);
            command.Parameters.AddWithValue("login", Convert.ToString(Program.client_login));
            try
            {
                sql_reader = await command.ExecuteReaderAsync();
                while (await sql_reader.ReadAsync())
                {
                    stars_count = Convert.ToInt32(sql_reader["stars"]);
                }
                if(stars_count == 1)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                }
                else if(stars_count == 2)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                }
                else if(stars_count == 3)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                }
                else if(stars_count == 4)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                }
                else if(stars_count == 5)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                    pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                }
            }
            catch
            {
                
            }
            finally
            {
                if (sql_reader != null)
                {
                    sql_reader.Close();
                }
            }

            if (sql_reader != null)
            {
                sql_reader.Close();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star.png");
                stars_count = 4;
                num++;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox2.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox3.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox4.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                pictureBox5.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\star_1.png");
                stars_count = 5;
                num++;
            }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {         
            SqlCommand command1 = new SqlCommand("UPDATE [Info] SET [stars] = @stars WHERE [login] = @login", sql_connection);
            command1.Parameters.AddWithValue("login", Convert.ToString(Program.client_login));
            command1.Parameters.AddWithValue("stars", stars_count);

            command1.ExecuteNonQuery();

            sndPlayer.Stop();

            if (sql_connection != null && sql_connection.State != ConnectionState.Closed)
            {
                sql_connection.Close();
            }
            this.Close();
            if(form == "Login")
            {
                Login f = new Login();
                f.Show();
            }
            else if(form == "Menu")
            {
                Menu f = new Menu();
                f.Show();
            }
            else if(form == "Tours")
            {
                Tours f = new Tours();
                f.Show();
            }
            else if(form == "Interview")
            {
                Interview f = new Interview();
                f.Show();
            }
            else if(form == "Data")
            {
                Data f = new Data(active, beach);
                f.Show();
            }
            else if(form == "Information")
            {
                Information f = new Information(step, active, beach, add_budget);
                f.Show();
            }
            else if(form == "Order")
            {
                Order f = new Order();
                f.Show();
            }
            else if(form == "Change_Parameters")
            {
                Change_Parameters f = new Change_Parameters(step, active, beach, add_budget);
                f.Show();
            }
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.LightGray;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.White;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.LightGray;
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox8.BackColor = Color.White;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.LightGray;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.White;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.White;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.color = 2;
            this.BackColor = Color.LightBlue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.color = 1;
            this.BackColor = Color.LightSalmon;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
