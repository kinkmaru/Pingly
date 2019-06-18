namespace BestPing.Forms
{
    partial class DeleteItemForm
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
            this.deleteFormLabel = new System.Windows.Forms.Label();
            this.confirmDeleteButton = new System.Windows.Forms.Button();
            this.cancelDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteFormLabel
            // 
            this.deleteFormLabel.AutoSize = true;
            this.deleteFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFormLabel.Location = new System.Drawing.Point(95, 43);
            this.deleteFormLabel.Name = "deleteFormLabel";
            this.deleteFormLabel.Size = new System.Drawing.Size(87, 26);
            this.deleteFormLabel.TabIndex = 0;
            this.deleteFormLabel.Text = "Delete?";
            // 
            // confirmDeleteButton
            // 
            this.confirmDeleteButton.Location = new System.Drawing.Point(54, 133);
            this.confirmDeleteButton.Name = "confirmDeleteButton";
            this.confirmDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.confirmDeleteButton.TabIndex = 1;
            this.confirmDeleteButton.Text = "<Confirm>";
            this.confirmDeleteButton.UseVisualStyleBackColor = true;
            this.confirmDeleteButton.Click += new System.EventHandler(this.confirmDeleteButton_Click);
            // 
            // cancelDeleteButton
            // 
            this.cancelDeleteButton.Location = new System.Drawing.Point(148, 133);
            this.cancelDeleteButton.Name = "cancelDeleteButton";
            this.cancelDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.cancelDeleteButton.TabIndex = 2;
            this.cancelDeleteButton.Text = "<Cancel>";
            this.cancelDeleteButton.UseVisualStyleBackColor = true;
            this.cancelDeleteButton.Click += new System.EventHandler(this.cancelDeleteButton_Click);
            // 
            // DeleteGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelDeleteButton);
            this.Controls.Add(this.confirmDeleteButton);
            this.Controls.Add(this.deleteFormLabel);
            this.Name = "DeleteGameForm";
            this.Text = "DeleteGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteFormLabel;
        private System.Windows.Forms.Button confirmDeleteButton;
        private System.Windows.Forms.Button cancelDeleteButton;
    }
}