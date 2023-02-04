using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{


    public partial class Calculator : Form
    {

        



        public string operation = "";
        public bool operand=false;
        public Calculator()
        {
            InitializeComponent();
            this.ActiveControl = eq;
        }

        private void checkZero()
        {
            if (textBox_Result.Text == "0")
                textBox_Result.Text = "";    
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (operand == true /* && !(operation != "+" || operation != "-" || operation != "*" || operation != "/")*/)
            {
                textBox_Result.Text = "0";
                operand = false;
            }
            /*
            else if (operand == true && !(button.Text != "0" || button.Text != "1" || button.Text != "2" || button.Text != "3" || button.Text != "4" || button.Text != "5" || button.Text != "6" || button.Text != "7" || button.Text != "8" || button.Text != "9" || button.Text != "." ))
            {
                textBox_Result.Text = "0";
            }
            */
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
            upLabel.Text = "";
            textBox_Result.Text = "0";
            operand = false;
            operation = "";
            s_op.Text = "";

        }


        private void eq_Click(object sender, EventArgs e)
        {

            if (upLabel.Text != "")
            {
                string s1 = upLabel.Text;
                string s2 = textBox_Result.Text;
                if (upLabel.Text.Substring(s1.Length - 1) == ".")
                    upLabel.Text.Remove(s1.Length-1);
                if (textBox_Result.Text.Substring(s2.Length - 1) == ".")
                    textBox_Result.Text.Remove(s2.Length-1);
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
                s_op.Text = upLabel.Text = "";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            /*
            if (operand == true && upLabel.Text!="")
            {
                double op1 = double.Parse(upLabel.Text);
                double op2 = double.Parse(textBox_Result.Text);

                textBox_Result.Text = (op1 + op2).ToString();

                Console.WriteLine("CHECK");
            }*/
            operand = true;
            upLabel.Text = textBox_Result.Text;
            s_op.Text = operation = "+";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            s_op.Text = operation = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            s_op.Text = operation = "/";
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            operand = true;
            upLabel.Text = textBox_Result.Text;
            s_op.Text = operation = "*";
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

        private void pi_Click(object sender, EventArgs e)
        {
            string s = Math.PI.ToString();
            s = s.Remove(s.Length - 4);
            textBox_Result.Text = s;
        }

        private void plus_minus_Click(object sender, EventArgs e)
        {
            string res = "";
            if(textBox_Result.Text != "0" && textBox_Result.Text.Length!=0)
            {
                string s = textBox_Result.Text.Substring(0, 1);
                if (s != "-")
                {
                    res ="-"+textBox_Result.Text;
                } else
                {
                    res = textBox_Result.Text.Remove(0, 1);
                }
                textBox_Result.Text = res;
            }

            //textBox_Result.Text = Math.PI.ToString();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            Button b = new Button();
            EventArgs es = new EventArgs();
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) 
            {
                b.Text = "0";
                buttonClick(b,es);
            }
            else if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                b.Text = "1";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                b.Text = "2";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                b.Text = "3";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                b.Text = "4";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                b.Text = "5";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                b.Text = "6";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                b.Text = "7";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                b.Text = "8";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                b.Text = "9";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                b.Text = ".";
                buttonClick(b, es);
            }
            else if (e.KeyCode == Keys.Add)
            {
                plus_Click(b, es);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                minus_Click(b, es);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                Clear_Click_1(b, es);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                divide_Click(b, es);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                eq_Click(b, es);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                clear_Click(b, es);
            }
            else if (e.KeyCode == Keys.Y)
            {
                powerOf2_Click(b, es);
            }
            else if (e.KeyCode == Keys.P)
            {
                pi_Click(b, es);
            }
            else if (e.KeyCode == Keys.Back)
            {
                backspace_Click(b, es);
            }
        }

        private void powerOf2_Click(object sender, EventArgs e)
        {
            double d = double.Parse(textBox_Result.Text);
            double s = Math.Pow(d, 2);
            textBox_Result.Text = s.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double d = double.Parse(textBox_Result.Text);
            double s = Math.Sqrt(d);
            textBox_Result.Text = s.ToString();
        }

        private void percent_Click(object sender, EventArgs e)
        {
            double d = double.Parse(textBox_Result.Text);
            double s = d / 100;
            textBox_Result.Text = s.ToString();
        }
    }
}
