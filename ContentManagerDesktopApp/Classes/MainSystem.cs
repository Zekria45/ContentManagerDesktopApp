using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContentManagerDesktopApp
{
    class MainSystem
    {
        String userDirectory = @"C:\Content Manager\Users";
        private String EncrpytKey = "GWvkrOOvtIyxD9pOfyjs";

        public MainSystem()
        {

        }

        //private Dictionary<string, Users> CollectionOfusers = new Dictionary<string, Users>();

        public bool VerifyLogin(String username, string password)
        {
            return false;
        }

        public bool CreateUser(string username, string password)
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
                    string encryptedPass = StringCipher.Encrypt(password, EncrpytKey);
                    newFile.Write(encryptedPass);
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
    }
}
