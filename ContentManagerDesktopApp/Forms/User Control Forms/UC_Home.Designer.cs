namespace ContentManagerDesktopApp
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.contentHistoryLabel = new System.Windows.Forms.Label();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contentHistoryLabel
            // 
            this.contentHistoryLabel.AutoSize = true;
            this.contentHistoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contentHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentHistoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.contentHistoryLabel.Location = new System.Drawing.Point(53, 21);
            this.contentHistoryLabel.Name = "contentHistoryLabel";
            this.contentHistoryLabel.Size = new System.Drawing.Size(237, 37);
            this.contentHistoryLabel.TabIndex = 4;
            this.contentHistoryLabel.Text = "Content History";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mainPictureBox.Image")));
            this.mainPictureBox.Location = new System.Drawing.Point(532, 93);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(365, 312);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 5;
            this.mainPictureBox.TabStop = false;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(532, 438);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentBox.Size = new System.Drawing.Size(365, 88);
            this.commentBox.TabIndex = 6;
            this.commentBox.Text = "No text";
            // 
            // imageList
            // 
            this.imageList.Location = new System.Drawing.Point(60, 93);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(376, 433);
            this.imageList.TabIndex = 7;
            this.imageList.UseCompatibleStateImageBehavior = false;
            this.imageList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageList_MouseClick);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.contentHistoryLabel);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(984, 614);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label contentHistoryLabel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.ListView imageList;
    }
}
