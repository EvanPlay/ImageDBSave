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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void cbInkognito_Unchecked(object sender, RoutedEventArgs e)
        {
            tbUserName.IsReadOnly = false;
            tbUserName.Text = "";
        }

        private void cbInkognito_Checked(object sender, RoutedEventArgs e)
        {
            tbUserName.IsReadOnly = true;
            tbUserName.Foreground = Brushes.Gray;
            tbUserName.Text = "UnName";
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            if(cbInkognito.IsChecked  == true)
            {
                string UserStatus = tbUserName.Text;
                new MainWindow(UserStatus).ShowDialog();
                //MainWindow mainWindow = new(IdUser);
                //mainWindow.ShowDialog();
                Close();
            }
            else
            {
                if(tbUserName.Text.Length >0)
                {
                    if(pbUserPassword.Password.Length >0)
                    {
                        string UserStatus = tbUserName.Text;
                        new MainWindow(UserStatus).ShowDialog();
                        //MainWindow mainWindow = new(IdUser);
                        //mainWindow.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле пароля.");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните поле имя-пароль.");
                }
            }
        }
    }
}
