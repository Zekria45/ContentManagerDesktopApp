using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api;

namespace ContentManagerDesktopApp
{
    class DropBoxAccess
    {
        static string token = "token-here";

        public DropBoxAccess()
        {
            var task = Task.Run((Func<Task>)DropBoxAccess.Run);
            task.Wait();
        }

        static async Task Run()
        {
            using (var dbx = new DropboxClient(token))
            {
                var list = await dbx.Files.ListFolderAsync(string.Empty);
                foreach (var item in list.Entries.Where(i => i.IsFolder))
                {
                    Console.WriteLine("D  {0}/", item.Name);
                }

                foreach (var item in list.Entries.Where(i => i.IsFile))
                {
                    Console.WriteLine("F{0,8} {1}", item.AsFile.Size, item.Name);
                }
            }
        }
    }
}
