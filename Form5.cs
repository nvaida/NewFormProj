using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FormProject
{
    public partial class Form5 : Form
    {
        Form1 form1;
        public Form5(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt) | *.txt|All files (*.*)|*.* ";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string file = openFileDialog1.FileName;
            string textFile = File.ReadAllText(file);
            richTextBox1.Text = textFile;
            string n = textFile;
            string signatura = comboBox1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
