using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api;
//4.6.1 .Net

namespace ContentManagerDesktopApp
{
    class DropBoxAccess
    {
        private static string tokens = "o_IbVJupIAAAAAAAAAAAUJHPZUp68RpGBl7jlfXpAmQI84BU7tZVwjsBOE85E0AK";
        
        
        public DropBoxAccess()
        {
            var task = Task.Run((Func<Task>)Program.Run);
        }

        static async Task Run(string token)
        {
            using (var dbx = new DropboxClient(tokens))
            {

            }
        }
    }
}
