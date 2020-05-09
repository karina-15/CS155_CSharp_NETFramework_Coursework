/// Homework No. 12 Exercise No. 01
/// File Name:      MainWindow.xaml.cs
/// @author:        Karina Elias
/// Date:           Dec 10, 2019
/// 
/// Problem Statement: Create a WPF application that uses a
/// delegate to calculate the area of a square, circle or triangle.
/// Have 3 buttons (1 for each shape) that sets the delegate.
/// Have a fourth button that uses the delegate to calculate
/// the area. For the area of the triangle have the height and
/// the base be the same value.
/// 
/// 
/// Overall Plan
/// 1. Create GUI which includes:
///     3 textblocks for title, input instruction, resulting area
///     1 textbox for user input of length or radius
///     3 radiobuttons for square, circle, or triangle selection
///     1 button to calculate area
/// 2. Create a delegate to calculate area
/// 3. Create methods and event handlers for each shape area
/// 4. Create event handler to display result when button is clicked
/// 
/// Classes needed and Purpose (Input, Processing, Output)
/// main class  - MainWindow.xaml.cs
/// GUI window  - MainWindow.xaml

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

namespace Homework12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create delegate
        delegate double Area(double length);
        // delegate variable
        Area area;

        public MainWindow()
        {
            InitializeComponent();
        }

        // calculate area of a square
        public double SquareArea(double length)
        {
            return length * length;
        }
        // event handler for square radio button
        private void SquareBtn_Checked(object sender, RoutedEventArgs e)
        {
            area = SquareArea;
        }

        // calculate area of circle
        public double CircleArea(double r)
        {
            // pi*r^2 rounded 2 decimal places
            return Math.Round(Math.PI * (r * r),2);
        }
        // event handler for circle radio button 
        private void CircleBtn_Checked(object sender, RoutedEventArgs e)
        {
            area = CircleArea;
        }

        // calculate area of triangle
        public double TriangleArea(double length)
        {
            // sides are of equal length
            return (length * length) / 2.0;
        }
        // event handler for triangle radio button
        private void TriangleBtn_Checked(object sender, RoutedEventArgs e)
        {
            area = TriangleArea;
        }

        // event handler to display area when button is clicked
        private void ResultBtn_Click(object sender, RoutedEventArgs e)
        {
            // get user input from textbox and convert to double
            try
            {
                resultTextBlock.Foreground = Brushes.Black;
                resultTextBlock.Text = "Area = " +
                    Convert.ToString(area(Convert.ToDouble(inputTextBox.Text)));
            }
            catch(FormatException) // textblock is empty
            {
                resultTextBlock.Foreground = Brushes.Red;
                resultTextBlock.Text = "Enter a number";
            }
            catch (NullReferenceException) // no radiobutton is clicked
            {
                resultTextBlock.Foreground = Brushes.Red;
                resultTextBlock.Text = "Choose a shape";
            }
        }
    }
}
