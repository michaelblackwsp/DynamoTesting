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
            this.tabList = new System.Windows.Forms.TabControl();
            this.launcherTab = new System.Windows.Forms.TabPage();
            this.softwareWarningLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.favouritesLabel = new System.Windows.Forms.Label();
            this.launchButton = new System.Windows.Forms.Button();
            this.softwareComboBox = new System.Windows.Forms.ComboBox();
            this.software = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.versionDropdownMenu = new System.Windows.Forms.ComboBox();
            this.clientDropdownMenu = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.favouritesPanel = new System.Windows.Forms.Panel();
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
            this.upToDateLabel = new System.Windows.Forms.Label();
            this.versionNumber = new System.Windows.Forms.Label();
            this.releaseNotes = new System.Windows.Forms.LinkLabel();
            this.languageLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.eula = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabList.SuspendLayout();
            this.launcherTab.SuspendLayout();
            this.superLinksTab.SuspendLayout();
            this.resourcesTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.launcherTab);
            this.tabList.Controls.Add(this.superLinksTab);
            this.tabList.Controls.Add(this.resourcesTab);
            this.tabList.Controls.Add(this.aboutTab);
            this.tabList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabList.Location = new System.Drawing.Point(11, 12);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(414, 485);
            this.tabList.TabIndex = 21;
            // 
            // launcherTab
            // 
            this.launcherTab.Controls.Add(this.softwareWarningLabel);
            this.launcherTab.Controls.Add(this.resetButton);
            this.launcherTab.Controls.Add(this.favouritesLabel);
            this.launcherTab.Controls.Add(this.launchButton);
            this.launcherTab.Controls.Add(this.softwareComboBox);
            this.launcherTab.Controls.Add(this.software);
            this.launcherTab.Controls.Add(this.versionLabel);
            this.launcherTab.Controls.Add(this.clientLabel);
            this.launcherTab.Controls.Add(this.versionDropdownMenu);
            this.launcherTab.Controls.Add(this.clientDropdownMenu);
            this.launcherTab.Controls.Add(this.cancelButton);
            this.launcherTab.Controls.Add(this.saveButton);
            this.launcherTab.Controls.Add(this.nameTextBox);
            this.launcherTab.Controls.Add(this.tableLayoutPanel);
            this.launcherTab.Controls.Add(this.favouritesPanel);
            this.launcherTab.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.launcherTab.Location = new System.Drawing.Point(4, 22);
            this.launcherTab.Name = "launcherTab";
            this.launcherTab.Padding = new System.Windows.Forms.Padding(3);
            this.launcherTab.Size = new System.Drawing.Size(406, 459);
            this.launcherTab.TabIndex = 1;
            this.launcherTab.Text = "Launcher";
            this.launcherTab.UseVisualStyleBackColor = true;
            this.launcherTab.Click += new System.EventHandler(this.launcherTab_Click_1);
            // 
            // softwareWarningLabel
            // 
            this.softwareWarningLabel.AutoSize = true;
            this.softwareWarningLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.softwareWarningLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.softwareWarningLabel.Location = new System.Drawing.Point(16, 386);
            this.softwareWarningLabel.Name = "softwareWarningLabel";
            this.softwareWarningLabel.Size = new System.Drawing.Size(129, 13);
            this.softwareWarningLabel.TabIndex = 39;
            this.softwareWarningLabel.Text = "* Software not installed";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(358, 0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 24);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // favouritesLabel
            // 
            this.favouritesLabel.AutoSize = true;
            this.favouritesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.favouritesLabel.Location = new System.Drawing.Point(259, 37);
            this.favouritesLabel.Name = "favouritesLabel";
            this.favouritesLabel.Size = new System.Drawing.Size(60, 13);
            this.favouritesLabel.TabIndex = 38;
            this.favouritesLabel.Text = "Favourites";
            this.favouritesLabel.Click += new System.EventHandler(this.favouritesLabel_Click_1);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(15, 408);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(95, 36);
            this.launchButton.TabIndex = 37;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // softwareComboBox
            // 
            this.softwareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.softwareComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.softwareComboBox.FormattingEnabled = true;
            this.softwareComboBox.Items.AddRange(new object[] {
            "Civil 3D",
            "OpenRoads Designer"});
            this.softwareComboBox.Location = new System.Drawing.Point(15, 52);
            this.softwareComboBox.Name = "softwareComboBox";
            this.softwareComboBox.Size = new System.Drawing.Size(220, 21);
            this.softwareComboBox.TabIndex = 28;
            this.softwareComboBox.SelectedIndexChanged += new System.EventHandler(this.softwareComboBox_SelectedIndexChanged);
            // 
            // software
            // 
            this.software.AutoSize = true;
            this.software.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.software.Location = new System.Drawing.Point(15, 37);
            this.software.Name = "software";
            this.software.Size = new System.Drawing.Size(53, 13);
            this.software.TabIndex = 27;
            this.software.Text = "Software";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.versionLabel.Location = new System.Drawing.Point(130, 90);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 25;
            this.versionLabel.Text = "Version";
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientLabel.Location = new System.Drawing.Point(15, 90);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(37, 13);
            this.clientLabel.TabIndex = 24;
            this.clientLabel.Text = "Client";
            this.clientLabel.Click += new System.EventHandler(this.clientLabel_Click_1);
            // 
            // versionDropdownMenu
            // 
            this.versionDropdownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionDropdownMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versionDropdownMenu.FormattingEnabled = true;
            this.versionDropdownMenu.Location = new System.Drawing.Point(131, 105);
            this.versionDropdownMenu.Name = "versionDropdownMenu";
            this.versionDropdownMenu.Size = new System.Drawing.Size(104, 21);
            this.versionDropdownMenu.TabIndex = 23;
            // 
            // clientDropdownMenu
            // 
            this.clientDropdownMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientDropdownMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientDropdownMenu.FormattingEnabled = true;
            this.clientDropdownMenu.Location = new System.Drawing.Point(15, 105);
            this.clientDropdownMenu.MaxDropDownItems = 20;
            this.clientDropdownMenu.Name = "clientDropdownMenu";
            this.clientDropdownMenu.Size = new System.Drawing.Size(110, 21);
            this.clientDropdownMenu.TabIndex = 22;
            this.clientDropdownMenu.SelectedIndexChanged += new System.EventHandler(this.clientDropdownMenu_SelectedIndexChanged_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(326, 420);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(67, 24);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(259, 420);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(61, 24);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(259, 392);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(134, 22);
            this.nameTextBox.TabIndex = 31;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Font = new System.Drawing.Font("Segoe UI Symbol", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel.Location = new System.Drawing.Point(15, 145);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(220, 240);
            this.tableLayoutPanel.TabIndex = 29;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel_Paint);
            // 
            // favouritesPanel
            // 
            this.favouritesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.favouritesPanel.Location = new System.Drawing.Point(259, 52);
            this.favouritesPanel.Name = "favouritesPanel";
            this.favouritesPanel.Size = new System.Drawing.Size(134, 334);
            this.favouritesPanel.TabIndex = 34;
            this.favouritesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.favouritesPanel_Paint);
            // 
            // superLinksTab
            // 
            this.superLinksTab.Controls.Add(this.linksComingSoonLabel);
            this.superLinksTab.Location = new System.Drawing.Point(4, 22);
            this.superLinksTab.Name = "superLinksTab";
            this.superLinksTab.Padding = new System.Windows.Forms.Padding(3);
            this.superLinksTab.Size = new System.Drawing.Size(406, 459);
            this.superLinksTab.TabIndex = 0;
            this.superLinksTab.Text = "Super Links";
            this.superLinksTab.UseVisualStyleBackColor = true;
            this.superLinksTab.Click += new System.EventHandler(this.launcherTab_Click);
            // 
            // linksComingSoonLabel
            // 
            this.linksComingSoonLabel.AutoSize = true;
            this.linksComingSoonLabel.Location = new System.Drawing.Point(149, 174);
            this.linksComingSoonLabel.Name = "linksComingSoonLabel";
            this.linksComingSoonLabel.Size = new System.Drawing.Size(80, 13);
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
            this.resourcesTab.Location = new System.Drawing.Point(4, 22);
            this.resourcesTab.Name = "resourcesTab";
            this.resourcesTab.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTab.Size = new System.Drawing.Size(406, 459);
            this.resourcesTab.TabIndex = 2;
            this.resourcesTab.Text = "Resources";
            this.resourcesTab.UseVisualStyleBackColor = true;
            // 
            // civil3dRequestForm
            // 
            this.civil3dRequestForm.AutoSize = true;
            this.civil3dRequestForm.Location = new System.Drawing.Point(127, 103);
            this.civil3dRequestForm.Name = "civil3dRequestForm";
            this.civil3dRequestForm.Size = new System.Drawing.Size(119, 13);
            this.civil3dRequestForm.TabIndex = 7;
            this.civil3dRequestForm.TabStop = true;
            this.civil3dRequestForm.Text = "Civil 3D Request Form";
            this.civil3dRequestForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.civil3dRequestForm_LinkClicked);
            // 
            // horizonOracleSupport
            // 
            this.horizonOracleSupport.AutoSize = true;
            this.horizonOracleSupport.Location = new System.Drawing.Point(123, 196);
            this.horizonOracleSupport.Name = "horizonOracleSupport";
            this.horizonOracleSupport.Size = new System.Drawing.Size(129, 13);
            this.horizonOracleSupport.TabIndex = 6;
            this.horizonOracleSupport.TabStop = true;
            this.horizonOracleSupport.Text = "Horizon Oracle Support";
            this.horizonOracleSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.horizonOracleSupport_LinkClicked);
            // 
            // pans
            // 
            this.pans.AutoSize = true;
            this.pans.Location = new System.Drawing.Point(172, 281);
            this.pans.Name = "pans";
            this.pans.Size = new System.Drawing.Size(32, 13);
            this.pans.TabIndex = 5;
            this.pans.TabStop = true;
            this.pans.Text = "PANs";
            this.pans.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pans_LinkClicked);
            // 
            // wspServiceNow
            // 
            this.wspServiceNow.AutoSize = true;
            this.wspServiceNow.Location = new System.Drawing.Point(140, 256);
            this.wspServiceNow.Name = "wspServiceNow";
            this.wspServiceNow.Size = new System.Drawing.Size(95, 13);
            this.wspServiceNow.TabIndex = 4;
            this.wspServiceNow.TabStop = true;
            this.wspServiceNow.Text = "WSP Service Now";
            this.wspServiceNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.wspServiceNow_LinkClicked);
            // 
            // oracleTimesheet
            // 
            this.oracleTimesheet.AutoSize = true;
            this.oracleTimesheet.Location = new System.Drawing.Point(139, 173);
            this.oracleTimesheet.Name = "oracleTimesheet";
            this.oracleTimesheet.Size = new System.Drawing.Size(95, 13);
            this.oracleTimesheet.TabIndex = 3;
            this.oracleTimesheet.TabStop = true;
            this.oracleTimesheet.Text = "Oracle Timesheet";
            this.oracleTimesheet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.oracleTimesheet_LinkClicked);
            // 
            // digitalOperationsHomePage
            // 
            this.digitalOperationsHomePage.AutoSize = true;
            this.digitalOperationsHomePage.Location = new System.Drawing.Point(108, 80);
            this.digitalOperationsHomePage.Name = "digitalOperationsHomePage";
            this.digitalOperationsHomePage.Size = new System.Drawing.Size(163, 13);
            this.digitalOperationsHomePage.TabIndex = 2;
            this.digitalOperationsHomePage.TabStop = true;
            this.digitalOperationsHomePage.Text = "Digital Operations Home Page";
            this.digitalOperationsHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.digitalOperationsHomePage_LinkClicked);
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.upToDateLabel);
            this.aboutTab.Controls.Add(this.versionNumber);
            this.aboutTab.Controls.Add(this.releaseNotes);
            this.aboutTab.Controls.Add(this.languageLabel);
            this.aboutTab.Controls.Add(this.usernameLabel);
            this.aboutTab.Controls.Add(this.eula);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutTab.Size = new System.Drawing.Size(406, 459);
            this.aboutTab.TabIndex = 3;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            this.aboutTab.Click += new System.EventHandler(this.aboutTab_Click);
            // 
            // upToDateLabel
            // 
            this.upToDateLabel.AutoSize = true;
            this.upToDateLabel.Location = new System.Drawing.Point(167, 209);
            this.upToDateLabel.Name = "upToDateLabel";
            this.upToDateLabel.Size = new System.Drawing.Size(68, 13);
            this.upToDateLabel.TabIndex = 27;
            this.upToDateLabel.Text = "(Up to date)";
            this.upToDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upToDateLabel.Click += new System.EventHandler(this.upToDateLabel_Click);
            // 
            // versionNumber
            // 
            this.versionNumber.AutoSize = true;
            this.versionNumber.Location = new System.Drawing.Point(168, 193);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(63, 13);
            this.versionNumber.TabIndex = 26;
            this.versionNumber.Text = "Version 1.0";
            this.versionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionNumber.Click += new System.EventHandler(this.buildNumber_Click);
            // 
            // releaseNotes
            // 
            this.releaseNotes.AutoSize = true;
            this.releaseNotes.Location = new System.Drawing.Point(163, 227);
            this.releaseNotes.Name = "releaseNotes";
            this.releaseNotes.Size = new System.Drawing.Size(79, 13);
            this.releaseNotes.TabIndex = 25;
            this.releaseNotes.TabStop = true;
            this.releaseNotes.Text = "Release Notes";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(3, 439);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languageLabel.Size = new System.Drawing.Size(56, 13);
            this.languageLabel.TabIndex = 24;
            this.languageLabel.Text = "language";
            this.languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(3, 424);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 23;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click_1);
            // 
            // eula
            // 
            this.eula.AutoSize = true;
            this.eula.Location = new System.Drawing.Point(106, 80);
            this.eula.Name = "eula";
            this.eula.Size = new System.Drawing.Size(188, 13);
            this.eula.TabIndex = 3;
            this.eula.TabStop = true;
            this.eula.Text = "End-User License Agreement (EULA)";
            this.eula.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eula_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(275, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 266);
            this.panel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 24);
            this.button1.TabIndex = 35;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(275, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 24);
            this.button2.TabIndex = 30;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(275, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 510);
            this.Controls.Add(this.tabList);
            this.Name = "repconLauncher";
            this.Text = "REPCON";
            this.Load += new System.EventHandler(this.repconLauncher_Load);
            this.tabList.ResumeLayout(false);
            this.launcherTab.ResumeLayout(false);
            this.launcherTab.PerformLayout();
            this.superLinksTab.ResumeLayout(false);
            this.superLinksTab.PerformLayout();
            this.resourcesTab.ResumeLayout(false);
            this.resourcesTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Label linksComingSoonLabel;
        private Button cancelButton;
        private LinkLabel digitalOperationsHomePage;
        private LinkLabel oracleTimesheet;
        private LinkLabel wspServiceNow;
        private LinkLabel pans;
        private LinkLabel horizonOracleSupport;
        private LinkLabel civil3dRequestForm;
        private TabPage aboutTab;
        private LinkLabel eula;
        private Label languageLabel;
        private Label usernameLabel;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage1;
        private Button launchButton;
        private Panel favouritesPanel;
        private Label versionNumber;
        private LinkLabel releaseNotes;
        private Label upToDateLabel;
        private Label favouritesLabel;
        private Label label1;
        private Label softwareWarningLabel;
    }
}