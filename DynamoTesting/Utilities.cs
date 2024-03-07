using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;
using System.Globalization;

namespace DynamoTesting
{
    public class Utilities
    {
        public string GetWindowsVersionAndLanguage()
        {
            OperatingSystem os = Environment.OSVersion;
            CultureInfo culture = CultureInfo.CurrentCulture;

            string version = os.Version.ToString();
            string language = culture.Name; // use culture.DisplayName for long form

            return version + " (" + language + ")";
        }

        public static bool RegistryExists(string path, string location)
        {
            try
            {
                RegistryKey key;

                if (location == "CurrentUser")
                {
                    key = Registry.CurrentUser.OpenSubKey(path);
                }
                else if (location == "LocalMachine")
                {
                    key = Registry.LocalMachine.OpenSubKey(path);
                }
                else
                {
                    throw new ArgumentException("Invalid location specified.");
                }

                return key != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void StartSoftware(string path)
        {

            if (System.IO.File.Exists(path))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = path,
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

        public static string GetUserEmail(string username)
        {
            using (var searcher = new DirectorySearcher($"(samaccountname={username})"))
            {
                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    var mailProperty = result.Properties["mail"];
                    if (mailProperty != null && mailProperty.Count > 0)
                    {
                        return mailProperty[0].ToString();
                    }
                }
                return null;
            }
        }
    }

    public class ActiveDirectoryHelper
    {
        public static string GetUserEmail(string username)
        {
            using (var searcher = new DirectorySearcher($"(samaccountname={username})"))
            {
                SearchResult result = searcher.FindOne();
                if (result != null)
                {
                    var mailProperty = result.Properties["mail"];
                    if (mailProperty != null && mailProperty.Count > 0)
                    {
                        return mailProperty[0].ToString();
                    }
                }
                return null;
            }
        }
    }

}
