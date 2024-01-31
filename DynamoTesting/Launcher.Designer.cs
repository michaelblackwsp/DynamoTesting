namespace DynamoTesting
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
            this.components = new System.ComponentModel.Container();
            this.launchButton = new System.Windows.Forms.Button();
            this.clientDropdownMenu = new System.Windows.Forms.ComboBox();
            this.shortcutsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionDropdownMenu = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageDropdownMenu = new System.Windows.Forms.ComboBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.addRegistryButton = new System.Windows.Forms.Button();
            this.checkRegistryButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(78, 112);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(121, 23);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch Civil 3D";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.FormattingEnabled = true;
            this.clientDropdownMenu.Location = new System.Drawing.Point(78, 12);
            this.clientDropdownMenu.MaxDropDownItems = 20;
            this.clientDropdownMenu.Name = "clientDropdownMenu";
            this.clientDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.clientDropdownMenu.TabIndex = 1;
            this.clientDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.clientDropdownMenu_Selected);
            // 
            // shortcutsModelBindingSource
            // 
            this.shortcutsModelBindingSource.DataSource = typeof(DynamoTesting.Model);
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Location = new System.Drawing.Point(78, 68);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.versionDropdownMenu.TabIndex = 2;
            this.versionDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.versionDropdownMenu_Selected);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(34, 15);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(38, 15);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(27, 71);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(13, 41);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(59, 15);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Language";
            this.languageLabel.Click += new System.EventHandler(this.languageLabel_Click);
            // 
            // languageDropdownMenu
            // 
            this.languageDropdownMenu.FormattingEnabled = true;
            this.languageDropdownMenu.Location = new System.Drawing.Point(78, 40);
            this.languageDropdownMenu.Name = "languageDropdownMenu";
            this.languageDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.languageDropdownMenu.TabIndex = 6;
            this.languageDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.languageDropdownMenu_Selected);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(86, 138);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(105, 15);
            this.pathLabel.TabIndex = 7;
            this.pathLabel.Text = "Click to show path";
            this.pathLabel.Click += new System.EventHandler(this.pathLabel_Click);
            // 
            // addRegistryButton
            // 
            this.addRegistryButton.Location = new System.Drawing.Point(138, 204);
            this.addRegistryButton.Name = "addRegistryButton";
            this.addRegistryButton.Size = new System.Drawing.Size(105, 23);
            this.addRegistryButton.TabIndex = 8;
            this.addRegistryButton.Text = "Update Profile";
            this.addRegistryButton.UseVisualStyleBackColor = true;
            this.addRegistryButton.Click += new System.EventHandler(this.updateRegistryButton_Click);
            // 
            // checkRegistryButton
            // 
            this.checkRegistryButton.Location = new System.Drawing.Point(27, 204);
            this.checkRegistryButton.Name = "checkRegistryButton";
            this.checkRegistryButton.Size = new System.Drawing.Size(105, 23);
            this.checkRegistryButton.TabIndex = 9;
            this.checkRegistryButton.Text = "Check Profile";
            this.checkRegistryButton.UseVisualStyleBackColor = true;
            this.checkRegistryButton.Click += new System.EventHandler(this.checkRegistryButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(1, 265);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(134, 15);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Click to show Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 284);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.checkRegistryButton);
            this.Controls.Add(this.addRegistryButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.languageDropdownMenu);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.versionDropdownMenu);
            this.Controls.Add(this.clientDropdownMenu);
            this.Controls.Add(this.launchButton);
            this.Name = "repconLauncher";
            this.Text = "REPCON Launcher";
            this.Load += new System.EventHandler(this.repconLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button launchButton;
        private ComboBox clientDropdownMenu;
        private ComboBox versionDropdownMenu;
        private Label clientLabel;
        private Label versionLabel;
        private Label languageLabel;
        private ComboBox languageDropdownMenu;
        private BindingSource shortcutsModelBindingSource;
        private Label pathLabel;
        private Button addRegistryButton;
        private Button checkRegistryButton;
        private Label usernameLabel;
    }
}