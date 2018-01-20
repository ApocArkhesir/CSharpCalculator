using System;
using System.Windows;

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _number1;
        private double _number2;
        private string _operation = String.Empty;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Calculator";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

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
                try
                {
                    _number1 = Convert.ToDouble(_number1.ToString().Remove(_number1.ToString().Length - 1));
                    Display.Text = _number1.ToString();
                }
                catch (FormatException e)
                {
                    _number1 = 0;
                    Display.Text = _number1.ToString();
                }                
            }
            else
            {
                try
                {
                    _number2 = Convert.ToDouble(_number2.ToString().Remove(_number2.ToString().Length - 1));
                    Display.Text = _number2.ToString();
                }
                catch (FormatException e)
                {
                    _number2 = 0;
                    Display.Text = _number2.ToString();
                }
            }
        }

        private void ChooseOperation(string operation)
        {
            _operation = operation;
            Display.Text = "0";
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

                case "%":
                    _number1 = (_number1 * _number2) / 100;
                    Display.Text = _number1.ToString();
                    break;

                case "sqrt":
                    _number1 = Math.Sqrt(_number1);
                    Display.Text = _number1.ToString();
                    break;

                case "pow":
                    _number1 = Math.Pow(_number1, 2);
                    Display.Text = _number1.ToString();
                    break;

                case "1/x":
                    _number1 = Math.Pow(_number1, -1);
                    Display.Text = _number1.ToString();
                    break;

                case "sign":
                    _number1 *= -1;
                    Display.Text = _number1.ToString();
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

        private void ButtonPerc_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("%");
        }

        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("sqrt");
        }

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("pow");
        }

        private void ButtonInv_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("1/x");
        }

        private void ButtonSign_Click(object sender, RoutedEventArgs e)
        {
            ChooseOperation("sign");
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            _number1 = 
        }
    }
}
