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
using MySql.Data.MySqlClient;
using System.Data;

namespace MySqlTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();
                connString.Server = tbAddress.Text;
                connString.UserID = tbUsername.Text;
                connString.Password = tbPassword.Password;
                connString.Database = tbDatabase.Text;

                MySqlConnection conn = new MySqlConnection(connString.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message.ToString());
            }
        }

    }
}
