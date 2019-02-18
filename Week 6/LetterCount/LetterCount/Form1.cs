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

namespace LetterCount
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
            var LetterCount = 0;
            var line = sr.ReadLine();
            while (sr.Peek() != -1)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    MessageBox.Show("The amount of times t is at the end of a word is: " + sr.ReadLine() + LetterCount);
                }
            }
            sr.Close();

            
        }
    }
}
