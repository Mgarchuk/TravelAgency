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
    public partial class Tours : Form
    {
        int step = 0;

        public Tours()
        {
            InitializeComponent();
            if (Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
                button1.BackColor = Color.Bisque;
                button2.BackColor = Color.Bisque;
                button3.BackColor = Color.Bisque;
                button1.ForeColor = Color.LightSalmon;
                button2.ForeColor = Color.LightSalmon;
                button3.ForeColor = Color.LightSalmon;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(step != 5)
            {
                step++;
            }
            
            if(step == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\korea1.jpg");
                label1.Text = "Сеул, Корея";
                label2.Text = "Цена: 1200 у.е.";
                label3.Text = "Кол-во дней: 12";
                label4.Text = "Питание: вкл";
            }
            else if(step == 2)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Berlin.jpg");
                label1.Text = "Берлин, Германия";
                label2.Text = "Цена: 300 у.е.";
                label3.Text = "Кол-во дней: 5";
                label4.Text = "Питание: не вкл";
            }
            else if (step == 3)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Port.jpg");
                label1.Text = "Португалия, Лиссабон";
                label2.Text = "Цена: 900 у.е.";
                label3.Text = "Кол-во дней: 9";
                label4.Text = "Питание: не вкл";
            }
            else if(step == 4)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\budapesht.jpg");
                label1.Text = "Венгрия, Будапешт";
                label2.Text = "Цена: 400 у.е.";
                label3.Text = "Кол-во дней: 6";
                label4.Text = "Питание: не вкл";
            }
            else if(step == 5)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Spain.jpg");
                label1.Text = "Испания, Мадрид";
                label2.Text = "Цена: 850 у.е.";
                label3.Text = "Кол-во дней: 9";
                label4.Text = "Питание: вкл";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(step != 0)
            {
                --step;
            }

            if (step == 0)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\paris.jpg");
                label1.Text = "Париж, Франция";
                label2.Text = "Цена: 400 у.е.";
                label3.Text = "Кол-во дней: 4";
                label4.Text = "Питание: вкл";
            }
            else if (step == 1)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\korea1.jpg");
                label1.Text = "Сеул, Корея";
                label2.Text = "Цена: 1200 у.е.";
                label3.Text = "Кол-во дней: 12";
                label4.Text = "Питание: вкл";
            }
            else if (step == 2)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Berlin.jpg");
                label1.Text = "Берлин, Германия";
                label2.Text = "Цена: 300 у.е.";
                label3.Text = "Кол-во дней: 5";
                label4.Text = "Питание: не вкл";
            }
            else if (step == 3)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Port.jpg");
                label1.Text = "Португалия, Лиссабон";
                label2.Text = "Цена: 900 у.е.";
                label3.Text = "Кол-во дней: 9";
                label4.Text = "Питание: не вкл";
            }
            else if (step == 4)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\budapesht.jpg");
                label1.Text = "Венгрия, Будапешт";
                label2.Text = "Цена: 400 у.е.";
                label3.Text = "Кол-во дней: 6";
                label4.Text = "Питание: не вкл";
            }

        }

        private void Tours_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new Menu();
            m.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order f = new Order();
            f.Show();
            this.Close();
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

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox3_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4 .BackColor = Color.LightGray;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings s = new Settings("Tours");
            s.Show();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }
    }
}
