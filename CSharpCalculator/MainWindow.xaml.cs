using System;
using System.Windows;

namespace CSharpCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _number1 = "0";
        private string _number2 = "0";
        private string _operation = String.Empty;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Calculator";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void AddDigit(double digit)
        {
            if (_operation == String.Empty)
            {
                _number1 = (double.Parse(_number1) * 10 + digit).ToString();
                Display.Text = _number1;
            }
            else
            {
                _number2 = (double.Parse(_number2) * 10 + digit).ToString();
                Display.Text = _number2;
            } 
        }

        private void RemoveDigit()
        {
            if (_operation == String.Empty)
            {
                if (_number1.Length > 1)
                {
                    _number1 = _number1.Remove(_number1.Length - 1);
                    Display.Text = _number1;
                }
                else
                {
                    _number1 = "0";
                    Display.Text = _number1;
                }
            }
            else
            {
                if (_number2.Length < 1)
                {
                    _number2 = _number2.Remove(_number2.Length - 1);
                    Display.Text = _number2;
                }
                else
                {
                    _number2 = "0";
                    Display.Text = _number2;
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
                    _number1 = (double.Parse(_number1) + double.Parse(_number2)).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "-":
                    _number1 = (double.Parse(_number1) - double.Parse(_number2)).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "*":
                    _number1 = (double.Parse(_number1) * double.Parse(_number2)).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "/":
                    if (_number2 != "0")
                    {
                        _number1 = (double.Parse(_number1) + double.Parse(_number2)).ToString();
                        Display.Text = _number1;
                    }
                    else
                        Display.Text = "Cannot divide by zero.";
                    _operation = String.Empty;
                    break;

                case "%":
                    _number1 = (double.Parse(_number1) * double.Parse(_number2) / 100).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "sqrt":
                    _number1 = Math.Sqrt(double.Parse(_number1)).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "pow":
                    _number1 = Math.Pow(double.Parse(_number1), 2).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "1/x":
                    _number1 = Math.Pow(double.Parse(_number1), -1).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;

                case "sign":
                    _number1 = (double.Parse(_number1) * -1).ToString();
                    Display.Text = _number1;
                    _operation = String.Empty;
                    break;
            }
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == String.Empty)
                _number1 = String.Empty;
            else
                _number2 = String.Empty;

            Display.Text = "0";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _number1 = String.Empty;
            _number2 = String.Empty;
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
            _number1 = _number1.Insert(_number1.LastIndexOfAny(_number1.ToCharArray()), ",");
            Display.Text = _number1;
        }
    }
}
