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

namespace Zarodolgozat
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInOkButtonClick(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Nem írta be a felhasználónevét!","Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(passwordBox.Password))
            {
                MessageBox.Show("Nem írta be a jelszavát!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
    }
}
