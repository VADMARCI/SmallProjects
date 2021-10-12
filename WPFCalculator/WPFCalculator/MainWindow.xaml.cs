using System;
using System.Linq;
using System.Windows;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static double firstNumber;
        static double secondNumber;
        static double res;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (MainArea.Text.Equals(""))
            {
                firstNumber = 0;
                SmallArea.Text = "0/";
            }
            else
            {
                firstNumber = Convert.ToDouble(MainArea.Text);
                SmallArea.Text = MainArea.Text + "/";
                MainArea.Text = "";
            }
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (MainArea.Text.Equals(""))
            {
                firstNumber = 0;
                SmallArea.Text = "0+";
            }
            else
            {
                firstNumber = Convert.ToDouble(MainArea.Text);
                SmallArea.Text = MainArea.Text + "+";
                MainArea.Text = "";
            }
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (MainArea.Text.Equals(""))
            {
                firstNumber = 0;
                SmallArea.Text = "0-";
            }
            else
            {
                firstNumber = Convert.ToDouble(MainArea.Text);
                SmallArea.Text = MainArea.Text + "-";
                MainArea.Text = ""; 
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (MainArea.Text.Equals(""))
            {
                firstNumber = 0;
                SmallArea.Text = "0x";
            }
            else
            {
                firstNumber = Convert.ToDouble(MainArea.Text);
                SmallArea.Text = MainArea.Text + "x";
                MainArea.Text = "";
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "7";
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "9";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "8";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "6";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "3";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            MainArea.Text = MainArea.Text + "0";
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            if (MainArea.Text.Contains(".")) { }
            else
            {
                if (MainArea.Text.Equals(""))
                {
                    MainArea.Text = "0.";
                }
                else
                {
                    MainArea.Text = MainArea.Text + ".";
                }
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            string[] keys = new string[] { "+", "-", "x", "/" };
            string sKeyResult = keys.FirstOrDefault<string>(s => SmallArea.Text.Contains(s));
            switch (sKeyResult)
            {
                case "+":
                    isMainEmpty();
                    res = firstNumber + secondNumber;
                    MainArea.Text = res.ToString();
                    break;
                case "-":
                    isMainEmpty();
                    res = firstNumber - secondNumber;
                    MainArea.Text = res.ToString();
                    break;
                case "x":
                    isMainEmpty();
                    res = firstNumber * secondNumber;
                    MainArea.Text = res.ToString();
                    break;
                case "/":
                    isMainEmpty();
                    res = firstNumber / secondNumber;
                    MainArea.Text = res.ToString();
                    break;
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            SmallArea.Text = "";
            MainArea.Text = "";
        }

        private void Reset()
        {
            if (res != 0)
            {
                firstNumber = 0;
                secondNumber = 0;
                SmallArea.Text = "";
                MainArea.Text = "";
                res = 0;
            }
        }
        private void isMainEmpty()
        {
            if (MainArea.Text.Equals(""))
            {
                secondNumber = 0;
            }
            else
            {
                secondNumber = Convert.ToDouble(MainArea.Text);
            }
        }
    }
}
