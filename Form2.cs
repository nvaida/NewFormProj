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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                uint number = Convert.ToUInt32(maskedTextBox2.Text);
                char digit = maskedTextBox1.Text[0];
                int count = a.Lab.GetDigitCount(number, digit);
                if (count > 2)
                {
                    MessageBox.Show("Данная цифра встречается более двух раз");
                }
                else
                {
                    MessageBox.Show("Данная цифра встречается не встречается более двух раз");
                }
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены!");
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = a.Lab.GetSumEqNumbers();
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                string str = "" + number;
                for (int j = 0; j < str.Length; j++)
                {
                    if (((str[j] - '0') % 2) != 0)
                    {
                        sum += (str[j] - '0');
                    }
                }
                listBox1.Items.Add(str);
            }
            textBox1.Text = sum.ToString();
            textBox1.Visible = true;
            listBox1.Visible = true;


        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                uint number = Convert.ToUInt32(maskedTextBox2.Text);
                MessageBox.Show("Количество четных цифр: " + a.Lab.GetEvenCount(number));

            }
            catch
            {
                MessageBox.Show("Введите натуральное число");
            }

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (maskedTextBox4.Text != string.Empty && maskedTextBox3.Text != string.Empty)
            {
                string last_name = maskedTextBox4.Text;
                string first_name = maskedTextBox3.Text;

                int min_len = Math.Min(last_name.Length, first_name.Length);
                int max_len = Math.Max(last_name.Length, first_name.Length);

                char[] head = new char[min_len];

                for (int i = 0; i < min_len; i++)
                {
                    int sum = last_name[i] | first_name[i];
                    head[i] = (char)sum;

                }

                string max_name;
                if (last_name.Length > first_name.Length)
                {
                    max_name = last_name;
                }
                else
                {
                    max_name = first_name;
                }

                char[] tail = max_name.Substring(min_len, max_len - min_len).ToCharArray();
                string str_head = new string(head);
                string str_tail = new string(tail);
                textBox2.Text = str_head;

                textBox3.Text = str_tail;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
