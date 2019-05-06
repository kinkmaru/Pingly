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
            this.gamesOLV = new BrightIdeasSoftware.ObjectListView();
            this.gamesListNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesListEditColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesListDeleteColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.regionsOLV = new BrightIdeasSoftware.ObjectListView();
            this.regionsListNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.regionsListEditColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.regionsListDeleteColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversOLV = new BrightIdeasSoftware.ObjectListView();
            this.serversListNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversListIpColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversListEditColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversListDeleteColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesListLabel = new System.Windows.Forms.Label();
            this.regionsListLabel = new System.Windows.Forms.Label();
            this.serversListLabel = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.addRegionButton = new System.Windows.Forms.Button();
            this.addServerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.gamesListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamesOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsOLV)).BeginInit();
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
            // gamesOLV
            // 
            this.gamesOLV.AllColumns.Add(this.gamesListNameColumn);
            this.gamesOLV.AllColumns.Add(this.gamesListEditColumn);
            this.gamesOLV.AllColumns.Add(this.gamesListDeleteColumn);
            this.gamesOLV.CellEditUseWholeCell = false;
            this.gamesOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gamesListNameColumn,
            this.gamesListEditColumn,
            this.gamesListDeleteColumn});
            this.gamesOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.gamesOLV.FullRowSelect = true;
            this.gamesOLV.HasCollapsibleGroups = false;
            this.gamesOLV.HideSelection = false;
            this.gamesOLV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gamesOLV.Location = new System.Drawing.Point(22, 86);
            this.gamesOLV.MultiSelect = false;
            this.gamesOLV.Name = "gamesOLV";
            this.gamesOLV.SelectAllOnControlA = false;
            this.gamesOLV.ShowGroups = false;
            this.gamesOLV.Size = new System.Drawing.Size(310, 81);
            this.gamesOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.gamesOLV.TabIndex = 3;
            this.gamesOLV.UseCompatibleStateImageBehavior = false;
            this.gamesOLV.View = System.Windows.Forms.View.Details;
            this.gamesOLV.SelectionChanged += new System.EventHandler(this.gamesOLV_SelectionChanged);
            // 
            // gamesListNameColumn
            // 
            this.gamesListNameColumn.AspectName = "Name";
            this.gamesListNameColumn.Text = "Name";
            this.gamesListNameColumn.Width = 224;
            // 
            // gamesListEditColumn
            // 
            this.gamesListEditColumn.Text = "Edit";
            this.gamesListEditColumn.Width = 30;
            // 
            // gamesListDeleteColumn
            // 
            this.gamesListDeleteColumn.Text = "Delete";
            this.gamesListDeleteColumn.Width = 43;
            // 
            // regionsOLV
            // 
            this.regionsOLV.AllColumns.Add(this.regionsListNameColumn);
            this.regionsOLV.AllColumns.Add(this.regionsListEditColumn);
            this.regionsOLV.AllColumns.Add(this.regionsListDeleteColumn);
            this.regionsOLV.CellEditUseWholeCell = false;
            this.regionsOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.regionsListNameColumn,
            this.regionsListEditColumn,
            this.regionsListDeleteColumn});
            this.regionsOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.regionsOLV.FullRowSelect = true;
            this.regionsOLV.HasCollapsibleGroups = false;
            this.regionsOLV.HideSelection = false;
            this.regionsOLV.Location = new System.Drawing.Point(22, 200);
            this.regionsOLV.MultiSelect = false;
            this.regionsOLV.Name = "regionsOLV";
            this.regionsOLV.SelectAllOnControlA = false;
            this.regionsOLV.ShowGroups = false;
            this.regionsOLV.Size = new System.Drawing.Size(310, 81);
            this.regionsOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.regionsOLV.TabIndex = 4;
            this.regionsOLV.UseCompatibleStateImageBehavior = false;
            this.regionsOLV.View = System.Windows.Forms.View.Details;
            this.regionsOLV.SelectionChanged += new System.EventHandler(this.regionsOLV_SelectionChanged);
            // 
            // regionsListNameColumn
            // 
            this.regionsListNameColumn.AspectName = "Name";
            this.regionsListNameColumn.Text = "Name";
            this.regionsListNameColumn.Width = 224;
            // 
            // regionsListEditColumn
            // 
            this.regionsListEditColumn.Text = "Edit";
            this.regionsListEditColumn.Width = 31;
            // 
            // regionsListDeleteColumn
            // 
            this.regionsListDeleteColumn.Text = "Delete";
            this.regionsListDeleteColumn.Width = 44;
            // 
            // serversOLV
            // 
            this.serversOLV.AllColumns.Add(this.serversListNameColumn);
            this.serversOLV.AllColumns.Add(this.serversListIpColumn);
            this.serversOLV.AllColumns.Add(this.serversListEditColumn);
            this.serversOLV.AllColumns.Add(this.serversListDeleteColumn);
            this.serversOLV.CellEditUseWholeCell = false;
            this.serversOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serversListNameColumn,
            this.serversListIpColumn,
            this.serversListEditColumn,
            this.serversListDeleteColumn});
            this.serversOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.serversOLV.FullRowSelect = true;
            this.serversOLV.HasCollapsibleGroups = false;
            this.serversOLV.HideSelection = false;
            this.serversOLV.Location = new System.Drawing.Point(22, 321);
            this.serversOLV.MultiSelect = false;
            this.serversOLV.Name = "serversOLV";
            this.serversOLV.SelectAllOnControlA = false;
            this.serversOLV.ShowGroups = false;
            this.serversOLV.Size = new System.Drawing.Size(310, 81);
            this.serversOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serversOLV.TabIndex = 5;
            this.serversOLV.UseCompatibleStateImageBehavior = false;
            this.serversOLV.View = System.Windows.Forms.View.Details;
            // 
            // serversListNameColumn
            // 
            this.serversListNameColumn.AspectName = "Name";
            this.serversListNameColumn.Text = "Name";
            this.serversListNameColumn.Width = 117;
            // 
            // serversListIpColumn
            // 
            this.serversListIpColumn.AspectName = "Ip";
            this.serversListIpColumn.Text = "IP";
            this.serversListIpColumn.Width = 104;
            // 
            // serversListEditColumn
            // 
            this.serversListEditColumn.Text = "Edit";
            this.serversListEditColumn.Width = 30;
            // 
            // serversListDeleteColumn
            // 
            this.serversListDeleteColumn.Text = "Delete";
            this.serversListDeleteColumn.Width = 45;
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
            this.regionsListLabel.Location = new System.Drawing.Point(36, 181);
            this.regionsListLabel.Name = "regionsListLabel";
            this.regionsListLabel.Size = new System.Drawing.Size(46, 13);
            this.regionsListLabel.TabIndex = 7;
            this.regionsListLabel.Text = "Regions";
            // 
            // serversListLabel
            // 
            this.serversListLabel.AutoSize = true;
            this.serversListLabel.Location = new System.Drawing.Point(33, 302);
            this.serversListLabel.Name = "serversListLabel";
            this.serversListLabel.Size = new System.Drawing.Size(43, 13);
            this.serversListLabel.TabIndex = 8;
            this.serversListLabel.Text = "Servers";
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(187, 57);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 9;
            this.addGameButton.Text = "<Add Game>";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // addRegionButton
            // 
            this.addRegionButton.Location = new System.Drawing.Point(244, 176);
            this.addRegionButton.Name = "addRegionButton";
            this.addRegionButton.Size = new System.Drawing.Size(75, 23);
            this.addRegionButton.TabIndex = 10;
            this.addRegionButton.Text = "Add Region";
            this.addRegionButton.UseVisualStyleBackColor = true;
            this.addRegionButton.Click += new System.EventHandler(this.addRegionButton_Click);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(244, 297);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(75, 23);
            this.addServerButton.TabIndex = 11;
            this.addServerButton.Text = "Add Server";
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
            // 
            // ConfigureGamesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 448);
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
            this.Controls.Add(this.regionsOLV);
            this.Controls.Add(this.gamesOLV);
            this.Controls.Add(this.selectedFileLabel);
            this.Name = "ConfigureGamesListForm";
            this.Text = "Configure Game List";
            this.Load += new System.EventHandler(this.ConfigureGamesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label selectedFileLabel;
        private BrightIdeasSoftware.ObjectListView gamesOLV;
        private BrightIdeasSoftware.ObjectListView regionsOLV;
        private BrightIdeasSoftware.ObjectListView serversOLV;
        private System.Windows.Forms.Label gamesListLabel;
        private System.Windows.Forms.Label regionsListLabel;
        private System.Windows.Forms.Label serversListLabel;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button addRegionButton;
        private System.Windows.Forms.Button addServerButton;
        private BrightIdeasSoftware.OLVColumn gamesListNameColumn;
        private BrightIdeasSoftware.OLVColumn regionsListNameColumn;
        private BrightIdeasSoftware.OLVColumn regionsListEditColumn;
        private BrightIdeasSoftware.OLVColumn serversListNameColumn;
        private BrightIdeasSoftware.OLVColumn serversListIpColumn;
        private BrightIdeasSoftware.OLVColumn serversListEditColumn;
        private BrightIdeasSoftware.OLVColumn gamesListEditColumn;
        private System.Windows.Forms.Button saveButton;
        private BrightIdeasSoftware.OLVColumn gamesListDeleteColumn;
        private BrightIdeasSoftware.OLVColumn regionsListDeleteColumn;
        private BrightIdeasSoftware.OLVColumn serversListDeleteColumn;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.ComboBox gamesListComboBox;
    }
}