using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool tziro = false;
        double number1 = 0;
        double number2 = 0;
        string c = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            tziro = false;
            Button bt = (Button)sender;
            
            string s = textBox1.Text;

            if ((s[0] == '0') && (s.Count() == 1))
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + bt.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + bt.Text;
            }
        }
        private void Button00_Click(object sender, EventArgs e)
        {
            if((tziro != true) && (textBox1.Text != "0"))
                textBox1.Text += (sender as Button).Text;
            else
                tziro = true;
        }

        private void ButtonKet_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Sqrt(number1).ToString();
        }

        private void btSqr_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Pow(number1,2).ToString();
        }

        private void btReferse_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (1/number1).ToString();
        }

        private void btErase_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            textBox1.Clear();

            if (s.Count() == 1)
                textBox1.Text = "0";

            for (int i = 0; i < s.Count() - 1; i++)
                textBox1.Text += s[i];  
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            
            Button bt = (Button)sender;
            number1 = Convert.ToDouble(textBox1.Text);
            c = bt.Text;
            label1.Text += number1.ToString() +" " + bt.Text;
            textBox1.Text = "0";
        }

        private void btResult_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            label1.Text += number2.ToString() + " =";
            switch (c)
            {
                
                case "+":
                    textBox1.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    textBox1.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    textBox1.Text = (number1 / number2).ToString();
                    break;
                case "x":
                    textBox1.Text = (number1 * number2).ToString();
                    break;
            }
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            number2 = 0;
            c = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "0";
            number1 = 0;
            number2 = 0;
            c = "";
        }

        private void btPM_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = (k * -1).ToString();
        }

        private void btTokos(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(textBox1.Text);
            label1.Text += number2.ToString() + "% =";

            if (label1.Text.Contains("+"))
                textBox1.Text = ((number1 * number2) / 100).ToString();
            else if (label1.Text.Contains("-"))
                textBox1.Text = (number1 - ((number1 * number2) / 100)).ToString();
            else if (label1.Text.Contains("x") || label1.Text.Contains("/"))
                textBox1.Text = Math.Abs(((number1 * number2)/10) / 100).ToString();
        }
    }
}
