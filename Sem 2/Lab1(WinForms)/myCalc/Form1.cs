using System;
using System.Windows.Forms;

namespace myCalc
{
    public partial class Form1 : Form
    {
        private float operandOne = 0,
                      operandTwo = 0;

        private string operation = "";
        private bool operationIsSelected = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (operationIsSelected)
            {
                textBox1.Clear();
                operationIsSelected = false;
            }
            textBox1.Text += ((Button)sender).Text;
        }

        private String calculate(float operandOne, float operandTwo, String operation)
        {
            switch (operation)
            {
                case "+":
                    return Convert.ToString((operandOne + operandTwo)); 
                case "-":
                    return Convert.ToString((operandOne - operandTwo));
                case "*":
                    return Convert.ToString((operandOne * operandTwo));
                case "/":
                    return Convert.ToString((operandOne / operandTwo));
                case "sqrt":
                    return Convert.ToString(Math.Sqrt(operandOne));
                default:
                    return "";
            }
        }

        private void ButtonOperation_Click(object sender, EventArgs e)
        {
            operationIsSelected = true;
            operation = label1.Text = ((Button)sender).Text;
            operandOne = Convert.ToSingle(textBox1.Text);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                operandTwo = Convert.ToSingle(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Поле для ввода пустое!");
                return;
            }

            textBox1.Text = calculate(operandOne, operandTwo, operation);

            operation = label1.Text = "";
            operandOne = operandTwo = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
