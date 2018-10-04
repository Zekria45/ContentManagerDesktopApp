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
        String testUser = "Joe";
        String testPass = "amazon";
        String encryptedTestPass;
        private String EncrpytKey = "GWvkrOOvtIyxD9pOfyjs";

        public MainSystem()
        {
            encryptedTestPass= StringCipher.Encrypt(testPass, EncrpytKey);
            CreateUser(testUser, testPass);
        }

        private Dictionary<string, Users> CollectionOfusers = new Dictionary<string, Users>();

        public bool VerifyLogin(String username, string password)
        {

            return false;
        }

        public bool CreateUser(string username, string password)
        {
            string fullDirectory = Path.Combine(userDirectory,testUser);
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
                    File.Create(fileNameLocation);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
