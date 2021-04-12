using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool lastCharSum { get; private set; } = false;
        private List<string> stack = new List<string>();
        private string temp;
        private float result = 0;
        private string lastOperation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            string tempStr = (string)((Button)e.OriginalSource).Content;
            if(mainText.Text.Length > 0 && mainText.Text != lastOperation)
            {
                mainText.Text += tempStr;
            }
            else
            {
                mainText.Text = tempStr;
            }
        }
        private void ClearButton(object sender, RoutedEventArgs e)
        {
            mainText.Text = "";
            stack.Clear();
        }

        private void ClearLastChar(object sender,RoutedEventArgs e)
        {
            string tempText = "";
            if(mainText.Text != "")
            {
                tempText = mainText.Text.Remove(mainText.Text.Length - 1);
            }
            mainText.Text = tempText;
        }

        private void EnterButton(object sender, RoutedEventArgs e)
        {
            switch (lastOperation)
            {
                case "+":
                    result = float.Parse(temp) + float.Parse(mainText.Text);
                    mainText.Text = $"{result}";
                    stack.Clear();
                    break;
                case "-":
                    result = float.Parse(temp) - float.Parse(mainText.Text);
                    mainText.Text = $"{result}";
                    stack.Clear();
                    break;
                case "/":
                    result = float.Parse(temp) / float.Parse(mainText.Text);
                    mainText.Text = $"{result}";
                    stack.Clear();
                    break;
                case "*":
                    result = float.Parse(temp) * float.Parse(mainText.Text);
                    mainText.Text = $"{result}";
                    stack.Clear();
                    break;
            }
                
        }

        private void SumButton(object sender, RoutedEventArgs e)
        {
            lastOperation = "+";
            if (stack.Count == 0)
            {
                stack.Add(mainText.Text);
                mainText.Text = "+";
                temp = stack.Last();
            }
            else
            {
                result = float.Parse(mainText.Text) + float.Parse(temp);
                mainText.Text = $"{result}";
            }
        }

        private void SubtractButton(object sender, RoutedEventArgs e)
        {
            lastOperation = "-";
            if (stack.Count == 0)
            {
                stack.Add(mainText.Text);
                mainText.Text = "-";
                temp = stack.Last();
            }
            else
            {
                result = float.Parse(mainText.Text) - float.Parse(temp);
                mainText.Text = $"{result}";
            }
        }

        private void DivideButton(object sender, RoutedEventArgs e)
        {
            lastOperation = "/";
            if (stack.Count == 0)
            {
                stack.Add(mainText.Text);
                mainText.Text = "/";
                temp = stack.Last();
            }
            else
            {
                result = float.Parse(temp) / float.Parse(mainText.Text);
                mainText.Text = $"{result}";
            }
        }
        private void MultiplyButton(object sender, RoutedEventArgs e)
        {
            lastOperation = "*";
            if (stack.Count == 0)
            {
                stack.Add(mainText.Text);
                mainText.Text = "*";
                temp = stack.Last();
            }
            else
            {
                result = float.Parse(temp) * float.Parse(mainText.Text);
                mainText.Text = $"{result}";
            }
        }
    }
}
