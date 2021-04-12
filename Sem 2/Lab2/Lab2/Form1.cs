using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int counter = 0;
        int top = 40;
        int left = 60;
        int i = 0;
        static string[] notRandomArray = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"};
        string[] randomArray = notRandomArray.OrderBy(x => rand.Next()).ToArray();

        public Form1()
        {
            InitializeComponent();
            ShuffleArray();
            BuildButtons();
        }

        private void ShuffleArray()
        {
            string[] randomArray = notRandomArray.OrderBy(x => rand.Next()).ToArray();
        }

        private void DeleteButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                tabPage2.Controls.RemoveByKey("btn" + i);
            }
            top = 40;
            left = 60;
            i = 0;
            counter = 0;
        }

        private void BuildButtons()
        {
            ShuffleArray();
            for (i = 0; i < 16; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = "btn" + i;
                button.Text = randomArray[i];
                button.Click += ButtonOnClick;

                tabPage2.Controls.Add(button);
                top += button.Height + 5;

                if (((i + 1) % 4) == 0 && i != 0)
                {
                    top = 40;
                    left += button.Width + 5;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0 && comboBox1.SelectedItem != null)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = "";
            }
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;

            if (button != null)
            {
                if (button.Text == (counter+1).ToString())
                {
                    button.Dispose();
                    counter++;
                }
                else
                {
                    DeleteButtons();
                    BuildButtons();
                }
                if(counter == 16)
                {
                    textBox2.Text = "Молодец!";
                    DeleteButtons();
                    BuildButtons();
                }
            }
        }
    }
}
