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

            // (string[]) because the method returns and array? Redefining the output it could already know about?
            string[] installedCivil3D = (string[])model.getCivil3DInstallations(model.yearToRNumber, model.languageToRegion);
            PopulateDataGridView(installedCivil3D);

            launchButton.Enabled = false;

            clientDropdownMenu.Items.AddRange(Model.clientOptions);
            string[] clientOptions = Model.clientOptions;
            clientDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            clientDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
            clientDropdownMenu.DrawItem += clientDropdownMenu_DrawItem;
            clientDropdownMenu.SelectedIndexChanged += clientDropdownMenu_SelectedIndexChanged;

            versionDropdownMenu.Items.AddRange(Model.versionOptions);
            string[] versionOptions = Model.versionOptions;
            versionDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            versionDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
            versionDropdownMenu.DrawItem += versionDropdownMenu_DrawItem;
            versionDropdownMenu.SelectedIndexChanged += versionDropdownMenu_SelectedIndexChanged;
        }

        private void repconLauncher_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("The form is loading!");
            Model model = new Model();
            model.getCivil3DInstallations(model.yearToRNumber, model.languageToRegion);
        }



        private void clientDropdownMenu_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                string option = clientDropdownMenu.Items[e.Index].ToString();
                e.DrawBackground();
                TextRenderer.DrawText(e.Graphics, option, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left);
            }
        }

        private void versionDropdownMenu_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                string option = versionDropdownMenu.Items[e.Index].ToString();
                e.DrawBackground();
                TextRenderer.DrawText(e.Graphics, option, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left);
            }
        }



        private void clientDropdownMenu_Selected(object sender, EventArgs e)
        {

        }

        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {

        }



        private void clientDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           toggleVersions();
           
        }

        private void versionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           toggleClients();
           
        }



        private bool isUpdatingDropdowns = false;
        private bool initialSelectionMade = false;
        private bool bothDropdownsSelected = false;

        private void toggleVersions()
        {
            string selected = clientDropdownMenu.SelectedItem?.ToString();

            if (!isUpdatingDropdowns)
            {
                isUpdatingDropdowns = true;

                if (selected != null)
                {
                    string[] filteredVersions = model.versionBasedOnClient[selected];
                    versionDropdownMenu.Items.Clear();
                    versionDropdownMenu.Items.AddRange(filteredVersions);
                    versionDropdownMenu.SelectedIndex = 0;

                    initialSelectionMade = true; // Set the flag after the initial selection
                }

                isUpdatingDropdowns = false;
                UpdateLaunchButtonState();
            }
        }

        private void toggleClients()
        {
            string selected = versionDropdownMenu.SelectedItem?.ToString();

            if (!isUpdatingDropdowns && initialSelectionMade && !bothDropdownsSelected)
            {
                isUpdatingDropdowns = true;

                if (selected != null)
                {
                    string[] filteredClients = model.clientBasedOnVersion[selected];
                    clientDropdownMenu.Items.Clear();
                    clientDropdownMenu.Items.AddRange(filteredClients);
                    clientDropdownMenu.SelectedIndex = 0;

                    bothDropdownsSelected = true; // Set the flag when both dropdowns have been selected
                }

                isUpdatingDropdowns = false;
                UpdateLaunchButtonState();
            }
        }

        private void UpdateLaunchButtonState()
        {
            string[] installedCivil3D = (string[])model.getCivil3DInstallations(model.yearToRNumber, model.languageToRegion);

            if (clientDropdownMenu.Items.Count > 0
                && versionDropdownMenu.Items.Count > 0
                && clientDropdownMenu.SelectedIndex != -1
                && versionDropdownMenu.SelectedIndex != -1)
            {

                string version = versionDropdownMenu.SelectedItem.ToString();
                string language = "English"; // TO DO: Add logic for allowable languages based on client/version

                string path = model.BuildRegistryPath(version, language, model.yearToRNumber, model.languageToRegion);

                if (model.stringExists(path, installedCivil3D))
                {
                    launchButton.Enabled = true;
                    MessageBox.Show(path);
                }
            }
            else
            {
                launchButton.Enabled = false;
            }
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            clientDropdownMenu.Items.Clear();
            clientDropdownMenu.Items.AddRange(Model.clientOptions.ToArray());
            versionDropdownMenu.Items.Clear();
            versionDropdownMenu.Items.AddRange(Model.versionOptions.ToArray());
            UpdateLaunchButtonState();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();

            // ************** THIS NEEDS TO BE LANGUAGE AVAILABLE BASED ON THE MATRIX
            string pathToShortcut = model.buildShortcut(client, "English", version);

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



        private void PopulateDataGridView(string[] paths)
        {
            dataGridView1.ColumnCount = 1; // One column for the paths
            dataGridView1.Columns[0].Name = "Civil 3D Version";
            dataGridView1.Columns[0].Width = 150;

            foreach (string path in paths)
            {
                dataGridView1.Rows.Add(path);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







        private void clientLabel_Click(object sender, EventArgs e)
        {

        }

        private void versionLabel_Click(object sender, EventArgs e)
        {

        }



        private void pathLabel_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();

            // ************** THIS NEEDS TO BE LANGUAGE AVAILABLE BASED ON THE MATRIX
            string language = "English";
            string version = versionDropdownMenu.SelectedItem.ToString();

            string pathToShortcut = model.buildShortcut(client, language, version);
            pathLabel.Text = pathToShortcut;
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            usernameLabel.Text = Environment.UserName;
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
    }
}
