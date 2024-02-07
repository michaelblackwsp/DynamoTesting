using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
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

        /*        public List<string> BuildOptionsBasedOnClient(string selectedClient)
                {
                    List<string> options = new List<string>();

                    if (selectedClient != null)
                    {
                        string[] versions = model.versionsBasedOnClient[selectedClient];
                        foreach (string version in versions)
                        {
                            string displayOption = selectedClient + " (" + version + ")";
                            options.Add(displayOption);
                        }

                    }
                    //UpdateLaunchButtonState();
                    return options;
                }*/

        public List<TableRowData> OptionsBasedOnClient(string selectedClient)
        {
            List<TableRowData> tableData = new List<TableRowData>();
            if (selectedClient != null)
            {
                string[] versions = model.versionsBasedOnClient[selectedClient];

                foreach (string version in versions)
                {
                    // Create a new TableRowData object representing a row in the table
                    TableRowData rowData = new TableRowData(selectedClient, version, false, false);

                    // Add the row data to the list
                    tableData.Add(rowData);
                }
            }
            return tableData;
        }

        public List<TableRowData> OptionsBasedOnVersion(string selectedVersion)
        {
            List<TableRowData> tableData = new List<TableRowData>();
            if (selectedVersion != null)
            {
                string[] clients = model.clientsBasedOnVersion[selectedVersion];

                foreach (string client in clients)
                {
                    // Create a new TableRowData object representing a row in the table
                    TableRowData rowData = new TableRowData(client, selectedVersion, false, false);

                    // Add the row data to the list
                    tableData.Add(rowData);
                }
            }
            return tableData;
        }

        public void HandleLaunchButtonClick(string client, string version, string language)
        {

            // THIS NEEDS TO BE LANGUAGE AVAILABLE BASED ON THE MATRIX
            string pathToShortcut = model.BuildShortcut(client, version, language);

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
