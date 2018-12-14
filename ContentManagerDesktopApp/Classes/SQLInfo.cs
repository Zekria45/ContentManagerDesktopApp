using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagerDesktopApp
{
    // this class is to provide info to the SQLConnect class from an XML file
    public class SQLInfo
    {
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        public SQLInfo(string server, string database, string uid, string password)
        {
            _server = server;
            _database = database;
            _uid = uid;
            _password = password;
        }

        public void setInfo(string server, string database, string uid, string password)
        {
            _server = server;
            _database = database;
            _uid = uid;
            _password = password;
        }

        public string getServer()
        {
            return _server;
        }

        public string getDataBase()
        {
            return _database;
        }

        public string getId()
        {
            return _uid;
        }

        public string getPassword()
        {
            return _password;
        }
    }
}
