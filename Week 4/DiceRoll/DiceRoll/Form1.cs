using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int getSides()
        {
            int sideCount;

            sideCount = 6;
            Random sc = new Random();

            return sideCount;
        }
        
        private int rollDie()
        {
            int result;
            
            Random rnd = new Random();

            result = rnd.Next(1, getSides() + 1);
            return result;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roll2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            roll1.Text = Convert.ToString(rollDie());
            roll2.Text = Convert.ToString(rollDie());
        }

    }
}
