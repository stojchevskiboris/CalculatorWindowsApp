using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Калкулатор : Form
    {
        public string operation = "";
        public bool operand=false;
        public Калкулатор()
        {
            InitializeComponent();
        }

        private void checkZero()
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Text = "";    
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (operand == true)
            {
                textBox_Result.Text = "0";
                operand = false;
            }
            Button button = (Button)sender;
            if (button.Text != ".")
            {
                checkZero();
            }
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains('.'))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else 
            { 
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
        }

        

        private void clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            operation = "+";
        }

        private void eq_Click(object sender, EventArgs e)
        {

            if (upLabel.Text != "")
            {
                double op1 = double.Parse(upLabel.Text);
                double op2 = double.Parse(textBox_Result.Text);
                if (operation== "+")
                {
                    textBox_Result.Text = (op1 + op2).ToString();
                }
                if (operation == "-")
                {
                    textBox_Result.Text = (op1 - op2).ToString();
                }
                if (operation == "*")
                {
                    textBox_Result.Text = (op1 * op2).ToString();
                }
                if (operation == "/")
                {
                    textBox_Result.Text = (op1 / op2).ToString();
                }
                operand = false;
                upLabel.Text = "";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            operation = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            operation = "/";
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            operation = "*";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0")
            {
                if (textBox_Result.Text.Length == 1)
                {
                    textBox_Result.Text = "0";
                } else
                {
                    string s = textBox_Result.Text;
                    textBox_Result.Text = s.Remove(s.Length - 1);
                }
            }
        }

        private void pow2_Click(object sender, EventArgs e)
        {
            double d = double.Parse(textBox_Result.Text);
            double s = Math.Pow(d, 2);
            textBox_Result.Text = s.ToString();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox_Result.Text);
        }
    }
}
