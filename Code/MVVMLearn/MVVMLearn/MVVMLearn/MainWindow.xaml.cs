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

namespace MVVMLearn
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        NameViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = base.DataContext as NameViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.UserName = "测试";
            _viewModel.CompanyName = "微软";
        }
    }
}