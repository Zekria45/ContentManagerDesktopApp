using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContentManagerDesktopApp
{
    public partial class UC_Home : UserControl
    {
        MainSystem mainSystem;

        public UC_Home(MainSystem mainSys)
        {
            InitializeComponent();
            mainSystem = mainSys;
            populateImageList();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            listViewProperties();

        }

        private void listViewProperties()
        {
            // adjusting properties of list view
            imageList.View = View.Details;
            imageList.Columns.Add("Images",200);
            imageList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void populateImageList()
        {
            ImageList listOfImages = new ImageList();
            listOfImages.ImageSize = new Size(200,200);
            string fullPath = mainSystem.userDirectory + "\\" + mainSystem.mainUser.userName + "\\Pictures";
            List<String> fileNames = new List<string>();

            try
            {
                String[] localPaths = Directory.GetFiles(fullPath);
                // populate image list
                foreach (String path in localPaths)
                {
                    Image img = Image.FromFile(path);
                    string rawPath = path;
                    //gets image name
                    img.Tag = rawPath.Replace(fullPath+"\\","");
                    listOfImages.Images.Add(img);
                    fileNames.Add(img.Tag.ToString());
                }
                imageList.SmallImageList = listOfImages;
                int i = 0;
                foreach(String imgName in fileNames)
                {
                    imageList.Items.Add(imgName,i);
                    i++;
                }
            }
            catch(Exception ex)
            {
                // do nothing
            }
        }

        private void imageList_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string fullPath = mainSystem.userDirectory + "\\" + mainSystem.mainUser.userName + "\\Pictures";
                string fileName = imageList.SelectedItems[0].SubItems[0].Text;
                string endDirectory = fullPath + "\\" + fileName;
                mainPictureBox.Image = Image.FromFile(@endDirectory);
            }
            catch(Exception ex)
            {
                // Do nothing
            }
        }

        private void imageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
