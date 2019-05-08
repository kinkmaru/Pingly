namespace BestPing
{
    partial class ConfigureGamesListForm
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
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.serversOLV = new BrightIdeasSoftware.ObjectListView();
            this.serversListNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversListIpColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesListLabel = new System.Windows.Forms.Label();
            this.regionsListLabel = new System.Windows.Forms.Label();
            this.serversListLabel = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.addRegionButton = new System.Windows.Forms.Button();
            this.addServerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.gamesListComboBox = new System.Windows.Forms.ComboBox();
            this.regionListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.serversOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.Location = new System.Drawing.Point(197, 27);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedFileLabel.TabIndex = 2;
            // 
            // serversOLV
            // 
            this.serversOLV.AllColumns.Add(this.serversListNameColumn);
            this.serversOLV.AllColumns.Add(this.serversListIpColumn);
            this.serversOLV.CellEditUseWholeCell = false;
            this.serversOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serversListNameColumn,
            this.serversListIpColumn});
            this.serversOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.serversOLV.FullRowSelect = true;
            this.serversOLV.HasCollapsibleGroups = false;
            this.serversOLV.HideSelection = false;
            this.serversOLV.Location = new System.Drawing.Point(22, 167);
            this.serversOLV.MultiSelect = false;
            this.serversOLV.Name = "serversOLV";
            this.serversOLV.SelectAllOnControlA = false;
            this.serversOLV.ShowGroups = false;
            this.serversOLV.Size = new System.Drawing.Size(310, 235);
            this.serversOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serversOLV.TabIndex = 5;
            this.serversOLV.UseCompatibleStateImageBehavior = false;
            this.serversOLV.View = System.Windows.Forms.View.Details;
            // 
            // serversListNameColumn
            // 
            this.serversListNameColumn.AspectName = "Name";
            this.serversListNameColumn.Text = "Name";
            this.serversListNameColumn.Width = 120;
            // 
            // serversListIpColumn
            // 
            this.serversListIpColumn.AspectName = "Ip";
            this.serversListIpColumn.Text = "IP";
            this.serversListIpColumn.Width = 104;
            // 
            // gamesListLabel
            // 
            this.gamesListLabel.AutoSize = true;
            this.gamesListLabel.Location = new System.Drawing.Point(19, 62);
            this.gamesListLabel.Name = "gamesListLabel";
            this.gamesListLabel.Size = new System.Drawing.Size(35, 13);
            this.gamesListLabel.TabIndex = 6;
            this.gamesListLabel.Text = "Game";
            // 
            // regionsListLabel
            // 
            this.regionsListLabel.AutoSize = true;
            this.regionsListLabel.Location = new System.Drawing.Point(19, 104);
            this.regionsListLabel.Name = "regionsListLabel";
            this.regionsListLabel.Size = new System.Drawing.Size(41, 13);
            this.regionsListLabel.TabIndex = 7;
            this.regionsListLabel.Text = "Region";
            // 
            // serversListLabel
            // 
            this.serversListLabel.AutoSize = true;
            this.serversListLabel.Location = new System.Drawing.Point(19, 143);
            this.serversListLabel.Name = "serversListLabel";
            this.serversListLabel.Size = new System.Drawing.Size(43, 13);
            this.serversListLabel.TabIndex = 8;
            this.serversListLabel.Text = "Servers";
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(187, 57);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(80, 23);
            this.addGameButton.TabIndex = 9;
            this.addGameButton.Text = "<Add Game>";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // addRegionButton
            // 
            this.addRegionButton.Location = new System.Drawing.Point(193, 99);
            this.addRegionButton.Name = "addRegionButton";
            this.addRegionButton.Size = new System.Drawing.Size(84, 23);
            this.addRegionButton.TabIndex = 10;
            this.addRegionButton.Text = "<Add Region>";
            this.addRegionButton.UseVisualStyleBackColor = true;
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(255, 138);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(84, 23);
            this.addServerButton.TabIndex = 11;
            this.addServerButton.Text = "<Add Server>";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(136, 413);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "<Save>";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(135, 27);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(64, 13);
            this.fileLabel.TabIndex = 13;
            this.fileLabel.Text = "<File Label>";
            // 
            // gamesListComboBox
            // 
            this.gamesListComboBox.FormattingEnabled = true;
            this.gamesListComboBox.Location = new System.Drawing.Point(60, 59);
            this.gamesListComboBox.Name = "gamesListComboBox";
            this.gamesListComboBox.Size = new System.Drawing.Size(121, 21);
            this.gamesListComboBox.TabIndex = 14;
            this.gamesListComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesListComboBox_SelectedIndexChanged);
            // 
            // regionListComboBox
            // 
            this.regionListComboBox.FormattingEnabled = true;
            this.regionListComboBox.Location = new System.Drawing.Point(66, 101);
            this.regionListComboBox.Name = "regionListComboBox";
            this.regionListComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionListComboBox.TabIndex = 15;
            this.regionListComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // ConfigureGamesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 448);
            this.Controls.Add(this.regionListComboBox);
            this.Controls.Add(this.gamesListComboBox);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.addRegionButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.serversListLabel);
            this.Controls.Add(this.regionsListLabel);
            this.Controls.Add(this.gamesListLabel);
            this.Controls.Add(this.serversOLV);
            this.Controls.Add(this.selectedFileLabel);
            this.Name = "ConfigureGamesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Game List";
            this.Load += new System.EventHandler(this.ConfigureGamesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serversOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFileLabel;
        private BrightIdeasSoftware.ObjectListView serversOLV;
        private System.Windows.Forms.Label gamesListLabel;
        private System.Windows.Forms.Label regionsListLabel;
        private System.Windows.Forms.Label serversListLabel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button addRegionButton;
        private System.Windows.Forms.Button addServerButton;
        private BrightIdeasSoftware.OLVColumn serversListNameColumn;
        private BrightIdeasSoftware.OLVColumn serversListIpColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.ComboBox gamesListComboBox;
        private System.Windows.Forms.ComboBox regionListComboBox;
    }
}