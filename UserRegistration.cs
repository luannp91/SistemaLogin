using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class UserRegistration
    {
        private static User[] users =
        {
            new User() { Name = "Johnny", Password = "abc123" },
            new User() { Name = "Emma", Password = "123abc" },
            new User() { Name = "Amy", Password = "abcdef" }
        };

        private static User _loggedUser = null;

        public static User LoggedUser
        {
            get { return _loggedUser; }
            private set { _loggedUser = value; }
        }

        public static bool Login(string name, string password)
        {
            foreach (User user in users)
            {
                if (user.Name == name && user.Password == password)
                {
                    LoggedUser = user;
                    return true;
                }
            }
            return false;
        }
    }
}
