using ImageDBSave.ProgramPage;
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

namespace ImageDBSave
{
    /// <summary>
    /// Логика взаимодействия для ImageLoadedWindow.xaml
    /// </summary>
    public partial class ImageLoadedWindow : Window
    {
        public ImageLoadedWindow(string UserStatus, string testFileName)
        {
            InitializeComponent();
            lUserStatus.Content += UserStatus;
            Loaded += ImageShow_Loaded;

            tbFileName.Text = testFileName;


            cbCorrectAccess.Visibility = Visibility.Collapsed;

            cbAccess.ItemsSource = new DB.User[]
            {
                new DB.User { StatusUser = "Test1"},
                new DB.User { StatusUser = "Test2"}
            };

            cbCorrectAccess.ItemsSource = new DB.User[]
            {
                new DB.User {Name = "Test3"},
                new DB.User {Name = "Test4"}
            };
            cbAccess.SelectedIndex = 0;
        }

        public void ImageShow_Loaded(object sender, RoutedEventArgs e)
        {
            fImageLoaded.Navigate(new ImageShowPage());

            //AppCommands appCommands = new(); //не работает
            //appCommands.ImageLoaded((x) => tbFileName.Text(x));
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btDownlodead_Click(object sender, RoutedEventArgs e)
        {
            AppCommands appCommands = new();
            appCommands.ImageLoaded((x) => MessageBox.Show(x));
        }

        private void cbAccess_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbAccess.SelectedItem != null)
            {
                cbCorrectAccess.Visibility=Visibility.Collapsed;
            }
            if(cbAccess.SelectedIndex is 1)
            {
                cbCorrectAccess.Visibility = Visibility.Visible;
            }
        }
    }
}
