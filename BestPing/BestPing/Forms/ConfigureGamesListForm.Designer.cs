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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureGamesListForm));
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.serversOLV = new BrightIdeasSoftware.ObjectListView();
            this.serversListNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversListIpColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.gamesListLabel = new System.Windows.Forms.Label();
            this.regionsListLabel = new System.Windows.Forms.Label();
            this.serversListLabel = new System.Windows.Forms.Label();
            this.AddButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.addServerButton = new System.Windows.Forms.Button();
            this.AddServerButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.SaveButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.fileLabel = new System.Windows.Forms.Label();
            this.gamesListComboBox = new System.Windows.Forms.ComboBox();
            this.regionListComboBox = new System.Windows.Forms.ComboBox();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.DeleteButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.deleteRegionButton = new System.Windows.Forms.Button();
            this.editRegionButton = new System.Windows.Forms.Button();
            this.EditButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.deleteServerButton = new System.Windows.Forms.Button();
            this.DeleteServerButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.editGameButton = new System.Windows.Forms.Button();
            this.addRegionButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
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
            this.serversOLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(0)))));
            this.serversOLV.FullRowSelect = true;
            this.serversOLV.HasCollapsibleGroups = false;
            this.serversOLV.HideSelection = false;
            this.serversOLV.LabelWrap = false;
            this.serversOLV.Location = new System.Drawing.Point(22, 167);
            this.serversOLV.Margin = new System.Windows.Forms.Padding(53);
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
            this.serversListNameColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.serversListNameColumn.Text = "Name";
            this.serversListNameColumn.Width = 120;
            // 
            // serversListIpColumn
            // 
            this.serversListIpColumn.AspectName = "Ip";
            this.serversListIpColumn.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
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
            this.serversListLabel.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(167)))));
            this.serversListLabel.Location = new System.Drawing.Point(19, 143);
            this.serversListLabel.Name = "serversListLabel";
            this.serversListLabel.Size = new System.Drawing.Size(61, 14);
            this.serversListLabel.TabIndex = 8;
            this.serversListLabel.Text = "Servers";
            // 
            // AddButtonImageList
            // 
            this.AddButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AddButtonImageList.ImageStream")));
            this.AddButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.AddButtonImageList.Images.SetKeyName(0, "AddButtonDisabled.png");
            this.AddButtonImageList.Images.SetKeyName(1, "AddButtonActive.png");
            this.AddButtonImageList.Images.SetKeyName(2, "AddButtonActiveHover.png");
            // 
            // addServerButton
            // 
            this.addServerButton.FlatAppearance.BorderSize = 0;
            this.addServerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addServerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addServerButton.ImageIndex = 0;
            this.addServerButton.ImageList = this.AddServerButtonImageList;
            this.addServerButton.Location = new System.Drawing.Point(310, 140);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(22, 22);
            this.addServerButton.TabIndex = 11;
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.addServerButton_Click);
            this.addServerButton.MouseEnter += new System.EventHandler(this.addServerButton_MouseEnter);
            this.addServerButton.MouseLeave += new System.EventHandler(this.addServerButton_MouseLeave);
            // 
            // AddServerButtonImageList
            // 
            this.AddServerButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AddServerButtonImageList.ImageStream")));
            this.AddServerButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.AddServerButtonImageList.Images.SetKeyName(0, "ServerAddButtonDisabled.png");
            this.AddServerButtonImageList.Images.SetKeyName(1, "ServerAddButtonActive.png");
            this.AddServerButtonImageList.Images.SetKeyName(2, "ServerAddButtonActiveHover.png");
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ImageIndex = 0;
            this.saveButton.ImageList = this.SaveButtonImageList;
            this.saveButton.Location = new System.Drawing.Point(164, 403);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(33, 33);
            this.saveButton.TabIndex = 12;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.SaveButtonIndexChange);
            this.saveButton.MouseLeave += new System.EventHandler(this.SaveButtonIndexChange);
            // 
            // SaveButtonImageList
            // 
            this.SaveButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SaveButtonImageList.ImageStream")));
            this.SaveButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.SaveButtonImageList.Images.SetKeyName(0, "SaveButtonActive.png");
            this.SaveButtonImageList.Images.SetKeyName(1, "SaveButtonHover.png");
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
            this.gamesListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesListComboBox.ForeColor = System.Drawing.Color.White;
            this.gamesListComboBox.FormattingEnabled = true;
            this.gamesListComboBox.Location = new System.Drawing.Point(76, 55);
            this.gamesListComboBox.Name = "gamesListComboBox";
            this.gamesListComboBox.Size = new System.Drawing.Size(121, 26);
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
            this.regionListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionListComboBox.ForeColor = System.Drawing.Color.White;
            this.regionListComboBox.FormattingEnabled = true;
            this.regionListComboBox.Location = new System.Drawing.Point(76, 97);
            this.regionListComboBox.Name = "regionListComboBox";
            this.regionListComboBox.Size = new System.Drawing.Size(121, 26);
            this.regionListComboBox.TabIndex = 15;
            this.regionListComboBox.SelectedIndexChanged += new System.EventHandler(this.regionListComboBoxSearchForRegion);
            this.regionListComboBox.TextChanged += new System.EventHandler(this.regionListComboBoxSearchForRegion);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.deleteGameButton.FlatAppearance.BorderSize = 0;
            this.deleteGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameButton.ImageIndex = 0;
            this.deleteGameButton.ImageList = this.DeleteButtonImageList;
            this.deleteGameButton.Location = new System.Drawing.Point(299, 52);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(33, 33);
            this.deleteGameButton.TabIndex = 16;
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            this.deleteGameButton.MouseEnter += new System.EventHandler(this.deleteGameButton_MouseEnter);
            this.deleteGameButton.MouseLeave += new System.EventHandler(this.deleteGameButton_MouseLeave);
            // 
            // DeleteButtonImageList
            // 
            this.DeleteButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DeleteButtonImageList.ImageStream")));
            this.DeleteButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DeleteButtonImageList.Images.SetKeyName(0, "DeleteButtonDisabled.png");
            this.DeleteButtonImageList.Images.SetKeyName(1, "DeleteButtonActive.png");
            this.DeleteButtonImageList.Images.SetKeyName(2, "DeleteButtonActiveHover.png");
            // 
            // deleteRegionButton
            // 
            this.deleteRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.deleteRegionButton.FlatAppearance.BorderSize = 0;
            this.deleteRegionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteRegionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteRegionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRegionButton.ImageIndex = 0;
            this.deleteRegionButton.ImageList = this.DeleteButtonImageList;
            this.deleteRegionButton.Location = new System.Drawing.Point(299, 94);
            this.deleteRegionButton.Name = "deleteRegionButton";
            this.deleteRegionButton.Size = new System.Drawing.Size(33, 33);
            this.deleteRegionButton.TabIndex = 17;
            this.deleteRegionButton.UseVisualStyleBackColor = false;
            this.deleteRegionButton.Click += new System.EventHandler(this.deleteRegionButton_Click);
            this.deleteRegionButton.MouseEnter += new System.EventHandler(this.deleteRegionButton_MouseEnter);
            this.deleteRegionButton.MouseLeave += new System.EventHandler(this.deleteRegionButton_MouseLeave);
            // 
            // editRegionButton
            // 
            this.editRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.editRegionButton.FlatAppearance.BorderSize = 0;
            this.editRegionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editRegionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editRegionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRegionButton.ImageIndex = 0;
            this.editRegionButton.ImageList = this.EditButtonImageList;
            this.editRegionButton.Location = new System.Drawing.Point(255, 94);
            this.editRegionButton.Name = "editRegionButton";
            this.editRegionButton.Size = new System.Drawing.Size(33, 33);
            this.editRegionButton.TabIndex = 19;
            this.editRegionButton.UseVisualStyleBackColor = false;
            this.editRegionButton.Click += new System.EventHandler(this.editRegionButton_Click);
            this.editRegionButton.MouseEnter += new System.EventHandler(this.editRegionButton_MouseEnter);
            this.editRegionButton.MouseLeave += new System.EventHandler(this.editRegionButton_MouseLeave);
            // 
            // EditButtonImageList
            // 
            this.EditButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("EditButtonImageList.ImageStream")));
            this.EditButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.EditButtonImageList.Images.SetKeyName(0, "EditButtonDisabled.jpg");
            this.EditButtonImageList.Images.SetKeyName(1, "EditButtonActive.png");
            this.EditButtonImageList.Images.SetKeyName(2, "EditButtonActiveHover.png");
            this.EditButtonImageList.Images.SetKeyName(3, "EditButtonEditingConfirm.png");
            // 
            // deleteServerButton
            // 
            this.deleteServerButton.FlatAppearance.BorderSize = 0;
            this.deleteServerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteServerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteServerButton.ImageIndex = 0;
            this.deleteServerButton.ImageList = this.DeleteServerButtonImageList;
            this.deleteServerButton.Location = new System.Drawing.Point(310, 140);
            this.deleteServerButton.Name = "deleteServerButton";
            this.deleteServerButton.Size = new System.Drawing.Size(22, 22);
            this.deleteServerButton.TabIndex = 20;
            this.deleteServerButton.UseVisualStyleBackColor = true;
            this.deleteServerButton.Visible = false;
            this.deleteServerButton.Click += new System.EventHandler(this.deleteServerButton_Click);
            this.deleteServerButton.MouseEnter += new System.EventHandler(this.DeleteServerButtonIndexChange);
            this.deleteServerButton.MouseLeave += new System.EventHandler(this.DeleteServerButtonIndexChange);
            // 
            // DeleteServerButtonImageList
            // 
            this.DeleteServerButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DeleteServerButtonImageList.ImageStream")));
            this.DeleteServerButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DeleteServerButtonImageList.Images.SetKeyName(0, "ServerDeleteButtonActive.png");
            this.DeleteServerButtonImageList.Images.SetKeyName(1, "ServerDeleteButtonActiveHover.png");
            // 
            // editGameButton
            // 
            this.editGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.editGameButton.FlatAppearance.BorderSize = 0;
            this.editGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGameButton.ForeColor = System.Drawing.Color.Transparent;
            this.editGameButton.ImageIndex = 0;
            this.editGameButton.ImageList = this.EditButtonImageList;
            this.editGameButton.Location = new System.Drawing.Point(255, 52);
            this.editGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Size = new System.Drawing.Size(33, 33);
            this.editGameButton.TabIndex = 18;
            this.editGameButton.UseVisualStyleBackColor = false;
            this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
            this.editGameButton.MouseEnter += new System.EventHandler(this.editGameButton_MouseEnter);
            this.editGameButton.MouseLeave += new System.EventHandler(this.editGameButton_MouseLeave);
            // 
            // addRegionButton
            // 
            this.addRegionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addRegionButton.FlatAppearance.BorderSize = 0;
            this.addRegionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addRegionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addRegionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRegionButton.ImageIndex = 0;
            this.addRegionButton.ImageList = this.AddButtonImageList;
            this.addRegionButton.Location = new System.Drawing.Point(212, 94);
            this.addRegionButton.Name = "addRegionButton";
            this.addRegionButton.Size = new System.Drawing.Size(33, 33);
            this.addRegionButton.TabIndex = 10;
            this.addRegionButton.UseVisualStyleBackColor = false;
            this.addRegionButton.Click += new System.EventHandler(this.addRegionButton_Click);
            this.addRegionButton.MouseEnter += new System.EventHandler(this.addRegionButton_MouseEnter);
            this.addRegionButton.MouseLeave += new System.EventHandler(this.addRegionButton_MouseLeave);
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addGameButton.FlatAppearance.BorderSize = 0;
            this.addGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameButton.ForeColor = System.Drawing.Color.Transparent;
            this.addGameButton.ImageIndex = 0;
            this.addGameButton.ImageList = this.AddButtonImageList;
            this.addGameButton.Location = new System.Drawing.Point(212, 52);
            this.addGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(33, 33);
            this.addGameButton.TabIndex = 9;
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            this.addGameButton.MouseEnter += new System.EventHandler(this.addGameButton_MouseEnter);
            this.addGameButton.MouseLeave += new System.EventHandler(this.addGameButton_MouseLeave);
            // 
            // ConfigureGamesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(394, 448);
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
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ImageList AddButtonImageList;
        private System.Windows.Forms.ImageList EditButtonImageList;
        private System.Windows.Forms.ImageList DeleteButtonImageList;
        private System.Windows.Forms.ImageList AddServerButtonImageList;
        private System.Windows.Forms.ImageList DeleteServerButtonImageList;
        private System.Windows.Forms.ImageList SaveButtonImageList;
    }
}