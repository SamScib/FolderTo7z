namespace FolderTo7z
{
    partial class MainForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectFromCfgButton = new System.Windows.Forms.Button();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.BackupButton = new System.Windows.Forms.Button();
            this.StatusMessageLabel = new System.Windows.Forms.Label();
            this.SignatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(76, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(294, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Auto Backup to 7z Tool";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(79, 68);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(144, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Select Folders to zip using 7z";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(82, 125);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(88, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse..";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(82, 205);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(88, 23);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SelectFromCfgButton
            // 
            this.SelectFromCfgButton.Location = new System.Drawing.Point(82, 164);
            this.SelectFromCfgButton.Name = "SelectFromCfgButton";
            this.SelectFromCfgButton.Size = new System.Drawing.Size(88, 23);
            this.SelectFromCfgButton.TabIndex = 5;
            this.SelectFromCfgButton.Text = "Get CFG";
            this.SelectFromCfgButton.UseVisualStyleBackColor = true;
            this.SelectFromCfgButton.Click += new System.EventHandler(this.SelectFromCfgButton_Click);
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(206, 125);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(610, 264);
            this.ItemListBox.TabIndex = 6;
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(82, 366);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(88, 23);
            this.BackupButton.TabIndex = 7;
            this.BackupButton.Text = "Backup to 7z!";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // StatusMessageLabel
            // 
            this.StatusMessageLabel.AutoSize = true;
            this.StatusMessageLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StatusMessageLabel.Location = new System.Drawing.Point(203, 402);
            this.StatusMessageLabel.Name = "StatusMessageLabel";
            this.StatusMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusMessageLabel.TabIndex = 8;
            // 
            // SignatureLabel
            // 
            this.SignatureLabel.AutoSize = true;
            this.SignatureLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SignatureLabel.Location = new System.Drawing.Point(203, 465);
            this.SignatureLabel.Name = "SignatureLabel";
            this.SignatureLabel.Size = new System.Drawing.Size(101, 13);
            this.SignatureLabel.TabIndex = 9;
            this.SignatureLabel.Text = "© Samuel Sciberras";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 506);
            this.Controls.Add(this.SignatureLabel);
            this.Controls.Add(this.StatusMessageLabel);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.SelectFromCfgButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.MaximumSize = new System.Drawing.Size(931, 545);
            this.MinimumSize = new System.Drawing.Size(931, 545);
            this.Name = "MainForm";
            this.Text = "Auto Zip Backup Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SelectFromCfgButton;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Label StatusMessageLabel;
        private System.Windows.Forms.Label SignatureLabel;
    }
}

