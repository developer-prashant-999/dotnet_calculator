using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcualtor
{
    public partial class Form1 : Form
    {
        Double result=0;
        string operators = "+";
        bool operationPeformed=false;
        double newvalue = 0;

        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (operationPeformed))
                textBox1.Clear();
            operationPeformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;

            }
            else
                textBox1.Text = textBox1.Text + button.Text;
                        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
                Button button = (Button)sender;
                operators = button.Text;
                result = Double.Parse(textBox1.Text);
                label1.Text = result + " " + operators;
                operationPeformed = true;

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        
            switch (operators) {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    result = Double.Parse(textBox1.Text);
                  
                    break;

                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    result = Double.Parse(textBox1.Text);
                    break;

                case "/":
                    if (Double.Parse(textBox1.Text) == 0) {
                        textBox1.Text = "Cannot divide by zero";
                        break;
                    }
                    else
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    result = Double.Parse(textBox1.Text);
                    break;

                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    result = Double.Parse(textBox1.Text);
                    break;

                default:
                    break;
            }
          
            label1.Text="";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                {
                textBox1.Text+=".";
                }
        }
    }
}
