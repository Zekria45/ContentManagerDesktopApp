using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ContentManagerDesktopApp.Forms;

namespace ContentManagerDesktopApp
{
    public class MainSystem
    {
        String userDirectory = @"C:\Content Manager\Users";
        public DBConnect mySQLConnect = new DBConnect();
        DropBoxAccess dbAccess = new DropBoxAccess();
        string mySQLStatus;
        public User mainUser = new User();

        public MainSystem()
        {
            mySQLStatus = mySQLConnect.message;
        }

        //private Dictionary<string, Users> CollectionOfusers = new Dictionary<string, Users>();

        public bool VerifyLogin(String username, string password)
        {
            mainUser = mySQLConnect.Login(username, password); 
            if(!(mainUser.id == -1))
            {
                mainUser.LogIn();
                return true;
            }
            return false;
        }

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
                //((DateTime)newsItem).ToString(@"yyyy-MM-dd");
                

                mySQLConnect.InsertQuery("logininfo", "(username, encryptpass, dateregistered, usertype)", columnValues);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        
        public bool CreateUserDirectory(string username, string password)
        {
            string fullDirectory = Path.Combine(userDirectory,username);
            try
            {
                if (!Directory.Exists(fullDirectory))
                {
                    Directory.CreateDirectory(fullDirectory);
                }
                string fileName = username + "EncrpytData.txt";
                string fileNameLocation = Path.Combine(fullDirectory,fileName);
                if(!File.Exists(fileNameLocation))
                {
                    StreamWriter newFile = new StreamWriter(fileNameLocation);
                    newFile.WriteLine(username + "\n");
                    //string encryptedPass = StringCipher.Encrypt(password, EncrpytKey);
                    //newFile.Write(encryptedPass);
                    newFile.Close();

                }
                return true;
            }
            catch
            {
                return false;
            }
        }

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

        public string sqlCommandBuilder(List<string> valueList) // creates a command that will be sent to DBConnect Functions
        {
            string firstString = valueList[0];
            string lastString = valueList[valueList.Count - 1];
            string sQ = '\''.ToString(); //single quote required to format string

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

    }
}
