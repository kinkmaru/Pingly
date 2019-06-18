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
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.deleteRegionButton = new System.Windows.Forms.Button();
            this.editGameButton = new System.Windows.Forms.Button();
            this.editRegionButton = new System.Windows.Forms.Button();
            this.deleteServerButton = new System.Windows.Forms.Button();
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
            this.serversOLV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.serversOLV.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.serversOLV.CellEditUseWholeCell = false;
            this.serversOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serversListNameColumn,
            this.serversListIpColumn});
            this.serversOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.serversOLV.Enabled = false;
            this.serversOLV.FullRowSelect = true;
            this.serversOLV.HasCollapsibleGroups = false;
            this.serversOLV.HideSelection = false;
            this.serversOLV.LabelWrap = false;
            this.serversOLV.Location = new System.Drawing.Point(22, 167);
            this.serversOLV.MultiSelect = false;
            this.serversOLV.Name = "serversOLV";
            this.serversOLV.SelectAllOnControlA = false;
            this.serversOLV.ShowGroups = false;
            this.serversOLV.Size = new System.Drawing.Size(310, 235);
            this.serversOLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serversOLV.TabIndex = 5;
            this.serversOLV.UseCompatibleStateImageBehavior = false;
            this.serversOLV.UseHotControls = false;
            this.serversOLV.View = System.Windows.Forms.View.Details;
            this.serversOLV.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.serversOLV_CellEditFinishing);
            this.serversOLV.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.serversOLV_CellEditStarting);
            this.serversOLV.SelectedIndexChanged += new System.EventHandler(this.serversOLV_SelectedIndexChanged);
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
            this.gamesListLabel.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.gamesListLabel.Location = new System.Drawing.Point(19, 62);
            this.gamesListLabel.Name = "gamesListLabel";
            this.gamesListLabel.Size = new System.Drawing.Size(43, 14);
            this.gamesListLabel.TabIndex = 6;
            this.gamesListLabel.Text = "Game";
            // 
            // regionsListLabel
            // 
            this.regionsListLabel.AutoSize = true;
            this.regionsListLabel.Enabled = false;
            this.regionsListLabel.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionsListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.regionsListLabel.Location = new System.Drawing.Point(19, 104);
            this.regionsListLabel.Name = "regionsListLabel";
            this.regionsListLabel.Size = new System.Drawing.Size(58, 14);
            this.regionsListLabel.TabIndex = 7;
            this.regionsListLabel.Text = "Regions";
            // 
            // serversListLabel
            // 
            this.serversListLabel.AutoSize = true;
            this.serversListLabel.Enabled = false;
            this.serversListLabel.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.serversListLabel.Location = new System.Drawing.Point(19, 143);
            this.serversListLabel.Name = "serversListLabel";
            this.serversListLabel.Size = new System.Drawing.Size(61, 14);
            this.serversListLabel.TabIndex = 8;
            this.serversListLabel.Text = "Servers";
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.addGameButton.Enabled = false;
            this.addGameButton.Location = new System.Drawing.Point(187, 57);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(80, 23);
            this.addGameButton.TabIndex = 9;
            this.addGameButton.Text = "<Add Game>";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // addRegionButton
            // 
            this.addRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.addRegionButton.Enabled = false;
            this.addRegionButton.Location = new System.Drawing.Point(193, 99);
            this.addRegionButton.Name = "addRegionButton";
            this.addRegionButton.Size = new System.Drawing.Size(84, 23);
            this.addRegionButton.TabIndex = 10;
            this.addRegionButton.Text = "<Add Region>";
            this.addRegionButton.UseVisualStyleBackColor = false;
            this.addRegionButton.Click += new System.EventHandler(this.addRegionButton_Click);
            // 
            // addServerButton
            // 
            this.addServerButton.Enabled = false;
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
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(205)))), ((int)(((byte)(25)))));
            this.saveButton.Location = new System.Drawing.Point(136, 413);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "<Save>";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.fileLabel.Location = new System.Drawing.Point(135, 27);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(76, 14);
            this.fileLabel.TabIndex = 13;
            this.fileLabel.Text = "<File Label>";
            // 
            // gamesListComboBox
            // 
            this.gamesListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gamesListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gamesListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.gamesListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gamesListComboBox.FormattingEnabled = true;
            this.gamesListComboBox.Location = new System.Drawing.Point(60, 59);
            this.gamesListComboBox.Name = "gamesListComboBox";
            this.gamesListComboBox.Size = new System.Drawing.Size(121, 21);
            this.gamesListComboBox.TabIndex = 14;
            this.gamesListComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesListComboBoxSearchForGame);
            this.gamesListComboBox.TextChanged += new System.EventHandler(this.gamesListComboBoxSearchForGame);
            // 
            // regionListComboBox
            // 
            this.regionListComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.regionListComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.regionListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.regionListComboBox.Enabled = false;
            this.regionListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regionListComboBox.FormattingEnabled = true;
            this.regionListComboBox.Location = new System.Drawing.Point(66, 101);
            this.regionListComboBox.Name = "regionListComboBox";
            this.regionListComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionListComboBox.TabIndex = 15;
            this.regionListComboBox.SelectedIndexChanged += new System.EventHandler(this.regionListComboBoxSearchForRegion);
            this.regionListComboBox.TextChanged += new System.EventHandler(this.regionListComboBoxSearchForRegion);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.deleteGameButton.Enabled = false;
            this.deleteGameButton.Location = new System.Drawing.Point(336, 57);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGameButton.TabIndex = 16;
            this.deleteGameButton.Text = "<Delete>";
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // deleteRegionButton
            // 
            this.deleteRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.deleteRegionButton.Enabled = false;
            this.deleteRegionButton.Location = new System.Drawing.Point(346, 99);
            this.deleteRegionButton.Name = "deleteRegionButton";
            this.deleteRegionButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRegionButton.TabIndex = 17;
            this.deleteRegionButton.Text = "<Delete>";
            this.deleteRegionButton.UseVisualStyleBackColor = false;
            this.deleteRegionButton.Click += new System.EventHandler(this.deleteRegionButton_Click);
            // 
            // editGameButton
            // 
            this.editGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(65)))));
            this.editGameButton.Enabled = false;
            this.editGameButton.Location = new System.Drawing.Point(264, 57);
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Size = new System.Drawing.Size(75, 23);
            this.editGameButton.TabIndex = 18;
            this.editGameButton.Text = "<Edit>";
            this.editGameButton.UseVisualStyleBackColor = false;
            this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // editRegionButton
            // 
            this.editRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(65)))));
            this.editRegionButton.Enabled = false;
            this.editRegionButton.Location = new System.Drawing.Point(274, 99);
            this.editRegionButton.Name = "editRegionButton";
            this.editRegionButton.Size = new System.Drawing.Size(75, 23);
            this.editRegionButton.TabIndex = 19;
            this.editRegionButton.Text = "<Edit>";
            this.editRegionButton.UseVisualStyleBackColor = false;
            this.editRegionButton.Click += new System.EventHandler(this.editRegionButton_Click);
            // 
            // deleteServerButton
            // 
            this.deleteServerButton.Enabled = false;
            this.deleteServerButton.Location = new System.Drawing.Point(255, 138);
            this.deleteServerButton.Name = "deleteServerButton";
            this.deleteServerButton.Size = new System.Drawing.Size(84, 23);
            this.deleteServerButton.TabIndex = 20;
            this.deleteServerButton.Text = "<Delete Server>";
            this.deleteServerButton.UseVisualStyleBackColor = true;
            this.deleteServerButton.Visible = false;
            this.deleteServerButton.Click += new System.EventHandler(this.deleteServerButton_Click);
            // 
            // ConfigureGamesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(429, 448);
            this.Controls.Add(this.deleteServerButton);
            this.Controls.Add(this.editRegionButton);
            this.Controls.Add(this.editGameButton);
            this.Controls.Add(this.deleteRegionButton);
            this.Controls.Add(this.deleteGameButton);
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
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Button deleteRegionButton;
        private System.Windows.Forms.Button editGameButton;
        private System.Windows.Forms.Button editRegionButton;
        private System.Windows.Forms.Button deleteServerButton;
    }
}