using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagerDesktopApp
{
    class MainSystem
    {
        static String testUser = "Joe";
        String testPass = "amazon";
        String encryptedTestPass;
        private String EncrpytKey = "boogietime";

        public MainSystem()
        {
            encryptedTestPass= StringCipher.Encrypt(testPass, EncrpytKey);
        }

        private Dictionary<string, Users> CollectionOfusers = new Dictionary<string, Users>();

        public bool VerifyLogin(String username, string password)
        {

            return false;
        }
    }
}
