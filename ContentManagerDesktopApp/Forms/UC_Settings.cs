using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ContentManagerDesktopApp
{
    public partial class UC_Settings : UserControl
    {
        MainSystem mainSystem;

        public UC_Settings(MainSystem mainSys)
        {
            InitializeComponent();
            mainSystem = mainSys;
            var task = Task.Run((Func<Task>)checkDBoxStatus);
        }

        private void configDBButton_Click(object sender, EventArgs e)
        {
            string directoryValue = "/Users/" + mainSystem.mainUser.userName;
            mainSystem.createFolder(directoryValue); // creating dropbox folder
            
        }

        public async Task checkDBoxStatus()
        {
            while(true)
            {
                Thread.Sleep(500);
                if (mainSystem.getDropBoxStatus() == GlobalVariables.DropBoxStatus.Created)
                {
                    dropBoxStatLabel.Text = "DropBox Status: " + mainSystem.getDropBoxStatus().ToString();
                }
                else if(mainSystem.getDropBoxStatus() == GlobalVariables.DropBoxStatus.Creating)
                {
                    dropBoxStatLabel.Text = "DropBox Status: " + mainSystem.getDropBoxStatus().ToString();
                }
                else
                {
                    dropBoxStatLabel.Text = "DropBox Status: " + mainSystem.getDropBoxStatus().ToString();
                }
                
                
            }
            
        }
    }
}
