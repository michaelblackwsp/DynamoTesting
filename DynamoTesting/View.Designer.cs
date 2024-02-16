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
            this.launchButton = new System.Windows.Forms.Button();
            this.clientDropdownMenu = new System.Windows.Forms.ComboBox();
            this.versionDropdownMenu = new System.Windows.Forms.ComboBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.software = new System.Windows.Forms.Label();
            this.softwareComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tabList = new System.Windows.Forms.TabControl();
            this.linksTab = new System.Windows.Forms.TabPage();
            this.favouriteButton5 = new System.Windows.Forms.Button();
            this.favouriteButton4 = new System.Windows.Forms.Button();
            this.favouriteButton3 = new System.Windows.Forms.Button();
            this.favouriteButton2 = new System.Windows.Forms.Button();
            this.favouriteButton1 = new System.Windows.Forms.Button();
            this.helpTab = new System.Windows.Forms.TabPage();
            this.launcherTab = new System.Windows.Forms.TabPage();
            this.tabList.SuspendLayout();
            this.linksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(31, 355);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(56, 23);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.FormattingEnabled = true;
            this.clientDropdownMenu.Location = new System.Drawing.Point(31, 151);
            this.clientDropdownMenu.MaxDropDownItems = 20;
            this.clientDropdownMenu.Name = "clientDropdownMenu";
            this.clientDropdownMenu.Size = new System.Drawing.Size(69, 23);
            this.clientDropdownMenu.TabIndex = 1;
            this.clientDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.clientDropdownMenu_Selected);
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Location = new System.Drawing.Point(106, 151);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(69, 23);
            this.versionDropdownMenu.TabIndex = 2;
            this.versionDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.versionDropdownMenu_Selected);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientLabel.Location = new System.Drawing.Point(31, 133);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(38, 15);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Client";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionLabel.Location = new System.Drawing.Point(106, 133);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "Version";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(9, 396);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(181, 151);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 23);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // software
            // 
            this.software.AutoSize = true;
            this.software.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.software.Location = new System.Drawing.Point(31, 62);
            this.software.Name = "software";
            this.software.Size = new System.Drawing.Size(53, 15);
            this.software.TabIndex = 15;
            this.software.Text = "Software";
            // 
            // softwareComboBox
            // 
            this.softwareComboBox.FormattingEnabled = true;
            this.softwareComboBox.Items.AddRange(new object[] {
            "Civil 3D (Autodesk)"});
            this.softwareComboBox.Location = new System.Drawing.Point(31, 80);
            this.softwareComboBox.Name = "softwareComboBox";
            this.softwareComboBox.Size = new System.Drawing.Size(144, 23);
            this.softwareComboBox.TabIndex = 16;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(31, 197);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(206, 141);
            this.tableLayoutPanel.TabIndex = 17;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(106, 355);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(172, 354);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(93, 23);
            this.nameTextBox.TabIndex = 19;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(268, 354);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(33, 23);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.linksTab);
            this.tabList.Controls.Add(this.helpTab);
            this.tabList.Controls.Add(this.launcherTab);
            this.tabList.Location = new System.Drawing.Point(9, 12);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(382, 381);
            this.tabList.TabIndex = 21;
            // 
            // linksTab
            // 
            this.linksTab.Controls.Add(this.favouriteButton5);
            this.linksTab.Controls.Add(this.favouriteButton4);
            this.linksTab.Controls.Add(this.favouriteButton3);
            this.linksTab.Controls.Add(this.favouriteButton2);
            this.linksTab.Controls.Add(this.favouriteButton1);
            this.linksTab.Location = new System.Drawing.Point(4, 24);
            this.linksTab.Name = "linksTab";
            this.linksTab.Padding = new System.Windows.Forms.Padding(3);
            this.linksTab.Size = new System.Drawing.Size(374, 353);
            this.linksTab.TabIndex = 1;
            this.linksTab.Text = "Links";
            this.linksTab.UseVisualStyleBackColor = true;
            // 
            // favouriteButton5
            // 
            this.favouriteButton5.Location = new System.Drawing.Point(282, 138);
            this.favouriteButton5.Name = "favouriteButton5";
            this.favouriteButton5.Size = new System.Drawing.Size(75, 23);
            this.favouriteButton5.TabIndex = 4;
            this.favouriteButton5.Text = "button5";
            this.favouriteButton5.UseVisualStyleBackColor = true;
            // 
            // favouriteButton4
            // 
            this.favouriteButton4.Location = new System.Drawing.Point(282, 109);
            this.favouriteButton4.Name = "favouriteButton4";
            this.favouriteButton4.Size = new System.Drawing.Size(75, 23);
            this.favouriteButton4.TabIndex = 3;
            this.favouriteButton4.Text = "button4";
            this.favouriteButton4.UseVisualStyleBackColor = true;
            // 
            // favouriteButton3
            // 
            this.favouriteButton3.Location = new System.Drawing.Point(282, 80);
            this.favouriteButton3.Name = "favouriteButton3";
            this.favouriteButton3.Size = new System.Drawing.Size(75, 23);
            this.favouriteButton3.TabIndex = 2;
            this.favouriteButton3.Text = "button3";
            this.favouriteButton3.UseVisualStyleBackColor = true;
            // 
            // favouriteButton2
            // 
            this.favouriteButton2.Location = new System.Drawing.Point(282, 51);
            this.favouriteButton2.Name = "favouriteButton2";
            this.favouriteButton2.Size = new System.Drawing.Size(75, 23);
            this.favouriteButton2.TabIndex = 1;
            this.favouriteButton2.Text = "button2";
            this.favouriteButton2.UseVisualStyleBackColor = true;
            // 
            // favouriteButton1
            // 
            this.favouriteButton1.Location = new System.Drawing.Point(282, 22);
            this.favouriteButton1.Name = "favouriteButton1";
            this.favouriteButton1.Size = new System.Drawing.Size(75, 23);
            this.favouriteButton1.TabIndex = 0;
            this.favouriteButton1.Text = "button1";
            this.favouriteButton1.UseVisualStyleBackColor = true;
            this.favouriteButton1.Click += new System.EventHandler(this.favouriteButton1_Click);
            // 
            // helpTab
            // 
            this.helpTab.Location = new System.Drawing.Point(4, 24);
            this.helpTab.Name = "helpTab";
            this.helpTab.Padding = new System.Windows.Forms.Padding(3);
            this.helpTab.Size = new System.Drawing.Size(377, 353);
            this.helpTab.TabIndex = 2;
            this.helpTab.Text = "Help";
            this.helpTab.UseVisualStyleBackColor = true;
            // 
            // launcherTab
            // 
            this.launcherTab.Location = new System.Drawing.Point(4, 24);
            this.launcherTab.Name = "launcherTab";
            this.launcherTab.Padding = new System.Windows.Forms.Padding(3);
            this.launcherTab.Size = new System.Drawing.Size(377, 353);
            this.launcherTab.TabIndex = 0;
            this.launcherTab.Text = "Launcher";
            this.launcherTab.UseVisualStyleBackColor = true;
            this.launcherTab.Click += new System.EventHandler(this.launcherTab_Click);
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 416);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.softwareComboBox);
            this.Controls.Add(this.software);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.versionDropdownMenu);
            this.Controls.Add(this.clientDropdownMenu);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.tabList);
            this.Name = "repconLauncher";
            this.Text = "REPCON Launcher";
            this.Load += new System.EventHandler(this.repconLauncher_Load);
            this.tabList.ResumeLayout(false);
            this.linksTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button launchButton;
        private ComboBox clientDropdownMenu;
        private ComboBox versionDropdownMenu;
        private Label clientLabel;
        private Label versionLabel;
        private Label usernameLabel;
        private Button resetButton;
        private Label software;
        private ComboBox softwareComboBox;
        private TableLayoutPanel tableLayoutPanel;
        private Button saveButton;
        private TextBox nameTextBox;
        private Button okButton;
        private TabControl tabList;
        private TabPage linksTab;
        private TabPage helpTab;
        private TabPage launcherTab;
        private Button favouriteButton5;
        private Button favouriteButton4;
        private Button favouriteButton3;
        private Button favouriteButton2;
        private Button favouriteButton1;
    }
}