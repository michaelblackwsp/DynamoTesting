using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        Model model = new Model();
        ViewModel viewModel;
        Preset preset = new Preset();

        private string pathToShortcut = null;
        private List<(string year, string language)> installedVersionsOfCivil3D = null;

        private List<Button> presetButtons = new List<Button>();
        private int buttonIndex = 0;


        public repconLauncher()
        {
            InitializeComponent();
            viewModel = new ViewModel(model);

            string[] installedCivil3D = (string[])model.GetCivil3DMetricProfiles(model.yearToRNumber, model.languageToRegion);

            launchButton.Enabled = false;
            saveButton.Enabled = false;

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

            nameTextBox.Visible = false;
            nameTextBox.Enter += preferenceNameTextBox_Enter;
            nameTextBox.Leave += preferenceNameTextBox_Leave;
            nameTextBox.Text = "Enter name";
            nameTextBox.ForeColor = SystemColors.GrayText;

            okButton.Visible = false;

            favouriteButton1.Visible = false;
            favouriteButton2.Visible = false;
            favouriteButton3.Visible = false;
            favouriteButton4.Visible = false;
            favouriteButton5.Visible = false;
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
                saveButton.Enabled = true;
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
            saveButton.Enabled = false;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (buttonIndex >= 5)
            {
                MessageBox.Show("You can only save up to 5 client environments. \n\nPurchase more Saves through the Digital Operations app store.");
                return;
            }

            nameTextBox.Visible = true;
            okButton.Visible = true;
        }


        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void preferenceNameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Enter name")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black; // Change text color to black
            }
        }

        private void preferenceNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Enter name";
                nameTextBox.ForeColor = Color.Gray; // Change text color to gray
            }
        }

        private void launcherTab_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            string buttonText = nameTextBox.Text;
            // TO DO: MAKE THE BUTTON COLOURED ACCORDING TO THE SOFTWARE

            // Update the button at the current index
            switch (buttonIndex)
            {
                case 0:
                    favouriteButton1.Text = buttonText;
                    favouriteButton1.Visible = true;
                    break;
                case 1:
                    favouriteButton2.Text = buttonText;
                    favouriteButton2.Visible = true;
                    break;
                case 2:
                    favouriteButton3.Text = buttonText;
                    favouriteButton3.Visible = true;
                    break;
                case 3:
                    favouriteButton4.Text = buttonText;
                    favouriteButton4.Visible = true;
                    break;
                case 4:
                    favouriteButton5.Text = buttonText;
                    favouriteButton5.Visible = true;
                    break;
                default:
                    // This case should not occur if the limit is properly enforced, but handle it just in case
                    MessageBox.Show("Invalid button index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Increment the buttonIndex
            buttonIndex++;

            // Hide the text box and OK button
            nameTextBox.Visible = false;
            okButton.Visible = false;

            // Make sure to keep previously added buttons visible
            for (int i = 0; i < buttonIndex; i++)
            {
                switch (i)
                {
                    case 0:
                        favouriteButton1.Visible = true;
                        break;
                    case 1:
                        favouriteButton2.Visible = true;
                        break;
                    case 2:
                        favouriteButton3.Visible = true;
                        break;
                    case 3:
                        favouriteButton4.Visible = true;
                        break;
                    case 4:
                        favouriteButton5.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            //LAUNCH THE SOFTWARE USING THE SAVED PATH FROM THE RADIO BUTTON
        }

        private void favouriteButton1_Click(object sender, EventArgs e)
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
