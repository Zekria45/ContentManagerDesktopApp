using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ContentManagerDesktopApp.Forms;
using Dropbox.Api;

namespace ContentManagerDesktopApp
{
    public class MainSystem
    {

        public String userDirectory = @"C:\Content Manager\Users";
        public SQLConnect mySQLConnect = new SQLConnect();
        DropBoxAccess dbAccess; // dropbox access
        string mySQLStatus;
        public User mainUser = new User();

        public MainSystem()
        {
            mySQLStatus = mySQLConnect.message;
            if (!initDropBox())
            {
                dbAccess = new DropBoxAccess("");
            }
        }
        
        // used to be able to login
        public bool VerifyLogin(String username, string password)
        {
            mainUser = mySQLConnect.Login(username, password); 
            if(!(mainUser.id == -1))
            {
                mainUser.LogIn();
                string dropBoxPath = "/Users/" + username;
                createFolder(dropBoxPath); // creating dropbox folder if not already made
                string localMachinePath = userDirectory + "\\" + username;
                downloadImages(dropBoxPath, localMachinePath);//string path, string directory
                return true;
            }
            return false;
        }

        // creates user in mySQL
        public bool CreateUser(string username, string password)
        {
            try
            {
                //('John Smith', '33')";
                string tryEncPass = mySQLConnect.encryptPass(password);
                if (tryEncPass == password)
                {
                    return false;
                }
                var valueList = new List<string>();
                valueList.Add(username);
                valueList.Add(tryEncPass);
                valueList.Add(DateTime.Now.ToString((@"yyyy-MM-dd")));
                valueList.Add(User.UserType.user.ToString());

                string columnValues = sqlCommandBuilder(valueList);

                mySQLConnect.InsertQuery("logininfo", "(username, encryptpass, dateregistered, usertype)", columnValues);

                string directoryValue = "/Users/" + username;
                createFolder(directoryValue); // creating dropbox folder

                CreateUserDirectory(username, tryEncPass);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        
        //create user folder on local machine
        public bool CreateUserDirectory(string username, string password)
        {
            string fullDirectory = Path.Combine(userDirectory,username);
            try
            {
                if (!Directory.Exists(fullDirectory))
                {
                    Directory.CreateDirectory(fullDirectory);
                    Directory.CreateDirectory(fullDirectory + "\\Pictures");
                }
                string fileName = username + "EncrpytData.txt";
                string fileNameLocation = Path.Combine(fullDirectory,fileName);
                if(!File.Exists(fileNameLocation))
                {
                    StreamWriter newFile = new StreamWriter(fileNameLocation);
                    newFile.WriteLine(username + "\n");
                    newFile.WriteLine(password + "\n");
                    newFile.Close();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        //creates initial folder in local machine
        private void CreateInitialDirectory()
        {
            try
            {
                if (!File.Exists(userDirectory))
                {
                    Directory.CreateDirectory(userDirectory);
                }
            }
            catch
            {

            }
        }

        // checks if valid password
        public bool ValidPassword(string password)
        {
            if((password.Length > 5)&&(password.Length < 15))
            {
                if((password.Any(char.IsUpper))&& (password.Any(char.IsLower)))
                {
                    return true;
                }
            }
            return false; ;
        }

        public string sqlCommandBuilder(List<string> valueList) // creates a command that will be sent to SQLConnect
        {
            string firstString = valueList[0];
            string lastString = valueList[valueList.Count - 1];
            string sQ = '\''.ToString(); //single quote required to format string

            // format of the string
            //('John Smith', '33', 'No')
            string command = "";

            int i = 0;
            foreach (string value in valueList)
            {
                if(i == 0)
                {
                    command = command + "(" + sQ + value + sQ + ",";
                }
                else if(i == valueList.Count -1)
                {
                    command = command + sQ + value + sQ + ")";
                }
                else
                {
                    command = command + sQ + value + sQ + ",";
                }
                i++;
            }
            return command;
        }

        //initializing dropbox
        private bool initDropBox()
        {
            try
            {
                string tokenValue = mySQLConnect.getToken();
                dbAccess = new DropBoxAccess(tokenValue);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool createFolder(string path) // create folder for dropbox
        {
            try
            {
                var task = dbAccess.CreateFolder(path);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool checkExistingFolder(string path)
        {
            try
            {
                var task = dbAccess.ListFolder(path);
                task.Wait();
            }
            catch
            {
                return false;
            }

            return false;
        }

        // download images as seperate task from dropbox
        public bool downloadImages(string path, string directory)
        {
            try
            {
                var task = dbAccess.DownloadAll(path, directory);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public GlobalVariables.DropBoxStatus getDropBoxStatus()
        {
            return dbAccess.dBoxStatus;
        }

        public void setDropBoxStatus(GlobalVariables.DropBoxStatus status)
        {
            dbAccess.dBoxStatus = status;
        }

        

    }
}
