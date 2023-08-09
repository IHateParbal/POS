using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace POS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madgw\source\repos\Console\POS\POS\Item detail.mdf;Integrated Security=True;Connect Timeout=30";

        public MainWindow()
        {
            InitializeComponent();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
            }
        }
        private void PlaceOrder(object sender, RoutedEventArgs e)
        {

        }
        private void Users(object sender, RoutedEventArgs e)
        {

        }
        private void Settings(object sender, RoutedEventArgs e)
        {

        }
        private void HotCoffeeFilter(object sender, RoutedEventArgs e)
        {

        }
        private void ColdCoffeeFilter(object sender, RoutedEventArgs e)
        {

        }
        private void SoftDrinks(object sender, RoutedEventArgs e)
        {

        }
        private void Desserts(object sender, RoutedEventArgs e)
        {

        }
        private void Snacks(object sender, RoutedEventArgs e)
        {

        }
        private void Expresso(object sender, RoutedEventArgs e)
        {

        }
        private void Cappuccino(object sender, RoutedEventArgs e)
        {

        }
        private void CafeLatte(object sender, RoutedEventArgs e)
        {

        }
        private void FilterCoffee(object sender, RoutedEventArgs e)
        {

        }
        private void ChilledLatte(object sender, RoutedEventArgs e)
        {

        }
        private void ChocoFudge(object sender, RoutedEventArgs e)
        {

        }
        private void VgPizza(object sender, RoutedEventArgs e)
        {

        }
        private void VGNShake(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {

        }
    }
}

    