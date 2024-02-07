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

        public List<string> BuildOptionsBasedOnClient(string selectedClient)
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
        }

        public List<string> BuildOptionsBasedOnVersion(string selectedVersion)
        {
            List<string> options_basedOnVersion = new List<string>();

            if (selectedVersion != null)
            {
                string[] clients = model.clientsBasedOnVersion[selectedVersion];
                foreach (string client in clients)
                {
                    string displayOption = client + " (" + selectedVersion + ")";
                    options_basedOnVersion.Add(displayOption);
                }

            }
            //UpdateLaunchButtonState();
            return options_basedOnVersion;
        }





/*
        private void UpdateLaunchButtonState()
        {

            string[] installedCivil3D = (string[])model.GetCivil3DInstallations(model.yearToRNumber, model.languageToRegion);

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

                    if (model.StringExists(path, installedCivil3D))
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

                    if (model.StringExists(path, installedCivil3D))
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

                        if (model.StringExists(path, installedCivil3D))
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
*/

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
}
