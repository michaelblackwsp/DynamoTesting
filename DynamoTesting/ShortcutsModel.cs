using Microsoft.Win32;
using System.Diagnostics;


namespace DynamoTesting
{
    public class ShortcutsModel
    {
        public static string[] clientOptions = { "BCMoT", "CofC", "DND", "MTQ", "MVRD", "MX", "VDG", "VDM", "VDQ", "VIA", "WSP_EN", "WSP_FR" };
        public static string[] languageOptions = { "English", "French" };
        public static string[] versionOptions = { "2018", "2019", "2020", "2021", "2022", "2023" };

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
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
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