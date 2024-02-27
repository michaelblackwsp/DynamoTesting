using Button = System.Windows.Forms.Button;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        Model model = new Model();
        ViewModel viewModel;

        private string builtShortcutPath = null;
        private List<(string year, string language)> installedVersionsOfCivil3D = null;

        // TO DO: put this in the class in the Model
        private List<FavouriteButton> favouriteButtons = new List<FavouriteButton>();
        private int buttonCount = 0;

        string favouriteButtonToolTip = null;

        // FIX ME: There has to be a better way to do this than to constantly change a global variable...
        bool useGreyText = false;

        private ContextMenuStrip rightClickMenu;

        public repconLauncher()
        {
            InitializeComponent();
            InitializeRightClickMenu();
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
            cancelButton.Visible = false;

        }

        private void repconLauncher_Load(object sender, EventArgs e)
        {
            model.GetWindowsLanguage();
            model.GetCivil3DMetricProfiles(model.yearToRNumber, model.languageToRegion);
            model.GetCivil3DInstallations();
            installedVersionsOfCivil3D = model.GetCivil3DInstallations();
            AddColumnHeaders();
            usernameLabel.Text = Environment.UserName;
            languageLabel.Text = model.GetWindowsLanguage();
        }

        private void InitializeRightClickMenu()
        {

            rightClickMenu = new ContextMenuStrip(); // Create the context menu
            
            ToolStripMenuItem renameMenuItem = new ToolStripMenuItem("Rename"); // Create menu items
            renameMenuItem.Click += RenameMenuItem_Click;
            rightClickMenu.Items.Add(renameMenuItem);

            ToolStripMenuItem updateMenuItem = new ToolStripMenuItem("Update");
            updateMenuItem.Click += UpdateMenuItem_Click;
            rightClickMenu.Items.Add(updateMenuItem);

            ToolStripMenuItem removeMenuItem = new ToolStripMenuItem("Remove");
            removeMenuItem.Click += RemoveMenuItem_Click;
            rightClickMenu.Items.Add(removeMenuItem);
        }


        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rename clicked");
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update clicked");
        }

        private void RemoveMenuItem_Click(object sender, EventArgs e)
        {
            
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender; // Get the MenuItem that triggered the event
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner; // Get the ContextMenuStrip that contains the MenuItem

            Button buttonToRemove = (Button)contextMenu.SourceControl; // Get the Button associated with the ContextMenuStrip
            FavouriteButton favouriteButtonToRemove = (FavouriteButton)buttonToRemove.Tag; // Get the FavouriteButton object corresponding to the button

            int indexToRemove = favouriteButtons.FindIndex(button => button == favouriteButtonToRemove);
            
            // Remove the button from the list
            if (indexToRemove != -1)
            {
                favouriteButtons.RemoveAt(indexToRemove);
            }
            buttonCount--;
            RedrawButtons();
        }




        private void okButton_Click(object sender, EventArgs e)
        {
            createFavouriteButton(nameTextBox.Text, builtShortcutPath, favouriteButtonToolTip);

            nameTextBox.Clear();
            nameTextBox.Visible = false;
            okButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void createFavouriteButton(string name, string shortcutPath, string tooltip)
        {
            FavouriteButton favouriteButton = new FavouriteButton(name, shortcutPath, tooltip);
            favouriteButtons.Add(favouriteButton);
            buttonCount++;

            RedrawButtons();
        }

        private void RedrawButtons()
        {
            // !!!!! THIS FIXED IT !!!!!! Create a copy of the controls collection to avoid modifying it while iterating
            var controlsCopy = new List<Control>(launcherTab.Controls.OfType<Button>());

            // Clear only the buttons that are of type FavouriteButton
            foreach (var control in controlsCopy)
            {
                if (control.Tag is FavouriteButton)
                {
                    launcherTab.Controls.Remove(control);
                    control.Dispose(); // Dispose the button to release resources
                }
            }

            int topPosition = 160;

            foreach (var favouriteButton in favouriteButtons)
            {
                Button button = new Button();
                button.Font = new Font("Segoe UI", 7, FontStyle.Regular);
                button.Text = favouriteButton.Name;
                button.Tag = favouriteButton; // Store the FavouriteButton instance in the Tag property
                button.Click += FavouriteButton_Click;
                button.ContextMenuStrip = rightClickMenu;

                // Create and configure the tooltip for the button
                ToolTip toolTip = new ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 500;
                toolTip.ReshowDelay = 200;
                toolTip.ShowAlways = true;
                toolTip.SetToolTip(button, favouriteButton.Tooltip);

                // Set the button's position
                button.Top = topPosition;
                button.Left = 280;
                button.Visible = true;

                // Increment the vertical position for the next button
                topPosition += button.Height + 5;

                // Add the button to the launcherTab
                launcherTab.Controls.Add(button);
            }
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
            saveButton.Enabled = false;
            UpdateTableData();
        }

        private void versionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientDropdownMenu.Enabled = false;
            launchButton.Enabled = false;
            saveButton.Enabled = false;
            UpdateTableData();
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

            AddColumnHeaders();
        }

        private void AddColumnHeaders()
        {
            tableLayoutPanel.ColumnStyles[0].Width = 40;
            tableLayoutPanel.ColumnStyles[1].Width = 40;
            tableLayoutPanel.ColumnStyles[2].Width = 40;
            tableLayoutPanel.ColumnStyles[3].Width = 40;

            // Add column headers
            CreateColumnHeader("Client", 0);
            CreateColumnHeader("Version", 1);
            CreateColumnHeader("EN", 2);
            CreateColumnHeader("FR", 3);
        }

        private void CreateColumnHeader(string text, int columnIndex)
        {
            Label headerLabel = new Label();
            headerLabel.Text = text;
            headerLabel.ForeColor = Color.Gray;
            headerLabel.TextAlign = ContentAlignment.MiddleCenter; // Center the text
            tableLayoutPanel.Controls.Add(headerLabel, columnIndex, 0); // Add header label to the first row
        }


        private void UpdateTableData()
        {
            useGreyText = true;

            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.ColumnCount = 4;

            tableLayoutPanel.ColumnStyles[0].Width = 40;
            tableLayoutPanel.ColumnStyles[1].Width = 40;
            tableLayoutPanel.ColumnStyles[2].Width = 40;
            tableLayoutPanel.ColumnStyles[3].Width = 40;

            List<TableRowData> options = null;

            // FIXME: Only make the Client and Version black if there is an option for the User to launch
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
                int rowIndex = 1;
                foreach (var option in options)
                {

                    if (option.EnglishOffered)
                    {
                        CreateAndAddRadioButton(2, rowIndex, option.Client, option.Version, "English");
                    }
                    else
                    {
                        CreateAndAddlightGrayLabel("--", 2, rowIndex);
                    }

                    if (option.FrenchOffered)
                    {
                        CreateAndAddRadioButton(3, rowIndex, option.Client, option.Version, "French");
                    }
                    else
                    {
                        CreateAndAddlightGrayLabel("--", 3, rowIndex);
                    }

                    if(useGreyText == true)
                    {
                        CreateAndAddGrayLabel(option.Client, 0, rowIndex);
                        CreateAndAddGrayLabel(option.Version, 1, rowIndex);
                    }
                    else
                    {
                        CreateAndAddBlackLabel(option.Client, 0, rowIndex);
                        CreateAndAddBlackLabel(option.Version, 1, rowIndex);
                    }



                    rowIndex++;
                }
            }

            AddColumnHeaders(); // TO DO: This really shouldn't come at the end
        }

        private void CreateAndAddRadioButton(int column, int row, string client, string version, string language)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Tag = new Tuple<string, string, string>(client, version, language);
            radioButton.Enabled = installedVersionsOfCivil3D.Contains((version, language));
            radioButton.CheckedChanged += RadioButton_CheckedChanged;
            radioButton.Margin = new Padding(13, 1, 0, 0);
            tableLayoutPanel.Controls.Add(radioButton, column, row);

            if (radioButton.Enabled)
            {
                useGreyText = false;
            }
        }

        private void CreateAndAddlightGrayLabel(string text, int column, int row)
        {
            Label label = new Label();
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.LightGray;
            tableLayoutPanel.Controls.Add(label, column, row);
        }

        private void CreateAndAddGrayLabel(string text, int column, int row)
        {
            Label label = new Label();
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.Gray;
            tableLayoutPanel.Controls.Add(label, column, row);
        }

        private void CreateAndAddBlackLabel(string text, int column, int row)
        {
            Label label = new Label();
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel.Controls.Add(label, column, row);
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

                builtShortcutPath = model.BuildShortcut(client, version, language);
                favouriteButtonToolTip = client + " (" + version  +" " + language + ")";

                launchButton.Enabled = true;
                saveButton.Enabled = true;
            }
        }


        private void launchButton_Click(object sender, EventArgs e)
        {
            model.StartSoftware(builtShortcutPath);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (buttonCount >= 6)
            {
                MessageBox.Show("You can only save up to 6 client environments.");
                return;
            }

            nameTextBox.Visible = true;
            okButton.Visible = true;
            cancelButton.Visible = true;
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


        private void FavouriteButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                FavouriteButton favorite = clickedButton.Tag as FavouriteButton;
                if (favorite != null)
                {
                    string shortcutPath = favorite.ShortcutPath;
                    model.StartSoftware(shortcutPath);
                }
            }
        }

        // TO DO: Get rid of _1 in name
        private void tableLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
            tableLayoutPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel, true, null);

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
        private void launcherTab_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Visible = false;
            okButton.Visible = false;
            cancelButton.Visible = false;
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
