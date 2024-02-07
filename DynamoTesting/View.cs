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
        ViewModel viewModel;

        public repconLauncher()
        {
            InitializeComponent();
            viewModel = new ViewModel(model);

            string[] installedCivil3D = (string[])model.GetCivil3DInstallations(model.yearToRNumber, model.languageToRegion);

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
            model.GetCivil3DInstallations(model.yearToRNumber, model.languageToRegion);
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


        private void BuildClientOptionsTable()
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnCount = 2;

            string selectedClient = clientDropdownMenu.SelectedItem?.ToString();
            string selectedVersion = versionDropdownMenu.SelectedItem?.ToString();

            List<string> options = null;
            if (clientDropdownMenu.SelectedItem != null)
            {
                options = viewModel.BuildOptionsBasedOnClient(selectedClient);
            }
            else if (versionDropdownMenu.SelectedItem != null)
            {
                options = viewModel.BuildOptionsBasedOnVersion(selectedVersion);
            }

            foreach (var option in options)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                radioButton.Tag = option; // Assign option text to Tag property

                Label label = new Label();
                label.Text = option;

                tableLayoutPanel.Controls.Add(radioButton);
                tableLayoutPanel.Controls.Add(label);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                int row = tableLayoutPanel.GetRow(radioButton);
                if (row >=0)
                {
                    launchButton.Enabled = true;
                    string selectedOption = ((Label)tableLayoutPanel.GetControlFromPosition(1, tableLayoutPanel.GetCellPosition(radioButton).Row)).Text;
                    MessageBox.Show("Selected option: " + selectedOption);
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

            //UpdateLaunchButtonState();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            string client = clientDropdownMenu.SelectedItem.ToString();
            string version = versionDropdownMenu.SelectedItem.ToString();
            string language = "English";

            viewModel.HandleLaunchButtonClick(client, version, language);
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

            string pathToShortcut = model.BuildShortcut(client, language, version);
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
