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

namespace HFCS_CH2_GroundUpProject
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


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5; 
            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x must be 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 3;
            string name = "Bobbo Jr.";
            if ((someValue == 3) || (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }
            myLabel.Text = "This line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while ( count < 10 )
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count -= 1;
            }

            myLabel.Text = "The answer is " + count;
        }
    }
}
