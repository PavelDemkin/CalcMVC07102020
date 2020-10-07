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

namespace MVC_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double result;

        public void Validate() // контролер
        {
            //Валидация полученных данных

            if (Num1TextBox.Text == "")
                Num1TextBox.Text = "0";
            if (Num2TextBox.Text == "")
                Num2TextBox.Text = "0";

            string text1 = Num1TextBox.Text.Trim();
            string text2 = Num2TextBox.Text.Trim();

            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = Convert.ToInt32(text1);
                num2 = Convert.ToInt32(text2);
            }
            catch (Exception exc)
            {

            }

            Calculate(num1, num2); //Передача данных модели

        }

        public void Calculate(int num1, int num2) // модель
        {
            switch (Znak.Text)
            {
                case "+":
                    result = num1 + num2; //Проведение операций с полученными данными
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / (double)num2;
                    break;
                case "%":
                    result = num1 / (double)num2 * 100;
                    break;
                case "√":
                    result = Math.Sqrt((double)num1);
                    break;
                case "x^2":
                    result = Math.Pow(num1, 2);
                    break;
                case "x^3":
                    result = Math.Pow(num1, 3);
                    break;
                case "x^y":
                    result = Math.Pow(num1, num2);
                    break;
                case "10^x":
                    result = Math.Pow(10, num1);
                    break;
                case "n!":
                    result = 1;
                    for (int i = num1; i > 0; i--)
                        result *= i;
                    break;
                case "sin":
                    result = Math.Sin(num1);
                    break;
                case "cos":
                    result = Math.Cos(num1);
                    break;
                case "tan":
                    result = Math.Tan(num1);
                    break;
                default:
                    break;
            }

            UpdateView(); //Вызов обновления представления
        }

        public void UpdateView()
        {
            ResultTextBlock.Text = result.ToString(); //Изменение вида
        }

        private void SlozhButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "+";
            Validate();
        }

        private void VichButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "-";
            Validate();
        }

        private void UmnozhButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "*";
            Validate();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "/";
            Validate();
        }

        private void ProcButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "%";
            Validate();
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "√";
            Validate();
        }

        private void KvadrButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "x^2";
            Validate();
        }

        private void KubButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "x^3";
            Validate();
        }

        private void StepenButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "x^y";
            Validate();
        }

        private void Stepen10Button_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "10^x";
            Validate();
        }

        private void FactButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "n!";
            Validate();
        }

        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "sin";
            Validate();
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "cos";
            Validate();
        }

        private void TanButton_Click(object sender, RoutedEventArgs e)
        {
            Znak.Text = "tan";
            Validate();
        }
    }
}
