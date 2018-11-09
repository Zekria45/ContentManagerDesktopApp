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
    public partial class UC_Settings : UserControl
    {
        MainSystem mainSystem;

        public UC_Settings(MainSystem mainSys)
        {
            InitializeComponent();
            mainSystem = mainSys;
        }

        private void configDBButton_Click(object sender, EventArgs e)
        {

        }
    }
}
