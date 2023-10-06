using System.DirectoryServices;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Lab3ver1
{
    public partial class Form1 : Form
    {
        
        const double E = 2.71828;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            textBox4.Text = "Результаты программы" + " Осипов Н.М" + Environment.NewLine;

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private double Fx(double x) //Метод для Определения Fx
        {
            if (radioButton1.Checked)
            {
                double fx = (Math.Pow(E, x) - Math.Pow(E, -x)) - 2;
                return fx;
            }
            else if (radioButton2.Checked)
            {
                double fx = Math.Pow(x, 2);
                return fx;
            }
            else
            {
                double fx = Math.Pow(E, x);
                return fx;

            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Решение 
        {
            textBox4.Clear();
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
             
                textBox4.Text += "При х = " + textBox1.Text + Environment.NewLine;
                textBox4.Text += "При у = " + textBox2.Text + Environment.NewLine;
                double d;
                if (x > y)
                {
                    textBox4.Text += "При вашем условие x>y  " + Environment.NewLine;
                    d = (Math.Pow((Fx(x) - y), 3)) + (Math.Atan(Fx(x)));
                    textBox4.Text += "d = " + d;
                }
                else if (y > x)
                {
                    textBox4.Text += "При вашем условие x<y  " + Environment.NewLine;
                    d = (Math.Pow((y - Fx(x)), 3)) + (Math.Atan(Fx(x)));
                    textBox4.Text += "d = " + d;
                }
                else
                {
                    textBox4.Text += "При вашем условие x=y  " + Environment.NewLine;
                    d = (Math.Pow((y + Fx(x)), 3)) + 0.5;
                    textBox4.Text += "d = " + d;
                }
            }
            catch
            {
                MessageBox.Show("Ошибочка сэр,введите корректные данные");
            }
        }
    }
    }
