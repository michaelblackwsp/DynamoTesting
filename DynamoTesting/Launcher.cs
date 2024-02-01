using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        Model model = new Model();
        
        public repconLauncher()
        {
            InitializeComponent();

            // TO DO: Why do I need the (string[]) in front, when in the model file I don't?
            string[] civil3DInstallations = (string[])model.checkCivil3DInstallations(model.yearToRNumberMap, model.languageToRegionMap);
            PopulateDataGridView(civil3DInstallations);

            clientDropdownMenu.Items.AddRange(Model.clientOptions);
            languageDropdownMenu.Items.AddRange(Model.languageOptions);
            versionDropdownMenu.Items.AddRange(Model.versionOptions);

            // QUESTION: Why can this come after AddRange? The order doesn't matter
            string[] versionOptions = Model.versionOptions;
            versionDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;         // Set drawing mode to Manual, each item at a time
            versionDropdownMenu.DrawItem += VersionDropdownMenu_DrawItem;   // Call this Method to handle the colour coding

            versionDropdownMenu.Enabled = false;
            clientDropdownMenu.SelectedIndexChanged += ClientDropdownMenu_SelectedIndexChanged;
            languageDropdownMenu.SelectedIndexChanged += LanguageDropdownMenu_SelectedIndexChanged;
            versionDropdownMenu.SelectedIndexChanged += VersionDropdownMenu_SelectedIndexChanged;

            launchButton.Enabled = false;

            clientDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            languageDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            // BUG: the style of the Version dropdown isn't applied because it is overruled by the disabling logic
            versionDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void repconLauncher_Load(object sender, EventArgs e)
        {
            // TO DO(?): Move logic above into the Load method?
            MessageBox.Show("The form is loading!");
            Model model = new Model();
            model.checkCivil3DInstallations(model.yearToRNumberMap, model.languageToRegionMap);
        }

        private void ClientDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientDropdownMenu.SelectedIndex != -1 && languageDropdownMenu.SelectedIndex != -1)
            {
                versionDropdownMenu.Enabled = true;
            } 
            else
            {
                versionDropdownMenu.Enabled = false;
            }
            UpdateLaunchButtonState();
        }

        private void LanguageDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientDropdownMenu.SelectedIndex != -1 && languageDropdownMenu.SelectedIndex != -1)
            {
                versionDropdownMenu.Enabled = true;
            }
            else
            {
                versionDropdownMenu.Enabled = false;
            }
            UpdateLaunchButtonState();
        }

        private void VersionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TO DO: Add in hover over tooltip "Please select a Client and Language first."
            UpdateLaunchButtonState();
        }

        private void UpdateLaunchButtonState()
        {
            if (clientDropdownMenu.SelectedIndex != -1 &&
                languageDropdownMenu.SelectedIndex != -1 &&
                versionDropdownMenu.SelectedIndex != -1)
            {
                launchButton.Enabled = true;
            }
            else
            {
                launchButton.Enabled = false;
            }
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

        //TO DO: Recycle this to be a generic method that checks for good/bad and assigns colour accordingly
/*        public Color setVersionColour(string choice)
        {
            Model model = new Model();
            string path = "";
            string language = languageDropdownMenu.Text;

            if (model.yearToRNumberMap.ContainsKey(choice))
            {
                Tuple<string, string> values = model.yearToRNumberMap[choice];
                string rNumber = values.Item1;
                string productId = values.Item2;
                string regionValue = model.languageToRegionMap[language];

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
            // TO DO(?): Change to greyed out and not selectable, or put (NOT AVAILABLE) next to it?
            // TO DO: After making the selection, tab out so the field is visible
        }*/


        private void clientDropdownMenu_Selected(object sender, EventArgs e)
        {
            
        }
        private void languageDropdownMenu_Selected(object sender, EventArgs e)
        {

        }
        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {

        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.buildShortcut(client, language, version);

            if (System.IO.File.Exists(pathToShortcut))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = pathToShortcut,
                    UseShellExecute = true  // Set this to true to use the default shell verb (open) for shortcuts
                };
                try
                {
                    Process.Start(processStartInfo);    // Start the process
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
            // BUG: handle when one or all choices is still empty
            string client = clientDropdownMenu.SelectedItem.ToString();
            string language = languageDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.buildShortcut(client, language, version);
            pathLabel.Text = pathToShortcut;
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

        private void myCivil3D_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateDataGridView(string[] paths)
        {
            dataGridView1.ColumnCount = 3; // One column for the paths
            dataGridView1.Columns[0].Name = "Civil 3D Version";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Name = "Language";
            dataGridView1.Columns[1].Width = 50;

            foreach (string path in paths)
            {
                dataGridView1.Rows.Add(path);
            }
        }

    }
}
