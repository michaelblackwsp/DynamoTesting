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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tabList = new System.Windows.Forms.TabControl();
            this.launcherTab = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.softwareComboBox = new System.Windows.Forms.ComboBox();
            this.software = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.versionDropdownMenu = new System.Windows.Forms.ComboBox();
            this.clientDropdownMenu = new System.Windows.Forms.ComboBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.favouritesPanel = new System.Windows.Forms.Panel();
            this.favouritesLabel = new System.Windows.Forms.Label();
            this.superLinksTab = new System.Windows.Forms.TabPage();
            this.linksComingSoonLabel = new System.Windows.Forms.Label();
            this.resourcesTab = new System.Windows.Forms.TabPage();
            this.helpComingSoonLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabList.SuspendLayout();
            this.launcherTab.SuspendLayout();
            this.favouritesPanel.SuspendLayout();
            this.superLinksTab.SuspendLayout();
            this.resourcesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(6, 428);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.launcherTab);
            this.tabList.Controls.Add(this.superLinksTab);
            this.tabList.Controls.Add(this.resourcesTab);
            this.tabList.Location = new System.Drawing.Point(12, 12);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(403, 413);
            this.tabList.TabIndex = 21;
            // 
            // launcherTab
            // 
            this.launcherTab.Controls.Add(this.cancelButton);
            this.launcherTab.Controls.Add(this.saveButton);
            this.launcherTab.Controls.Add(this.nameTextBox);
            this.launcherTab.Controls.Add(this.tableLayoutPanel);
            this.launcherTab.Controls.Add(this.softwareComboBox);
            this.launcherTab.Controls.Add(this.software);
            this.launcherTab.Controls.Add(this.resetButton);
            this.launcherTab.Controls.Add(this.versionLabel);
            this.launcherTab.Controls.Add(this.clientLabel);
            this.launcherTab.Controls.Add(this.versionDropdownMenu);
            this.launcherTab.Controls.Add(this.clientDropdownMenu);
            this.launcherTab.Controls.Add(this.launchButton);
            this.launcherTab.Controls.Add(this.favouritesPanel);
            this.launcherTab.Location = new System.Drawing.Point(4, 24);
            this.launcherTab.Name = "launcherTab";
            this.launcherTab.Padding = new System.Windows.Forms.Padding(3);
            this.launcherTab.Size = new System.Drawing.Size(395, 385);
            this.launcherTab.TabIndex = 1;
            this.launcherTab.Text = "Launcher";
            this.launcherTab.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(265, 354);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(44, 24);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(265, 330);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(105, 22);
            this.nameTextBox.TabIndex = 31;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.90196F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.09804F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(15, 146);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(223, 180);
            this.tableLayoutPanel.TabIndex = 29;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint_1);
            // 
            // softwareComboBox
            // 
            this.softwareComboBox.FormattingEnabled = true;
            this.softwareComboBox.Items.AddRange(new object[] {
            "Civil 3D",
            "OpenRoads Designer"});
            this.softwareComboBox.Location = new System.Drawing.Point(15, 36);
            this.softwareComboBox.Name = "softwareComboBox";
            this.softwareComboBox.Size = new System.Drawing.Size(222, 23);
            this.softwareComboBox.TabIndex = 28;
            this.softwareComboBox.SelectedIndexChanged += new System.EventHandler(this.softwareComboBox_SelectedIndexChanged);
            // 
            // software
            // 
            this.software.AutoSize = true;
            this.software.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.software.Location = new System.Drawing.Point(15, 18);
            this.software.Name = "software";
            this.software.Size = new System.Drawing.Size(53, 15);
            this.software.TabIndex = 27;
            this.software.Text = "Software";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(181, 107);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 23);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionLabel.Location = new System.Drawing.Point(90, 89);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 25;
            this.versionLabel.Text = "Version";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientLabel.Location = new System.Drawing.Point(15, 89);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(38, 15);
            this.clientLabel.TabIndex = 24;
            this.clientLabel.Text = "Client";
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Location = new System.Drawing.Point(90, 107);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(85, 23);
            this.versionDropdownMenu.TabIndex = 23;
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.FormattingEnabled = true;
            this.clientDropdownMenu.Location = new System.Drawing.Point(15, 107);
            this.clientDropdownMenu.MaxDropDownItems = 20;
            this.clientDropdownMenu.Name = "clientDropdownMenu";
            this.clientDropdownMenu.Size = new System.Drawing.Size(69, 23);
            this.clientDropdownMenu.TabIndex = 22;
            this.clientDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.clientDropdownMenu_SelectedIndexChanged_1);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(15, 341);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(95, 36);
            this.launchButton.TabIndex = 21;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // favouritesPanel
            // 
            this.favouritesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favouritesPanel.Controls.Add(this.favouritesLabel);
            this.favouritesPanel.Location = new System.Drawing.Point(262, 36);
            this.favouritesPanel.Name = "favouritesPanel";
            this.favouritesPanel.Size = new System.Drawing.Size(112, 290);
            this.favouritesPanel.TabIndex = 34;
            this.favouritesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.favouritesPanel_Paint);
            // 
            // favouritesLabel
            // 
            this.favouritesLabel.AutoSize = true;
            this.favouritesLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.favouritesLabel.Location = new System.Drawing.Point(17, 5);
            this.favouritesLabel.Name = "favouritesLabel";
            this.favouritesLabel.Size = new System.Drawing.Size(61, 15);
            this.favouritesLabel.TabIndex = 0;
            this.favouritesLabel.Text = "Favourites";
            this.favouritesLabel.Click += new System.EventHandler(this.favouritesLabel_Click);
            // 
            // superLinksTab
            // 
            this.superLinksTab.Controls.Add(this.linksComingSoonLabel);
            this.superLinksTab.Location = new System.Drawing.Point(4, 24);
            this.superLinksTab.Name = "superLinksTab";
            this.superLinksTab.Padding = new System.Windows.Forms.Padding(3);
            this.superLinksTab.Size = new System.Drawing.Size(395, 385);
            this.superLinksTab.TabIndex = 0;
            this.superLinksTab.Text = "Super Links";
            this.superLinksTab.UseVisualStyleBackColor = true;
            this.superLinksTab.Click += new System.EventHandler(this.launcherTab_Click);
            // 
            // linksComingSoonLabel
            // 
            this.linksComingSoonLabel.AutoSize = true;
            this.linksComingSoonLabel.Location = new System.Drawing.Point(142, 159);
            this.linksComingSoonLabel.Name = "linksComingSoonLabel";
            this.linksComingSoonLabel.Size = new System.Drawing.Size(83, 15);
            this.linksComingSoonLabel.TabIndex = 2;
            this.linksComingSoonLabel.Text = "Coming Soon!";
            // 
            // resourcesTab
            // 
            this.resourcesTab.Controls.Add(this.helpComingSoonLabel);
            this.resourcesTab.Location = new System.Drawing.Point(4, 24);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTab.Size = new System.Drawing.Size(395, 385);
            this.resourcesTab.TabIndex = 2;
            this.resourcesTab.Text = "Resources";
            this.resourcesTab.UseVisualStyleBackColor = true;
            // 
            // helpComingSoonLabel
            // 
            this.helpComingSoonLabel.AutoSize = true;
            this.helpComingSoonLabel.Location = new System.Drawing.Point(142, 159);
            this.helpComingSoonLabel.Name = "helpComingSoonLabel";
            this.helpComingSoonLabel.Size = new System.Drawing.Size(83, 15);
            this.helpComingSoonLabel.TabIndex = 1;
            this.helpComingSoonLabel.Text = "Coming Soon!";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(318, 428);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languageLabel.Size = new System.Drawing.Size(56, 15);
            this.languageLabel.TabIndex = 22;
            this.languageLabel.Text = "language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(58, 24);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.tabList);
            this.Name = "repconLauncher";
            this.Text = "REPCON";
            this.Load += new System.EventHandler(this.repconLauncher_Load);
            this.tabList.ResumeLayout(false);
            this.launcherTab.ResumeLayout(false);
            this.launcherTab.PerformLayout();
            this.favouritesPanel.ResumeLayout(false);
            this.favouritesPanel.PerformLayout();
            this.superLinksTab.ResumeLayout(false);
            this.superLinksTab.PerformLayout();
            this.resourcesTab.ResumeLayout(false);
            this.resourcesTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label usernameLabel;
        private TabControl tabList;
        private TabPage launcherTab;
        private TabPage resourcesTab;
        private TabPage superLinksTab;
        private Button saveButton;
        private TextBox nameTextBox;
        private TableLayoutPanel tableLayoutPanel;
        private ComboBox softwareComboBox;
        private Label software;
        private Button resetButton;
        private Label versionLabel;
        private Label clientLabel;
        private ComboBox versionDropdownMenu;
        private ComboBox clientDropdownMenu;
        private Button launchButton;
        private Label helpComingSoonLabel;
        private Label linksComingSoonLabel;
        private Label languageLabel;
        private Panel favouritesPanel;
        private Label favouritesLabel;
        private Button cancelButton;
    }
}