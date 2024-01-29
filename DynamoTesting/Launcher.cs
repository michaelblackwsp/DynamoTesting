using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        ShortcutsModel model = new ShortcutsModel();

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
            // TO DO: Where is the data coming from if it works when this is commented out?
            //clientDropdownMenu.DataSource = ShortcutsModel.clientOptions;
        }
        private void languageDropdownMenu_Selected(object sender, EventArgs e)
        {
            // TO DO: Where is the data coming from if it works when this is commented out?
            //languageDropdownMenu.DataSource = ShortcutsModel.languageOptions;
        }
        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {
            // TO DO: Where is the data coming from if it works when this is commented out?
            //versionDropdownMenu.DataSource = ShortcutsModel.versionOptions;
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.createShortcut(client, language, version);

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
            // TO DO: handle when one or all choices is still empty
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.createShortcut(client, language, version);
            label1.Text = pathToShortcut;
        }

        private void addRegistryButton_Click(object sender, EventArgs e)
        {
            model.updateRegistry();
        }

        private void checkRegistryButton_Click(object sender, EventArgs e)
        {
            string path = @"SOFTWARE\Autodesk\AutoCAD\R24.0\ACAD-4100:40C\Profiles\c3d_2021_fr_wsp_fr";
            model.RegistryExists(path);

            if (model.RegistryExists(path))
            {
                MessageBox.Show($"Registry key '{path}' exists.");
            }
            else
            {
                MessageBox.Show($"Registry key '{path}' does not exist.");
            }
        }

        private void checkCivil3DinRegistry_Click(object sender, EventArgs e)
        {
            string path = @"SOFTWARE\Autodesk\AutoCAD\R24.0\ACAD-4100:40C";
            model.RegistryExists(path);

            if (model.RegistryExists(path))
            {
                MessageBox.Show($"Civil 3D '{path}' exists.");
            }
            else
            {
                MessageBox.Show($"Civil 3D '{path} does not exist.");
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            usernameLabel.Text = Environment.UserName;
        }

        private void checkCivil3DinDirectory_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Autodesk\AutoCAD 2023\acad.exe";
            model.SoftwareExists(path);

            if (model.SoftwareExists(path))
            {
                MessageBox.Show($"Civil 3D '{path}' exists.");
            }
            else
            {
                MessageBox.Show($"Civil 3D '{path} does not exist.");
            }
        }
    }
}
