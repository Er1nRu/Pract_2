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

namespace pract16
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
            auth.IsEnabled = false;
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            bool usrExist = false;
            foreach (var item in User.Users)
            {
                if(item.login == Login.Text & item.password == Password.Text)
                {
                    Users users = new Users(item.login, item.password);
                    users.ShowDialog();
                    usrExist = true;
                } else
                {
                    usrExist = false; 
                }
            }
            if (!usrExist)
            {
                MessageBox.Show("Такого пользователя не существует!");
            }
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Login.Text != "" & Password.Text != "")
            {
                auth.IsEnabled = true;
            }
            else
            {
                auth.IsEnabled = false;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Login.Text = "";
            Password.Text = "";
        }
    }
}
