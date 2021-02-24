using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Travel_agency
{
    public partial class Login : Form
    {
        SqlConnection sql_connection;
        string Path = @"D:\OOP\Travel_agency\files\login_password.txt";
        public Login()
        {
            InitializeComponent();
            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
                button1.BackColor = Color.Bisque;
                button2.BackColor = Color.Bisque;
                button1.ForeColor = Color.LightSalmon;
                button2.ForeColor = Color.LightSalmon;
                
            }
            else if(Program.color == 2)
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button1.ForeColor = Color.LightSalmon;
                button2.ForeColor = Color.LightSalmon;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool norm = false;

            using (StreamReader sr = new StreamReader(Path))
            {
                while(sr.Peek() != -1)
                {
                    if (login + " " + password == sr.ReadLine())
                    {
                        if (sql_connection != null && sql_connection.State != ConnectionState.Closed)
                        {
                            sql_connection.Close();
                        }
                        norm = true;
                        Program.client_login = login;
                        Menu task = new Menu();
                        sr.Close();
                        task.Show();
                        this.Hide();
                        break;
                    }
                }
                if(norm == false)
                {
                    label3.Text = " Неправильно  введены  данные\n    или пользователь не найден";
                }
                
            }

            
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool norm = true;
            

            if (login.Contains(" ") || password.Contains(" "))
            {
                norm = false;
            }

            if(login.Length >= 8 &&  password.Length >= 8 && norm == true)  
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    while (sr.Peek() != -1)
                    {
                        if (login + " " + password == sr.ReadLine())
                        {
                            norm = true;
                            sr.Close();
                            break;
                        }
                        else
                        {
                            norm = false;
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
                {
                    if (norm == false)
                    {
                        sw.WriteLine(login + " " + password);
                        Program.client_login = login;
                        sw.Close();

                        if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO [Info] (login, password)VALUES(@login, @password)", sql_connection);
                            command.Parameters.AddWithValue("login", textBox1.Text);
                            command.Parameters.AddWithValue("password", textBox2.Text);
                            await command.ExecuteNonQueryAsync();

                        }
                        else
                        {
                            label3.Text = "Error";
                        }

                        if (sql_connection != null && sql_connection.State != ConnectionState.Closed)
                        {
                            sql_connection.Close();
                        }

                        Menu task = new Menu();
                        this.Hide();
                        task.ShowDialog();
                    }
                    else
                    {
                        label3.Text = "Логин занят";
                    }
                }             
            }
            else
            {
                label3.Text = " Неправильно введены данные";
            }
        }

        private async void Login_Load(object sender, EventArgs e)
        {

            string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OOP\Travel_agency\Database.mdf;Integrated Security=True";
            sql_connection = new SqlConnection(connection_string);
            await sql_connection.OpenAsync();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(sql_connection!=null && sql_connection.State != ConnectionState.Closed)
            {
                sql_connection.Close();
            }
            this.Close();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
