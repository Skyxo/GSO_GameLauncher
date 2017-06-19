namespace GameLauncher.View
{
    partial class NeuesSpielView
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
            this.saveButton = new System.Windows.Forms.Button();
            this.spielTitelTextBox = new System.Windows.Forms.TextBox();
            this.kategorieTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.durchsuchenButton = new System.Windows.Forms.Button();
            this.kategorieLabel = new System.Windows.Forms.Label();
            this.spielTitelGroupBox = new System.Windows.Forms.GroupBox();
            this.spielMetaGroupBox = new System.Windows.Forms.GroupBox();
            this.uskTextBox = new System.Windows.Forms.TextBox();
            this.uskLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.durchsuchenGroupBox = new System.Windows.Forms.GroupBox();
            this.installationsPfadLabel = new System.Windows.Forms.Label();
            this.installationsPfadOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.spielTitelGroupBox.SuspendLayout();
            this.spielMetaGroupBox.SuspendLayout();
            this.durchsuchenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(286, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(145, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Speichern und hinzufügen";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // spielTitelTextBox
            // 
            this.spielTitelTextBox.Location = new System.Drawing.Point(6, 19);
            this.spielTitelTextBox.Name = "spielTitelTextBox";
            this.spielTitelTextBox.Size = new System.Drawing.Size(406, 20);
            this.spielTitelTextBox.TabIndex = 1;
            // 
            // kategorieTextBox
            // 
            this.kategorieTextBox.Location = new System.Drawing.Point(6, 32);
            this.kategorieTextBox.Name = "kategorieTextBox";
            this.kategorieTextBox.Size = new System.Drawing.Size(403, 20);
            this.kategorieTextBox.TabIndex = 2;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(6, 71);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(403, 20);
            this.publisherTextBox.TabIndex = 3;
            // 
            // durchsuchenButton
            // 
            this.durchsuchenButton.Location = new System.Drawing.Point(317, 15);
            this.durchsuchenButton.Name = "durchsuchenButton";
            this.durchsuchenButton.Size = new System.Drawing.Size(92, 23);
            this.durchsuchenButton.TabIndex = 4;
            this.durchsuchenButton.Text = "Durchsuchen...";
            this.durchsuchenButton.UseVisualStyleBackColor = true;
            this.durchsuchenButton.Click += new System.EventHandler(this.durchsuchenButton_Click);
            // 
            // kategorieLabel
            // 
            this.kategorieLabel.AutoSize = true;
            this.kategorieLabel.Location = new System.Drawing.Point(3, 16);
            this.kategorieLabel.Name = "kategorieLabel";
            this.kategorieLabel.Size = new System.Drawing.Size(52, 13);
            this.kategorieLabel.TabIndex = 5;
            this.kategorieLabel.Text = "Kategorie";
            // 
            // spielTitelGroupBox
            // 
            this.spielTitelGroupBox.Controls.Add(this.spielTitelTextBox);
            this.spielTitelGroupBox.Location = new System.Drawing.Point(13, 13);
            this.spielTitelGroupBox.Name = "spielTitelGroupBox";
            this.spielTitelGroupBox.Size = new System.Drawing.Size(418, 49);
            this.spielTitelGroupBox.TabIndex = 6;
            this.spielTitelGroupBox.TabStop = false;
            this.spielTitelGroupBox.Text = "Spieltitel";
            // 
            // spielMetaGroupBox
            // 
            this.spielMetaGroupBox.Controls.Add(this.uskTextBox);
            this.spielMetaGroupBox.Controls.Add(this.uskLabel);
            this.spielMetaGroupBox.Controls.Add(this.publisherLabel);
            this.spielMetaGroupBox.Controls.Add(this.kategorieLabel);
            this.spielMetaGroupBox.Controls.Add(this.kategorieTextBox);
            this.spielMetaGroupBox.Controls.Add(this.publisherTextBox);
            this.spielMetaGroupBox.Location = new System.Drawing.Point(13, 68);
            this.spielMetaGroupBox.Name = "spielMetaGroupBox";
            this.spielMetaGroupBox.Size = new System.Drawing.Size(418, 149);
            this.spielMetaGroupBox.TabIndex = 7;
            this.spielMetaGroupBox.TabStop = false;
            this.spielMetaGroupBox.Text = "Spieldaten";
            // 
            // uskTextBox
            // 
            this.uskTextBox.Location = new System.Drawing.Point(6, 114);
            this.uskTextBox.Name = "uskTextBox";
            this.uskTextBox.Size = new System.Drawing.Size(403, 20);
            this.uskTextBox.TabIndex = 8;
            // 
            // uskLabel
            // 
            this.uskLabel.AutoSize = true;
            this.uskLabel.Location = new System.Drawing.Point(3, 98);
            this.uskLabel.Name = "uskLabel";
            this.uskLabel.Size = new System.Drawing.Size(29, 13);
            this.uskLabel.TabIndex = 7;
            this.uskLabel.Text = "USK";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(3, 55);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 6;
            this.publisherLabel.Text = "Publisher";
            // 
            // durchsuchenGroupBox
            // 
            this.durchsuchenGroupBox.Controls.Add(this.installationsPfadLabel);
            this.durchsuchenGroupBox.Controls.Add(this.durchsuchenButton);
            this.durchsuchenGroupBox.Location = new System.Drawing.Point(13, 223);
            this.durchsuchenGroupBox.Name = "durchsuchenGroupBox";
            this.durchsuchenGroupBox.Size = new System.Drawing.Size(418, 46);
            this.durchsuchenGroupBox.TabIndex = 9;
            this.durchsuchenGroupBox.TabStop = false;
            this.durchsuchenGroupBox.Text = "Installationspfad";
            // 
            // installationsPfadLabel
            // 
            this.installationsPfadLabel.AutoSize = true;
            this.installationsPfadLabel.Location = new System.Drawing.Point(7, 20);
            this.installationsPfadLabel.Name = "installationsPfadLabel";
            this.installationsPfadLabel.Size = new System.Drawing.Size(146, 13);
            this.installationsPfadLabel.TabIndex = 5;
            this.installationsPfadLabel.Text = "Auf \"Durchsuchen...\" klicken";
            // 
            // installationsPfadOpenFileDialog
            // 
            this.installationsPfadOpenFileDialog.FileName = "Durchsuchen...";
            // 
            // NeuesSpielView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.durchsuchenGroupBox);
            this.Controls.Add(this.spielMetaGroupBox);
            this.Controls.Add(this.spielTitelGroupBox);
            this.Controls.Add(this.saveButton);
            this.Name = "NeuesSpielView";
            this.ShowInTaskbar = false;
            this.Text = "Neues Spiel";
            this.spielTitelGroupBox.ResumeLayout(false);
            this.spielTitelGroupBox.PerformLayout();
            this.spielMetaGroupBox.ResumeLayout(false);
            this.spielMetaGroupBox.PerformLayout();
            this.durchsuchenGroupBox.ResumeLayout(false);
            this.durchsuchenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox spielTitelTextBox;
        private System.Windows.Forms.TextBox kategorieTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Button durchsuchenButton;
        private System.Windows.Forms.Label kategorieLabel;
        private System.Windows.Forms.GroupBox spielTitelGroupBox;
        private System.Windows.Forms.GroupBox spielMetaGroupBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox uskTextBox;
        private System.Windows.Forms.Label uskLabel;
        private System.Windows.Forms.GroupBox durchsuchenGroupBox;
        private System.Windows.Forms.Label installationsPfadLabel;
        private System.Windows.Forms.OpenFileDialog installationsPfadOpenFileDialog;
    }
}