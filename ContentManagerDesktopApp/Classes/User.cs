using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagerDesktopApp
{
    public class User
    {
        public enum UserType {admin, user }
        public UserType usertype = UserType.user;
        public String userName;
        private String _password;
        public int id;
        public bool loggedIn = false;
        public bool validUser = false;

        public User (int currentID, string username, string password)
        {
            id = currentID;
            userName = username;
            _password = password;
        }

        public User ()
        {
            id = -1;
            userName = "no user";
            _password = "no pass";
        }
    }
}
