using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form2 : Form
    {
        public Form2(string cB1, string cB3)
        {
            InitializeComponent();
            int A = Convert.ToInt32(cB1.ToString());
            int B = Convert.ToInt32(cB3.ToString());

            label1.Text = A.ToString() + B.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
