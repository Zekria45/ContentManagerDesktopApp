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
        public MainPage(MainSystem mainSystem)
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

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
            UC_Home uControl = new UC_Home();
            addControlToPanel(uControl);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            moveSidePanel(userButton);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            moveSidePanel(settingsButton);
        }

        private void logOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
