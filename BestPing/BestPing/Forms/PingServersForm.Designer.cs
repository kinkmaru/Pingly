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
            this.selectGameLabel = new System.Windows.Forms.Label();
            this.regionListLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressionLabel = new System.Windows.Forms.Label();
            this.listServersOLV = new BrightIdeasSoftware.ObjectListView();
            this.Status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Server = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Ping = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pingPrecisionComboBox = new System.Windows.Forms.ComboBox();
            this.pingPrecisionLabel = new System.Windows.Forms.Label();
            this.selectGameFileButton = new System.Windows.Forms.Button();
            this.selectedFileLabel = new System.Windows.Forms.Label();
            this.pingPrecisionNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.listServersOLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingPrecisionNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesListComboBox
            // 
            this.gamesListComboBox.FormattingEnabled = true;
            this.gamesListComboBox.Location = new System.Drawing.Point(118, 45);
            this.gamesListComboBox.Name = "gamesListComboBox";
            this.gamesListComboBox.Size = new System.Drawing.Size(186, 21);
            this.gamesListComboBox.TabIndex = 0;
            this.gamesListComboBox.Text = "<Options>";
            this.gamesListComboBox.SelectedIndexChanged += new System.EventHandler(this.gamesListComboBox_SelectedIndexChanged);
            // 
            // regionsListView
            // 
            this.regionsListView.Location = new System.Drawing.Point(27, 124);
            this.regionsListView.Name = "regionsListView";
            this.regionsListView.Size = new System.Drawing.Size(297, 30);
            this.regionsListView.TabIndex = 2;
            this.regionsListView.UseCompatibleStateImageBehavior = false;
            this.regionsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.regionsListView_MouseClick);
            // 
            // selectGameLabel
            // 
            this.selectGameLabel.AutoSize = true;
            this.selectGameLabel.Location = new System.Drawing.Point(36, 48);
            this.selectGameLabel.Name = "selectGameLabel";
            this.selectGameLabel.Size = new System.Drawing.Size(68, 13);
            this.selectGameLabel.TabIndex = 3;
            this.selectGameLabel.Text = "Select Game";
            // 
            // regionListLabel
            // 
            this.regionListLabel.AutoSize = true;
            this.regionListLabel.Location = new System.Drawing.Point(24, 108);
            this.regionListLabel.Name = "regionListLabel";
            this.regionListLabel.Size = new System.Drawing.Size(41, 13);
            this.regionListLabel.TabIndex = 5;
            this.regionListLabel.Text = "Region";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(80, 370);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 23);
            this.progressBar.Step = 0;
            this.progressBar.TabIndex = 7;
            // 
            // progressionLabel
            // 
            this.progressionLabel.AutoSize = true;
            this.progressionLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressionLabel.ForeColor = System.Drawing.Color.Black;
            this.progressionLabel.Location = new System.Drawing.Point(80, 350);
            this.progressionLabel.Name = "progressionLabel";
            this.progressionLabel.Size = new System.Drawing.Size(0, 15);
            this.progressionLabel.TabIndex = 8;
            this.progressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressionLabel.UseMnemonic = false;
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
            this.listServersOLV.Location = new System.Drawing.Point(27, 160);
            this.listServersOLV.Name = "listServersOLV";
            this.listServersOLV.SelectedBackColor = System.Drawing.Color.White;
            this.listServersOLV.SelectedForeColor = System.Drawing.Color.Black;
            this.listServersOLV.ShowGroups = false;
            this.listServersOLV.Size = new System.Drawing.Size(297, 182);
            this.listServersOLV.SortGroupItemsByPrimaryColumn = false;
            this.listServersOLV.TabIndex = 9;
            this.listServersOLV.UseCompatibleStateImageBehavior = false;
            this.listServersOLV.View = System.Windows.Forms.View.Details;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Server
            // 
            this.Server.AspectName = "Name";
            this.Server.Text = "Server Name";
            this.Server.Width = 88;
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
            "1 - Fast",
            "5 - Moderate",
            "10 - Thorough",
            "Custom"});
            this.pingPrecisionComboBox.Location = new System.Drawing.Point(118, 72);
            this.pingPrecisionComboBox.Name = "pingPrecisionComboBox";
            this.pingPrecisionComboBox.Size = new System.Drawing.Size(121, 21);
            this.pingPrecisionComboBox.TabIndex = 10;
            this.pingPrecisionComboBox.Text = "1 - Fast";
            this.pingPrecisionComboBox.SelectedIndexChanged += new System.EventHandler(this.pingPrecisionComboBox_SelectedIndexChanged);
            // 
            // pingPrecisionLabel
            // 
            this.pingPrecisionLabel.AutoSize = true;
            this.pingPrecisionLabel.Location = new System.Drawing.Point(36, 75);
            this.pingPrecisionLabel.Name = "pingPrecisionLabel";
            this.pingPrecisionLabel.Size = new System.Drawing.Size(74, 13);
            this.pingPrecisionLabel.TabIndex = 12;
            this.pingPrecisionLabel.Text = "Ping Precision";
            // 
            // selectGameFileButton
            // 
            this.selectGameFileButton.Location = new System.Drawing.Point(39, 13);
            this.selectGameFileButton.Name = "selectGameFileButton";
            this.selectGameFileButton.Size = new System.Drawing.Size(133, 23);
            this.selectGameFileButton.TabIndex = 13;
            this.selectGameFileButton.Text = "Choose Game List (XML)";
            this.selectGameFileButton.UseVisualStyleBackColor = true;
            this.selectGameFileButton.Click += new System.EventHandler(this.selectGameFileButton_Click);
            // 
            // selectedFileLabel
            // 
            this.selectedFileLabel.Location = new System.Drawing.Point(174, 13);
            this.selectedFileLabel.Name = "selectedFileLabel";
            this.selectedFileLabel.Size = new System.Drawing.Size(130, 23);
            this.selectedFileLabel.TabIndex = 14;
            this.selectedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pingPrecisionNumUpDown
            // 
            this.pingPrecisionNumUpDown.Enabled = false;
            this.pingPrecisionNumUpDown.Location = new System.Drawing.Point(245, 73);
            this.pingPrecisionNumUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.pingPrecisionNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pingPrecisionNumUpDown.Name = "pingPrecisionNumUpDown";
            this.pingPrecisionNumUpDown.Size = new System.Drawing.Size(59, 20);
            this.pingPrecisionNumUpDown.TabIndex = 15;
            this.pingPrecisionNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // PingServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 414);
            this.Controls.Add(this.pingPrecisionNumUpDown);
            this.Controls.Add(this.selectedFileLabel);
            this.Controls.Add(this.selectGameFileButton);
            this.Controls.Add(this.pingPrecisionLabel);
            this.Controls.Add(this.pingPrecisionComboBox);
            this.Controls.Add(this.listServersOLV);
            this.Controls.Add(this.progressionLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.regionListLabel);
            this.Controls.Add(this.selectGameLabel);
            this.Controls.Add(this.regionsListView);
            this.Controls.Add(this.gamesListComboBox);
            this.Name = "PingServersForm";
            this.Text = "Ping Game Servers";
            this.Load += new System.EventHandler(this.PingServersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listServersOLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingPrecisionNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gamesListComboBox;
        private System.Windows.Forms.ListView regionsListView;
        private System.Windows.Forms.Label selectGameLabel;
        private System.Windows.Forms.Label regionListLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressionLabel;
        private BrightIdeasSoftware.ObjectListView listServersOLV;
        private BrightIdeasSoftware.OLVColumn Status;
        private BrightIdeasSoftware.OLVColumn Server;
        private BrightIdeasSoftware.OLVColumn Ping;
        private System.Windows.Forms.ComboBox pingPrecisionComboBox;
        private System.Windows.Forms.Label pingPrecisionLabel;
        private System.Windows.Forms.Button selectGameFileButton;
        private System.Windows.Forms.Label selectedFileLabel;
        private System.Windows.Forms.NumericUpDown pingPrecisionNumUpDown;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

