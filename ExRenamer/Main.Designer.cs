namespace ExRenamer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.TextBox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.settingsGroup = new System.Windows.Forms.GroupBox();
            this.isFilesAndFolders = new System.Windows.Forms.RadioButton();
            this.isFolders = new System.Windows.Forms.RadioButton();
            this.isFiles = new System.Windows.Forms.RadioButton();
            this.isRecursive = new System.Windows.Forms.CheckBox();
            this.rename = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.Button();
            this.numberPad = new System.Windows.Forms.NumericUpDown();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.numberPadLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.scanMatch = new System.Windows.Forms.CheckBox();
            this.isTitleCase = new System.Windows.Forms.CheckBox();
            this.isLowercase = new System.Windows.Forms.CheckBox();
            this.scanRep = new System.Windows.Forms.TextBox();
            this.scanRepLabel = new System.Windows.Forms.Label();
            this.scan = new System.Windows.Forms.TextBox();
            this.scanLabel = new System.Windows.Forms.Label();
            this.suffix = new System.Windows.Forms.TextBox();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.searchPattern = new System.Windows.Forms.TextBox();
            this.outputGrid = new System.Windows.Forms.DataGridView();
            this.entryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.settingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dir";
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.folder.ForeColor = System.Drawing.Color.Navy;
            this.folder.Location = new System.Drawing.Point(38, 9);
            this.folder.MaximumSize = new System.Drawing.Size(560, 16);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(201, 15);
            this.folder.TabIndex = 1;
            this.folder.Text = "Drag n\' drop a dir or click here to choose";
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(77, 18);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(250, 20);
            this.prefix.TabIndex = 0;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixLabel.Location = new System.Drawing.Point(23, 21);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(33, 13);
            this.prefixLabel.TabIndex = 3;
            this.prefixLabel.Text = "Prefix";
            // 
            // settingsGroup
            // 
            this.settingsGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsGroup.Controls.Add(this.isFilesAndFolders);
            this.settingsGroup.Controls.Add(this.isFolders);
            this.settingsGroup.Controls.Add(this.isFiles);
            this.settingsGroup.Controls.Add(this.isRecursive);
            this.settingsGroup.Controls.Add(this.rename);
            this.settingsGroup.Controls.Add(this.preview);
            this.settingsGroup.Controls.Add(this.numberPad);
            this.settingsGroup.Controls.Add(this.number);
            this.settingsGroup.Controls.Add(this.numberPadLabel);
            this.settingsGroup.Controls.Add(this.numberLabel);
            this.settingsGroup.Controls.Add(this.scanMatch);
            this.settingsGroup.Controls.Add(this.isTitleCase);
            this.settingsGroup.Controls.Add(this.isLowercase);
            this.settingsGroup.Controls.Add(this.scanRep);
            this.settingsGroup.Controls.Add(this.scanRepLabel);
            this.settingsGroup.Controls.Add(this.scan);
            this.settingsGroup.Controls.Add(this.scanLabel);
            this.settingsGroup.Controls.Add(this.suffix);
            this.settingsGroup.Controls.Add(this.suffixLabel);
            this.settingsGroup.Controls.Add(this.prefix);
            this.settingsGroup.Controls.Add(this.prefixLabel);
            this.settingsGroup.Location = new System.Drawing.Point(15, 32);
            this.settingsGroup.Name = "settingsGroup";
            this.settingsGroup.Size = new System.Drawing.Size(782, 186);
            this.settingsGroup.TabIndex = 4;
            this.settingsGroup.TabStop = false;
            this.settingsGroup.Text = "Settings";
            // 
            // isFilesAndFolders
            // 
            this.isFilesAndFolders.AutoSize = true;
            this.isFilesAndFolders.Location = new System.Drawing.Point(219, 154);
            this.isFilesAndFolders.Name = "isFilesAndFolders";
            this.isFilesAndFolders.Size = new System.Drawing.Size(104, 17);
            this.isFilesAndFolders.TabIndex = 12;
            this.isFilesAndFolders.Text = "Files and Folders";
            this.isFilesAndFolders.UseVisualStyleBackColor = true;
            // 
            // isFolders
            // 
            this.isFolders.AutoSize = true;
            this.isFolders.Location = new System.Drawing.Point(219, 131);
            this.isFolders.Name = "isFolders";
            this.isFolders.Size = new System.Drawing.Size(59, 17);
            this.isFolders.TabIndex = 11;
            this.isFolders.Text = "Folders";
            this.isFolders.UseVisualStyleBackColor = true;
            // 
            // isFiles
            // 
            this.isFiles.AutoSize = true;
            this.isFiles.Checked = true;
            this.isFiles.Location = new System.Drawing.Point(219, 108);
            this.isFiles.Name = "isFiles";
            this.isFiles.Size = new System.Drawing.Size(46, 17);
            this.isFiles.TabIndex = 10;
            this.isFiles.TabStop = true;
            this.isFiles.Text = "Files";
            this.isFiles.UseVisualStyleBackColor = true;
            // 
            // isRecursive
            // 
            this.isRecursive.AutoSize = true;
            this.isRecursive.Location = new System.Drawing.Point(26, 155);
            this.isRecursive.Name = "isRecursive";
            this.isRecursive.Size = new System.Drawing.Size(74, 17);
            this.isRecursive.TabIndex = 9;
            this.isRecursive.Text = "Recursive";
            this.isRecursive.UseVisualStyleBackColor = true;
            // 
            // rename
            // 
            this.rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rename.Location = new System.Drawing.Point(692, 148);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 23);
            this.rename.TabIndex = 21;
            this.rename.Text = "Rename";
            this.rename.UseVisualStyleBackColor = false;
            // 
            // preview
            // 
            this.preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview.Location = new System.Drawing.Point(429, 108);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(250, 64);
            this.preview.TabIndex = 20;
            this.preview.Text = "&Preview";
            this.preview.UseVisualStyleBackColor = true;
            // 
            // numberPad
            // 
            this.numberPad.Location = new System.Drawing.Point(429, 70);
            this.numberPad.Name = "numberPad";
            this.numberPad.Size = new System.Drawing.Size(250, 20);
            this.numberPad.TabIndex = 6;
            this.numberPad.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(77, 70);
            this.number.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(250, 20);
            this.number.TabIndex = 5;
            // 
            // numberPadLabel
            // 
            this.numberPadLabel.AutoSize = true;
            this.numberPadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPadLabel.Location = new System.Drawing.Point(396, 72);
            this.numberPadLabel.Name = "numberPadLabel";
            this.numberPadLabel.Size = new System.Drawing.Size(26, 13);
            this.numberPadLabel.TabIndex = 14;
            this.numberPadLabel.Text = "Pad";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(23, 72);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 13;
            this.numberLabel.Text = "Number";
            // 
            // scanMatch
            // 
            this.scanMatch.AutoSize = true;
            this.scanMatch.Location = new System.Drawing.Point(685, 20);
            this.scanMatch.Name = "scanMatch";
            this.scanMatch.Size = new System.Drawing.Size(82, 17);
            this.scanMatch.TabIndex = 3;
            this.scanMatch.Text = "Match case";
            this.scanMatch.UseVisualStyleBackColor = true;
            // 
            // isTitleCase
            // 
            this.isTitleCase.AutoSize = true;
            this.isTitleCase.Location = new System.Drawing.Point(26, 132);
            this.isTitleCase.Name = "isTitleCase";
            this.isTitleCase.Size = new System.Drawing.Size(70, 17);
            this.isTitleCase.TabIndex = 8;
            this.isTitleCase.Text = "TitleCase";
            this.isTitleCase.UseVisualStyleBackColor = true;
            // 
            // isLowercase
            // 
            this.isLowercase.AutoSize = true;
            this.isLowercase.Checked = true;
            this.isLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isLowercase.Location = new System.Drawing.Point(26, 109);
            this.isLowercase.Name = "isLowercase";
            this.isLowercase.Size = new System.Drawing.Size(135, 17);
            this.isLowercase.TabIndex = 7;
            this.isLowercase.Text = "Extension to lowercase";
            this.isLowercase.UseVisualStyleBackColor = true;
            // 
            // scanRep
            // 
            this.scanRep.Location = new System.Drawing.Point(429, 44);
            this.scanRep.Name = "scanRep";
            this.scanRep.Size = new System.Drawing.Size(250, 20);
            this.scanRep.TabIndex = 4;
            // 
            // scanRepLabel
            // 
            this.scanRepLabel.AutoSize = true;
            this.scanRepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanRepLabel.Location = new System.Drawing.Point(375, 47);
            this.scanRepLabel.Name = "scanRepLabel";
            this.scanRepLabel.Size = new System.Drawing.Size(47, 13);
            this.scanRepLabel.TabIndex = 9;
            this.scanRepLabel.Text = "Replace";
            // 
            // scan
            // 
            this.scan.Location = new System.Drawing.Point(429, 18);
            this.scan.Name = "scan";
            this.scan.Size = new System.Drawing.Size(250, 20);
            this.scan.TabIndex = 2;
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.Location = new System.Drawing.Point(390, 21);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(32, 13);
            this.scanLabel.TabIndex = 7;
            this.scanLabel.Text = "Scan";
            // 
            // suffix
            // 
            this.suffix.Location = new System.Drawing.Point(77, 44);
            this.suffix.Name = "suffix";
            this.suffix.Size = new System.Drawing.Size(250, 20);
            this.suffix.TabIndex = 1;
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suffixLabel.Location = new System.Drawing.Point(23, 47);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 5;
            this.suffixLabel.Text = "Suffix";
            // 
            // searchPattern
            // 
            this.searchPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPattern.Location = new System.Drawing.Point(733, 6);
            this.searchPattern.Name = "searchPattern";
            this.searchPattern.Size = new System.Drawing.Size(66, 20);
            this.searchPattern.TabIndex = 26;
            this.searchPattern.Text = "*.*";
            // 
            // outputGrid
            // 
            this.outputGrid.AllowUserToAddRows = false;
            this.outputGrid.AllowUserToDeleteRows = false;
            this.outputGrid.AllowUserToOrderColumns = true;
            this.outputGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryName,
            this.status});
            this.outputGrid.Location = new System.Drawing.Point(15, 224);
            this.outputGrid.Name = "outputGrid";
            this.outputGrid.ReadOnly = true;
            this.outputGrid.Size = new System.Drawing.Size(782, 318);
            this.outputGrid.TabIndex = 27;
            // 
            // entryName
            // 
            this.entryName.HeaderText = "Entry name";
            this.entryName.MinimumWidth = 150;
            this.entryName.Name = "entryName";
            this.entryName.ReadOnly = true;
            this.entryName.Width = 550;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // Main
            // 
            this.AcceptButton = this.preview;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 554);
            this.Controls.Add(this.outputGrid);
            this.Controls.Add(this.searchPattern);
            this.Controls.Add(this.settingsGroup);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Explorer Renamer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.settingsGroup.ResumeLayout(false);
            this.settingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.GroupBox settingsGroup;
        private System.Windows.Forms.TextBox scanRep;
        private System.Windows.Forms.Label scanRepLabel;
        private System.Windows.Forms.TextBox scan;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.TextBox suffix;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.NumericUpDown numberPad;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Label numberPadLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.CheckBox scanMatch;
        private System.Windows.Forms.CheckBox isTitleCase;
        private System.Windows.Forms.CheckBox isLowercase;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Button preview;
        private System.Windows.Forms.CheckBox isRecursive;
        private System.Windows.Forms.RadioButton isFilesAndFolders;
        private System.Windows.Forms.RadioButton isFolders;
        private System.Windows.Forms.RadioButton isFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox searchPattern;
        private System.Windows.Forms.DataGridView outputGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
    }
}

