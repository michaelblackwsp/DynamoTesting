using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;


namespace DynamoTesting
{
    public class Model
    {
        public static string[] clientOptions = { "BCMoT", "CofC", "MTQ", "MVRD", "MX", "VDG", "VDM", "VDQ", "VIA", "WSP_EN", "WSP_FR" };
        public static string[] languageOptions = { "English", "French" };
        public static string[] versionOptions = { "2019", "2020", "2021", "2022", "2023" };



        public Dictionary<string, string[]> versionBasedOnClient = new Dictionary<string, string[]>
        {
            { "BCMoT", new string[] { "2019" } },
            { "CofC", new string[] { "2020", "2022" } },
            { "MTQ", new string[] { "2019", "2020" } },
            { "MVRD", new string[] { "2020", "2022" } },
            { "MX", new string[] { "2020", "2022" } },
            { "VDG", new string[] {"2019", "2020" } },
            { "VDM", new string[] { "2023" } },
            { "VDQ", new string[] { "2019" } },
            { "VIA", new string[] { "2019" } },
            { "WSP_EN", new string[] { "2020", "2021", "2022" } },
            { "WSP_FR", new string[] { "2019", "2020", "2021", "2022" } },
        };

        public Dictionary<string, string[]> clientBasedOnVersion = new Dictionary<string, string[]>
        {
            { "2019", new string[] {"BCMoT", "MTQ", "VDG", "VDQ", "VIA", "WSP_FR"} },
            { "2020", new string[] {"CofC", "MTQ", "MVRD", "MX", "VDG", "WSP_EN", "WSP_FR"} },
            { "2021", new string[] {"WSP_EN", "WSP_FR" } },
            { "2022", new string[] {"CofC", "MVRD", "MX", "WSP_EN", "WSP_FR" } },
            { "2023", new string[] { "VDM" } },
        };



        public Dictionary<string, Tuple<string, string>> yearToRNumber = new Dictionary<string, Tuple<string, string>>
        {
            { "2019", Tuple.Create("R23.0", "2000") },
            { "2020", Tuple.Create("R23.1", "3000") },
            { "2021", Tuple.Create("R24.0", "4100") },
            { "2022", Tuple.Create("R24.1", "5100") },
            { "2023", Tuple.Create("R24.2", "6100") },
        };

        public Dictionary<string, string> languageToRegion = new Dictionary<string, string>
        {
            { "English", "409" },
            { "French", "40C" },
        };



        public Array getCivil3DInstallations(Dictionary<string, Tuple<string, string>> installations, Dictionary<string, string> languages)
        {
            string registryPath = null;
            List<string> listOfInstalls = new List<string>();

            foreach (var version in installations.Keys)
            {
                Tuple<string, string> rNumber_productID = installations[version];
                string rNumber = rNumber_productID.Item1;
                string productId = rNumber_productID.Item2;

                foreach (var language in languages.Keys)
                {
                    string regionValue = languages[language];
                    registryPath = $@"SOFTWARE\Autodesk\AutoCAD\{rNumber}\ACAD-{productId}:{regionValue}\Profiles\<<C3D_Metric>>";

                    bool softwareExists = registryExists(registryPath);
                    if (softwareExists)
                    {
                        listOfInstalls.Add(registryPath.ToString());
                    } 
                }
            }

            return listOfInstalls.ToArray();
        }

        public string BuildRegistryPath(string selectedVersion, string selectedLanguage, Dictionary<string, Tuple<string, string>> installations, Dictionary<string, string> languages)
        {
            string registryPath = null;

            Tuple<string, string> rNumber_productID = installations[selectedVersion];
            string rNumber = rNumber_productID.Item1;
            string productId = rNumber_productID.Item2;

            string regionValue = languages[selectedLanguage];

            registryPath = $@"SOFTWARE\Autodesk\AutoCAD\{rNumber}\ACAD-{productId}:{regionValue}\Profiles\<<C3D_Metric>>";

            return registryPath;
        }



        public bool registryExists(string path)
        { // Can this be static, as in a part of this class, not an instance of the class?
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path);
                return key != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool stringExists(string path, Array array)
        {
            string[] yourArray = (string[])getCivil3DInstallations(yearToRNumber, languageToRegion);

            return yourArray.Contains(path); // Using LINQ for simplicity
        }



        public string buildShortcut(string client, string language, string version)
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


        
    }

}