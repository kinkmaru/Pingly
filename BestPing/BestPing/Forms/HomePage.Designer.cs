namespace BestPing
{
    partial class HomePage
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
            this.pingServersButton = new System.Windows.Forms.Button();
            this.editGameListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pingServersButton
            // 
            this.pingServersButton.Location = new System.Drawing.Point(76, 38);
            this.pingServersButton.Name = "pingServersButton";
            this.pingServersButton.Size = new System.Drawing.Size(121, 69);
            this.pingServersButton.TabIndex = 0;
            this.pingServersButton.Text = "Ping Servers";
            this.pingServersButton.UseVisualStyleBackColor = true;
            this.pingServersButton.Click += new System.EventHandler(this.pingServersButton_Click);
            // 
            // editGameListButton
            // 
            this.editGameListButton.Location = new System.Drawing.Point(76, 132);
            this.editGameListButton.Name = "editGameListButton";
            this.editGameListButton.Size = new System.Drawing.Size(121, 69);
            this.editGameListButton.TabIndex = 1;
            this.editGameListButton.Text = "Edit Game List";
            this.editGameListButton.UseVisualStyleBackColor = true;
            this.editGameListButton.Click += new System.EventHandler(this.editGameListButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.editGameListButton);
            this.Controls.Add(this.pingServersButton);
            this.Name = "HomePage";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pingServersButton;
        private System.Windows.Forms.Button editGameListButton;
    }
}