using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentManagerDesktopApp
{
    public partial class Home : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        MainSystem mainSystem = new MainSystem();

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // minimize button
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(mainSystem.VerifyLogin(userLoginTextBox.Text, passLoginTextBox.Text) == false)
            {
                loginMessageLabel.Visible = true;
                loginMessageLabel.Text = "Invalid Login";
            }
        }

        private void userLoginTextBox_Click(object sender, EventArgs e)
        {
            userLoginTextBox.Text = "";
            userLoginTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void passLoginTextBox_Click(object sender, EventArgs e)
        {
            passLoginTextBox.Text = "";
            passLoginTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void userLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            userLoginTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void passLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            passLoginTextBox.ForeColor = System.Drawing.Color.Black;
            passLoginTextBox.PasswordChar = '*';
        }

        private void userLoginTextBox_Enter(object sender, EventArgs e)
        {
            userLoginTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
