using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ContentManagerDesktopApp
{
    // code is based off https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
    // database connect

    public class SQLConnect
    {
        static string failedKey = "failed key";

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public string message = "";

        //Constructor
        public SQLConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "userdatabasecm";
            uid = "codeadmin";
            password = "-password024-";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        message = "Cannot connect to server.  Contact administrator";
                        break;

                    case 1045:
                        message = "Invalid username/password, please try again";
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        //Insert statement
        public void InsertQuery(string tableName, string columnNames, string columnValues)
        {
            // example of query
            //"INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            string query = "INSERT INTO " + tableName + " " + columnNames + " VALUES" + columnValues;

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                catch(Exception ex)
                {
                    this.CloseConnection();
                }
                
            }
        }

        //Check login
        public User Login(string loginUser, string password)
        {
            string query = "SELECT * FROM logininfo";
            User nullUser = new User();
            string encryptKey = getSysInfo("encryptkey");// encryptkey
            //string encrpyedPass = encryptPass(password);

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string pulledEncPass = dataReader["encryptpass"] + "";
                    string rawPass = StringCipher.Decrypt(pulledEncPass,encryptKey);
                    if (((dataReader["username"] + "") == loginUser))
                    {
                        if(password == rawPass)
                        {
                            int id = Convert.ToInt32(dataReader["iduser"] + "");
                            string userName = dataReader["username"] + "";
                            string passWord = rawPass;
                            User createdUser = new User(id, userName, passWord);
                            dataReader.Close();
                            this.CloseConnection();
                            return createdUser;
                        }
                    }
                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();
            }
            else
            {
                return nullUser;
            }
            return nullUser;
        }

        private string getSysInfo(string valueToPull)
        {
            string systemValue = failedKey;
            //string query = "Select encryptkey from systeminfo where idsysteminfo=1";
            string query = "Select " + valueToPull + " from systeminfo where idsysteminfo=1";

            
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        systemValue = dataReader[valueToPull] + "";
                    }
                    //close Data Reader
                    dataReader.Close();
                }
                catch(Exception ex)
                {
                    this.CloseConnection();
                }
                this.CloseConnection();
            }
            //close Connection
            return systemValue;
        }

        public string getToken()
        {
            string tokenValue = "";
            try
            {
                tokenValue = getSysInfo("dropboxtoken");
                return tokenValue;
            }
            catch(Exception ex)
            {
                return tokenValue;
            }

            
        }

        public string encryptPass(string rawPass)
        {
            try
            {
                return StringCipher.Encrypt(rawPass, getSysInfo("encryptkey"));
            }
            catch(Exception ex)
            {
                return rawPass;
            }
        }

        public string decryptPass(string encPass)
        {
            try
            {
                return StringCipher.Decrypt(encPass, getSysInfo("encryptkey"));
            }
            catch(Exception ex)
            {
                return encPass;
            }
        }
    }
}
