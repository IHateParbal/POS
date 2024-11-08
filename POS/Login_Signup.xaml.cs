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
using System.Windows.Shapes;

namespace POS
{
    /// <summary>
    /// Interaction logic for Login_Signup.xaml
    /// </summary>
    public partial class Login_Signup : Window
    {
        public Login_Signup()
        {
            InitializeComponent();
        }
        public void NavigateToSignupPage()
        {
            MainFocusFrame.NavigationService.Navigate(new Uri("signuppage.xaml", UriKind.Relative));
        }

        public void NavigateToLoginPage()
        {
            MainFocusFrame.NavigationService.Navigate(new Uri("Login.xaml", UriKind.Relative));
        }
    }
}
