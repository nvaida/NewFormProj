using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject
{
    public partial class Form4_1 : Form
    {
        public Form4_1()
        {
            InitializeComponent();
        }
        //Построение графика
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                listBox1.Items.Clear();
                chart1.Series[0].Points.Clear();
                Degree(a, n);
                listBox1.Visible = true;


            }
            catch
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }
        //Возведения числа в натуральную степень
        private double Degree(double a, int n)
        {
            double y;
            if (n == 0)
            {
                y = 1;
            }
            else
            {
                y = Degree(a, n - 1) * a;
            }

            chart1.Series[0].Points.AddXY(n, y);
            string str = "Степень: " + n + " Ответ:" + y;
            listBox1.Items.Add(str);
            return y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !(e.KeyChar == ',') && !(e.KeyChar == '-'))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
            chart1.Series[0].Points.Clear();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
