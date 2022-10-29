using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumericButton_Click (object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Display.Text += button.Content.ToString();
            second = Int32.Parse(Display.Text);
            
            
        }
        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }

        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Display.Text);
            op = '/';
            Display.Clear();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Display.Text);
            op = '+';
            Display.Clear();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Display.Text);
            op = '-';
            Display.Clear();
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(Display.Text);
            op = '*';
            Display.Clear();
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            second = Int32.Parse(Display.Text);
            int result = 0;

            if(op == '+')
            {
                result = first + second;
            }
            else if (op == '*')
            {
                result = first * second;
            }
            else if (op == '-')
            {
                result = first - second;
            }
            else if (op == '/')
            {
                result = first / second;
            }
            if(Display.Text == "0")
            {
                Display.Clear();
            }
            Display.Text = result.ToString();
        }
    }
}
