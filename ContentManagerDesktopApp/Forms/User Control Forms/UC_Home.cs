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
            imageList.View = View.Details;
            imageList.Columns.Add("Images",200);
            imageList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void populateImageList()
        {
            ImageList listOfImages = new ImageList();
            listOfImages.ImageSize = new Size(200,200);
            string fullPath = mainSystem.userDirectory + "\\" + mainSystem.mainUser.userName + "\\Pictures";
            

            try
            {
                String[] localPaths = Directory.GetFiles(fullPath);
                // populate image list
                foreach (String path in localPaths)
                {
                    listOfImages.Images.Add(Image.FromFile(path));
                }
                imageList.SmallImageList = listOfImages;
                int i = 0;
                foreach(Image img in imageList.SmallImageList.Images)
                {
                    imageList.Items.Add("test",i);
                    i++;
                }
                //imageList.Items.Add("Test", 0);
                //imageList.Items.Add("Test", 0);

            }
            catch
            {
                // do nothing
            }
        }
    }
}
