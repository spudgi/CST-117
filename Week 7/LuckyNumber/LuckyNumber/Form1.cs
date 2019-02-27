using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyNumber
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private delegate void del_LoadMonth();
        private delegate void del_LoadYear();

        private void LoadMonth()
        {
            if (comboBox2.InvokeRequired)
                comboBox2.Invoke(new del_LoadMonth(LoadMonth), null);
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    comboBox2.Items.Insert(i, CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames[i]);
                }
                comboBox2.SelectedIndex = DateTime.Now.Month - 1;
            }
        }
        private void LoadYear()
        {
            try
            {
                if (comboBox1.InvokeRequired)
                {
                    comboBox1.Invoke(new del_LoadYear(LoadYear), null);
                }
                else
                {
                    int iCurrentYear = DateTime.Now.Year;
                    for (int i = 1950; i <= iCurrentYear; i++)
                    {
                        comboBox1.Items.Add(i.ToString());
                    }

                    comboBox1.SelectedIndex = (comboBox1.Items.Count - 1);
                }
            }
            catch (Exception ex)
            {

            }

        }

        class ComboItem
        {
            public string MyYear
            {
                get;
                set;
            }
            public int value
            {
                get;
                set;
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(comboBox1.Text, comboBox3.Text);
            f.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
