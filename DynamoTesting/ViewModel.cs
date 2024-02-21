using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DynamoTesting
{
    public class ViewModel
    {
        private readonly Model model;
        public ViewModel(Model model)
        {
            this.model = model;
        }

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
    }

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
}
