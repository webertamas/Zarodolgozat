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
    /// Interaction logic for AgreementWindow.xaml
    /// </summary>
    public partial class AgreementWindow : Window
    {
        AgreementViewModel _vm;

        public AgreementWindow()
        {
            InitializeComponent();
            _vm = new AgreementViewModel();
            DataContext = _vm;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AgreementFormViewModel vm = new AgreementFormViewModel(new Agreement()) { IsNew = true };
            AgreementFormView agreementForm = new AgreementFormView { DataContext = vm };
            agreementForm.ShowDialog();

            var agreementList = _vm.AgreementList;
            if (agreementForm.DialogResult == true)
            {
                agreementList.Add(vm.Agreement);
                vm.AgreementSave();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectAgreement!=null)
            {
                AgreementFormViewModel vm = new AgreementFormViewModel(_vm.SelectAgreement) { IsNew = false };
                AgreementFormView agreementForm = new AgreementFormView { DataContext = vm };
                agreementForm.DataGrid.IsEnabled = false;

                agreementForm.ShowDialog();
            }

        }
    }
}