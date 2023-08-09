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
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainFrame.Navigate(new Uri("Login_signup.xaml?mode=signuppage", UriKind.Relative));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.MainFrame.Navigate(new Uri("Login_signup.xaml?mode=login", UriKind.Relative));
            }
        }
    }
}
