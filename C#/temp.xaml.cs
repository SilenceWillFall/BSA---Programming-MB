using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Programming_MB_Demo.Resources;
 
namespace Programming_MB_Demo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double DegText, CelText;
            DegText = double.Parse(TextBox1.Text);
            CelText = (5.0 / 9.0) * (DegText - 32.0);
            Text4.Visibility = System.Windows.Visibility.Visible;
            Text5.Text = CelText.ToString();
            Text5B.Visibility = System.Windows.Visibility.Visible;
            if (DegText > 100)
            {
                Text6.Text = "It's Hot! Better Hydrate";
                Text6.Visibility = System.Windows.Visibility.Visible;
            }
            else if (DegText <= 32)
            {
                Text6.Text = "It's Cold! Better pack long underwear";
                Text6.Visibility = System.Windows.Visibility.Visible;
            }
 
        }
 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            Text4.Visibility = System.Windows.Visibility.Collapsed;
            Text5B.Visibility = System.Windows.Visibility.Collapsed;
            Text5.Text = "";
            Text6.Visibility = System.Windows.Visibility.Collapsed;
 
        }
 
 
    }
}