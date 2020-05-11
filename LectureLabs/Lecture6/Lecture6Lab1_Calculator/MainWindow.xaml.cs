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

namespace Lecture6Lab1_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            operatorListBox.Items.Add("+");
            operatorListBox.Items.Add("-");
            operatorListBox.Items.Add("*");
            operatorListBox.Items.Add("/");
            operatorListBox.Items.Add("%");
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            messageTextBox.Text = "";
            double result;
            double num1 = 0;
            double num2 = 0;
            try
            {
                num1 = Convert.ToDouble(lhsTextBox.Text);
                num2 = Convert.ToDouble(rhsTextBox.Text);

                if (Convert.ToString(operatorListBox.SelectedItem) == "+")
                {
                    result = num1 + num2;
                    messageTextBox.Text = String.Format("{0} + {1} = {2}", num1, num2, result);
                }
                else if (Convert.ToString(operatorListBox.SelectedItem) == "-")
                {
                    result = num1 - num2;
                    messageTextBox.Text = String.Format("{0} - {1} = {2}", num1, num2, result);
                }
                else if (Convert.ToString(operatorListBox.SelectedItem) == "*")
                {
                    result = num1 * num2;
                    messageTextBox.Text = String.Format("{0} * {1} = {2}", num1, num2, result);
                }
                else if (Convert.ToString(operatorListBox.SelectedItem) == "/")
                {
                    result = num1 / num2;
                    messageTextBox.Text = String.Format("{0} / {1} = {2}", num1, num2, Math.Round(result, 4));
                }
                else if (Convert.ToString(operatorListBox.SelectedItem) == "%")
                {
                    result = num1 % num2;
                    messageTextBox.Text = String.Format("{0} % {1} = {2}", num1, num2, result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                lhsTextBox.Text = "";
                rhsTextBox.Text = "";
            }
        }
    }
}
