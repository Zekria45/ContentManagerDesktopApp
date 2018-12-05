using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Dropbox.Api;
using Dropbox.Api.Common;
using Dropbox.Api.Files;
using Dropbox.Api.Team;

namespace ContentManagerDesktopApp
{
    // code based on https://github.com/dropbox/dropbox-sdk-dotnet/blob/master/dropbox-sdk-dotnet/Examples/SimpleTest/Program.cs#L239

    class DropBoxAccess
    {
        
        public GlobalVariables.DropBoxStatus dBoxStatus = GlobalVariables.DropBoxStatus.NotCreated;

        private string token = "";
        DropboxClient client;

        public DropBoxAccess(string tokenToUse)
        {
            token = tokenToUse;
            client = new DropboxClient(token);
        }
        

        // Create a foler in dropbox
        public async Task<FolderMetadata> CreateFolder(string path) //DropboxClient client, 
        {
            dBoxStatus = GlobalVariables.DropBoxStatus.Creating;
            var folderArg = new CreateFolderArg(path);
            var folder = await client.Files.CreateFolderV2Async(folderArg);
            Console.WriteLine("Folder: " + path + " created!");
            dBoxStatus = GlobalVariables.DropBoxStatus.Created;

            return folder.Metadata;
        }

        // List folders from dropbox
        public async Task<ListFolderResult> ListFolder(string path)
        {
            Console.WriteLine("--- Files ---");
            var list = await client.Files.ListFolderAsync(path);

            // show folders then files
            foreach (var item in list.Entries.Where(i => i.IsFolder))
            {
                Console.WriteLine("D  {0}/", item.Name);
            }

            foreach (var item in list.Entries.Where(i => i.IsFile))
            {
                var file = item.AsFile;

                Console.WriteLine("F{0,8} {1}",
                    file.Size,
                    item.Name);
            }

            if (list.HasMore)
            {
                Console.WriteLine("   ...");
            }
            return list;
        }

        // folder is folder in dropbox, file is the file in dropbox, directory is where you want it downloaded on local machine
        public async Task Download(string folder, string file, string directory)
        {
            string localFilePath = directory;//@"C:\Content Manager\Users\" + name;
            using (var response = await client.Files.DownloadAsync("/" + folder + "/" + file))
            {
                using (var fileStream = File.Create(localFilePath))
                {
                    (await response.GetContentAsStreamAsync()).CopyTo(fileStream);

                }
            }
        }
        
        // downloads all files in a dropbox folder
        // path is path in dropbox, directory is directory on local machine
        public async Task DownloadAll(string path, string directory)
        {
            try
            {
                var list = await client.Files.ListFolderAsync(path);

                foreach (var item in list.Entries.Where(i => i.IsFile))
                {
                    var file = item.AsFile;
                    string fileName = file.Name;

                    using (var response = await client.Files.DownloadAsync(path + "/" + fileName))
                    {
                        string nameDirectory = directory + "\\Pictures\\" + file.Name;
                        using (var fileStream = File.OpenWrite(nameDirectory))
                        {
                            (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                // do nothing
            }
            

        }
        
    }
}
