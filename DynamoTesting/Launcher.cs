using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        public repconLauncher()
        {
            InitializeComponent();
            clientDropdownMenu.Items.AddRange(ShortcutsModel.clientOptions);
            languageDropdownMenu.Items.AddRange(ShortcutsModel.languageOptions);
            versionDropdownMenu.Items.AddRange(ShortcutsModel.versionOptions);
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

        private void clientDropdownMenu_Selected(object sender, EventArgs e)
        {

        }
        private void languageDropdownMenu_Selected(object sender, EventArgs e)
        {
            languageDropdownMenu.DataSource = ShortcutsModel.languageOptions;
            //languageDropdownMenu.Enabled = false;
        }
        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {
            versionDropdownMenu.DataSource = ShortcutsModel.versionOptions;
            //versionDropdownMenu.Enabled = false;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            ShortcutsModel shortcutsModel = new ShortcutsModel();
            string pathToShortcut = shortcutsModel.createShortcut(client, language, version);

            if (System.IO.File.Exists(pathToShortcut))
            {
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

        private void label1_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();
            ShortcutsModel shortcutsModel = new ShortcutsModel();
            string pathToShortcut = shortcutsModel.createShortcut(client, language, version);
            label1.Text = pathToShortcut;
        }
    }
}
