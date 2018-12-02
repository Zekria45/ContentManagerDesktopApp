using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContentManagerDesktopApp;

namespace ContentManagerDesktopApp.Forms
{
    public partial class MainPage : Form
    {

        MainSystem mainSystem = new MainSystem();
        // creating all panels
        UC_Home hControl;
        UC_Settings sControl;


        public MainPage(MainSystem mainSys)
        {
            InitializeComponent();
            mainSystem = mainSys;
            userNameLabel.Text = mainSystem.mainUser.userName;
            hControl = new UC_Home();
            sControl = new UC_Settings(mainSystem);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            addControlToPanel(hControl);
        }

        public void moveSidePanel(Control pressedButton)
        {
            sidePanel.Top = pressedButton.Top;
            sidePanel.Height = pressedButton.Height;
        }

        private void addControlToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            mainUIPanel.Controls.Clear();
            mainUIPanel.Controls.Add(c);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            moveSidePanel(homeButton);
            addControlToPanel(hControl);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            moveSidePanel(settingsButton);
            addControlToPanel(sControl);
        }

        private void logOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
