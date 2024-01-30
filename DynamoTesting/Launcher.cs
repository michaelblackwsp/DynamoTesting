using System;
using System.Diagnostics;
using System.Drawing;
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

            // TO DO: Why can this come after? The order doesn't matter
            string[] versionOptions = ShortcutsModel.versionOptions;
            versionDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
            versionDropdownMenu.DrawItem += VersionDropdownMenu_DrawItem;
        }

        private void repconLauncher_Load(object sender, EventArgs e)
        {
            // TO DO: Move logic into the Load method?
        }

        private void VersionDropdownMenu_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                string option = versionDropdownMenu.Items[e.Index].ToString();
                Color colour = setVersionColour(option);

                e.DrawBackground(); // This line somehow makes the text not fuzzy when mouseover

                TextRenderer.DrawText(e.Graphics, option, e.Font, e.Bounds, colour, TextFormatFlags.Left);

                // TO DO: REMOVE THIS?
                //e.DrawFocusRectangle();
            }
        }

        public Color setVersionColour(string choice)
        {
            string path = "";

            string language = languageDropdownMenu.Text;

            Dictionary<string, Tuple<string, string>> yearToRNumberMap = new Dictionary<string, Tuple<string, string>>
            {
                { "2018", Tuple.Create("R22.0", "1000") },
                { "2019", Tuple.Create("R23.0", "2000") },
                { "2020", Tuple.Create("R23.1", "3000") },
                { "2021", Tuple.Create("R24.0", "4100") },
                { "2022", Tuple.Create("R24.1", "5100") },
                { "2023", Tuple.Create("R24.2", "6100") },
            };

            Dictionary<string, string> languageToRegionMap = new Dictionary<string, string>
            {
                { "English", "409" },
                { "French", "40C" },

            };

            if (yearToRNumberMap.ContainsKey(choice))
            {
                Tuple<string, string> values = yearToRNumberMap[choice];
                string rNumber = values.Item1;
                string productId = values.Item2;
                string regionValue = languageToRegionMap[language];

                path = $@"SOFTWARE\Autodesk\AutoCAD\{rNumber}\ACAD-{productId}:{regionValue}\Profiles\<<C3D_Metric>>";

            }
            else
            {
                MessageBox.Show("Problem looping through the versions");
            }

            bool softwareVersion = model.registryExists(path);

            Color colour = Color.Black;
            if (softwareVersion == true)
            {
                colour =  Color.Green;
            }
            else
            {
                colour =  Color.Red;
            }

            return colour; 
        }



        private void clientDropdownMenu_Selected(object sender, EventArgs e)
        {
            // TO DO: The colour changes back to black after a selection is made
        }
        private void languageDropdownMenu_Selected(object sender, EventArgs e)
        {
            // TO DO: The colour changes back to black after a selection is made
        }
        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {
            // TO DO: The colour changes back to black after a selection is made
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

        private void pathLabel_Click(object sender, EventArgs e)
        {
            // TO DO: handle when one or all choices is still empty
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.createShortcut(client, language, version);
            pathLabel.Text = pathToShortcut;
        }



        private void checkRegistryButton_Click(object sender, EventArgs e)
        {
            string path = @"SOFTWARE\Autodesk\AutoCAD\R24.0\ACAD-4100:40C\Profiles\c3d_2021_fr_wsp_fr";
            model.registryExists(path);

            if (model.registryExists(path))
            {
                MessageBox.Show($"Registry key '{path}' exists.");
            }
            else
            {
                MessageBox.Show($"Registry key '{path}' does not exist.");
            }
        }

        private void updateRegistryButton_Click(object sender, EventArgs e)
        {
            model.updateRegistry();
        }



        private void checkCivil3DinRegistry_Click(object sender, EventArgs e)
        {
            string path = @"SOFTWARE\Autodesk\AutoCAD\R24.0\ACAD-4100:40C\Profiles\<<C3D_Metric>>";
            model.registryExists(path);

            if (model.registryExists(path))
            {
                MessageBox.Show($"Civil 3D '{path}' exists.");
            }
            else
            {
                MessageBox.Show($"Civil 3D '{path} does not exist.");
            }
        }

        private void checkCivil3DinDirectory_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\Autodesk\AutoCAD 2023\acad.exe";
            model.softwareExists(path);

            if (model.softwareExists(path))
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



        private void clientLabel_Click(object sender, EventArgs e)
        {

        }
        private void versionLabel_Click(object sender, EventArgs e)
        {

        }
        private void languageLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
