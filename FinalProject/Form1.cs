using System.Data;
using System;
using System.Globalization;
using System.Diagnostics;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            currentCalculation += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            currentCalculation += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            currentCalculation += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            currentCalculation += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            currentCalculation += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            currentCalculation += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            currentCalculation += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            currentCalculation += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            currentCalculation += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            currentCalculation += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            currentCalculation += ".";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentCalculation += "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentCalculation += "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentCalculation += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentCalculation += "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_Equals_Click();

        }
        private void button_Equals_Click()
        {
            try
            {
                textBox1.Text = new DataTable().Compute(currentCalculation, null).ToString();
                currentCalculation = textBox1.Text;
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
                currentCalculation = "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            currentCalculation = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if ((currentCalculation.Contains(".") == true) || (float.TryParse(currentCalculation, out float floatValue) == true))
            {
                float a = float.Parse(currentCalculation, CultureInfo.InvariantCulture.NumberFormat);
                textBox1.Text = Math.Pow(a,2).ToString();
                currentCalculation = Math.Pow(a, 2).ToString();
            }
            else
            {
                int a = int.Parse(currentCalculation, CultureInfo.InvariantCulture.NumberFormat);
                textBox1.Text = Math.Pow(a,2).ToString();
                currentCalculation = Math.Pow(a, 2).ToString();
            }
            //currentCalculation = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if ((currentCalculation.Contains(".") == true) || (float.TryParse(currentCalculation, out float floatValue) == true))
            {
                float a = float.Parse(currentCalculation, CultureInfo.InvariantCulture.NumberFormat);
                textBox1.Text = Math.Sqrt(a).ToString();
                currentCalculation = Math.Sqrt(a).ToString();
            }
            /*else if (float.TryParse(currentCalculation, out float floatValue) == true)
            {
                float a = float.Parse(currentCalculation, CultureInfo.InvariantCulture.NumberFormat);
                textBox1.Text = Math.Sqrt(a).ToString();
            }*/
            else
            {
                int a = int.Parse(currentCalculation, CultureInfo.InvariantCulture.NumberFormat);
                textBox1.Text = Math.Sqrt(a).ToString();
                currentCalculation = Math.Sqrt(a).ToString();
            }
            //currentCalculation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int intNumber = Int32.Parse(currentCalculation[0].ToString());
                currentCalculation = currentCalculation.Insert(0, "-");
                textBox1.Text = currentCalculation;
            }
            catch
            {
                Debug.Print(currentCalculation[0].Equals("-").ToString());
                if (currentCalculation[0].ToString().Equals("-"))
                {
                    Debug.WriteLine(currentCalculation);
                    currentCalculation = currentCalculation.Remove(0,1);
                    textBox1.Text = currentCalculation;
                }
            }
        }
    }
}