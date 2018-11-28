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
        private bool _loggedIn = false;

        public User (int currentID, string username, string password)
        {
            id = currentID;
            userName = username;
            _password = password;
        }

        public User ()
        {
            id = -1; // -1 is invalid user
            userName = "no user";
            _password = "no pass";
        }

        public void LogIn()
        {
            _loggedIn = true;
        }

        public void LogOut()
        {
            _loggedIn = false;
        }
        
        
    }
}
