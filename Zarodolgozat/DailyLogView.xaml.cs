﻿using System;
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
    /// Interaction logic for DailyLogView.xaml
    /// </summary>
    public partial class DailyLogView : Window
    {
        public DailyLogView()
        {
            InitializeComponent();
            AgreementViewModel _vm = new AgreementViewModel();
            DataContext = _vm;
        }
    }
}
