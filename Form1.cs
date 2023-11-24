using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ProgrammingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lab1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form3(this);
            form.Owner = this;
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter("C:/Users/nasty/source/repos/FormProject/exception.txt"))
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void Lab3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void Lab4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form5(this);
            form.Show();
        }
    }
}
