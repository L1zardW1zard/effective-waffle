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

namespace lab2_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox textBox2 = new TextBox();
        static Random rand = new Random();
        int counter = 0;
        int i = 0;
        static string[] notRandomArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16" };
        string[] randomArray = notRandomArray.OrderBy(x => rand.Next()).ToArray();
        public MainWindow()
        {
            InitializeComponent();
            ShuffleArray();
            BuildButtons();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            if (comboBox1.Items.Count > 0 && comboBox1.SelectedItem != null)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = "";
            }
        }

        private void ShuffleArray()
        {
            string[] randomArray = notRandomArray.OrderBy(x => rand.Next()).ToArray();
        }

        private void DeleteButtons()
        {
            ButtonGrid.Children.Clear();

            i = 0;
            counter = 0;
        }

        private void BuildButtons()
        {
            ShuffleArray();

            for (i = 0; i < 16; i++)
            {
                Button button = new Button();
                button.Width = 40;
                button.Height = 30;
                button.Name = "btn" + i;
                button.Content = randomArray[i];
                button.Click += ButtonOnClick;

                ButtonGrid.Children.Add(button);
            }
            ButtonGrid.Children.Add(textBox2);
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            if (button != null)
            {
                if (button.Content.ToString() == (counter + 1).ToString())
                {
                    button.Visibility = Visibility.Hidden;
                    counter++;
                }
                else
                {
                    DeleteButtons();
                    ShuffleArray();
                    BuildButtons();
                }
                if (counter == 16)
                {
                    textBox2.Text = "Молодец!";
                    DeleteButtons();
                    BuildButtons();
                }
            }
        }
    }
}
