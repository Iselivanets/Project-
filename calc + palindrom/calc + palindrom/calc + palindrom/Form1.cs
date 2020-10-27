using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc___palindrom
{
    public partial class Form1 : Form
    {
        long A,B;
        int flag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            label1.Text += "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) //plus "+"
        {
            A = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            flag = 1; //it is means that we will plus the elements
            label1.Text += " + ";
        }

        private void button11_Click(object sender, EventArgs e) //minus "-"
        {
            A = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            flag = 2; //it is means that we will minus the elements
            label1.Text += " - ";
        }

        private void button12_Click(object sender, EventArgs e) //multiply "*"
        {
            A = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            flag = 3; //it is means that we will multiply the elements
            label1.Text += " * ";
        }


        private void button13_Click(object sender, EventArgs e) //division "/"
        {
            A = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            flag = 4; //it is means that we will multiply the elements
            label1.Text += " / ";
        }

        private void button16_Click(object sender, EventArgs e) //"C"
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e) //is it palindrom?
        {
            String S0 = textBox1.Text;
            String S = "";
            for (int i = 0; i<S0.Length; i++)
            {
                if (S0[i] != ' ')
                {
                    S += S0[i];
                }
            }
            int I = S.Length / 2;
            String S1 = "";
            String S2 = "";
            for (int j = 0; j<I; j++)
            {
                S1 += S[j];
            } 
            if (S.Length % 2 != 0)
            {
                for (int j = S.Length - 1; j > I; j--)
                {
                    S2 += S[j];
                }
            }
            else
            {
                for (int j = S.Length-1; j>=I; j--)
                {
                    S2 += S[j];
                }
            }
            if (S1 == S2)
            {
                label2.Text = "It is palindrom!";
            }
            else
            {
                label2.Text = "It is not palindrom!";
            }
        }

        private void button15_Click(object sender, EventArgs e) //"="
        {
            B = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            label1.Text += " = ";
            if (flag == 1)
            {
                textBox1.Text = Convert.ToString(A + B);
                label1.Text += Convert.ToString(A + B);
            }
            else if (flag == 2)
            {
                textBox1.Text = Convert.ToString(A - B);
                label1.Text += Convert.ToString(A - B);
            }
            else if (flag == 3)
            {
                textBox1.Text = Convert.ToString(A * B);
                label1.Text += Convert.ToString(A * B);
            }
            else if (flag == 4)
            {
                if ((A % B) == 0)
                {
                    textBox1.Text = Convert.ToString(A / B);
                    label1.Text += Convert.ToString(A / B);
                }
                else
                {
                    double a = A;
                    double b = B;
                    textBox1.Text = Convert.ToString(a / b);
                    label1.Text += Convert.ToString(a / b);
                }
            }
        }
    }
}
