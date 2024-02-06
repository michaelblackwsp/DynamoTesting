using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

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
            //PopulateDataGridView(installedCivil3D);

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
            versionDropdownMenu.Enabled = false;
            BuildClientOptionsTable();
        }

        private void versionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientDropdownMenu.Enabled = false;
            BuildClientOptionsTable();
        }


        private List<string> buildOptions_basedOnClient()
        {
            string selectedClient = clientDropdownMenu.SelectedItem?.ToString();
            List<string> options_basedOnClient = new List<string>();

            if (selectedClient != null)
            {
                string[] versions = model.versionBasedOnClient[selectedClient];
                foreach (string version in versions) 
                {
                    string displayOption = selectedClient + " (" + version + ")";
                    options_basedOnClient.Add(displayOption);
                }

            }
            //UpdateLaunchButtonState();
            return options_basedOnClient;
        }

        private List<string> buildOptions_basedOnVersion()
        {
            string selectedVersion = versionDropdownMenu.SelectedItem?.ToString();
            List<string> options_basedOnVersion = new List<string>();

            if (selectedVersion != null)
            {
                string[] clients = model.clientBasedOnVersion[selectedVersion];
                foreach (string client in clients)
                {
                    string displayOption = client + " (" + selectedVersion + ")";
                    options_basedOnVersion.Add(displayOption);
                }

            }
            //UpdateLaunchButtonState();
            return options_basedOnVersion;
        }

        private void BuildClientOptionsTable()
        {
            // Clear any existing controls in the TableLayoutPanel
            tableLayoutPanel.Controls.Clear();

            // Set the column count
            tableLayoutPanel.ColumnCount = 2;

            List<string> options =
                clientDropdownMenu.SelectedItem != null ? buildOptions_basedOnClient() :
                versionDropdownMenu.SelectedItem != null ? buildOptions_basedOnVersion() : 
                new List<string>();


            // Add rows dynamically
            foreach (var option in options)
            {
                // Create radio button
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;

                // Create label for option
                Label label = new Label();
                label.Text = option;

                // Add controls to the table layout panel
                tableLayoutPanel.Controls.Add(radioButton);
                tableLayoutPanel.Controls.Add(label);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                // Do something when a radio button is checked
                // For example, you can get the option text
                string selectedOption = ((Label)tableLayoutPanel.GetControlFromPosition(1, tableLayoutPanel.GetCellPosition(radioButton).Row)).Text;
                MessageBox.Show("Selected option: " + selectedOption);
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
                string client = clientDropdownMenu.SelectedItem.ToString();
                List<string> languages = model.GetLanguagesForSelectedClient(client);

                bool englishAndFrench = languages.Contains("English") && languages.Contains("French");
                bool onlyEnglish = languages.Contains("English");
                bool onlyFrench = languages.Contains("French");

                if (onlyEnglish)
                {
                    string language = "English";
                    string path = model.BuildRegistryPath(version, language, model.yearToRNumber, model.languageToRegion);

                    if (model.stringExists(path, installedCivil3D))
                    {
                        launchButton.Enabled = true;
                        MessageBox.Show(client + " " + version + " can be loaded with Civil 3D " + version + " " + language);
                        //break;
                    }

                    else
                    {
                        launchButton.Enabled = false; MessageBox.Show(client + " " + version + " cannot be loaded. Civil 3D " + version + " " + language + " is not installed.\n\n" + "Please install Civil 3D " + version + " " + language + " from the Software Centre, or contact Digital Operations for more information.");
                    }
                } 

                if (onlyFrench)
                {
                    string language = "French";
                    string path = model.BuildRegistryPath(version, language, model.yearToRNumber, model.languageToRegion);

                    if (model.stringExists(path, installedCivil3D))
                    {
                        launchButton.Enabled = true;
                        MessageBox.Show(client + " " + version + " can be loaded with Civil 3D " + version + " " + language);
                        //break;
                    }

                    else
                    {
                        launchButton.Enabled = false; MessageBox.Show(client + " " + version + " cannot be loaded. Civil 3D " + version + " " + language + " is not installed.\n\n" + "Please install Civil 3D " + version + " " + language + " from the Software Centre, or contact Digital Operations for more information.");
                    }
                }

                if (englishAndFrench)
                {
                    foreach (string language in languages)
                    {
                        string path = model.BuildRegistryPath(version, language, model.yearToRNumber, model.languageToRegion);

                        if (model.stringExists(path, installedCivil3D))
                        {
                            launchButton.Enabled = true;
                            MessageBox.Show(client + " " + version + " can be loaded with Civil 3D " + version + " " + language);
                            break;
                        }

                        else
                        {
                            launchButton.Enabled = false; MessageBox.Show(client + " " + version + " cannot be loaded. Civil 3D " + version + " " + language + " is not installed.\n\n" + "Please install Civil 3D " + version + " " + language + " from the Software Centre, or contact Digital Operations for more information.");
                        }
                    }
                }

            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.Clear();

            clientDropdownMenu.Enabled = true;
            clientDropdownMenu.Items.Clear();
            clientDropdownMenu.Items.AddRange(Model.clientOptions.ToArray());

            versionDropdownMenu.Enabled = true;
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



/*        private void PopulateDataGridView(string[] paths)
        {
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.RowCount = 7;

            dataGridView1.Columns[0].Name = "Client Environment";
            dataGridView1.Columns[0].Width = 163;



            *//* dataGridView1.ColumnCount = 1; // One column for the paths
             dataGridView1.Columns[0].Name = "Civil 3D Version";
             dataGridView1.Columns[0].Width = 150;*/




            /*            foreach (string path in paths)
                        {
                            dataGridView1.Rows.Add(path);
                        }*//*
        }*/

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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
