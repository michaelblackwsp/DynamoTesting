using Microsoft.Win32;
using System.Diagnostics;


namespace DynamoTesting
{
    public class Model
    {
        public static string[] clientOptions = { "BCMoT", "CofC", "DND", "MTQ", "MVRD", "MX", "VDG", "VDM", "VDQ", "VIA", "WSP_EN", "WSP_FR" };
        public static string[] languageOptions = { "English", "French" };
        public static string[] versionOptions = { "2018", "2019", "2020", "2021", "2022", "2023" };

        public Dictionary<string, Tuple<string, string>> yearToRNumberMap = new Dictionary<string, Tuple<string, string>>
        {
            { "2018", Tuple.Create("R22.0", "1000") },
            { "2019", Tuple.Create("R23.0", "2000") },
            { "2020", Tuple.Create("R23.1", "3000") },
            { "2021", Tuple.Create("R24.0", "4100") },
            { "2022", Tuple.Create("R24.1", "5100") },
            { "2023", Tuple.Create("R24.2", "6100") },
        };

        public Dictionary<string, string> languageToRegionMap = new Dictionary<string, string>
        {
            { "English", "409" },
            { "French", "40C" },
        };

        public string createShortcut(string client, string language, string version)
        {
            string shortFormLanguage = null;
            string modifiedVersionShortcut = null;

            if (language == "English")
            {
                language = "english_software";
                shortFormLanguage = "en";
            }

            if (language == "French")
            {
                language = "logiciel_francais";
                shortFormLanguage = "fr";
            }

            modifiedVersionShortcut = "c3d" + "_" + version + "_" + shortFormLanguage + "_" + client.ToLower() + ".lnk";
            string shortcut = "W:\\1_service\\2_environments\\" + client + "\\" + language + "\\" + modifiedVersionShortcut;

            return shortcut;
        }

        public void updateRegistry()
        {
            try
            {
                // Specify the path to your .reg file
                string regFilePath = @"C:\Users\CAMB075971\Downloads\c3d_2021_fr_wsp_fr.reg";

                // Create a new process start info
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "regedit.exe",
                    Arguments = "/s " + regFilePath,  // /s option to run silently without user prompts
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                // Start the process
                using (Process regeditProcess = new Process { StartInfo = psi })
                {
                    regeditProcess.Start();
                    regeditProcess.WaitForExit();

                    MessageBox.Show("Registry keys successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool registryExists(string path)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path); // Set to Current User, not Local Machine
                return key != null;
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
                return false;
            }
        }

        public bool softwareExists(string path)
        {
            try
            {
                return File.Exists(path);
            }
            catch (Exception)
            {
                // Handle exceptions if necessary
                return false;
            }
        }


    }

}