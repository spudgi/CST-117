using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Random r = new Random();
        string first = "Hello my name is Caleb and I love this class!";
        string second = "This class is awesome!";

        public string First
        {
            get => First; set => First = value;
        }
        public string Second
        {
            get => Second; set => Second = value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int sum;

            number1 = Convert.ToInt32(textBox1.Text);

            number2 = Convert.ToInt32(textBox2.Text);

            sum = number1 + number2;


            MessageBox.Show(sum.ToString(), "The sum is");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number3;
            double number4;
            double number5;
            double number6;
            double number7;

            double sum2;

            number3 = Convert.ToDouble(textBox3.Text);
            number4 = Convert.ToDouble(textBox4.Text);
            number5 = Convert.ToDouble(textBox5.Text);
            number6 = Convert.ToDouble(textBox6.Text);
            number7 = Convert.ToDouble(textBox7.Text);

            sum2 = (number3 + number4 + number5 + number6 + number7) / 4;

            MessageBox.Show(sum2.ToString(), "The average is");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(r.Next(10).ToString() + r.Next(10).ToString(), "The sum of 2 random numbers is");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number8 = r.Next(10);
            int number9 = r.Next(10);
            int number10 = r.Next(10);

            int divisor = 3;

            int sum3;

            sum3 = (number8 + number9 + number10);

            if (sum3 % divisor == 0)
            {
                MessageBox.Show(sum3.ToString(), "is devisible by 3");
            }
            else
            {
                MessageBox.Show(sum3.ToString(), "is not devisible by 3");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(String.Compare(first,second) < 0)
            {
                MessageBox.Show(first.ToString() + " > " + second.ToString(), "is more than" );
            }
            else
            {
                MessageBox.Show(first.ToString() + " < " + second.ToString(), "is less than");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double number11 = r.Next(10);
            double number12 = r.Next(10);
            double number13 = r.Next(10);

            double[] anArray = {number11, number12, number13};

            double maxValue = anArray.Max();

            MessageBox.Show(maxValue.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Min = 0;
            int Max = 50;

            int[] d = new int[50];

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(Min, Max);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool number14 = r.Next(0, 10) > 0;
            bool number15 = r.Next(0, 10) > 0;

            if(number14 == number15)
            {
                MessageBox.Show(number14 + " Is equal to " + number15);
            }
            else
            {
                MessageBox.Show(number14 + " Is not equal to " + number15);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] array = new int[2,2];
            array[0, 0] = r.Next(4);

            for (int i = 0; i < array.Length; i++)
            {
                array [2, 2] = r.Next(4); 
            }
            MessageBox.Show(array[0, 0].ToString() + array[2, 2].ToString());
        }
    }
}
