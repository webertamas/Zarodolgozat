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
    /// Interaction logic for ClientView.xaml
    /// </summary>
    public partial class ClientView : Window
    {
        ClientViewModel _vm;

        public ClientView()
        {
            InitializeComponent();
            _vm = new ClientViewModel();
            DataContext = _vm;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ClientFormViewModel vm = new ClientFormViewModel(new Client()) { IsNew = true };
            ClientFormWindow clientForm = new ClientFormWindow { DataContext = vm };
            clientForm.ShowDialog();
            var clientList = _vm.ClientList;
            if (clientForm.DialogResult == true)
            {
                clientList.Add(vm.Client);
                vm.Save();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectClient!=null)
            {
                ClientFormViewModel vm = new ClientFormViewModel(_vm.SelectClient);
                ClientFormWindow clientForm = new ClientFormWindow { DataContext = vm };
                clientForm.lastNameTextBox.IsEnabled = false;
                clientForm.firstNameTextBox.IsEnabled = false;
                clientForm.birthNameTextBox.IsEnabled = false;
                clientForm.ssnTextBox.IsEnabled = false;
                clientForm.birthPlaceTextBox.IsEnabled = false;
                clientForm.birthDateTextBox.IsEnabled = false;
                clientForm.mothersBirthLastNameTextBox.IsEnabled = false;
                clientForm.mothersBirthFirstNameTextBox.IsEnabled = false;
                clientForm.ShowDialog();

            }
        }
    }
}
