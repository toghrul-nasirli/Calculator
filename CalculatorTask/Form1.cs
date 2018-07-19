using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculatorTask
{
    public partial class Form1 : Form
    {
        int operation = 0;
        double number_1 = 0, number_2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(350, 510);
            MaximumSize = new Size(350, 510);
            textBox1.Text = "0";
            textBox2.Text = "";
            square.Text = "x" + ((char)0x00B2).ToString();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            textBox1.Text = "";

            for (int i = 0; i < data.Length - 1; i++)
            {
                textBox1.Text += data[i];
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void negative_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            number_1 = -number_1;
            textBox1.Text = number_1.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operation = 1;
            number_1 = Convert.ToDouble(textBox1.Text);
            Reset();
            textBox2.Text = number_1.ToString() + " ÷";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operation = 2;
            number_1 = Convert.ToDouble(textBox1.Text);
            Reset();
            textBox2.Text = number_1.ToString() + " ×";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = 3;
            number_1 = Convert.ToDouble(textBox1.Text);
            Reset();
            textBox2.Text = number_1.ToString() + " -";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operation = 4;
            number_1 = Convert.ToDouble(textBox1.Text);
            Reset();
            textBox2.Text = number_1.ToString() + " +";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            number_2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Calculate().ToString();
            textBox2.Text = "";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            number_2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = (Calculate() / 100).ToString();
            textBox2.Text = "";
        }

        private void square_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"sqr({number_1})";
            textBox1.Text = (number_1 * number_1).ToString();
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"sqrt({number_1})";
            textBox1.Text = Math.Sqrt(number_1).ToString();
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            number_1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = $"reciproc({number_1})";
            textBox1.Text = (1 / number_1).ToString();
        }

        public void Reset()
        {
            textBox1.Text = "0";
        }

        public double Calculate()
        {
            double result = 0;

            switch (operation)
            {
                case 1:
                    result = number_1 / number_2;
                    break;
                case 2:
                    result = number_1 * number_2;
                    break;
                case 3:
                    result = number_1 - number_2;
                    break;
                case 4:
                    result = number_1 + number_2;
                    break;
                case 5:
                    result = (number_1 * number_2) / 100;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    number0_Click(new object(), new EventArgs()); break;
                case Keys.D1:
                    number1_Click(new object(), new EventArgs()); break;
                case Keys.D2:
                    number2_Click(new object(), new EventArgs()); break;
                case Keys.D3:
                    number3_Click(new object(), new EventArgs()); break;
                case Keys.D4:
                    number4_Click(new object(), new EventArgs()); break;
                case Keys.D5:
                    number5_Click(new object(), new EventArgs()); break;
                case Keys.D6:
                    number6_Click(new object(), new EventArgs()); break;
                case Keys.D7:
                    number7_Click(new object(), new EventArgs()); break;
                case Keys.D8:
                    number8_Click(new object(), new EventArgs()); break;
                case Keys.D9:
                    number9_Click(new object(), new EventArgs()); break;
                case Keys.NumPad0:
                    number0_Click(new object(), new EventArgs()); break;
                case Keys.NumPad1:
                    number1_Click(new object(), new EventArgs()); break;
                case Keys.NumPad2:
                    number2_Click(new object(), new EventArgs()); break;
                case Keys.NumPad3:
                    number3_Click(new object(), new EventArgs()); break;
                case Keys.NumPad4:
                    number4_Click(new object(), new EventArgs()); break;
                case Keys.NumPad5:
                    number5_Click(new object(), new EventArgs()); break;
                case Keys.NumPad6:
                    number6_Click(new object(), new EventArgs()); break;
                case Keys.NumPad7:
                    number7_Click(new object(), new EventArgs()); break;
                case Keys.NumPad8:
                    number8_Click(new object(), new EventArgs()); break;
                case Keys.NumPad9:
                    number9_Click(new object(), new EventArgs()); break;
                case Keys.Divide:
                    divide_Click(new object(), new EventArgs()); break;
                case Keys.Multiply:
                    multiply_Click(new object(), new EventArgs()); break;
                case Keys.Add:
                    plus_Click(new object(), new EventArgs()); break;
                case Keys.Subtract:
                    minus_Click(new object(), new EventArgs()); break;
                case Keys.OemMinus:
                    minus_Click(new object(), new EventArgs()); break;
                case Keys.Oemplus:
                    equals_Click(new object(), new EventArgs()); break;
            }
        }
    }
}
