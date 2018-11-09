namespace ContentManagerDesktopApp
{
    partial class UC_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsLabel = new System.Windows.Forms.Label();
            this.configDBButton = new System.Windows.Forms.Button();
            this.dropBoxStatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.settingsLabel.Location = new System.Drawing.Point(53, 21);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(197, 55);
            this.settingsLabel.TabIndex = 5;
            this.settingsLabel.Text = "Settings";
            // 
            // configDBButton
            // 
            this.configDBButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configDBButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.configDBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.configDBButton.ForeColor = System.Drawing.Color.Black;
            this.configDBButton.Location = new System.Drawing.Point(63, 176);
            this.configDBButton.Name = "configDBButton";
            this.configDBButton.Size = new System.Drawing.Size(140, 51);
            this.configDBButton.TabIndex = 6;
            this.configDBButton.Text = "Configure";
            this.configDBButton.UseVisualStyleBackColor = false;
            this.configDBButton.Click += new System.EventHandler(this.configDBButton_Click);
            // 
            // dropBoxStatLabel
            // 
            this.dropBoxStatLabel.AutoSize = true;
            this.dropBoxStatLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dropBoxStatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropBoxStatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dropBoxStatLabel.Location = new System.Drawing.Point(56, 109);
            this.dropBoxStatLabel.Name = "dropBoxStatLabel";
            this.dropBoxStatLabel.Size = new System.Drawing.Size(476, 37);
            this.dropBoxStatLabel.TabIndex = 7;
            this.dropBoxStatLabel.Text = "DropBox Status: Not Configured";
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.dropBoxStatLabel);
            this.Controls.Add(this.configDBButton);
            this.Controls.Add(this.settingsLabel);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(984, 614);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button configDBButton;
        private System.Windows.Forms.Label dropBoxStatLabel;
    }
}
