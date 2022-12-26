using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculater
{
    public partial class Form1 : Form
    {
        double input = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
            this.textBox2.Text = this.textBox2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
            this.textBox2.Text = this.textBox2.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
            this.textBox2.Text = this.textBox2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
            this.textBox2.Text = this.textBox2.Text + "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input = double.Parse(this.textBox1.Text);
            operation = "/";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
            this.textBox2.Text = this.textBox2.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
            this.textBox2.Text = this.textBox2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
            this.textBox2.Text = this.textBox2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
            this.textBox2.Text = this.textBox2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
            this.textBox2.Text = this.textBox2.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
            this.textBox2.Text = this.textBox2.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ".";
            this.textBox2.Text = this.textBox2.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input = double.Parse(this.textBox1.Text);
            operation = "+";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input = double.Parse(this.textBox1.Text);
            operation = "-";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input = double.Parse(this.textBox1.Text);
            operation = "*";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double input2 = double.Parse(this.textBox1.Text);
            double result = 0;

            if (this.operation == "+")
            {
                result = input + input2;
            }
            else if (this.operation == "-")
            {
                result = input - input2;
            }
            else if (this.operation == "*")
            {
                result = input * input2;
            }
            else if (this.operation == "/")
            {
                result = input / input2;
            }
            this.textBox1.Text = result.ToString("#,##0");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
