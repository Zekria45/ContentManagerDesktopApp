using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManagerDesktopApp
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            listViewProperties();

        }

        private void listViewProperties()
        {
            imageList.View = View.Details;
            imageList.Columns.Add("Images",188);
            imageList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void populateImageList()
        {
            ImageList listOfImages = new ImageList();
            listOfImages.ImageSize = new Size(160,160);

            try
            {
                // populate image list
            }
            catch
            {

            }
        }
    }
}
