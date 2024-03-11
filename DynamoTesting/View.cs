using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Reflection;
using Button = System.Windows.Forms.Button;
using ToolTip = System.Windows.Forms.ToolTip;

namespace DynamoTesting
{
    public partial class repconLauncher : Form
    {
        #region Initialization
        civil3dModel civil3dModel = new civil3dModel();
        openRoadsModel openRoadsModel = new openRoadsModel();
        private ViewModel viewModel;

        Utilities utilities = new Utilities();

        private string builtShortcutPath = "";
        string favouriteButtonToolTip = ""; // FIX ME: Why is this needed when it's part of the class?
        bool useGreyText = false;

        private ContextMenuStrip rightClickMenu;

        public repconLauncher()
        {
            InitializeComponent();
            InitializeRightClickMenu();
            EnableDoubleBuffering(tableLayoutPanel);

            viewModel = new ViewModel(civil3dModel, openRoadsModel);

            //string[] installedCivil3D = (string[])civil3dModel.GetCivil3DMetricProfiles(civil3dModel.yearToRNumber, civil3dModel.languageToRegion);

            launchButton.Enabled = false;
            saveButton.Enabled = false;

            nameTextBox.Enabled = false;
            cancelButton.Enabled = false;

            clientDropdownMenu.Enabled = false;
            versionDropdownMenu.Enabled = false;
            resetButton.Enabled = false;

        }

        private void EnableDoubleBuffering(Control control)
        {
            Type type = control.GetType();
            PropertyInfo propertyInfo = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propertyInfo?.SetValue(control, true, null);
        }

        // TO DO: ADD DEFAULT (METRIC / IMPERIAL) VERSIONS OF SOFTWARE

        private void repconLauncher_Load(object sender, EventArgs e)
        {
            tableLayoutPanel.Visible = false;
            utilities.GetWindowsVersionAndLanguage();
            //civil3dModel.GetCivil3DMetricProfiles(civil3dModel.yearToRNumber, civil3dModel.languageToRegion);
            civil3dModel.installedVersionsOfCivil3D = civil3dModel.GetCivil3DInstallations(); // INVESTIGATE THIS

            openRoadsModel.GetOpenRoadsInstallations();


            usernameLabel.Text = Environment.UserName;
            languageLabel.Text = utilities.GetWindowsVersionAndLanguage();
            viewModel.ReadFromFavouriteButtonsJson();
            DrawButtons();

            nameTextBox.Text = "Enter name to save";
            nameTextBox.Enter += nameTextBox_Enter;
            nameTextBox.Leave += nameTextBox_Leave;
            nameTextBox.ForeColor = SystemColors.GrayText;

            string userEmail = ActiveDirectoryHelper.GetUserEmail(Environment.UserName);
            if (userEmail != null && userEmail.EndsWith("@wsp.com"))
            {
                //MessageBox.Show(userEmail); //Add @a49 email?
            }
            else
            {
                MessageBox.Show("Unauthorized to use. WSP email not recognized. \n\nPlease contact Digital Operations. Application will now close.");
                Application.Exit();
            }

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
        #endregion


        #region Draw and Handle Dropdown Menu Events
        private void softwareComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.PerformClick(); // Reset the form so it doesn't try to draw the OpenRoads table based on old Civil 3D selection
            UpdateTableData();

            string selectedSoftware = softwareComboBox.SelectedItem.ToString();

            clientDropdownMenu.Enabled = true;
            versionDropdownMenu.Enabled = true;

            clientDropdownMenu.Items.Clear();
            versionDropdownMenu.Items.Clear();

            if (selectedSoftware == "OpenRoads Designer")
            {
                clientDropdownMenu.Items.AddRange(openRoadsModel.clientOptions);
                string[] clientOptions = openRoadsModel.clientOptions;
                clientDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
                clientDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
                clientDropdownMenu.DrawItem += clientDropdownMenu_DrawItem;
                clientDropdownMenu.SelectedIndexChanged += clientDropdownMenu_SelectedIndexChanged;

                versionDropdownMenu.Items.AddRange(openRoadsModel.versionOptions);
                string[] versionOptions = openRoadsModel.versionOptions;
                versionDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
                versionDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
                versionDropdownMenu.DrawItem += versionDropdownMenu_DrawItem;
                versionDropdownMenu.SelectedIndexChanged += versionDropdownMenu_SelectedIndexChanged;
            }
            else if (selectedSoftware == "Civil 3D")
            {
                clientDropdownMenu.Items.AddRange(civil3dModel.clientOptions);
                string[] clientOptions = civil3dModel.clientOptions;
                clientDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
                clientDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
                clientDropdownMenu.DrawItem += clientDropdownMenu_DrawItem;
                clientDropdownMenu.SelectedIndexChanged += clientDropdownMenu_SelectedIndexChanged;

                versionDropdownMenu.Items.AddRange(civil3dModel.versionOptions);
                string[] versionOptions = civil3dModel.versionOptions;
                versionDropdownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
                versionDropdownMenu.DrawMode = DrawMode.OwnerDrawFixed;
                versionDropdownMenu.DrawItem += versionDropdownMenu_DrawItem;
                versionDropdownMenu.SelectedIndexChanged += versionDropdownMenu_SelectedIndexChanged;
            }

        }

