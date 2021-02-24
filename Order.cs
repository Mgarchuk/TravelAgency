using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_agency
{
    public partial class Order : Form
    {
        int step = 10;
        bool active;
        bool beach;
        int add_budget;
        public Order()
        {
            InitializeComponent();

            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
                button1.BackColor = Color.Bisque;
                button1.ForeColor = Color.LightSalmon;
                panel1.BackColor = Color.NavajoWhite;
                panel2.BackColor = Color.NavajoWhite;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                panel1.BackColor = Color.LightGray;
                panel2.BackColor = Color.LightGray;
            }
            textBox1.Text = "номер карты";
            textBox2.Text = "м/г";
            textBox3.Text = "имя фамилия";
            textBox4.Text = "cvc";
        }
        public Order(int step, bool active, bool beach, int add_budget)
        {
            InitializeComponent();
            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
                button1.BackColor = Color.Bisque;
                button1.ForeColor = Color.LightSalmon;
                panel1.BackColor = Color.NavajoWhite;
                panel2.BackColor = Color.NavajoWhite;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                panel1.BackColor = Color.LightGray;
                panel2.BackColor = Color.LightGray;
            }
            this.step = step;
            this.active = active;
            this.beach = beach;
            textBox1.Text = "номер карты";
            textBox2.Text = "м/г";
            textBox3.Text = "имя фамилия";
            textBox4.Text = "cvc";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long budget;
            int cvc;
            if (long.TryParse(textBox1.Text, out budget)   && (textBox1.Text.Length == 16) && (textBox4.Text.Length == 3) && int.TryParse(textBox4.Text, out cvc) && textBox3.Text.Contains(" ") && (textBox2.Text.Length == 5))
            {
                if(textBox5.Text == "BANANAMAMA")
                {
                    MessageBox.Show("Заказ оплачен, промокод дал 20% скидки");
                }
                else if(textBox5.Text.Length != 0)
                {
                    MessageBox.Show("Закакз оплачен, промокод неверный");
                }   
                else
                {
                    MessageBox.Show("Заказ оплачен");
                }
                
            }
            else
            {
                MessageBox.Show("Неправильно введены данные");
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            textBox3.Text.ToUpper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (step != 10)
            {
                Information i = new Information(step, active, beach, add_budget);
                i.Show();
            }
            else
            { 
                Tours t = new Tours();
                t.Show();
            }
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
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

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
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
            if(step != 10)
            {
                Settings s = new Settings("Order", active, beach, step);
                s.Show();
            }
            else
            {
                Settings s = new Settings("Order");
                s.Show();
            }
            
        }
    }
}
