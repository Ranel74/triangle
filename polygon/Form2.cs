using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polygon
{
    public partial class Form2 : Form
    {
        public int a = 0;
        public int b = 0;
        public int c = 0;

        public double p = 0;
        public double S = 0;
        public Form2()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && int.Parse(textBox1.Text) > 0 && int.Parse(textBox2.Text) > 0 && int.Parse(textBox3.Text) > 0 && (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)) > int.Parse(textBox3.Text))
                {
                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    c = int.Parse(textBox3.Text);
                    if (a + b <= c || a + c <= b || b + c <= a)
                    {
                        p = 0;
                        S = 0;
                        label3.Text = "Не существует";
                        label3.Visible = true;
                    }
                    else if ((a * a) == (b * b + c * c) || (b * b) == (c * c + a * a) || (c * c) == (a * a + b * b))
                    {
                        p = 0;
                        S = 0;
                        label3.Text = "Прямоугольный";
                        label3.Visible = true;

                        p = (a + b + c) / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        label4.Text = Convert.ToString(S);
                        label4.Visible = true;
                    }
                    else if (a * a > b * b + c * c || c * c > a * a + b * b || b * b > a * a + c * c)
                    {
                        p = 0;
                        S = 0;
                        label3.Text = "Тупоугольный";
                        label3.Visible = true;

                        p = (a + b + c) / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        label4.Text = Convert.ToString(S);
                        label4.Visible = true;
                    }
                    else
                    {
                        p = 0;
                        S = 0;
                        label3.Text = "Остроугольный";
                        label3.Visible = true;

                        p = (a + b + c) / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        label4.Text = Convert.ToString(S);
                        label4.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные треугольнка!");
                }
            }
            catch
            {
                MessageBox.Show("оШиБкА");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
