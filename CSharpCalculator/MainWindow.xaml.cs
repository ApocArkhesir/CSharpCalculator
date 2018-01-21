using System;
using System.Globalization;
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
        private string _displayed = "0";
        private string _operation = "";
        private readonly NumberFormatInfo _numberFormat = new CultureInfo("pl-PL", false).NumberFormat;

        public MainWindow()
        {
            InitializeComponent();

            Title = "Calculator";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            WindowStyle = WindowStyle.SingleBorderWindow;
            Topmost = true;
            ResizeMode = ResizeMode.CanResize;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("7");
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("8");
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("9");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("4");
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("5");
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("6");
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("1");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("2");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("3");
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("0");
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
            _number2 = Display.Text;
            switch (_operation)
            {
                case "+" :
                    _displayed = (double.Parse(_number1) + double.Parse(_number2)).ToString(CultureInfo.CurrentCulture);
                    Display.Text = _displayed;
                    break;

                case "-":
                    _displayed = (double.Parse(_number1) - double.Parse(_number2)).ToString(CultureInfo.CurrentCulture);
                    Display.Text = _displayed;
                    break;

                case "*":
                    _displayed = (double.Parse(_number1) * double.Parse(_number2)).ToString(CultureInfo.CurrentCulture);
                    Display.Text = _displayed;
                    break;

                case "/":
                    if (_number2 != "0")
                    {
                        _displayed = (double.Parse(_number1) / double.Parse(_number2)).ToString(CultureInfo.CurrentCulture);
                        Display.Text = _displayed;
                    }
                    else
                        Display.Text = "Division by zero.";
                    break;

                case "%":
                    _displayed = (double.Parse(_number1) * double.Parse(_number2) / 100).ToString(CultureInfo.CurrentCulture);
                    Display.Text = _displayed;
                    break;

                case "sign":
                    _displayed = (double.Parse(_number1) * -1).ToString(CultureInfo.CurrentCulture);
                    Display.Text = _displayed;
                    break;
            }
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
            _displayed = "";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _number1 = "";
            _number2 = "";
            _operation = "";
            _displayed = "";
            Display.Text = "";
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
            _displayed = Display.Text;
            _displayed = Math.Sqrt(double.Parse(_displayed)).ToString(CultureInfo.CurrentCulture);
            Display.Text = _displayed;
            _displayed = "0";
        }

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            _displayed = Display.Text;
            _displayed = Math.Pow(double.Parse(_displayed), 2).ToString(CultureInfo.CurrentCulture);
            Display.Text = _displayed;
            _displayed = "0";
        }

        private void ButtonInv_Click(object sender, RoutedEventArgs e)
        {
            _displayed = Display.Text;
            _displayed = Math.Pow(double.Parse(_displayed), -1).ToString(CultureInfo.CurrentCulture);
            Display.Text = _displayed;
            _displayed = "0";
        }

        private void ButtonSign_Click(object sender, RoutedEventArgs e)
        {
            _displayed = Display.Text;
            _displayed = (double.Parse(_number1) * -1).ToString(CultureInfo.CurrentCulture);
            Display.Text = _displayed;
            _displayed = "0";
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            _displayed = _displayed.Insert(_displayed.LastIndexOfAny(_displayed.ToCharArray()) + 1,
                _numberFormat.NumberDecimalSeparator);
            Display.Text = _displayed;
        }

        private void AddDigit(string digit)
        {
            if (_displayed == "0")
                _displayed = digit;
            else
                _displayed += digit;
            Display.Text = _displayed;
        }

        private void RemoveDigit()
        {
            _displayed = Display.Text;
            Display.Text = _displayed.Length > 1 ? _displayed.Remove(_displayed.Length - 1) : "0";
            _displayed = "";
        }

        private void ChooseOperation(string operation)
        {
            _number1 = Display.Text;
            _operation = operation;
            _displayed = "";
        }
    }
}
