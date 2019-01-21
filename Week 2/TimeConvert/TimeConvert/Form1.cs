using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double S;
            double M;
            double H;
            double D;

            if (double.TryParse(textBox1.Text, out S))
            {
                if (double.TryParse(textBox1.Text, out M))
                {
                    H = S / M;

                    textBox2.Text = H.ToString;
                }
                else
                {
                    textBox2.AppendText("Invalid input for seconds.");
                }
            }
        }
    }
}
