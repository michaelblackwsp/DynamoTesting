using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        Model model = new Model();
        ViewModel viewModel;

        private string pathToShortcut = null;
        private List<(string year, string language)> installedVersionsOfCivil3D = null;

        public repconLauncher()
        {
            InitializeComponent();
            viewModel = new ViewModel(model);

            string[] installedCivil3D = (string[])model.GetCivil3DMetricProfiles(model.yearToRNumber, model.languageToRegion);

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
            model.GetCivil3DMetricProfiles(model.yearToRNumber, model.languageToRegion);
            model.GetCivil3DInstallations();
            installedVersionsOfCivil3D = model.GetCivil3DInstallations();
            usernameLabel.Text = Environment.UserName;
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
            launchButton.Enabled = false;
            BuildClientOptionsTable();
        }

        private void versionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientDropdownMenu.Enabled = false;
            launchButton.Enabled= false;
            BuildClientOptionsTable();
        }


        private void BuildClientOptionsTable()
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnCount = 4;

            tableLayoutPanel.ColumnStyles[0].Width = 40;
            tableLayoutPanel.ColumnStyles[1].Width = 40;
            tableLayoutPanel.ColumnStyles[2].Width = 40;
            tableLayoutPanel.ColumnStyles[3].Width = 40;

            List<TableRowData> options = null;

            if (clientDropdownMenu.SelectedItem != null)
            {
                string selectedClient = clientDropdownMenu.SelectedItem?.ToString();
                options = viewModel.OptionsBasedOnClient(selectedClient);
            }
            else if (versionDropdownMenu.SelectedItem != null)
            {
                string selectedVersion = versionDropdownMenu.SelectedItem?.ToString();
                options = viewModel.OptionsBasedOnVersion(selectedVersion);
            }

            if (options != null)
            {
                int rowIndex = 0;
                foreach (var option in options)
                {
                    Label clientLabel = new Label();
                    clientLabel.Text = option.Client;
                    tableLayoutPanel.Controls.Add(clientLabel, 0, rowIndex);

                    Label versionLabel = new Label();
                    versionLabel.Text = option.Version;
                    tableLayoutPanel.Controls.Add(versionLabel, 1, rowIndex);

                    // Change here to use language instead of client
                    if (option.EnglishOffered)
                    {
                        RadioButton englishRadioButton = new RadioButton();
                        englishRadioButton.Tag = new Tuple<string, string, string>(option.Client, option.Version, "English");
                        tableLayoutPanel.Controls.Add(englishRadioButton, 2, rowIndex);
                        englishRadioButton.Enabled = installedVersionsOfCivil3D.Contains((option.Version, "English")); // Enable/disable based on existence in the extracted list
                        englishRadioButton.CheckedChanged += RadioButton_CheckedChanged;
                    }
                    else
                    {
                        Label englishOfferedLabel = new Label();
                        englishOfferedLabel.Text = "-";
                        tableLayoutPanel.Controls.Add(englishOfferedLabel, 2, rowIndex);
                    }

                    // Change here to use language instead of client
                    if (option.FrenchOffered)
                    {
                        RadioButton frenchRadioButton = new RadioButton();
                        frenchRadioButton.Tag = new Tuple<string, string, string>(option.Client, option.Version, "French");
                        tableLayoutPanel.Controls.Add(frenchRadioButton, 3, rowIndex);
                        frenchRadioButton.Enabled = installedVersionsOfCivil3D.Contains((option.Version, "French")); // Enable/disable based on existence in the extracted list
                        frenchRadioButton.CheckedChanged += RadioButton_CheckedChanged;
                    }
                    else
                    {
                        Label frenchOfferedLabel = new Label();
                        frenchOfferedLabel.Text = "-";
                        tableLayoutPanel.Controls.Add(frenchOfferedLabel, 3, rowIndex);
                    }

                    rowIndex++;
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                var tagTuple = radioButton.Tag as Tuple<string, string, string>;
                string client = tagTuple.Item1;
                string version = tagTuple.Item2;
                string language = tagTuple.Item3;

                pathToShortcut = model.BuildShortcut(client, version, language);

                launchButton.Enabled = true;
            }
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            model.StartSoftware(pathToShortcut);
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

            launchButton.Enabled = false;
        }



        private void clientLabel_Click(object sender, EventArgs e)
        {

        }
        private void versionLabel_Click(object sender, EventArgs e)
        {

        }


        private void usernameLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
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
