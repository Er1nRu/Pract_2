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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
            reg.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usr = new User(Login.Text, Password.Text);
            Users users = new Users(usr.login,usr.password);
            users.ShowDialog();
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Login.Text != "" & Password.Text != "")
            {
                reg.IsEnabled = true;
            } else
            {
                reg.IsEnabled = false;
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Login.Text = "";
            Password.Text = "";
        }
    }
}
