using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FormProject
{
    public partial class Form4 : Form
    {
        Color Corpus = new Color();
        Color Foliage = new Color();
        float Weight;

        Graphics g;

        public Form4()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
        //Дерево Пифагора
        public void DrawTree(double x, double y, double angle, double Len, int a, int b)
        {
            var coloring = new Color();
            coloring = Corpus;

            if (a <= b)
            {
                coloring = Foliage;
            }
            double x1, y1;
            Pen MyPen = new Pen(coloring, Weight);

            if (a != 0)
            {

                x1 = x + Len * Math.Cos(angle);
                y1 = y - Len * Math.Sin(angle);
                g.DrawLine(MyPen, (float)x, (float)y, (float)x1, (float)y1);
                DrawTree((int)x1, (int)y1, angle + 0.5, Len / 1.6, a - 1, b);
                DrawTree((int)x1, (int)y1, angle - 0.5, Len / 1.6, a - 1, b);
            }


        }
        //Салфетка Серпинского
        public void DrawDoily(float x, float y, float Len, int a)
        {
            var color = new Color();


            if (a == 1)
            {
                color = Color.PaleVioletRed;
            }
            else if (a == 2)
            {
                color = Color.LightCoral;
            }
            else
            {
                color = Color.Black;
            }
            Pen MyPen = new Pen(color, Weight);
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0) continue;
                    if (a > 1)
                    {
                        DrawDoily(x + j * Len / 3, y + i * Len / 3, Len / 3, a - 1);
                    }

                    g.DrawRectangle(MyPen, x + j * Len / 3 - Len / 6, y + i * Len / 3 - Len / 6, Len / 3, Len / 3);

                }
            }


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //Создание рисунка
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    throw new Exception("Выберите задание");
                }
                if (checkBox1.Checked == true)
                {

                    checkBox2.Enabled = false;
                    int a = Convert.ToInt32(numericUpDown1.Value);
                    int b = a / 2 - 1;
                    g = panel1.CreateGraphics();
                    g.Clear(Color.White);


                    try
                    {
                        if (Corpus == Color.Empty)
                        {
                            throw new Exception("Выберите цвет ствола дерева");

                        }

                        if (Foliage == Color.Empty)
                        {
                            throw new Exception("Выберите цвет листьев дерева");
                        }
                        DrawTree(panel1.Width / 2, panel1.Height / 2 + 360, Math.PI / 2, 250, a, b);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (checkBox2.Checked == true)
                {

                    checkBox1.Enabled = false;
                    int a = Convert.ToInt32(numericUpDown2.Value);
                    g = panel1.CreateGraphics();
                    g.Clear(Color.LavenderBlush);
                    DrawDoily(panel1.Width / 2, panel1.Height / 2, 400, a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        //толщина пера
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Weight = (int)numericUpDown4.Value;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Foliage = Color.DarkGreen;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Foliage = Color.Lime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foliage = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Foliage = Color.SeaGreen;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Foliage = Color.LightGreen;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Foliage = Color.MediumSeaGreen;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Foliage = Color.OliveDrab;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Foliage = Color.Olive;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Foliage = Color.YellowGreen;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Foliage = Color.Gold;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Corpus = Color.Sienna;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Corpus = Color.SaddleBrown;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Corpus = Color.DarkGoldenrod;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Corpus = Color.Maroon;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Corpus = Color.Chocolate;
        }
        //Очистка
        private void button5_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            g.Clear(Color.White);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
            {
                checkBox2.Checked = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form4_1();
            form.ShowDialog();
        }
    }
}
