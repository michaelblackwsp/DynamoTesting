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
            this.label1 = new System.Windows.Forms.Label();
            this.addRegistryButton = new System.Windows.Forms.Button();
            this.checkRegistryButton = new System.Windows.Forms.Button();
            this.checkCivil3DinRegistry = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.checkCivil3DinDirectory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shortcutsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(266, 75);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(114, 23);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch Civil 3D";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.FormattingEnabled = true;
            this.clientDropdownMenu.Location = new System.Drawing.Point(99, 12);
            this.clientDropdownMenu.Name = "clientDropdownMenu";
            this.clientDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.clientDropdownMenu.TabIndex = 1;
            this.clientDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.clientDropdownMenu_Selected);
            // 
            // shortcutsModelBindingSource
            // 
            this.shortcutsModelBindingSource.DataSource = typeof(DynamoTesting.ShortcutsModel);
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.FormattingEnabled = true;
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
            this.languageDropdownMenu.Location = new System.Drawing.Point(99, 41);
            this.languageDropdownMenu.Name = "languageDropdownMenu";
            this.languageDropdownMenu.Size = new System.Drawing.Size(121, 23);
            this.languageDropdownMenu.TabIndex = 6;
            this.languageDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.languageDropdownMenu_Selected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "test";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addRegistryButton
            // 
            this.addRegistryButton.Location = new System.Drawing.Point(11, 195);
            this.addRegistryButton.Name = "addRegistryButton";
            this.addRegistryButton.Size = new System.Drawing.Size(171, 23);
            this.addRegistryButton.TabIndex = 8;
            this.addRegistryButton.Text = "Update Profile (in Registry)";
            this.addRegistryButton.UseVisualStyleBackColor = true;
            this.addRegistryButton.Click += new System.EventHandler(this.addRegistryButton_Click);
            // 
            // checkRegistryButton
            // 
            this.checkRegistryButton.Location = new System.Drawing.Point(11, 166);
            this.checkRegistryButton.Name = "checkRegistryButton";
            this.checkRegistryButton.Size = new System.Drawing.Size(172, 23);
            this.checkRegistryButton.TabIndex = 9;
            this.checkRegistryButton.Text = "Check Profile (in Registry)";
            this.checkRegistryButton.UseVisualStyleBackColor = true;
            this.checkRegistryButton.Click += new System.EventHandler(this.checkRegistryButton_Click);
            // 
            // checkCivil3DinRegistry
            // 
            this.checkCivil3DinRegistry.Location = new System.Drawing.Point(266, 12);
            this.checkCivil3DinRegistry.Name = "checkCivil3DinRegistry";
            this.checkCivil3DinRegistry.Size = new System.Drawing.Size(208, 23);
            this.checkCivil3DinRegistry.TabIndex = 10;
            this.checkCivil3DinRegistry.Text = "Check Civil 3D (in registry)";
            this.checkCivil3DinRegistry.UseVisualStyleBackColor = true;
            this.checkCivil3DinRegistry.Click += new System.EventHandler(this.checkCivil3DinRegistry_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(396, 203);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // checkCivil3DinDirectory
            // 
            this.checkCivil3DinDirectory.Location = new System.Drawing.Point(266, 41);
            this.checkCivil3DinDirectory.Name = "checkCivil3DinDirectory";
            this.checkCivil3DinDirectory.Size = new System.Drawing.Size(208, 23);
            this.checkCivil3DinDirectory.TabIndex = 12;
            this.checkCivil3DinDirectory.Text = "Check Civil 3D (in directory)";
            this.checkCivil3DinDirectory.UseVisualStyleBackColor = true;
            this.checkCivil3DinDirectory.Click += new System.EventHandler(this.checkCivil3DinDirectory_Click);
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 228);
            this.Controls.Add(this.checkCivil3DinDirectory);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.checkCivil3DinRegistry);
            this.Controls.Add(this.checkRegistryButton);
            this.Controls.Add(this.addRegistryButton);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Button addRegistryButton;
        private Button checkRegistryButton;
        private Button checkCivil3DinRegistry;
        private Label usernameLabel;
        private Button checkCivil3DinDirectory;
    }
}