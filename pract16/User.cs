using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract16
{
    internal class User
    {


        public static List<User> Users = new List<User>();

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
            Users.Add(this);
        }

        public string login { get; set; }
        public string password { get; set; }


    }
}
