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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.environmentName = new System.Windows.Forms.Label();
            this.softwareYear = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.languageChoice = new System.Windows.Forms.ComboBox();
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
            this.launchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CofC",
            "MTO",
            "MTQ",
            "MVRD",
            "MX",
            "WSP_EN",
            "WSP_FR"});
            this.comboBox1.Location = new System.Drawing.Point(99, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.comboBox2.Location = new System.Drawing.Point(99, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 2;
            // 
            // environmentName
            // 
            this.environmentName.AutoSize = true;
            this.environmentName.Location = new System.Drawing.Point(20, 16);
            this.environmentName.Name = "environmentName";
            this.environmentName.Size = new System.Drawing.Size(75, 15);
            this.environmentName.TabIndex = 3;
            this.environmentName.Text = "Environment";
            this.environmentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // softwareYear
            // 
            this.softwareYear.AutoSize = true;
            this.softwareYear.Location = new System.Drawing.Point(48, 45);
            this.softwareYear.Name = "softwareYear";
            this.softwareYear.Size = new System.Drawing.Size(45, 15);
            this.softwareYear.TabIndex = 4;
            this.softwareYear.Text = "Version";
            this.softwareYear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Location = new System.Drawing.Point(34, 75);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(59, 15);
            this.language.TabIndex = 5;
            this.language.Text = "Language";
            this.language.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // languageChoice
            // 
            this.languageChoice.FormattingEnabled = true;
            this.languageChoice.Items.AddRange(new object[] {
            "English",
            "French"});
            this.languageChoice.Location = new System.Drawing.Point(99, 72);
            this.languageChoice.Name = "languageChoice";
            this.languageChoice.Size = new System.Drawing.Size(121, 23);
            this.languageChoice.TabIndex = 6;
            // 
            // repconLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 181);
            this.Controls.Add(this.languageChoice);
            this.Controls.Add(this.language);
            this.Controls.Add(this.softwareYear);
            this.Controls.Add(this.environmentName);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.launchButton);
            this.Name = "repconLauncher";
            this.Text = "REPCON Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button launchButton;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label environmentName;
        private Label softwareYear;
        private Label language;
        private ComboBox languageChoice;
    }
}