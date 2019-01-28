using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int number = Convert.ToInt32(textBox1.Text);
            double root = 1;
            int i = 0;

            while (true)
            {
                i = i + 1;
                root = (number / root + root) / 2;
                if (i == number + 1) { break; }
            }
            textBox2.Text = root.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
