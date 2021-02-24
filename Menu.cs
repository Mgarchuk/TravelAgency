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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if(Program.color == 1)
            {
                this.BackColor = Color.LightSalmon;
                button1.BackColor = Color.Bisque;
                button2.BackColor = Color.Bisque;
                button1.ForeColor = Color.LightSalmon;
                button2.ForeColor = Color.LightSalmon;
            }
            else
            {
                this.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Interview task = new Interview();
            task.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Tours t = new Tours();
            t.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = Application.OpenForms[0];
            f.Show();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
           
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

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.LightGray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.LightGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings s = new Settings("Menu");
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Offer s = new Offer();
            s.Show();
        }
    }
}
