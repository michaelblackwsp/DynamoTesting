using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynamoTesting
{
    public class ViewModel
    {
        #region Initialization
        private readonly civil3dModel civil3dModel;
        private readonly openRoadsModel openRoadsModel;
        public ViewModel(civil3dModel civil3dModel, openRoadsModel openRoadsModel)
        {
            this.civil3dModel = civil3dModel;
            this.openRoadsModel = openRoadsModel;
        }
        #endregion


        #region Prepare Civil 3D Client and Version Dropdown Menu Options
        public List<Civil3DTableRowData> Civil3dOptionsBasedOnClient(string selectedClient)
        {
            List<Civil3DTableRowData> tableData = new List<Civil3DTableRowData>();
            string[] versions = civil3dModel.versionsBasedOnClient[selectedClient];

            if (civil3dModel.languageBasedOnClient.ContainsKey(selectedClient))
            {
                List<string> language = civil3dModel.languageBasedOnClient[selectedClient];

                foreach (string version in versions)
                {
                    bool englishOffered = language.Contains("English");
                    bool frenchOffered = language.Contains("French");
                    Civil3DTableRowData rowData = new Civil3DTableRowData(selectedClient, version, englishOffered, frenchOffered);
                    tableData.Add(rowData);
                }
            }
            else
            {
                throw new KeyNotFoundException($"Languages for client '{selectedClient}' not found.");
            }

            return tableData;
        }
        public List<Civil3DTableRowData> Civil3dOptionsBasedOnVersion(string selectedVersion)
        {
            List<Civil3DTableRowData> tableData = new List<Civil3DTableRowData>();
            string[] clients = civil3dModel.clientsBasedOnVersion[selectedVersion];

            foreach (string client in clients)
            {
                if (civil3dModel.languageBasedOnClient.ContainsKey(client))
                {
                    List<string> languages = civil3dModel.languageBasedOnClient[client];

                    bool englishOffered = languages.Contains("English");
                    bool frenchOffered = languages.Contains("French");

                    Civil3DTableRowData rowData = new Civil3DTableRowData(client, selectedVersion, englishOffered, frenchOffered);
                    tableData.Add(rowData);
                }
                else
                {
                    throw new KeyNotFoundException($"Languages for client '{selectedVersion}' not found.");
                }
            }

            return tableData;
        }
        #endregion


        #region Prepare OpenRoads Client and Version Dropdown Menu Options
        public List<OpenRoadsTableRowData> OpenRoadsOptionsBasedOnClient(string selectedClient)
        {
            List<OpenRoadsTableRowData> tableData = new List<OpenRoadsTableRowData>();
            string[] versions = openRoadsModel.versionsBasedOnClient[selectedClient];

            foreach (string version in versions)
            {
                OpenRoadsTableRowData rowData = new OpenRoadsTableRowData(selectedClient, version);
                tableData.Add(rowData);
            }

            return tableData;
        }
        public List<OpenRoadsTableRowData> OpenRoadsOptionsBasedOnVersion(string selectedVersion)
        {
            List<OpenRoadsTableRowData> tableData = new List<OpenRoadsTableRowData>();
            string[] clients = openRoadsModel.clientsBasedOnVersion[selectedVersion];

            foreach (string client in clients)
            {
                OpenRoadsTableRowData rowData = new OpenRoadsTableRowData(client, selectedVersion);
                tableData.Add(rowData);
            }

            return tableData;
        }
        #endregion


        #region Favourite Buttons JSON
        public List<FavouriteButton> favouriteButtons = new List<FavouriteButton>();    // FIX ME: Should this be in the Model?
        public int buttonCount = 0;

        public void WriteToFavouriteButtonsJson()
        {
            //FOR RELEASE: Add logic to create the JSON file if for some reason it doesn't exist on the user's machine
            string filePath = Path.Combine(Application.StartupPath, "preferences", "favouriteButtons.json");
            //string filePath = @"C:\Users\CAMB075971\source\repos\WinForms_Sandbox\DynamoTesting\preferences\favouriteButtons.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(favouriteButtons, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void ReadFromFavouriteButtonsJson()
        {
            string filePath = Path.Combine(Application.StartupPath, "preferences", "favouriteButtons.json");
            //string filePath = @"C:\Users\CAMB075971\source\repos\WinForms_Sandbox\DynamoTesting\preferences\favouriteButtons.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                favouriteButtons = JsonSerializer.Deserialize<List<FavouriteButton>>(jsonString);
            }
            else
            {
                MessageBox.Show("Favourites file was not found. REPCON has created it. You can now save favourite buttons.");
            }
        }
        #endregion

    }

    #region Civil 3D TableRowData Class
    public class Civil3DTableRowData
    {
        public string Client { get; }
        public string Version { get; }
        public bool EnglishOffered { get; }
        public bool FrenchOffered { get; }

        public Civil3DTableRowData(string client, string version, bool englishOffered, bool frenchOffered)
        {
            Client = client;
            Version = version;
            EnglishOffered = englishOffered;
            FrenchOffered = frenchOffered;
        }
    }
    #endregion


    #region OpenRoads TableRowData Class
    public class OpenRoadsTableRowData
    {
        public string Client { get; }
        public string Version { get; }

        public OpenRoadsTableRowData(string client, string version)
        {
            Client = client;
            Version = version;
        }
    }
    #endregion

    #region Favourite Button Class
    public class FavouriteButton
    {
        // ONCE RELEASED: Handle removing of environments by colouring buttons / giving warning
        public string Name { get; set; }
        public string ShortcutPath { get; set; }
        public string Tooltip { get; set; }
        public string Software { get; set; }
        public string IconPath { get; set; }

        public FavouriteButton(string name, string shortcutPath, string tooltip, string software, string iconPath)
        {
            Name = name;
            ShortcutPath = shortcutPath;
            Tooltip = tooltip;
            Software = software;
            IconPath = iconPath;
        }
    }
    #endregion

}
