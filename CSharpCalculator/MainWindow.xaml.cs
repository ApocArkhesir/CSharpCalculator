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
        private float _number1;
        private float _number2;
        private string _operation = String.Empty;

        private void AddDigit(int digit)
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

        private void RemoveDigit()
        {
            if (_operation == String.Empty)
            {
                _number1 = (_number1 / 10);
                Display.Text = _number1.ToString();
            }
            else
            {
                _number2 = (_number2 / 10);
                Display.Text = _number2.ToString();
            }

        }

        private void ChooseOperation(string operation)
        {
            _operation = operation;
            Display.Text = "0";
        }

        public MainWindow()
        {
            InitializeComponent();

            Title = "Calculator";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(9);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(6);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(1);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(2);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(3);
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            AddDigit(0);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("+");
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("-");
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("*");
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("/");
        }

        private void ButtonEq_Click(object sender, RoutedEventArgs e)
        {
            switch (_operation)
            {
                case "+" :
                    _number1 += _number2;
                    Display.Text = _number1.ToString();
                    break;

                case "-":
                    _number1 -= _number2;
                    Display.Text = _number1.ToString();
                    break;

                case "*":
                    _number1 *= _number2;
                    Display.Text = _number1.ToString();
                    break;

                case "/":
                    if (_number2 != 0)
                    {
                        _number1 /= _number2;
                        Display.Text = _number1.ToString();
                    }
                    else
                        Display.Text = "Cannot divide by zero.";
                    break;
            }
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == String.Empty)
                _number1 = 0;
            else
                _number2 = 0;

            Display.Text = "0";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _number1 = 0;
            _number2 = 0;
            _operation = String.Empty;
            Display.Text = "0";
        }

        private void ButtonBspace_Click(object sender, RoutedEventArgs e)
        {
            RemoveDigit();

        }
    }
}
