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
    public partial class Form3 : Form
    {
        public Form3(Form1 form)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        //создание массива со случайными элементами
        private void radioButton2_CheckedChanged(object sender, EventArgs e)    
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.RowCount = 2;
            int[] numbers = new int[(int)numericUpDown1.Value];
            Random random = new Random();
            dataGridView1.TopLeftHeaderCell.Value = "";
            dataGridView1.Rows[0].HeaderCell.Value = "Исходный массив";
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 50);
                dataGridView1.Columns[i].HeaderText = "" + (i + 1);

                dataGridView1.Rows[0].Cells[i].Value = numbers[i].ToString();
            }
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.ReadOnly = false;
            checkBox1.Enabled = true;
        }

       
        //создание массива для ввода вручную
        private void radioButton1_CheckedChanged(object sender, EventArgs e)   
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
                dataGridView1.RowCount = 2;
                int[] numbers = new int[(int)numericUpDown1.Value];
                dataGridView1.TopLeftHeaderCell.Value = "";
                dataGridView1.Rows[0].HeaderCell.Value = "Исходный массив";
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1.Columns[i].HeaderText = "" + (i + 1);
                }

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                checkBox1.Checked = false;
                checkBox1.Enabled = false;
                timer1.Enabled = false;
                dataGridView1.ReadOnly = false;
            }

        }
        //нахождение удвоенной суммы положительных элементов массива
        private void button1_Click(object sender, EventArgs e)           
        {
            Form1 main = this.Owner as Form1;
            int sum = 0;
            List<int> numbers = new List<int>();
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    throw new Exception("Не выбран способ ввода");
                }
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Rows[0].Cells[i].Value == null)
                    {
                        throw new Exception("Есть незаполненные ячейки");
                    }
                    else
                    {
                        numbers.Add(Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value));

                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > 0)
                    {
                        sum += numbers[i];
                    }
                }
                sum *= 2;
                MessageBox.Show(Convert.ToString("Удвоенная сумма:" + sum));
            }
            catch (Exception ex)
            {
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                main.textBox1.Text += ex.Message + " " + date + " " + time + Environment.NewLine;

                MessageBox.Show(ex.Message);

                return;
            }



        }

        
        //индексы элементов,к-ые больше предыдущих
        private void button2_Click(object sender, EventArgs e)    
        {
            Form1 main = this.Owner as Form1;
            listBox1.Items.Clear();
            List<int> list = new List<int>();
            List<int> numbers = new List<int>();
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    throw new Exception("Не выбран способ ввода");
                }
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Rows[0].Cells[i].Value == null)
                    {
                        throw new Exception("Есть незаполненные ячейки");

                    }
                    else
                    {
                        numbers.Add(Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value));
                    }
                }
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        list.Add(i + 1);
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    int index = list[i];
                    string str = "" + (index + 1);
                    listBox1.Items.Add(str);
                }
                listBox1.Visible = true;
            }
            catch (Exception ex)
            {

                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                main.textBox1.Text += ex.Message + " " + date + " " + time + Environment.NewLine;

                MessageBox.Show(ex.Message);

                return;
            }

        }

        //2 пары соседних элементов с одинаковым знаком
        private void button3_Click(object sender, EventArgs e)          
        {
            int a = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                numbers.Add(Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value));
            }
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < 0 && numbers[i + 1] < 0 || numbers[i] > 0 && numbers[i + 1] > 0)
                {
                    a++;
                }
            }
            if (a >= 2)
            {
                MessageBox.Show("Есть 2 пары соседних элементов с одинаковым знаком");

            }
            else
            {
                MessageBox.Show("Двух пар, соседних элементов с одинаковым знаком, не найдено");
            }
        }

        //ввод только чисел
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)  
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        //включение таймера
        private void checkBox1_CheckedChanged(object sender, EventArgs e)  
        {

            if (radioButton2.Checked == true)
            {

                timer1.Enabled = checkBox1.Checked;

            }

        }

        //случайный ввод массива
        private void timer1_Tick(object sender, EventArgs e)    
        {
            timer1.Interval = (int)numericUpDown2.Value * 1000;
            this.radioButton2_CheckedChanged(sender, e);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
            }
        }
    }
}
