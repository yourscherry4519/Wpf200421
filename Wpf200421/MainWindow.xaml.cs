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

namespace Wpf200421
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen.Visibility = Visibility.Collapsed;
            ButtonClose.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Page pg = null;
            switch(((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "MainItem":
                    pg = new Page1();
                    MainFrame.Navigate(pg);
                    break;

                case "FirstItem":
                    pg = new Page2();
                    MainFrame.Navigate(pg);
                    break;

                case "ForItem":
                    pg = new Page3();
                    MainFrame.Navigate(pg);
                    break;

                case "SItem":
                    pg = new Page4();
                    MainFrame.Navigate(pg);
                    break;

                case "DItem":
                    pg = new Page5();
                    MainFrame.Navigate(pg);
                    break;
            }

        }
    }
}
