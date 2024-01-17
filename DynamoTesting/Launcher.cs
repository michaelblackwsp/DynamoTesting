using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        public repconLauncher()
        {
            InitializeComponent();
        }

        private void repconLauncher_Load(object sender, EventArgs e)
        {

        }
        private void clientLabel_Click(object sender, EventArgs e)
        {

        }
        private void versionLabel_Click(object sender, EventArgs e)
        {

        }
        private void languageLabel_Click(object sender, EventArgs e)
        {

        }


        private void environmentDropdownMenu_Selected(object sender, EventArgs e)
        {

        }

        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {

        }

        private void languageDropdownMenu_Selected(object sender, EventArgs e)
        {

        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            // Path to shortcut file
            string pathToShortcut = "W:\\1_service\\2_environments\\MTQ\\english_software\\c3d_2020_en_mtq.lnk";

            // Make sure the file exists before starting the process
            if (System.IO.File.Exists(pathToShortcut))
            {
                // Create a new process start info
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pathToShortcut,
                    UseShellExecute = true  // Set this to true to use the default shell verb (open) for shortcuts
                };

                try
                {
                    // Start the process
                    Process.Start(processStartInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error starting external program: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Shortcut file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
