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

namespace Travel_agency
{
    public partial class Interview : Form
    {
        SqlConnection sql_connection;
        bool active = false;
        bool beach = false;
        int budget;
        public Interview()
        {
            InitializeComponent();
            if (Program.color == 1)
            {
                this.BackColor = Color.PeachPuff;
                button1.BackColor = Color.LightSalmon;
                button1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }

            textBox1.Text = Client.Get_name();
            textBox2.Text = Client.Get_surname();
            textBox3.Text = Client.Get_budget().ToString();
            textBox4.Text = Client.Get_phone_number().ToString();

        }

        public Interview(int budget)
        {
            
            InitializeComponent();
            if (Program.color == 1)
            {
                this.BackColor = Color.PeachPuff;
                button1.BackColor = Color.LightSalmon;
                button1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }

            textBox1.Text = Client.Get_name();
            textBox2.Text = Client.Get_surname();
            textBox3.Text = Client.Get_budget().ToString();
            textBox4.Text = Client.Get_phone_number().ToString();

            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }
        private async void interview_Load(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OOP\Travel_agency\Database.mdf;Integrated Security=True";
            sql_connection = new SqlConnection(connection_string);
            await sql_connection.OpenAsync();
            SqlDataReader sql_reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Info] WHERE [login] = @login", sql_connection);
            command.Parameters.AddWithValue("login", Convert.ToString(Program.client_login));
            sql_reader = await command.ExecuteReaderAsync();
            while (await sql_reader.ReadAsync())
            {
                textBox1.Text = Convert.ToString(sql_reader["name"]);
                textBox2.Text = Convert.ToString(sql_reader["surname"]);
                textBox3.Text = Convert.ToString(sql_reader["budget"]);
                textBox4.Text = Convert.ToString(sql_reader["number"]);
                try
                {
                    Client.Set_budget(Convert.ToDouble(textBox3.Text));
                }
                catch
                {

                }

                    
                if (Convert.ToInt32(sql_reader["visa_EU"]) == 1)
                {
                    checkBox1.Checked = true;
                }

                if (Convert.ToInt32(sql_reader["visa_KOR"]) == 1)
                {
                    checkBox2.Checked = true;
                }

                if (Convert.ToInt32(sql_reader["beach"]) == 1)
                {
                    checkBox3.Checked = true;
                }

                if (Convert.ToInt32(sql_reader["active"]) == 1)
                {
                    checkBox4.Checked = true;
                }
            }

            if (sql_reader != null)
            {
                sql_reader.Close();
            }




        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int active_bd = 0;
            int beach_bd = 0;
            int visa_EU_bd = 0;
            int visa_KOR_bd = 0;
            if (textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || textBox4.TextLength == 0)
            {
                MessageBox.Show("Не все данные введены");
            }
            else
            {
                double budget = Client.Get_budget();
                if (double.TryParse(textBox3.Text, out budget))
                {
                    Client.Set_budget(Convert.ToInt32(budget));
                }


                int phone_number;
                if (int.TryParse(textBox4.Text, out phone_number))
                {
                    if (textBox4.Text.Length == 9)
                    {
                        Client.Set_id_number(Convert.ToInt32(phone_number));
                    }

                }

                Client.Set_name(textBox1.Text);
                Client.Set_surname(textBox2.Text);
                Client.Set_phone_number(phone_number);

                if (checkBox1.Checked)
                {
                    Client.Set_visa_EU(true);
                    visa_EU_bd = 1;
                }
                else
                    Client.Set_visa_EU(false);


                if (checkBox2.Checked)
                {
                    Client.Set_visa_KOR(true);
                    visa_KOR_bd = 1;
                }
                else
                    Client.Set_visa_KOR(false);

                if (checkBox3.Checked)
                {
                    beach = true;
                    beach_bd = 1;
                }
                else
                    beach = false;

                if (checkBox4.Checked)
                {
                    active = true;
                    active_bd = 1;
                }
                else
                    active = false;

                if (Client.Get_name().Length > 0 && Client.Get_surname().Length > 0 && budget > 10 && budget < 100000000 && Client.Get_phone_number() > 0)
                {

                    SqlCommand command = new SqlCommand("UPDATE [Info] SET [name] = @name, [surname] =@surname, [budget] = @budget, [number] = @number, [visa_EU] = @visa_EU, [visa_KOR] = @visa_KOR, [active]= @active, [beach] = @beach WHERE [login] = @login", sql_connection);
                    command.Parameters.AddWithValue("login", Program.client_login);
                    command.Parameters.AddWithValue("name", textBox1.Text);
                    command.Parameters.AddWithValue("surname", textBox2.Text);
                    command.Parameters.AddWithValue("budget", Convert.ToString(Client.Get_budget()));
                    command.Parameters.AddWithValue("number", textBox4.Text);
                    command.Parameters.AddWithValue("visa_EU", visa_EU_bd);
                    command.Parameters.AddWithValue("visa_KOR", visa_KOR_bd);
                    command.Parameters.AddWithValue("active", active_bd);
                    command.Parameters.AddWithValue("beach", beach_bd);

                    await command.ExecuteNonQueryAsync();

                    if (sql_connection != null && sql_connection.State != ConnectionState.Closed)
                    {
                        sql_connection.Close();
                    }


                    if(checkBox1.Visible)
                    {
                        Data data = new Data(active, beach);
                        data.Show();
                        this.Hide();
                    }
                    else
                    {
                        Order f = new Order();
                        f.Show();
                        this.Close();
                    }
                    
                }

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Interview_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu f = new Menu();
            f.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.LightGray;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.LightGray;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings s = new Settings("Interview");
            s.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Singleton s = Singleton.Initialize();
            textBox3.Text = Convert.ToString(Client.Get_budget());
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
         
        }
    }
}
