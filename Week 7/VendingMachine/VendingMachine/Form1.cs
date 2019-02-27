using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Modules;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        private MachineView _machine = new MachineView();
        public Form1()
        {
            InitializeComponent();
            MachineView DataContex = _machine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            payDayqty.Text = ;
        }

        private void buttonDisp_Click(object sender, EventArgs e)
        {
            payDayqty.Text = _machine.Items();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _machine.Refill();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void payDayqty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
