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

namespace Homework4Lecture4Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // constants
        const int FINE = 60;
        const int FINE_EA_MILE = 7;
        const int EXCESS_SPEED = 25;
        const int EXCESS_FINE = 250;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckIfSpeedingButton_Click(object sender, RoutedEventArgs e)
        {
            int speedLimit, clockedSpeed, fine;

            speedLimit = Convert.ToInt32(speedLimitTextBox.Text);
            clockedSpeed = Convert.ToInt32(clockedSpeedTextBox.Text);

            if (clockedSpeed > speedLimit)
            {
                if (clockedSpeed > speedLimit)
                {
                    speedingCanvas.Background = Brushes.Yellow;
                    fine = FINE + (FINE_EA_MILE * (clockedSpeed - speedLimit));
                    if (clockedSpeed > (speedLimit + EXCESS_SPEED))
                    {
                        speedingCanvas.Background = Brushes.Red;
                        fine = EXCESS_FINE + FINE + (FINE_EA_MILE * (clockedSpeed - speedLimit));
                    }
                    fineTextBox.Text = String.Format("${0}", Convert.ToString(fine));
                }
            }
            else
            {
                speedingCanvas.Background = Brushes.Green;
                fineTextBox.Text = "No fine";
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit program.");
            Console.ReadLine();
        }
    }
}
