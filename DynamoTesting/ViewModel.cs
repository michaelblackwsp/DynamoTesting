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
        private readonly Model model;
        public ViewModel(Model model)
        {
            this.model = model;
        }
        #endregion


        #region Prepare Client and Version Dropdown Menu Options
        public List<TableRowData> OptionsBasedOnClient(string selectedClient)
        {
            List<TableRowData> tableData = new List<TableRowData>();
            string[] versions = model.versionsBasedOnClient[selectedClient];

            if (model.languageBasedOnClient.ContainsKey(selectedClient))
            {
                List<string> language = model.languageBasedOnClient[selectedClient];

                foreach (string version in versions)
                {
                    bool englishOffered = language.Contains("English");
                    bool frenchOffered = language.Contains("French");
                    TableRowData rowData = new TableRowData(selectedClient, version, englishOffered, frenchOffered);
                    tableData.Add(rowData);
                }
            }
            else
            {
                throw new KeyNotFoundException($"Languages for client '{selectedClient}' not found.");
            }

            return tableData;
        }

        public List<TableRowData> OptionsBasedOnVersion(string selectedVersion)
        {
            List<TableRowData> tableData = new List<TableRowData>();
            string[] clients = model.clientsBasedOnVersion[selectedVersion];

            foreach (string client in clients)
            {
                if (model.languageBasedOnClient.ContainsKey(client))
                {
                    List<string> languages = model.languageBasedOnClient[client];

                    bool englishOffered = languages.Contains("English");
                    bool frenchOffered = languages.Contains("French");

                    TableRowData rowData = new TableRowData(client, selectedVersion, englishOffered, frenchOffered);
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


        #region Favourite Buttons JSON
        public List<FavouriteButton> favouriteButtons = new List<FavouriteButton>();    // FIX ME: Should this be in the Model?
        public int buttonCount = 0;

        public void WriteToFavouriteButtonsJson()
        {
            // TO DO: Make this generic to the User
            string filePath = Path.Combine(Application.StartupPath, "preferences", "favouriteButtons.json");
            //string filePath = @"C:\Users\CAMB075971\source\repos\WinForms_Sandbox\DynamoTesting\preferences\favouriteButtons.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(favouriteButtons, options);
            File.WriteAllText(filePath, jsonString);
            
            // TO DO: Add a catch in case the file doesn't exist
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
                MessageBox.Show("Preferences file cannot be found. Please contact Digital Operations.");
            }
        }
        #endregion

    }

    #region TableRowData Class
    public class TableRowData
    {
        public string Client { get; }
        public string Version { get; }
        public bool EnglishOffered { get; }
        public bool FrenchOffered { get; }

        public TableRowData(string client, string version, bool englishOffered, bool frenchOffered)
        {
            // client, version etc. are the parameters passed to the TableRowData object
            Client = client;
            Version = version;
            EnglishOffered = englishOffered;
            FrenchOffered = frenchOffered;
        }
    }
    #endregion
}
