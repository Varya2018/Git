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

namespace Dekt1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Bth_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Отрасль());
            // Manager.MainFrame = MainFrame;
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CIZ());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Тб());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new instryment());
        }
    }
}
