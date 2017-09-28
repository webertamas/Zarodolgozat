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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zarodolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;

        public MainWindow()
        {
            var logInWindow = new LogInWindow();
            logInWindow.ShowDialog();
            InitializeComponent();

            _vm = new MainViewModel
            {
                User = logInWindow.ViewModel.AuthenticatedUser
            };

            DataContext = _vm;

        }
    }
}
