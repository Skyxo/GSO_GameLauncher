namespace GameLauncher.View
{
    partial class GameLauncher
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
            this.neuesSpielButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neuesSpielButton
            // 
            this.neuesSpielButton.BackColor = System.Drawing.Color.LightGray;
            this.neuesSpielButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neuesSpielButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.neuesSpielButton.ForeColor = System.Drawing.Color.Gray;
            this.neuesSpielButton.Location = new System.Drawing.Point(12, 12);
            this.neuesSpielButton.Name = "neuesSpielButton";
            this.neuesSpielButton.Size = new System.Drawing.Size(50, 50);
            this.neuesSpielButton.TabIndex = 0;
            this.neuesSpielButton.Text = "+";
            this.neuesSpielButton.UseVisualStyleBackColor = false;
            this.neuesSpielButton.Click += new System.EventHandler(this.neuesSpielButton_Click);
            // 
            // GameLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.neuesSpielButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameLauncher";
            this.Text = "GameLauncher";
            this.Click += new System.EventHandler(this.GameLauncher_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameLauncher_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameLauncher_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button neuesSpielButton;
    }
}