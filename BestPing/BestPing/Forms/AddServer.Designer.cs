namespace BestPing
{
    partial class AddServer
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.ipTextBox1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addServerLabel = new System.Windows.Forms.Label();
            this.ipTextBox2 = new System.Windows.Forms.TextBox();
            this.ipTextBox3 = new System.Windows.Forms.TextBox();
            this.ipTextBox4 = new System.Windows.Forms.TextBox();
            this.ipSeparator1 = new System.Windows.Forms.Label();
            this.ipSeparator2 = new System.Windows.Forms.Label();
            this.ipSeparator3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(37, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(78, 55);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(146, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // ipTextBox1
            // 
            this.ipTextBox1.Location = new System.Drawing.Point(60, 97);
            this.ipTextBox1.Name = "ipTextBox1";
            this.ipTextBox1.Size = new System.Drawing.Size(34, 20);
            this.ipTextBox1.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(57, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "<Save>";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(168, 174);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "<Cancel>";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addServerLabel
            // 
            this.addServerLabel.AutoSize = true;
            this.addServerLabel.Location = new System.Drawing.Point(116, 20);
            this.addServerLabel.Name = "addServerLabel";
            this.addServerLabel.Size = new System.Drawing.Size(60, 13);
            this.addServerLabel.TabIndex = 6;
            this.addServerLabel.Text = "Add Server";
            // 
            // ipTextBox2
            // 
            this.ipTextBox2.Location = new System.Drawing.Point(108, 97);
            this.ipTextBox2.Name = "ipTextBox2";
            this.ipTextBox2.Size = new System.Drawing.Size(34, 20);
            this.ipTextBox2.TabIndex = 3;
            // 
            // ipTextBox3
            // 
            this.ipTextBox3.Location = new System.Drawing.Point(156, 97);
            this.ipTextBox3.Name = "ipTextBox3";
            this.ipTextBox3.Size = new System.Drawing.Size(34, 20);
            this.ipTextBox3.TabIndex = 4;
            // 
            // ipTextBox4
            // 
            this.ipTextBox4.Location = new System.Drawing.Point(204, 97);
            this.ipTextBox4.Name = "ipTextBox4";
            this.ipTextBox4.Size = new System.Drawing.Size(34, 20);
            this.ipTextBox4.TabIndex = 5;
            // 
            // ipSeparator1
            // 
            this.ipSeparator1.AutoSize = true;
            this.ipSeparator1.Location = new System.Drawing.Point(96, 104);
            this.ipSeparator1.Name = "ipSeparator1";
            this.ipSeparator1.Size = new System.Drawing.Size(10, 13);
            this.ipSeparator1.TabIndex = 10;
            this.ipSeparator1.Text = ".";
            // 
            // ipSeparator2
            // 
            this.ipSeparator2.AutoSize = true;
            this.ipSeparator2.Location = new System.Drawing.Point(144, 103);
            this.ipSeparator2.Name = "ipSeparator2";
            this.ipSeparator2.Size = new System.Drawing.Size(10, 13);
            this.ipSeparator2.TabIndex = 11;
            this.ipSeparator2.Text = ".";
            // 
            // ipSeparator3
            // 
            this.ipSeparator3.AutoSize = true;
            this.ipSeparator3.Location = new System.Drawing.Point(192, 103);
            this.ipSeparator3.Name = "ipSeparator3";
            this.ipSeparator3.Size = new System.Drawing.Size(10, 13);
            this.ipSeparator3.TabIndex = 12;
            this.ipSeparator3.Text = ".";
            // 
            // AddServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ipSeparator3);
            this.Controls.Add(this.ipSeparator2);
            this.Controls.Add(this.ipSeparator1);
            this.Controls.Add(this.ipTextBox4);
            this.Controls.Add(this.ipTextBox3);
            this.Controls.Add(this.ipTextBox2);
            this.Controls.Add(this.addServerLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.ipTextBox1);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.Name = "AddServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox ipTextBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label addServerLabel;
        private System.Windows.Forms.TextBox ipTextBox2;
        private System.Windows.Forms.TextBox ipTextBox3;
        private System.Windows.Forms.TextBox ipTextBox4;
        private System.Windows.Forms.Label ipSeparator1;
        private System.Windows.Forms.Label ipSeparator2;
        private System.Windows.Forms.Label ipSeparator3;
    }
}