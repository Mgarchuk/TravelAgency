using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel_agency.tours_information;

namespace Travel_agency
{
    public partial class Data : Form
    {
        int step = 0;
        int start_step = 0;
        bool active;
        bool beach;
        int cost_visa_EU = 0;
        int cost_visa_KOR = 0;

        public Data(bool active, bool beach)
        {
            InitializeComponent();
            this.active = active;
            this.beach = beach;
            
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

            if (Program.countries[step].Get_visa_EU() == true && Client.Get_visa_EU() == false)
            {
                cost_visa_EU = 70;
            }
            if (Program.countries[step].Get_visa_KOR() == true && Client.Get_visa_KOR() == false)
            {
                cost_visa_KOR = 70;
            }
            if ((Client.Get_budget() - cost_visa_KOR> 1199) && active)
            {
                string path = "D:\\OOP\\Travel_agency\\Photo\\korea1.jpg";
                data_filling(path);
                label1.Text = "Сеул, Корея";
                label2.Text = "Цена: 1200 у.е.";
                label3.Text = "Кол-во дней: 12";
                label4.Text = "Питание: вкл";
                label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item1);
                label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item2);
                label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item3);

                step = 0;
            }
            else if (Client.Get_budget() - cost_visa_EU>= 900 && beach)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Port.jpg");
                label1.Text = "Португалия, Лиссабон";
                label2.Text = "Цена: 900 у.е.";
                label3.Text = "Кол-во дней: 9";
                label4.Text = "Питание: не вкл";
                label6.Text = "качество пляжа: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item1);
                label7.Text = "качество температуры: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item2);
                label8.Text = "качество еды: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item3);

                step = 1;
            }
            else if (Client.Get_budget() - cost_visa_EU >= 850 && beach)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Spain.jpg");
                label1.Text = "Испания, Мадрид";
                label2.Text = "Цена: 850 у.е.";
                label3.Text = "Кол-во дней: 9";
                label4.Text = "Питание: вкл";
                label6.Text = "качество развлечений: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item1);
                label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item2);
                label8.Text = "качество экстрима: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item3);
                step = 2;
            }
            else if (Client.Get_budget() - cost_visa_EU >= 400 && active)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\budapesht.jpg");
                label1.Text = "Венгрия, Будапешт";
                label2.Text = "Цена: 400 у.е.";
                label3.Text = "Кол-во дней: 6";
                label4.Text = "Питание: не вкл";
                label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item1);
                label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item2);
                label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item3);
                step = 4;
            }
            else if(Client.Get_budget() - cost_visa_EU>= 400 && active)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\paris.jpg");
                label1.Text = "Париж, Франция";
                label2.Text = "Цена: 400 у.е.";
                label3.Text = "Кол-во дней: 4";
                label4.Text = "Питание: вкл";
                label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item1);
                label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item2);
                label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item3);
                step = 3;
            }
            else if (Client.Get_budget() - cost_visa_EU >= 300 && active)
            {
                pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Berlin.jpg");
                label1.Text = "Берлин, Германия";
                label2.Text = "Цена: 300 у.е.";
                label3.Text = "Кол-во дней: 5";
                label4.Text = "Питание: не вкл";
                label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item1);
                label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item2);
                label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item3);
                step = 5;
            }
            else
                label1.Text = "Подходящих туров нет:";

            start_step = step;
        }

        public void data_filling(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляю, вы нашли промокод\n                  BANANAMAMA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (step < 5)
            {
                step += 1;

                if ((step == 1 && Client.Get_budget() - cost_visa_EU >= 900) && beach)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Port.jpg");
                    label1.Text = "Португалия, Лиссабон";
                    label2.Text = "Цена: 900 у.е.";
                    label3.Text = "Кол-во дней: 9";
                    label4.Text = "Питание: не вкл";
                    label6.Text = "качество пляжа: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item1);
                    label7.Text = "качество температуры: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item2);
                    label8.Text = "качество еды: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item3);
                    break;
                }
                else if (step == 2 && Client.Get_budget() - cost_visa_EU >= 850)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Spain.jpg");
                    label1.Text = "Испания, Мадрид";
                    label2.Text = "Цена: 850 у.е.";
                    label3.Text = "Кол-во дней: 9";
                    label4.Text = "Питание: вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item3);
                    break;
                }
                else if (step == 3 && Client.Get_budget() - cost_visa_EU >= 400 && active)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\budapesht.jpg");
                    label1.Text = "Венгрия, Будапешт";
                    label2.Text = "Цена: 400 у.е.";
                    label3.Text = "Кол-во дней: 6";
                    label4.Text = "Питание: не вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item3);
                    break;
                }
                else if (step == 4 && Client.Get_budget() - cost_visa_EU >= 400 && active)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\paris.jpg");
                    label1.Text = "Париж, Франция";
                    label2.Text = "Цена: 400 у.е.";
                    label3.Text = "Кол-во дней: 4";
                    label4.Text = "Питание: вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item3);
                    break;
                }
                else if (step == 5 && Client.Get_budget() - cost_visa_EU >= 300 && active)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Berlin.jpg");
                    label1.Text = "Берлин, Германия";
                    label2.Text = "Цена: 300 у.е.";
                    label3.Text = "Кол-во дней: 5";
                    label4.Text = "Питание: не вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Berlin    ").Item3);
                    break;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while(step > start_step)
            {
                step -= 1;

                if (step == 0 && Client.Get_budget() - cost_visa_KOR > 1199 && active)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\korea1.jpg");
                    label1.Text = "Сеул, Корея";
                    label2.Text = "Цена: 1200 у.е.";
                    label3.Text = "Кол-во дней: 12";
                    label4.Text = "Питание: вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Seoul     ").Item3);
                    break;
                }
                else if (step == 1 && Client.Get_budget() - cost_visa_EU >= 900 && beach)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Port.jpg");
                    label1.Text = "Португалия, Лиссабон";
                    label2.Text = "Цена: 900 у.е.";
                    label3.Text = "Кол-во дней: 9";
                    label4.Text = "Питание: не вкл";
                    label6.Text = "качество пляжа: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item1);
                    label7.Text = "качество температуры: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item2);
                    label8.Text = "качество еды: " + Convert.ToString(Program.beach_tours_list[1].Get_tours_information("Lisbon    ").Item3);   
                    break;
                }
                else if (step == 2 && Client.Get_budget() - cost_visa_EU >= 850)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\Spain.jpg");
                    label1.Text = "Испания, Мадрид";
                    label2.Text = "Цена: 850 у.е.";
                    label3.Text = "Кол-во дней: 9";
                    label4.Text = "Питание: вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.beach_tours_list[0].Get_tours_information("Madrid    ").Item3);
                    break;
                }
                else if (step == 3 && Client.Get_budget() - cost_visa_EU >= 400 && active)
                {
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\budapesht.jpg");
                    label1.Text = "Венгрия, Будапешт";
                    label2.Text = "Цена: 400 у.е.";
                    label3.Text = "Кол-во дней: 6";
                    label4.Text = "Питание: не вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Budapest  ").Item3);
                    break;
                }
                else if (step == 4 && Client.Get_budget() - cost_visa_EU >= 400 && active)
                { 
                    pictureBox1.Image = Image.FromFile("D:\\OOP\\Travel_agency\\Photo\\paris.jpg");
                    label1.Text = "Париж, Франция";
                    label2.Text = "Цена: 400 у.е.";
                    label3.Text = "Кол-во дней: 4";
                    label4.Text = "Питание: вкл";
                    label6.Text = "качество развлечений: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item1);
                    label7.Text = "качество достопримечательностей: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item2);
                    label8.Text = "качество экстрима: " + Convert.ToString(Program.active_tours_list[3].Get_tours_information("Paris     ").Item3);
                    break;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Information tour = new Information(step, active, beach, 0);
            tour.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Interview f = new Interview();
            f.Show();
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

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.LightGray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Settings s = new Settings("Data", active, beach);
            s.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
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

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
