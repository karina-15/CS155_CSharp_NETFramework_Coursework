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

namespace Lecture3Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string ENDING = "ay";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OutputButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName, lastName;

            firstName = FirstNameTextBox.Text;
            lastName = LastNameTextBox.Text;

            PigLatinTextBox.Text = PigLatin(firstName) + " " + PigLatin(lastName);
        }

        static string PigLatin(string input)
        {
            input = input.ToLower();
            string firstLetter = input.Substring(0, 1);
            string secondLetter = input.Substring(1, 1).ToUpper();
            string remainderName = input.Substring(2);

            return secondLetter + remainderName + firstLetter + ENDING;
        }
    }
}
