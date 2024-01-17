﻿namespace DynamoTesting
{
    partial class repconLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.launchButton = new System.Windows.Forms.Button();
            this.environtmentDropdownMenu = new System.Windows.Forms.ComboBox();
            this.versionDropdownMenu = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageDropdownMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(72, 134);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // environtmentDropdownMenu
            // 
            this.environtmentDropdownMenu.FormattingEnabled = true;
            this.environtmentDropdownMenu.Items.AddRange(new object[] {
            "CofC",
            "MTO",
            "MTQ",
            "MVRD",
            "MX",
            "WSP_EN",
            "WSP_FR"});
            this.environtmentDropdownMenu.Location = new System.Drawing.Point(99, 12);
            this.environtmentDropdownMenu.Name = "environtmentDropdownMenu";
            this.environtmentDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.environtmentDropdownMenu.TabIndex = 1;
            this.environtmentDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.environmentDropdownMenu_Selected);
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.versionDropdownMenu.Location = new System.Drawing.Point(99, 75);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.versionDropdownMenu.TabIndex = 2;
            this.versionDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.versionDropdownMenu_Selected);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(55, 15);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(38, 15);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(48, 78);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(34, 44);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(59, 15);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Language";
            this.languageLabel.Click += new System.EventHandler(this.languageLabel_Click);
            // 
            // languageDropdownMenu
            // 
            this.languageDropdownMenu.FormattingEnabled = true;
            this.languageDropdownMenu.Items.AddRange(new object[] {
            "English",
            "French"});
            this.languageDropdownMenu.Location = new System.Drawing.Point(99, 41);
            this.languageDropdownMenu.Name = "languageDropdownMenu";
            this.languageDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.languageDropdownMenu.TabIndex = 6;
            this.languageDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.languageDropdownMenu_Selected);
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 181);
            this.Controls.Add(this.languageDropdownMenu);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.versionDropdownMenu);
            this.Controls.Add(this.environtmentDropdownMenu);
            this.Controls.Add(this.launchButton);
            this.Name = "repconLauncher";
            this.Text = "REPCON Launcher";
            this.Load += new System.EventHandler(this.repconLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button launchButton;
        private ComboBox environtmentDropdownMenu;
        private ComboBox versionDropdownMenu;
        private Label clientLabel;
        private Label versionLabel;
        private Label languageLabel;
        private ComboBox languageDropdownMenu;
    }
}