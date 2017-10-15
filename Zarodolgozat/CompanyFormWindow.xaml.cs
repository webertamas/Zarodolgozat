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
    /// Interaction logic for CompanyFormView.xaml
    /// </summary>
    public partial class CompanyFormView : Window
    {
        CompanyFormViewModel _vm;

        public CompanyFormView()
        {
            InitializeComponent();
            _vm = new CompanyFormViewModel(new Company());
            DataContext = _vm;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var companyVM = (CompanyFormViewModel)DataContext;
            if (!companyVM.CompanyValidate())
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
