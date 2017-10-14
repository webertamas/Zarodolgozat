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

namespace Zarodolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ClientViewModel _vm;

        public MainWindow()
        {
            //var logInView = new LogInView();
            //logInView.ShowDialog();
            InitializeComponent();

            _vm = new ClientViewModel
            {
                //User = logInView.ViewModel.AuthenticatedUser
                User=new User { Username="asdf", Password="asdf"}
            };

            DataContext = _vm;

        }

        private void LogoutButton_click(object sender, RoutedEventArgs e)
        {
            var loginView = new LogInView(true);
            var result= MessageBox.Show("Biztos, hogy ki akar lépni?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result==MessageBoxResult.OK)
            {
                Hide();
                loginView.ShowDialog();
                if (loginView.ViewModel.AuthenticatedUser != null)
                {
                    _vm.User = loginView.ViewModel.AuthenticatedUser;
                    Show();
                }
                else
                {
                    Close();
                }
            }
            

        }

        private void AgreementButton_Click(object sender, RoutedEventArgs e)
        {
            AgreementWindow agrwindow = new AgreementWindow();
            agrwindow.ShowDialog();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            ClientView clientview = new ClientView();
            clientview.ShowDialog();
        }

        private void DailyLogButton_Click(object sender, RoutedEventArgs e)
        {
            DailyLogView dlview = new DailyLogView();
            dlview.ShowDialog();
        }
    }
}
