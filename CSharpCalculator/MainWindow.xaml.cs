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

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float _number1 = 0;
        private float _number2 = 0;
        private string _operation = "";

        private void DisplayDigit(int digit)
        {
            if (_operation == String.Empty)
            {
                _number1 = (_number1 * 10) + digit;
                Display.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 * 10) + digit;
                Display.Text = _number2.ToString();
            }
           
        }

        public MainWindow()
        {
            InitializeComponent();

            this.Title = "Calculator";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(9);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(6);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(3);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            DisplayDigit(0);
        }
    }
}
