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
            this.components = new System.ComponentModel.Container();
            this.displayPicture = new System.Windows.Forms.PictureBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contentHistoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // displayPicture
            // 
            this.displayPicture.Location = new System.Drawing.Point(564, 74);
            this.displayPicture.Name = "displayPicture";
            this.displayPicture.Size = new System.Drawing.Size(337, 309);
            this.displayPicture.TabIndex = 1;
            this.displayPicture.TabStop = false;
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(564, 411);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(337, 107);
            this.commentBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.contentHistoryLabel);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.displayPicture);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(984, 614);
            ((System.ComponentModel.ISupportInitialize)(this.displayPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayPicture;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label contentHistoryLabel;
    }
}
