using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox1.Text = of.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(textBox1.Text);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.Write(richTextBox1.Text.ToLower());
            sw.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.Write(richTextBox1.Text.Length >= 2);
            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.Write(richTextBox1.Text.OrderByDescending(n => n.length).First());
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.Write(richTextBox1.Text.ToLower());
            for (int i = 0; i < sw.Length; i++)
            {
                if (sw.Contains("a") || sw.Contains("e") || sw.Contains("i") || sw.Contains("o") || sw.Contains("u"))
                {
                    total++;
                }
            }
            
        }
    }
}
