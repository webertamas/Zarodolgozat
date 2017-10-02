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
        //readonly MainViewModel _vm;

 

        public AgreementWindow()
        {
            InitializeComponent();
            MainViewModel _vm = new MainViewModel();
            DataContext = _vm;
        }
    }
}