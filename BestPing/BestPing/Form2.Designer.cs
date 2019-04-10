namespace BestPing
{
    partial class Form2
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.gamesOLV = new BrightIdeasSoftware.ObjectListView();
            this.Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.regionsOLV = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.serversOLV = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addGameButton = new System.Windows.Forms.Button();
            this.addRegionButton = new System.Windows.Forms.Button();
            this.addServerButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gamesOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(22, 17);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(152, 33);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.Location = new System.Drawing.Point(197, 27);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(35, 13);
            this.selectedFileLabel.TabIndex = 2;
            this.selectedFileLabel.Text = "label1";
            // 
            // gamesOLV
            // 
            this.gamesOLV.AllColumns.Add(this.Name);
            this.gamesOLV.AllColumns.Add(this.olvColumn1);
            this.gamesOLV.CellEditUseWholeCell = false;
            this.gamesOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.olvColumn1});
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
            // Name
            // 
            this.Name.AspectName = "Name";
            this.Name.Text = "Name";
            this.Name.Width = 247;
            // 
            // olvColumn1
            // 
            this.olvColumn1.Text = "Actions";
            // 
            // regionsOLV
            // 
            this.regionsOLV.AllColumns.Add(this.olvColumn3);
            this.regionsOLV.AllColumns.Add(this.olvColumn4);
            this.regionsOLV.CellEditUseWholeCell = false;
            this.regionsOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4});
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
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Name";
            this.olvColumn3.Text = "Name";
            this.olvColumn3.Width = 248;
            // 
            // olvColumn4
            // 
            this.olvColumn4.Text = "Actions";
            // 
            // serversOLV
            // 
            this.serversOLV.AllColumns.Add(this.olvColumn5);
            this.serversOLV.AllColumns.Add(this.olvColumn6);
            this.serversOLV.AllColumns.Add(this.olvColumn7);
            this.serversOLV.CellEditUseWholeCell = false;
            this.serversOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
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
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Name";
            this.olvColumn5.Text = "Name";
            this.olvColumn5.Width = 117;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Ip";
            this.olvColumn6.Text = "IP";
            this.olvColumn6.Width = 128;
            // 
            // olvColumn7
            // 
            this.olvColumn7.Text = "Actions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Games";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Regions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servers";
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(244, 62);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 9;
            this.addGameButton.Text = "Add Game";
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
            this.saveButton.Location = new System.Drawing.Point(157, 413);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 448);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addServerButton);
            this.Controls.Add(this.addRegionButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serversOLV);
            this.Controls.Add(this.regionsOLV);
            this.Controls.Add(this.gamesOLV);
            this.Controls.Add(this.selectedFileLabel);
            this.Controls.Add(this.selectFileButton);
            this.Text = "Modify XML File";
            ((System.ComponentModel.ISupportInitialize)(this.gamesOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionsOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label selectedFileLabel;
        private BrightIdeasSoftware.ObjectListView gamesOLV;
        private BrightIdeasSoftware.ObjectListView regionsOLV;
        private BrightIdeasSoftware.ObjectListView serversOLV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Button addRegionButton;
        private System.Windows.Forms.Button addServerButton;
        private BrightIdeasSoftware.OLVColumn Name;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.Button saveButton;
    }
}