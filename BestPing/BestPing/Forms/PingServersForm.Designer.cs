namespace BestPing
{
    partial class PingServersForm
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
            this.gamesListComboBox = new System.Windows.Forms.ComboBox();
            this.regionsListView = new System.Windows.Forms.ListView();
            this.regionListLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listServersOLV = new BrightIdeasSoftware.ObjectListView();
            this.Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Server = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Ping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pingPrecisionComboBox = new System.Windows.Forms.ComboBox();
            this.pingPrecisionLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.editSettingsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.cancelSettingsButton = new System.Windows.Forms.Button();
            this.errorMessagesLabel = new System.Windows.Forms.Label();
            this.editFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listServersOLV)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesListComboBox
            // 
            this.gamesListComboBox.FormattingEnabled = true;
            this.gamesListComboBox.Location = new System.Drawing.Point(65, 39);
            this.gamesListComboBox.Name = "gamesListComboBox";
            this.gamesListComboBox.Size = new System.Drawing.Size(186, 21);
            this.gamesListComboBox.TabIndex = 0;
            this.gamesListComboBox.Text = "Game Name";
            this.gamesListComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesListComboBox_SelectedIndexChanged);
            // 
            // regionsListView
            // 
            this.regionsListView.HideSelection = false;
            this.regionsListView.Location = new System.Drawing.Point(407, 82);
            this.regionsListView.Name = "regionsListView";
            this.regionsListView.Size = new System.Drawing.Size(171, 30);
            this.regionsListView.TabIndex = 2;
            this.regionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // regionListLabel
            // 
            this.regionListLabel.AutoSize = true;
            this.regionListLabel.Location = new System.Drawing.Point(360, 89);
            this.regionListLabel.Name = "regionListLabel";
            this.regionListLabel.Size = new System.Drawing.Size(44, 13);
            this.regionListLabel.TabIndex = 5;
            this.regionListLabel.Text = "Region:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 131);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 5);
            this.progressBar.Step = 0;
            this.progressBar.TabIndex = 7;
            // 
            // listServersOLV
            // 
            this.listServersOLV.AllColumns.Add(this.Status);
            this.listServersOLV.AllColumns.Add(this.Server);
            this.listServersOLV.AllColumns.Add(this.Ping);
            this.listServersOLV.AlternateRowBackColor = System.Drawing.Color.Silver;
            this.listServersOLV.BackColor = System.Drawing.SystemColors.Control;
            this.listServersOLV.CellEditUseWholeCell = false;
            this.listServersOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Status,
            this.Server,
            this.Ping});
            this.listServersOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.listServersOLV.FullRowSelect = true;
            this.listServersOLV.HasCollapsibleGroups = false;
            this.listServersOLV.HideSelection = false;
            this.listServersOLV.Location = new System.Drawing.Point(27, 136);
            this.listServersOLV.Name = "listServersOLV";
            this.listServersOLV.SelectedBackColor = System.Drawing.Color.White;
            this.listServersOLV.SelectedForeColor = System.Drawing.Color.Black;
            this.listServersOLV.ShowGroups = false;
            this.listServersOLV.Size = new System.Drawing.Size(297, 266);
            this.listServersOLV.SortGroupItemsByPrimaryColumn = false;
            this.listServersOLV.TabIndex = 9;
            this.listServersOLV.UseCompatibleStateImageBehavior = false;
            this.listServersOLV.View = System.Windows.Forms.View.Details;
            // 
            // Status
            // 
            this.Status.Text = "";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 26;
            // 
            // Server
            // 
            this.Server.AspectName = "Name";
            this.Server.Text = "Server Name";
            this.Server.Width = 147;
            // 
            // Ping
            // 
            this.Ping.AspectName = "Ping";
            this.Ping.Text = "Ping (m/s)";
            this.Ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ping.Width = 77;
            // 
            // pingPrecisionComboBox
            // 
            this.pingPrecisionComboBox.FormattingEnabled = true;
            this.pingPrecisionComboBox.Items.AddRange(new object[] {
            "Fast",
            "Moderate",
            "Thorough"});
            this.pingPrecisionComboBox.Location = new System.Drawing.Point(447, 43);
            this.pingPrecisionComboBox.Name = "pingPrecisionComboBox";
            this.pingPrecisionComboBox.Size = new System.Drawing.Size(131, 21);
            this.pingPrecisionComboBox.TabIndex = 10;
            this.pingPrecisionComboBox.Text = "Fast";
            // 
            // pingPrecisionLabel
            // 
            this.pingPrecisionLabel.AutoSize = true;
            this.pingPrecisionLabel.Location = new System.Drawing.Point(360, 46);
            this.pingPrecisionLabel.Name = "pingPrecisionLabel";
            this.pingPrecisionLabel.Size = new System.Drawing.Size(74, 13);
            this.pingPrecisionLabel.TabIndex = 12;
            this.pingPrecisionLabel.Text = "Ping Precision";
            // 
            // fileLabel
            // 
            this.fileLabel.Location = new System.Drawing.Point(450, 173);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(130, 23);
            this.fileLabel.TabIndex = 14;
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // editSettingsButton
            // 
            this.editSettingsButton.Location = new System.Drawing.Point(249, 7);
            this.editSettingsButton.Name = "editSettingsButton";
            this.editSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.editSettingsButton.TabIndex = 16;
            this.editSettingsButton.Text = "<Settings>";
            this.editSettingsButton.UseVisualStyleBackColor = true;
            this.editSettingsButton.Click += new System.EventHandler(this.editSettingsButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(249, 97);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "<Refresh>";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(423, 17);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(45, 13);
            this.settingsLabel.TabIndex = 18;
            this.settingsLabel.Text = "Settings";
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.AutoSize = true;
            this.selectedFileLabel.Location = new System.Drawing.Point(369, 178);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(71, 13);
            this.selectedFileLabel.TabIndex = 19;
            this.selectedFileLabel.Text = "Selected File:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Location = new System.Drawing.Point(393, 291);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 20;
            this.saveSettingsButton.Text = "<Save>";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(487, 291);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSettingsButton.TabIndex = 21;
            this.cancelSettingsButton.Text = "<Cancel>";
            this.cancelSettingsButton.UseVisualStyleBackColor = true;
            // 
            // errorMessagesLabel
            // 
            this.errorMessagesLabel.AutoSize = true;
            this.errorMessagesLabel.Location = new System.Drawing.Point(363, 376);
            this.errorMessagesLabel.Name = "errorMessagesLabel";
            this.errorMessagesLabel.Size = new System.Drawing.Size(35, 13);
            this.errorMessagesLabel.TabIndex = 22;
            this.errorMessagesLabel.Text = "label1";
            // 
            // editFileButton
            // 
            this.editFileButton.Location = new System.Drawing.Point(503, 199);
            this.editFileButton.Name = "editFileButton";
            this.editFileButton.Size = new System.Drawing.Size(75, 23);
            this.editFileButton.TabIndex = 23;
            this.editFileButton.Text = "<Edit File>";
            this.editFileButton.UseVisualStyleBackColor = true;
            this.editFileButton.Click += new System.EventHandler(this.editFileButton_Click);
            // 
            // PingServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 414);
            this.Controls.Add(this.editFileButton);
            this.Controls.Add(this.errorMessagesLabel);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.selectedFileLabel);
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editSettingsButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.pingPrecisionLabel);
            this.Controls.Add(this.pingPrecisionComboBox);
            this.Controls.Add(this.listServersOLV);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.regionListLabel);
            this.Controls.Add(this.regionsListView);
            this.Controls.Add(this.gamesListComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PingServersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Game Servers";
            this.Load += new System.EventHandler(this.PingServersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listServersOLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView regionsListView;
        private System.Windows.Forms.Label regionListLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private BrightIdeasSoftware.ObjectListView listServersOLV;
        private BrightIdeasSoftware.OLVColumn Status;
        private BrightIdeasSoftware.OLVColumn Server;
        private BrightIdeasSoftware.OLVColumn Ping;
        private System.Windows.Forms.ComboBox pingPrecisionComboBox;
        private System.Windows.Forms.Label pingPrecisionLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button editSettingsButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label selectedFileLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.Button cancelSettingsButton;
        private System.Windows.Forms.ComboBox gamesListComboBox;
        private System.Windows.Forms.Label errorMessagesLabel;
        private System.Windows.Forms.Button editFileButton;
    }
}

