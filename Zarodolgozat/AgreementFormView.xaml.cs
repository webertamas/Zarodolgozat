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
    /// Interaction logic for AgreementFormWindow.xaml
    /// </summary>
    public partial class AgreementFormView : Window
    {
        AgreementFormViewModel _vm;

        public AgreementFormView()
        {
            InitializeComponent();
            _vm = new AgreementFormViewModel();
            DataContext = _vm;
            DataGrid.ItemsSource = _vm.ClientList.ToList();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var agreementFVM = (AgreementFormViewModel)DataContext;
            
            if (!agreementFVM.AgreementValidate())
            {
                MessageBox.Show("Hiba!", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DialogResult = true;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }
    }
}
