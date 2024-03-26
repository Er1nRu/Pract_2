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
    /// Логика взаимодействия для Generate.xaml
    /// </summary>
    public partial class Generate : Page
    {
        string[] usernames = { "Alex123", "Emma456", "Max789", "Sophia111", "Ryan333", "Olivia555", "Luke777", "Ava999", "Liam222", "Isabella444" };

        string[] passwords = { "qwerty123", "password456", "letmein789", "123456abc", "secure123", "pass123word", "hello1234", "welcome567", "password123", "abc123def" };
        public Generate()
        {
            InitializeComponent();
            count.Content = "Кол-во пользователей: ";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            for(int i = 0; i < sld.Value; i++)
            {
                new User(usernames[r.Next(usernames.Length)], passwords[r.Next(passwords.Length)]);
            }
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            count.Content = $"Кол-во пользователей: {(int)sld.Value}";
        }
    }
}
