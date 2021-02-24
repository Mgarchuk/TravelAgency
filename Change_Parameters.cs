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
    public partial class Change_Parameters : Form
    {
        int step;
        bool active, beach;
        int add_cost = 0;
        public Change_Parameters(int step, bool active, bool beach, int add_cost)
        {
            InitializeComponent();
            this.step = step;
            this.active = active;
            this.beach = beach;
            this.add_cost = add_cost;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            Information f = new Information(step, active, beach, add_cost);
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings s = new Settings("Change_Parameters", active, beach, step);
            s.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                add_cost = 100;
            }
            else if(radioButton2.Checked)
            {
                add_cost = 50;
            }
            else if(radioButton3.Checked)
            {
                add_cost = 250;
            }
            else if(radioButton4.Checked)
            {
                add_cost = 1000;
            }

            add_cost += Convert.ToInt32(numericUpDown1.Value) * 150;

            Information f = new Information(step, active, beach, add_cost);
            f.Show();
            this.Close();

        }

        private void Change_Parameters_Load(object sender, EventArgs e)
        {

        }
    }
}
