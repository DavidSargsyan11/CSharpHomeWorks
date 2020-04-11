namespace Test2
{
    partial class ListItem
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
            this.lblSArtist = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSArtist
            // 
            this.lblSArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSArtist.Enabled = false;
            this.lblSArtist.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSArtist.ForeColor = System.Drawing.Color.Black;
            this.lblSArtist.Location = new System.Drawing.Point(345, 9);
            this.lblSArtist.Name = "lblSArtist";
            this.lblSArtist.Size = new System.Drawing.Size(152, 30);
            this.lblSArtist.TabIndex = 5;
            this.lblSArtist.Text = "Artist";
            this.lblSArtist.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lblSArtist.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSName.AutoEllipsis = true;
            this.lblSName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSName.ForeColor = System.Drawing.Color.Black;
            this.lblSName.Location = new System.Drawing.Point(3, 9);
            this.lblSName.Name = "lblSName";
            this.lblSName.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblSName.Size = new System.Drawing.Size(336, 30);
            this.lblSName.TabIndex = 4;
            this.lblSName.Text = "Name";
            this.lblSName.Click += new System.EventHandler(this.ListItem_Click);
            this.lblSName.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.lblSName.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            // 
            // lblSTime
            // 
            this.lblSTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTime.Enabled = false;
            this.lblSTime.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSTime.ForeColor = System.Drawing.Color.Black;
            this.lblSTime.Location = new System.Drawing.Point(712, 9);
            this.lblSTime.Name = "lblSTime";
            this.lblSTime.Size = new System.Drawing.Size(85, 30);
            this.lblSTime.TabIndex = 6;
            this.lblSTime.Text = "0:00";
            this.lblSTime.Click += new System.EventHandler(this.ListItem_Click);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSTime);
            this.Controls.Add(this.lblSArtist);
            this.Controls.Add(this.lblSName);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(805, 44);
            this.Click += new System.EventHandler(this.ListItem_Click);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSArtist;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSTime;
    }
}
