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

namespace ImageDBSave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string UserStatus)
        {
            InitializeComponent();
            if (UserStatus == "UnName")
            {
                cbIncogniton.Visibility = Visibility.Collapsed;
                btEnter.Visibility = Visibility.Visible;
            }
            else
            {
                cbIncogniton.Visibility = Visibility.Visible;
                btEnter.Visibility = Visibility.Collapsed;
            }
        }


        private void cbIncogniton_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изображение будет загружено в режиме инкогнито.");
        }

        private void cbIncogniton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изображение будет загружено с учётом bмени автора загрузки.");
        }
        private void cbIncogniton_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Неизвестная ошибка. Мы не можем понять, как вы умудрились ответить на вопрос \"да или нет\" - \"да, нет\".");
        }

        private void btImageLoaded_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция находится в разработке.");
        }

        private void btImaegSearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция находится в разработке.");
        }

        //public void AplicationClose(object sender, CancelEventArgs e)
        //{
        //    if (MessageBox.Show("Вы уверены, что хотите закрыть прилоежние?", "Закрыть приложение?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
        //    {
        //        e.Cancel = false;
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }
        //}
        //Перенести в отдельный класс

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new();
            authorizationWindow.Show();
            Close();
        }
    }
}