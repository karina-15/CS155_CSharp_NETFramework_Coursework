/// Homework No. 04 Exercise No. 01
/// File Name:      MainWindow.xaml.cs
/// @author:        Karina Elias
/// Date:           Sep. 22, 2019
/// 
/// Problem Statement: Write a GUI program that
/// calculates a person's body mass index. User inputs weight
/// in pounds and height in inches. A healthy BMI in the range
/// of 15-26 (inclusive). GUI will display BMI and blue if it
/// is below, green if it is within, or yellow if it is above
/// the healthy range.
/// 
/// Overall Plan
/// 1. Create Window layout
///     1 label for program description
///     2 labels & textboxes for 2 inputs
///     1 button to Calculate BMI
///     1 label & textbox for BMI output
///     1 canvas for blue, green, or yellow color
/// 2. Get inputs from textboxes and convert the strings to int
/// 3. Calculate BMI
///     bmi = (weight * 720) / (height*height)
/// 4. Compare with range using if else statments
/// 5. Convert bmi int to string and display output in 
///     !isEnabled BMI textbox
/// 6. Display appropriate color in canvas
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

namespace Homework4Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // constants
        const int MULTIPLY_WEIGHT = 720;
        const int RANGE_START = 15;
        const int RANGE_END = 26;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ---INPUT---
            int weight = Convert.ToInt32(weightTextBox.Text);
            int height = Convert.ToInt32(heightTextBox.Text);

            // ---PROCESS---
            int bmi = 0;
            bmi = (weight * MULTIPLY_WEIGHT) / (height*height);
            if(bmi < RANGE_START)
            {
                BMITextBox.Text = String.Format("{0} is below the healthy range",
                    Convert.ToString(bmi));
                Canvas.Background = Brushes.Blue;
            }
            else if (bmi > RANGE_END)
            {
                BMITextBox.Text = String.Format("{0} is above the healthy range",
                    Convert.ToString(bmi));
                Canvas.Background = Brushes.Yellow;
            }
            else
            {
                BMITextBox.Text = String.Format("{0} is in the healthy range",
                    Convert.ToString(bmi));
                Canvas.Background = Brushes.Green;
            }

            Console.ReadLine();
        }
    }
}
