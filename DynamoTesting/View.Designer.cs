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
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.civil3dRequestForm = new System.Windows.Forms.LinkLabel();
            this.horizonOracleSupport = new System.Windows.Forms.LinkLabel();
            this.pans = new System.Windows.Forms.LinkLabel();
            this.wspServiceNow = new System.Windows.Forms.LinkLabel();
            this.oracleTimesheet = new System.Windows.Forms.LinkLabel();
            this.digitalOperationsHomePage = new System.Windows.Forms.LinkLabel();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.eula = new System.Windows.Forms.LinkLabel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.tabList.SuspendLayout();
            this.launcherTab.SuspendLayout();
            this.favouritesPanel.SuspendLayout();
            this.superLinksTab.SuspendLayout();
            this.resourcesTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 456);
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
            this.tabList.Controls.Add(this.aboutTab);
            this.tabList.Location = new System.Drawing.Point(12, 12);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(403, 441);
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
            this.launcherTab.Size = new System.Drawing.Size(395, 413);
            this.launcherTab.TabIndex = 1;
            this.launcherTab.Text = "Launcher";
            this.launcherTab.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 378);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(58, 24);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(265, 378);
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
            this.nameTextBox.Location = new System.Drawing.Point(265, 354);
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
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(223, 197);
            this.tableLayoutPanel.TabIndex = 29;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint_1);
            // 
            // softwareComboBox
            // 
            this.softwareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.versionDropdownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Location = new System.Drawing.Point(90, 107);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(85, 23);
            this.versionDropdownMenu.TabIndex = 23;
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.launchButton.Location = new System.Drawing.Point(15, 365);
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
            this.favouritesPanel.Size = new System.Drawing.Size(112, 307);
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
            this.superLinksTab.Size = new System.Drawing.Size(395, 413);
            this.superLinksTab.TabIndex = 0;
            this.superLinksTab.Text = "Super Links";
            this.superLinksTab.UseVisualStyleBackColor = true;
            this.superLinksTab.Click += new System.EventHandler(this.launcherTab_Click);
            // 
            // linksComingSoonLabel
            // 
            this.linksComingSoonLabel.AutoSize = true;
            this.linksComingSoonLabel.Location = new System.Drawing.Point(155, 174);
            this.linksComingSoonLabel.Name = "linksComingSoonLabel";
            this.linksComingSoonLabel.Size = new System.Drawing.Size(83, 15);
            this.linksComingSoonLabel.TabIndex = 2;
            this.linksComingSoonLabel.Text = "Coming Soon!";
            // 
            // resourcesTab
            // 
            this.resourcesTab.Controls.Add(this.civil3dRequestForm);
            this.resourcesTab.Controls.Add(this.horizonOracleSupport);
            this.resourcesTab.Controls.Add(this.pans);
            this.resourcesTab.Controls.Add(this.wspServiceNow);
            this.resourcesTab.Controls.Add(this.oracleTimesheet);
            this.resourcesTab.Controls.Add(this.digitalOperationsHomePage);
            this.resourcesTab.Location = new System.Drawing.Point(4, 24);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTab.Size = new System.Drawing.Size(395, 413);
            this.resourcesTab.TabIndex = 2;
            this.resourcesTab.Text = "Resources";
            this.resourcesTab.UseVisualStyleBackColor = true;
            // 
            // civil3dRequestForm
            // 
            this.civil3dRequestForm.AutoSize = true;
            this.civil3dRequestForm.Location = new System.Drawing.Point(133, 103);
            this.civil3dRequestForm.Name = "civil3dRequestForm";
            this.civil3dRequestForm.Size = new System.Drawing.Size(123, 15);
            this.civil3dRequestForm.TabIndex = 7;
            this.civil3dRequestForm.TabStop = true;
            this.civil3dRequestForm.Text = "Civil 3D Request Form";
            this.civil3dRequestForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.civil3dRequestForm_LinkClicked);
            // 
            // horizonOracleSupport
            // 
            this.horizonOracleSupport.AutoSize = true;
            this.horizonOracleSupport.Location = new System.Drawing.Point(129, 196);
            this.horizonOracleSupport.Name = "horizonOracleSupport";
            this.horizonOracleSupport.Size = new System.Drawing.Size(131, 15);
            this.horizonOracleSupport.TabIndex = 6;
            this.horizonOracleSupport.TabStop = true;
            this.horizonOracleSupport.Text = "Horizon Oracle Support";
            this.horizonOracleSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.horizonOracleSupport_LinkClicked);
            // 
            // pans
            // 
            this.pans.AutoSize = true;
            this.pans.Location = new System.Drawing.Point(178, 281);
            this.pans.Name = "pans";
            this.pans.Size = new System.Drawing.Size(35, 15);
            this.pans.TabIndex = 5;
            this.pans.TabStop = true;
            this.pans.Text = "PANs";
            this.pans.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pans_LinkClicked);
            // 
            // wspServiceNow
            // 
            this.wspServiceNow.AutoSize = true;
            this.wspServiceNow.Location = new System.Drawing.Point(146, 256);
            this.wspServiceNow.Name = "wspServiceNow";
            this.wspServiceNow.Size = new System.Drawing.Size(99, 15);
            this.wspServiceNow.TabIndex = 4;
            this.wspServiceNow.TabStop = true;
            this.wspServiceNow.Text = "WSP Service Now";
            this.wspServiceNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wspServiceNow_LinkClicked);
            // 
            // oracleTimesheet
            // 
            this.oracleTimesheet.AutoSize = true;
            this.oracleTimesheet.Location = new System.Drawing.Point(145, 173);
            this.oracleTimesheet.Name = "oracleTimesheet";
            this.oracleTimesheet.Size = new System.Drawing.Size(98, 15);
            this.oracleTimesheet.TabIndex = 3;
            this.oracleTimesheet.TabStop = true;
            this.oracleTimesheet.Text = "Oracle Timesheet";
            this.oracleTimesheet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.oracleTimesheet_LinkClicked);
            // 
            // digitalOperationsHomePage
            // 
            this.digitalOperationsHomePage.AutoSize = true;
            this.digitalOperationsHomePage.Location = new System.Drawing.Point(114, 80);
            this.digitalOperationsHomePage.Name = "digitalOperationsHomePage";
            this.digitalOperationsHomePage.Size = new System.Drawing.Size(167, 15);
            this.digitalOperationsHomePage.TabIndex = 2;
            this.digitalOperationsHomePage.TabStop = true;
            this.digitalOperationsHomePage.Text = "Digital Operations Home Page";
            this.digitalOperationsHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.digitalOperationsHomePage_LinkClicked);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.eula);
            this.aboutTab.Location = new System.Drawing.Point(4, 24);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(395, 413);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // eula
            // 
            this.eula.AutoSize = true;
            this.eula.Location = new System.Drawing.Point(97, 80);
            this.eula.Name = "eula";
            this.eula.Size = new System.Drawing.Size(198, 15);
            this.eula.TabIndex = 3;
            this.eula.TabStop = true;
            this.eula.Text = "End-User License Agreement (EULA)";
            this.eula.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eula_LinkClicked);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(300, 456);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languageLabel.Size = new System.Drawing.Size(56, 15);
            this.languageLabel.TabIndex = 22;
            this.languageLabel.Text = "language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 477);
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
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
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
        private Label linksComingSoonLabel;
        private Label languageLabel;
        private Panel favouritesPanel;
        private Label favouritesLabel;
        private Button cancelButton;
        private LinkLabel digitalOperationsHomePage;
        private LinkLabel oracleTimesheet;
        private LinkLabel wspServiceNow;
        private LinkLabel pans;
        private LinkLabel horizonOracleSupport;
        private LinkLabel civil3dRequestForm;
        private TabPage aboutTab;
        private LinkLabel eula;
    }
}