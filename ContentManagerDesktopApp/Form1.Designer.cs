namespace ContentManagerDesktopApp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Login = new System.Windows.Forms.Panel();
            this.newUserLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passLoginTextBox = new System.Windows.Forms.TextBox();
            this.userLoginTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.Label();
            this.contentManagerLabel1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.loginMessageLabel = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.Controls.Add(this.loginMessageLabel);
            this.Login.Controls.Add(this.newUserLabel);
            this.Login.Controls.Add(this.loginButton);
            this.Login.Controls.Add(this.passLoginTextBox);
            this.Login.Controls.Add(this.userLoginTextBox);
            this.Login.Controls.Add(this.loginTextBox);
            this.Login.Controls.Add(this.contentManagerLabel1);
            this.Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Login.ForeColor = System.Drawing.Color.Silver;
            this.Login.Location = new System.Drawing.Point(0, 43);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(498, 462);
            this.Login.TabIndex = 0;
            // 
            // newUserLabel
            // 
            this.newUserLabel.AutoSize = true;
            this.newUserLabel.LinkColor = System.Drawing.Color.Black;
            this.newUserLabel.Location = new System.Drawing.Point(221, 313);
            this.newUserLabel.Name = "newUserLabel";
            this.newUserLabel.Size = new System.Drawing.Size(60, 13);
            this.newUserLabel.TabIndex = 6;
            this.newUserLabel.TabStop = true;
            this.newUserLabel.Text = "New User?";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(137, 348);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(232, 46);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passLoginTextBox
            // 
            this.passLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passLoginTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passLoginTextBox.Location = new System.Drawing.Point(137, 255);
            this.passLoginTextBox.Name = "passLoginTextBox";
            this.passLoginTextBox.Size = new System.Drawing.Size(232, 38);
            this.passLoginTextBox.TabIndex = 4;
            this.passLoginTextBox.Text = "password";
            // 
            // userLoginTextBox
            // 
            this.userLoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.userLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.userLoginTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.userLoginTextBox.Location = new System.Drawing.Point(137, 211);
            this.userLoginTextBox.Name = "userLoginTextBox";
            this.userLoginTextBox.Size = new System.Drawing.Size(232, 38);
            this.userLoginTextBox.TabIndex = 3;
            this.userLoginTextBox.Text = "username";
            // 
            // loginTextBox
            // 
            this.loginTextBox.AutoSize = true;
            this.loginTextBox.Font = new System.Drawing.Font("Verdana", 30F);
            this.loginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginTextBox.Location = new System.Drawing.Point(189, 128);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(128, 48);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Text = "Login";
            // 
            // contentManagerLabel1
            // 
            this.contentManagerLabel1.AutoSize = true;
            this.contentManagerLabel1.Font = new System.Drawing.Font("Verdana", 30F);
            this.contentManagerLabel1.ForeColor = System.Drawing.Color.Black;
            this.contentManagerLabel1.Location = new System.Drawing.Point(67, 49);
            this.contentManagerLabel1.Name = "contentManagerLabel1";
            this.contentManagerLabel1.Size = new System.Drawing.Size(365, 48);
            this.contentManagerLabel1.TabIndex = 0;
            this.contentManagerLabel1.Text = "Content Manager";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Arial", 8.25F);
            this.closeButton.Location = new System.Drawing.Point(461, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minButton
            // 
            this.minButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.Location = new System.Drawing.Point(430, 12);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(25, 25);
            this.minButton.TabIndex = 2;
            this.minButton.Text = "_";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginMessageLabel
            // 
            this.loginMessageLabel.AutoSize = true;
            this.loginMessageLabel.ForeColor = System.Drawing.Color.Black;
            this.loginMessageLabel.Location = new System.Drawing.Point(232, 414);
            this.loginMessageLabel.Name = "loginMessageLabel";
            this.loginMessageLabel.Size = new System.Drawing.Size(27, 13);
            this.loginMessageLabel.TabIndex = 7;
            this.loginMessageLabel.Text = "N/A";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(498, 505);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Label contentManagerLabel1;
        private System.Windows.Forms.Label loginTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.TextBox userLoginTextBox;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passLoginTextBox;
        private System.Windows.Forms.LinkLabel newUserLabel;
        private System.Windows.Forms.Label loginMessageLabel;
    }
}

