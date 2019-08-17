namespace PLEXRenamer
{
    partial class frmMain
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
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.dlgOpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstEpisodes = new System.Windows.Forms.ListBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.prgRenaming = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(12, 9);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(61, 13);
            this.lblFolderPath.TabIndex = 0;
            this.lblFolderPath.Text = "Folder Path";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(15, 25);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(410, 20);
            this.txtFolderPath.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(431, 23);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(113, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolder_Click);
            // 
            // txtShowName
            // 
            this.txtShowName.Location = new System.Drawing.Point(15, 64);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.Size = new System.Drawing.Size(410, 20);
            this.txtShowName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TV Show Name";
            // 
            // lstEpisodes
            // 
            this.lstEpisodes.FormattingEnabled = true;
            this.lstEpisodes.HorizontalScrollbar = true;
            this.lstEpisodes.Location = new System.Drawing.Point(15, 90);
            this.lstEpisodes.Name = "lstEpisodes";
            this.lstEpisodes.Size = new System.Drawing.Size(410, 420);
            this.lstEpisodes.TabIndex = 5;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(431, 90);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(113, 23);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // prgRenaming
            // 
            this.prgRenaming.Location = new System.Drawing.Point(431, 119);
            this.prgRenaming.Name = "prgRenaming";
            this.prgRenaming.Size = new System.Drawing.Size(113, 23);
            this.prgRenaming.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 517);
            this.Controls.Add(this.prgRenaming);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.lstEpisodes);
            this.Controls.Add(this.txtShowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.lblFolderPath);
            this.Name = "frmMain";
            this.Text = "PLEX Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog dlgOpenFolder;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEpisodes;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.ProgressBar prgRenaming;
    }
}

