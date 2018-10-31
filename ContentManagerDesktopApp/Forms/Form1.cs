using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContentManagerDesktopApp.Forms;

namespace ContentManagerDesktopApp
{
    public partial class Home : Form
    {
        enum WindowMode { Login, Register }
        // allows moving of windows form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        WindowMode currentMode = WindowMode.Login;

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
            passLoginTextBoxConfirm.Visible = false;
        }

        private void minButton_Click(object sender, EventArgs e) // minimize button
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e) // close button
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e) // behavior for pressing main action button (login/Regiser)
        {
            if (currentMode == WindowMode.Login)
            {
                if (mainSystem.VerifyLogin(userLoginTextBox.Text, passLoginTextBox.Text) == false)
                {
                    setMessage("Invalid Login");
                }
                else
                {   
                    MainPage newPage = new MainPage(mainSystem);
                    newPage.Show();
                }
            }
            else if (currentMode == WindowMode.Register)
            {
                if (passLoginTextBox.Text == passLoginTextBoxConfirm.Text)
                {
                    if(mainSystem.ValidPassword(passLoginTextBox.Text))
                    {
                        if (mainSystem.CreateUser(userLoginTextBox.Text, passLoginTextBox.Text))
                        {
                            switchMode();
                            setMessage("User Created");
                        }
                        else
                        {
                            setMessage("Failed to create user");
                        }
                    }
                    else
                    {
                        setMessage("Must have upper/lower case and more than 5 characters.");
                    }
                }
                else
                {
                    setMessage("passwords do not match");
                }

            }
            else
            {
                setMessage("Unkown Bug");
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

        private void passLoginTextBoxConfirm_Click(object sender, EventArgs e)
        {
            passLoginTextBoxConfirm.Text = "";
            passLoginTextBoxConfirm.ForeColor = System.Drawing.Color.Black;
        }

        private void userLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            userLoginTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void passLoginTextBox_TextChanged(object sender, EventArgs e)
        {
            passLoginTextBox.ForeColor = System.Drawing.Color.Black;
            passLoginTextBox.UseSystemPasswordChar = true;
        }

        private void passLoginTextBoxConfirm_TextChanged(object sender, EventArgs e)
        {
            passLoginTextBoxConfirm.ForeColor = System.Drawing.Color.Black;
            passLoginTextBoxConfirm.UseSystemPasswordChar = true;

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

        private void newUserLabel_Click(object sender, EventArgs e)
        {
            switchMode();
        }

        public void switchMode() // method from switching from register mode to login mode 
        {
            if(currentMode == WindowMode.Login)
            {
                currentMode = WindowMode.Register;

                loginMessageLabel.Visible = false;
                passLoginTextBox.Text = "";
                passLoginTextBox.UseSystemPasswordChar = false;
                passLoginTextBoxConfirm.UseSystemPasswordChar = false;
                userLoginTextBox.Text = "username";
                passLoginTextBox.Text = "password";
                passLoginTextBoxConfirm.Text = "confirm password";
                loginTextBox.Text = "Register";
                loginTextBox.Location = new Point(160, 174);
                loginButton.Text = "Register";
                newUserLabel.Visible = false;
                passLoginTextBoxConfirm.Visible = true;
            }
            else
            {
                currentMode = WindowMode.Login;

                loginMessageLabel.Visible = false;
                userLoginTextBox.Text = "username";
                passLoginTextBox.Text = "";
                passLoginTextBox.UseSystemPasswordChar = true;
                passLoginTextBox.Text = "password";
                passLoginTextBoxConfirm.Visible = false;
                newUserLabel.Visible = true;
                loginButton.Text = "Login";
                loginTextBox.Text = "Login";
                loginTextBox.Location = new Point(189, 174);
            }
        }

        public void setMessage(string message)
        {
            loginMessageLabel.Visible = true;
            loginMessageLabel.Text = message;

            loginMessageLabel.Visible = true;
            loginMessageLabel.AutoSize = false;
            loginMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            loginMessageLabel.Dock = DockStyle.Bottom;
        }
    }
}
