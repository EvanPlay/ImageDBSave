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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace ImageDBSave
{
    /// <summary>
    /// Логика взаимодействия для UpdatesWindow.xaml
    /// </summary>
    public partial class UpdatesWindow : Window
    {

        public UpdatesWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MessageWindow messageWindow = new();
            messageWindow.Show();
        }

        //private void btBack_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageWindow messageWindow = new();
        //    messageWindow.Show();
        //    this.Close();
        //}

        private void ListViewItem1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update000());
        }

        private void ListViewItem2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update001());
        }

        private void ListViewItem3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update002());
        }

        private void ListViewItem4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update003());
        }

        private void ListViewItem5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update005());
        }

        private void ListViewItem6_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update006());
        }

        private void ListViewItem7_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update007());
        }

        private void ListViewItem8_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update008());
        }

        private void ListViewItem9_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update009());
        }

        private void ListViewItem10_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update010());
        }

        private void ListViewItem11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            fUpdate.Navigate(new UpdatePage.Update011());
        }
    }
}
