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
using System.Windows.Shapes;

namespace POS
{
    /// <summary>
    /// Interaction logic for start.xaml
    /// </summary>
    public partial class start : Window
    {
        public start()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login_Signup loginSignupWindow = new Login_Signup();
            loginSignupWindow.NavigateToSignupPage(); // Call a method to navigate to the signup page
            loginSignupWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login_Signup loginSignupWindow = new Login_Signup();
            loginSignupWindow.NavigateToLoginPage(); // Call a method to navigate to the login page
            loginSignupWindow.Show();
        }
    }
}
