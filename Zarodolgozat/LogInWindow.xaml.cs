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
        public LoginViewModel ViewModel { get; }
        public User LogInUser { get; internal set; }

        public LogInWindow()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }


        private void LogInOkButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Password = passwordBox.Password;
            if (ViewModel.Login())
                Close();
            else if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Nem írta be a felhasználónevét!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (string.IsNullOrEmpty(passwordBox.Password))
            {
                MessageBox.Show("Nem írta be a jelszavát!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            else
                MessageBox.Show("A felhasználónév és a jelszó nem megfelelő", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void AbortButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = ViewModel.AuthenticatedUser == null; //Environment.Exit(1);
            //MessageBoxResult result = MessageBox.Show("Biztos hogy ki akar lépni?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if (result == MessageBoxResult.Yes)
            //{
            //    e.Cancel = ViewModel.AuthenticatedUser == null;
            //    Environment.Exit(1);
            //}
        }
    }
}