        private void clientDropdownMenu_DrawItem(object? sender, DrawItemEventArgs e)
            {   // REFACTOR INTO UTILITY METHOD
            if (e.Index >= 0)
                {
                    string option = clientDropdownMenu.Items[e.Index].ToString();
                    e.DrawBackground();
                    // Check if the item is selected
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    {
                        // Set the background color for selected item to default color for DropDownList
                        e.Graphics.FillRectangle(SystemBrushes.ControlLight, e.Bounds);
                    }
                    else
                    {
                        // Set the background color for unselected item to white
                        e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                    }
                    TextRenderer.DrawText(e.Graphics, option, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left);
                }
            }
        private void clientDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Enabled = true;
            versionDropdownMenu.Enabled = false;
            launchButton.Enabled = false;
            saveButton.Enabled = false;
            UpdateTableData();
        }

        private void versionDropdownMenu_DrawItem(object? sender, DrawItemEventArgs e)
        {   // REFACTOR INTO UTILITY METHOD
            if (e.Index >= 0)
            {
                string option = versionDropdownMenu.Items[e.Index].ToString();
                e.DrawBackground();
                // Check if the item is selected
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    // Set the background color for selected item to default color for DropDownList
                    e.Graphics.FillRectangle(SystemBrushes.ControlLight, e.Bounds);
                }
                else
                {
                    // Set the background color for unselected item to white
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                }
                TextRenderer.DrawText(e.Graphics, option, e.Font, e.Bounds, Color.Black, TextFormatFlags.Left);
            }
        }
        private void versionDropdownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetButton.Enabled = true;
            clientDropdownMenu.Enabled = false;
            launchButton.Enabled = false;
            saveButton.Enabled = false;
            UpdateTableData();
        }
        #endregion


        #region Form Buttons and Text Inputs
        private void resetButton_Click(object sender, EventArgs e)
        {
            tableLayoutPanel.Controls.Clear();

            clientDropdownMenu.Enabled = true;
            clientDropdownMenu.Items.Clear();

            versionDropdownMenu.Enabled = true;
            versionDropdownMenu.Items.Clear();

            string selectedSoftware = softwareComboBox.SelectedItem.ToString();

            if (selectedSoftware == "Civil 3D")
            {
                clientDropdownMenu.Items.AddRange(civil3dModel.clientOptions);
                versionDropdownMenu.Items.AddRange(civil3dModel.versionOptions);
                AddCivil3DColumnHeaders();
            }
            else if (selectedSoftware == "OpenRoads Designer")
            {
                clientDropdownMenu.Items.AddRange(openRoadsModel.clientOptions);
                versionDropdownMenu.Items.AddRange(openRoadsModel.versionOptions);
                AddOpenRoadsColumnHeaders();
            }

            resetButton.Enabled = false;

            launchButton.Enabled = false;
            saveButton.Enabled = false;

            nameTextBox.Enabled = false;
            cancelButton.Enabled = false;

        }
        private void launchButton_Click(object sender, EventArgs e)
        {
            utilities.StartSoftware(builtShortcutPath);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string software = softwareComboBox.SelectedItem.ToString();
            string iconPath = GetIconPath(software);

            // FIX ME: buttonCount is not being recognized after switching to JSON
            if (viewModel.buttonCount >= 100)
            {
                MessageBox.Show("You can only save up to 5 client environments.");
                return;
            }

            CreateFavouriteButton(nameTextBox.Text, builtShortcutPath, favouriteButtonToolTip, software, iconPath);

            nameTextBox.Clear();
            nameTextBox.Enabled = false;
            cancelButton.Enabled = false;
            saveButton.Enabled = false;
        }
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            // TO DO: Get rid of _1
            nameTextBox.Clear();
            nameTextBox.Text = "Enter name to save";
            nameTextBox.ForeColor = Color.Gray;
            cancelButton.Enabled = false;
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Enter name to save")
            {
                cancelButton.Enabled = true;
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }

            if (nameTextBox.Text != "")
            {
                saveButton.Enabled = true;
            }
        }
        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Enter name to save";
                nameTextBox.ForeColor = Color.Gray;
            }
        }
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length >= 1 && nameTextBox.Text != "Enter name to save")
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
        #endregion


        #region Client Environment Table
        private void AddCivil3DColumnHeaders()
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
        private void AddOpenRoadsColumnHeaders()
        {
            tableLayoutPanel.ColumnStyles[0].Width = 40;
            tableLayoutPanel.ColumnStyles[1].Width = 40;

            CreateColumnHeader("Client", 0);
            CreateColumnHeader("Version", 1);

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
            tableLayoutPanel.Visible = true;
            useGreyText = true;

            string selectedSoftware = softwareComboBox.SelectedItem.ToString();
            if (selectedSoftware == "Civil 3D")
            {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.ColumnCount = 4;

                tableLayoutPanel.ColumnStyles[0].Width = 40;
                tableLayoutPanel.ColumnStyles[1].Width = 40;
                tableLayoutPanel.ColumnStyles[2].Width = 40;
                tableLayoutPanel.ColumnStyles[3].Width = 40;

                List<Civil3DTableRowData> options = null;

                if (clientDropdownMenu.SelectedItem != null)
                {
                    string selectedClient = clientDropdownMenu.SelectedItem?.ToString();
                    options = viewModel.Civil3dOptionsBasedOnClient(selectedClient);
                }
                else if (versionDropdownMenu.SelectedItem != null)
                {
                    string selectedVersion = versionDropdownMenu.SelectedItem?.ToString();
                    options = viewModel.Civil3dOptionsBasedOnVersion(selectedVersion);
                }

                if (options != null)
                {
                    int rowIndex = 1;
                    foreach (var option in options)
                    {
                        useGreyText = true;
                        if (option.EnglishOffered)
                        {
                            CreateAndAddRadioButton_Civil3D(2, rowIndex, option.Client, option.Version, "English");
                        }
                        else
                        {
                            CreateAndAddlightGrayLabel("--", 2, rowIndex);
                        }

                        if (option.FrenchOffered)
                        {
                            CreateAndAddRadioButton_Civil3D(3, rowIndex, option.Client, option.Version, "French");
                        }
                        else
                        {
                            CreateAndAddlightGrayLabel("--", 3, rowIndex);
                        }

                        if (useGreyText == true)
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

                AddCivil3DColumnHeaders();
            }

            else if (selectedSoftware == "OpenRoads Designer")
            {
                tableLayoutPanel.Controls.Clear();
                tableLayoutPanel.ColumnCount = 3;

                tableLayoutPanel.ColumnStyles[0].Width = 40;
                tableLayoutPanel.ColumnStyles[1].Width = 40;
                tableLayoutPanel.ColumnStyles[2].Width = 40;

                List<OpenRoadsTableRowData> options = null;

                List<string> openRoadsInstallations = openRoadsModel.GetOpenRoadsInstallations();

                if (clientDropdownMenu.SelectedItem != null)
                {
                    string selectedClient = clientDropdownMenu.SelectedItem?.ToString();
                    options = viewModel.OpenRoadsOptionsBasedOnClient(selectedClient);
                }
                else if (versionDropdownMenu.SelectedItem != null)
                {
                    string selectedVersion = versionDropdownMenu.SelectedItem?.ToString();
                    options = viewModel.OpenRoadsOptionsBasedOnVersion(selectedVersion);
                }

                if (options != null)
                {
                    int rowIndex = 1;
                    foreach (var option in options)
                    {
                        useGreyText = true;

                        if (openRoadsInstallations.Contains(option.Version))
                        {
                            useGreyText = false;
                            CreateAndAddRadioButton_OpenRoads(2, rowIndex, option.Client, option.Version);
                            CreateAndAddBlackLabel(option.Client, 0, rowIndex);
                            CreateAndAddBlackLabel(option.Version, 1, rowIndex);
                        }
                        else
                        {
                            useGreyText = true;
                            CreateAndAddRadioButton_OpenRoads(2, rowIndex, option.Client, option.Version);
                            CreateAndAddGrayLabel(option.Client, 0, rowIndex);
                            CreateAndAddGrayLabel(option.Version, 1, rowIndex);
                        }


                        rowIndex++;
                    }
                }

                AddOpenRoadsColumnHeaders();
            }

        }

        private void CreateAndAddRadioButton_Civil3D(int column, int row, string client, string version, string language)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Tag = new Tuple<string, string, string>(client, version, language);
            radioButton.Enabled = civil3dModel.installedVersionsOfCivil3D.Contains((version, language));
            radioButton.CheckedChanged += RadioButton_CheckedChanged_Civil3D;
            radioButton.Margin = new Padding(13, 1, 0, 0);
            tableLayoutPanel.Controls.Add(radioButton, column, row);

            if (radioButton.Enabled)
            {
                useGreyText = false;
            }
        }

        private void CreateAndAddRadioButton_OpenRoads(int column, int row, string client, string version)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Tag = new Tuple<string, string>(client, version);
            radioButton.Enabled = openRoadsModel.GetOpenRoadsInstallations().Contains(version);
            radioButton.CheckedChanged += RadioButton_CheckedChanged_OpenRoads;
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

        private void RadioButton_CheckedChanged_Civil3D(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                nameTextBox.Enabled = true;

                var tagTuple = radioButton.Tag as Tuple<string, string, string>;
                string client = tagTuple.Item1;
                string version = tagTuple.Item2;
                string language = tagTuple.Item3;

                builtShortcutPath = civil3dModel.BuildCivil3DEnvironmentShortcut(client, version, language);
                favouriteButtonToolTip = client + " (" + version  +" " + language + ")";

                launchButton.Enabled = true;

            }
        }

        // REFACTOR EVERYTHING TO DO WITH RADIO BUTTONS, BUT MAKE LANGUAGE NULL WHEN PASSED IN FOR OPEN ROADS
        private void RadioButton_CheckedChanged_OpenRoads(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                nameTextBox.Enabled = true;

                var tagTuple = radioButton.Tag as Tuple<string, string>;
                string client = tagTuple.Item1;
                string version = tagTuple.Item2;

                builtShortcutPath = openRoadsModel.BuildOpenRoadsEnvironmentShortcut(client, version);
                favouriteButtonToolTip = client + " [" + version + "]";

                launchButton.Enabled = true;

            }
        }

        private void tableLayoutPanel_Paint_1(object sender, PaintEventArgs e)
        {
            tableLayoutPanel.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel, true, null);

        } // TO DO: Get rid of _1 in name
        #endregion


        #region Favourite Buttons
        private string GetIconPath(string software)
        {
            if (software == "Civil 3D")
            {
                return "C:\\Users\\CAMB075971\\source\\repos\\WinForms_Sandbox\\DynamoTesting\\Icons\\Civil3D.ico";
            }
            else if (software == "OpenRoads Designer") ;
            {
                return "C:\\Users\\CAMB075971\\source\\repos\\WinForms_Sandbox\\DynamoTesting\\Icons\\OpenRoads.ico";
            }
        }

        private void CreateFavouriteButton(string name, string shortcutPath, string tooltip, string software, string iconPath)
        {
            FavouriteButton favouriteButton = new FavouriteButton(name, shortcutPath, tooltip, software, iconPath);
            viewModel.favouriteButtons.Add(favouriteButton);
            viewModel.buttonCount++;
            viewModel.WriteToFavouriteButtonsJson();

            DrawButtons();
        }

        private void DrawButtons()
        {
            var controlsCopy = new List<Control>(favouritesPanel.Controls.OfType<Button>());

            foreach (var control in controlsCopy)
            {
                if (control.Tag is FavouriteButton)
                {
                    favouritesPanel.Controls.Remove(control);
                    control.Dispose(); // Dispose the button to release resources
                }
            }

            int topPosition = 30;
            foreach (var favouriteButton in viewModel.favouriteButtons)
            {
                Button button = BuildButton(favouriteButton); // Use helper function to prepare button
                button.Top = topPosition;
                button.Left = 10;
                button.Visible = true;
                button.BringToFront();
                topPosition += button.Height + 5;
                favouritesPanel.Controls.Add(button);
            }

            if (favouritesPanel.Controls.Count > 0)
            {
                int panelHeight = favouritesPanel.Controls[favouritesPanel.Controls.Count - 1].Bottom + 10;
                favouritesPanel.AutoScroll = panelHeight > favouritesPanel.Height; //check if scrolling is necessary
            }
        }

        private Button BuildButton(FavouriteButton favouriteButton)
        {
            Button button = new Button();
            button.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            button.Text = favouriteButton.Name;
            button.Tag = favouriteButton; // Store the FavouriteButton instance in the Tag property
            button.Click += FavouriteButton_Click;
            button.ContextMenuStrip = rightClickMenu;
            button.ForeColor = Color.Black;

            button.TextImageRelation = TextImageRelation.ImageBeforeText; // Display image before text

            if (File.Exists(favouriteButton.IconPath))
            {
                try
                {
                    using (Image originalImage = Image.FromFile(favouriteButton.IconPath))
                    {
                        int imageSize = 15;
                        Image resizedImage = new Bitmap(originalImage, new Size(imageSize, imageSize));
                        button.Image = resizedImage;
                        button.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading or resizing icon: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Icon file not found: {favouriteButton.IconPath}");
            }

            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 200;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(button, favouriteButton.Tooltip);
            button.Size = new Size(90, 25);

            return button;
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
                    utilities.StartSoftware(shortcutPath);
                }
            }
        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button buttonToRename = (Button)contextMenu.SourceControl;
            FavouriteButton favouriteButtonToRename = (FavouriteButton)buttonToRename.Tag;

            Form dialog = new Form();
            dialog.Text = "Enter new name";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.Size = new Size(250, 115);

            TextBox nameTextBox = new TextBox();
            nameTextBox.Location = new Point(10, 10); // Location of window
            nameTextBox.Size = new Size(210, 20);
            nameTextBox.Text = favouriteButtonToRename.Name.ToString(); // Set placeholder text
            dialog.Controls.Add(nameTextBox);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(10, nameTextBox.Bottom + 10); // Adjusted Y-coordinate
            dialog.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(okButton.Right + 10, nameTextBox.Bottom + 10);
            dialog.Controls.Add(cancelButton);

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string newName = nameTextBox.Text;
                favouriteButtonToRename.Name = newName;

                int indexToUpdate = viewModel.favouriteButtons.FindIndex(button => button == favouriteButtonToRename);
                if (indexToUpdate != -1)
                {
                    viewModel.favouriteButtons[indexToUpdate].Name = newName;
                    viewModel.WriteToFavouriteButtonsJson();
                }

                DrawButtons();
            }
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            // BUG: SOFTWARE MIGHT NOT BE SELECTED AT START
            string software = softwareComboBox.SelectedItem?.ToString();

            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;
            Button buttonToUpdate = (Button)contextMenu.SourceControl;
            FavouriteButton favouriteButtonToUpdate = (FavouriteButton)buttonToUpdate.Tag;

            bool radioButtonSelected = false;
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    radioButtonSelected = true;
                    break;
                }
            }

            if (!radioButtonSelected)
            {
                MessageBox.Show("Please select a client environment to update the favourite button with.", "No Environment Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string originalToolTip = favouriteButtonToUpdate.Tooltip;

            if (originalToolTip == favouriteButtonToolTip)
            {
                MessageBox.Show("The selected environment is the same as the original.", "Nothing to update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this button?", "Update button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                favouriteButtonToUpdate.ShortcutPath = builtShortcutPath;
                favouriteButtonToUpdate.Tooltip = favouriteButtonToolTip;
                favouriteButtonToUpdate.Software = software;
                string iconPath = GetIconPath(software);
                favouriteButtonToUpdate.IconPath = iconPath;
                int indexToUpdate = viewModel.favouriteButtons.FindIndex(button => button == favouriteButtonToUpdate);

                if (indexToUpdate != -1)
                {
                    viewModel.favouriteButtons[indexToUpdate] = favouriteButtonToUpdate;
                    viewModel.WriteToFavouriteButtonsJson();
                }
                DrawButtons();
            }
        }

        private void RemoveMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;                         // Get the MenuItem that triggered the event
            ContextMenuStrip contextMenu = (ContextMenuStrip)menuItem.Owner;                // Get the ContextMenuStrip that contains the MenuItem
            Button buttonToRemove = (Button)contextMenu.SourceControl;                      // Get the Button associated with the ContextMenuStrip
            FavouriteButton favouriteButtonToRemove = (FavouriteButton)buttonToRemove.Tag;  // Get the FavouriteButton object corresponding to the button

            DialogResult result = MessageBox.Show("Are you sure you want to remove this button?", "Remove button", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int indexToRemove = viewModel.favouriteButtons.FindIndex(button => button == favouriteButtonToRemove);

                if (indexToRemove != -1)
                {
                    viewModel.favouriteButtons.RemoveAt(indexToRemove);
                }
                viewModel.buttonCount--;
                viewModel.WriteToFavouriteButtonsJson();

                DrawButtons();
            }
        }

        #endregion





        #region Unused Event Handlers
        private void clientDropdownMenu_Selected(object sender, EventArgs e)
        {

        }
        private void versionDropdownMenu_Selected(object sender, EventArgs e)
        {

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
        private void favouritesLabel_Click(object sender, EventArgs e)
        {

        }
        private void favouritesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clientDropdownMenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        #endregion

        private void digitalOperationsHomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://wsponline.sharepoint.com/sites/CA-CAipmoDpdOps");
        }

        private void civil3dRequestForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://apps.powerapps.com/play/e/1cffb129-e912-e209-a2e7-d63404f22af0/a/e9300341-d97a-4f13-9bf0-897f752b7ffa?tenantId=3d234255-e20f-4205-88a5-9658a402999b");
        }

        private void oracleTimesheet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://emit.fa.ca3.oraclecloud.com/fscmUI/faces/FuseWelcome");
        }

        private void horizonOracleSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://wsponline.sharepoint.com/sites/GBL-Horizon/SitePages/Horizon-Oracle-Support.aspx");
        }

        private void wspServiceNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://wsp.service-now.com/wsp");
        }

        private void pans_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://wsponline.sharepoint.com/sites/PAN-Home");
        }

        private void eula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            utilities.OpenWebsite("https://wsponline.sharepoint.com/sites/PAN-Home");
        }
    }
}

