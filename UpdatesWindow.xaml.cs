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

        List<VersionPO> versionPOs = new List<VersionPO>()
        {
            new VersionPO() { ID=0 , Name="Версия 0.0.0"} ,
            new VersionPO() { ID=1 , Name="Версия 0.0.1"} ,
            new VersionPO() { ID=2 , Name="Версия 0.0.2"} ,
            new VersionPO() { ID=3 , Name="Версия 0.0.3"} ,
            new VersionPO() { ID=5 , Name="Версия 0.0.4 - 0.0.5"} ,
            new VersionPO() { ID=6 , Name="Версия 0.0.6"} ,
            new VersionPO() { ID=7 , Name="Версия 0.0.7"} ,
            new VersionPO() { ID=8 , Name="Версия 0.0.8"} ,
            new VersionPO() { ID=9 , Name="Версия 0.0.9"} ,
            new VersionPO() { ID=10 , Name="Версия 0.0.10"} ,
            new VersionPO() { ID=11 , Name="Версия 0.0.11"} ,
            new VersionPO() { ID=12 , Name="Версия 0.0.12"} ,
        };


        public UpdatesWindow()
        {
            InitializeComponent();
            lBVers.ItemsSource = versionPOs;
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

        

        //private void ListViewItem11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    fUpdate.Navigate(new UpdatePage.Update011());
        //}


        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Border)
            {
                var ob = (Border)e.OriginalSource;
                var content = ob.DataContext as VersionPO;
                if (content != null)
                {
                    switch (content.ID.ToString())
                    {
                        case "0": fUpdate.Navigate(new UpdatePage.Update000()); break;
                        case "1": fUpdate.Navigate(new UpdatePage.Update001()); break;
                        case "2": fUpdate.Navigate(new UpdatePage.Update002()); break;
                        case "3": fUpdate.Navigate(new UpdatePage.Update003()); break;
                        case "5": fUpdate.Navigate(new UpdatePage.Update005()); break;
                        case "6": fUpdate.Navigate(new UpdatePage.Update006()); break;
                        case "7": fUpdate.Navigate(new UpdatePage.Update007()); break;
                        case "8": fUpdate.Navigate(new UpdatePage.Update008()); break;
                        case "9": fUpdate.Navigate(new UpdatePage.Update009()); break;
                        case "10": fUpdate.Navigate(new UpdatePage.Update010()); break;
                        case "11": fUpdate.Navigate(new UpdatePage.Update011()); break;
                        case "12": fUpdate.Navigate(new UpdatePage.Update012()); break;
                    }
                }
            }

            if (e.OriginalSource is TextBlock)
            {
                var ob = (TextBlock)e.OriginalSource;
                var content = ob.DataContext as VersionPO;
                if (content != null)
                {
                    switch (content.ID.ToString())
                    {
                        case "0": fUpdate.Navigate(new UpdatePage.Update000()); break;
                        case "1": fUpdate.Navigate(new UpdatePage.Update001()); break;
                        case "2": fUpdate.Navigate(new UpdatePage.Update002()); break;
                        case "3": fUpdate.Navigate(new UpdatePage.Update003()); break;
                        case "5": fUpdate.Navigate(new UpdatePage.Update005()); break;
                        case "6": fUpdate.Navigate(new UpdatePage.Update006()); break;
                        case "7": fUpdate.Navigate(new UpdatePage.Update007()); break;
                        case "8": fUpdate.Navigate(new UpdatePage.Update008()); break;
                        case "9": fUpdate.Navigate(new UpdatePage.Update009()); break;
                        case "10": fUpdate.Navigate(new UpdatePage.Update010()); break;
                        case "11": fUpdate.Navigate(new UpdatePage.Update011()); break;
                        case "12": fUpdate.Navigate(new UpdatePage.Update012()); break;
                    }
                }
            }
        }
    }
}
