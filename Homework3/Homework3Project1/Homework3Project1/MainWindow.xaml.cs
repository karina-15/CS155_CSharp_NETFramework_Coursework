/// Homework No. 03 Exercise No. 01
/// File Name:      MainWindow.xaml.cs
/// @author:        Karina Elias
/// Date:           Sep. 16, 2019
/// 
/// Problem Statement: Write a GUI programs that
/// reads in the amount of a monthly payment and
/// the outstanding balance and then outputs the
/// amount of the payment that goes to interest
/// and the amount that goes to principal. Assume
/// that the annual interest payment is 6.39%.
/// 
/// Overall Plan
/// 1. Create Window layout
///     2 labels & textboxes for 2 inputs
///     1 button to Calculate outputs
///     2 labels & textboxes (isEnabled=false) for 2 outputs
/// 2. Define 6.39% annual interest as constant
/// 3. Calculate amount of payment to interest
///     interestPaid =
///         (outstandingBalance * (ANNUAL_INTEREST_RATE/100))/12)
/// 4. Calculate amount of payment to principal
///     prinicpalPaid = (monthlyPayment - interestPaid)
/// 5. Display outputs in corresponding labels
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class - MainWindow

/// Import necessay C# or user-defined packages

/// Create main class and objects needed to implement tasks
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

namespace Homework3Project1
{
    /// <summary>
    /// Interaction logic for Homework3Project1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constants
        const double ANNUAL_INTEREST_RATE = 6.39;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Declare variables
            double monthlyPayment, outstandingBalance;  // input
            double interestPaid, principalPaid;         // output

            // ---INPUT---
            // Convert string inputs from textboxes to double & assign to variables
            monthlyPayment = Convert.ToDouble(monthlyPaymentTextBox.Text);
            outstandingBalance = Convert.ToDouble(outstandingBalanceTextBox.Text);

            // ---PROCESS---
            // Calculate amount paid to interest
            interestPaid = (outstandingBalance * (ANNUAL_INTEREST_RATE / 100)) / 12;
            // Calculate amount paid to principal
            principalPaid = monthlyPayment - interestPaid;

            // ---OUTPUT---
            // Assign variables to output textboxes
            interestPaidTextBox.Text = interestPaid.ToString("N2");
            principalPaidTextBox.Text = principalPaid.ToString("N2");
        }
    }
}
