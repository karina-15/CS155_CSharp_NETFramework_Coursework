﻿using System;
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

namespace Lecture6Input
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            operatorListBox().Items.Add();
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            outputTextBox.Text = "";
            try
            {
                int value = Convert.ToInt32(numberTextBox.Text);
                outputTextBox.Text = value;
            }
        }
    }
}
