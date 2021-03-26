using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorProiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }
        double value=0;
        int primaData = 0;
        public void schimbaValoare(String valoare)
        {
            if (textBox1.Text.Length < 9)
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text = textBox1.Text + valoare;
                }
                else
                {
                    textBox1.Text = valoare;
                }
            }
        }
        public void writeResult()
        {
            if (textBox2.Text.Substring(textBox2.Text.Length - 1) == "/" && (float)Convert.ToDouble("0" + textBox1.Text)!=0)
            {
                textBox2.Text = (value/(float)Convert.ToDouble("0" + textBox1.Text)).ToString();
                value = (float)Convert.ToDouble(textBox2.Text);
                if (textBox2.Text.Substring(0, 1) == ".")
                {
                    value /= Math.Pow(10, textBox1.Text.Length - 1);
                }
            }
            else if(textBox2.Text.Substring(textBox2.Text.Length - 1) == "*")
            {
                textBox2.Text = (value * (float)Convert.ToDouble("0" + textBox1.Text)).ToString();
                value = (float)Convert.ToDouble(textBox2.Text);
            }
            else if (textBox2.Text.Substring(textBox2.Text.Length - 1) == "+")
            {
                textBox2.Text = (value + (float)Convert.ToDouble("0" + textBox1.Text)).ToString();
                value = (float)Convert.ToDouble(textBox2.Text);
            }
            else if (textBox2.Text.Substring(textBox2.Text.Length - 1) == "-")
            {
                textBox2.Text = (value - (float)Convert.ToDouble("0" + textBox1.Text)).ToString();
                value = (float)Convert.ToDouble(textBox2.Text);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            schimbaValoare("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            schimbaValoare("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            schimbaValoare("9");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            schimbaValoare("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            schimbaValoare("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            schimbaValoare("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            schimbaValoare("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            schimbaValoare("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            schimbaValoare("3");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            schimbaValoare("0");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(".") == -1)
            {
                schimbaValoare(".");
                if(textBox1.Text.IndexOf(".") == 0)
                {
                    textBox1.Text = "0.";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
                if (primaData == 0)
                {
                    textBox2.Text = textBox1.Text + " /";
                    String ceva = "0" + textBox1.Text;
                    value = (float)Convert.ToDouble(ceva);
                    primaData = 1;
                }
                else
                {
                    writeResult();
                if(textBox2.Text.Substring(textBox2.Text.Length - 1) != "/")
                {
                    textBox2.Text = textBox2.Text + " /";
                }
                }
                textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (primaData == 0)
            {
                textBox2.Text = textBox1.Text + " *";
                String ceva = "0" + textBox1.Text;
                value = (float)Convert.ToDouble(ceva);
                if (textBox1.Text.Substring(0, 1) == ".")
                {
                    value = value / Math.Pow(10, textBox1.Text.Length - 1);
                }
                primaData = 1;
            }
            else
            {
                writeResult();
                if (textBox2.Text.Substring(textBox2.Text.Length - 1) != "/")
                {
                    textBox2.Text = textBox2.Text + " *";
                }
            }
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (primaData == 0)
            {
                textBox2.Text = textBox1.Text + " -";
                String ceva = "0" + textBox1.Text;
                value = (float)Convert.ToDouble(ceva);
                primaData = 1;
            }
            else
            {
                writeResult();
                if (textBox2.Text.Substring(textBox2.Text.Length - 1) != "/")
                {
                    textBox2.Text += " -";
                }
            }
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (primaData == 0)
            {
                textBox2.Text = textBox1.Text + " +";
                String ceva = "0" + textBox1.Text;
                value = (float)Convert.ToDouble(ceva);
                primaData = 1;
            }
            else
            {
                writeResult();
                if (textBox2.Text.Substring(textBox2.Text.Length - 1) != "/")
                {
                    textBox2.Text += " +";
                }
            }
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
            textBox2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            writeResult();
            textBox1.Text = textBox2.Text;

        }
    }
}
