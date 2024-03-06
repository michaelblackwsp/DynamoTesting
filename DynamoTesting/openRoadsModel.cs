namespace DynamoTesting
{
    public class openRoadsModel
    {
        Utilities utilities = new Utilities();
        public List<(string year, string language)> installedVersionsOfOpenRoads = null;

        #region OpenRoads Client Environments
        // TO DO: Add built-in (default) versions for each software
        public static string[] clientOptions = { "MTO", "MTQ", "VDM", "WSP_EN" };
        public static string[] versionOptions = { "2020-R1", "2021-R1", "2021-R2", "2021-R3", "2022-R3", "2023-R3" };

        // TO DO: Change these 3 dictionaries to be a single matrix, single source of truth
        public Dictionary<string, string[]> versionsBasedOnClient = new Dictionary<string, string[]>
        {
            { "MTO", new string[] { "2021-R1", "2021-R3" } },
            { "MTQ", new string[] { "2021-R3", "2022-R3", "2023-R3" } },
            { "VDM", new string[] { "2020-R1" } },
            { "WSP_EN", new string[] { "2021-R1", "2021-R2", "2021-R3", "2022-R3", "2023-R3" } },
        };
        public Dictionary<string, string[]> clientsBasedOnVersion = new Dictionary<string, string[]>
        {
            { "2020-R1", new string[] { "VDM" } },
            { "2021-R1", new string[] { "MTO", "VDM", "WSP_EN" } },
            { "2021-R2", new string[] { "WSP_EN" } },
            { "2021-R3", new string[] { "MTO", "MTQ", "WSP_EN" } },
            { "2022-R3", new string[] { "WSP_EN" } },
            { "2023-R3", new string[] { "WSP_EN" } },
        };
        #endregion


        #region Get Open Roads Installations and Windows System Info
/*        public Dictionary<string, Tuple<string, string>> yearToRNumber = new Dictionary<string, Tuple<string, string>>
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
        public List<(string year, string language)> GetCivil3DInstallations()
        {
            string[] profiles = (string[])GetCivil3DMetricProfiles(yearToRNumber, languageToRegion);
            List<(string year, string language)> civil3DInstallations = new List<(string year, string language)>();

            foreach (string profile in profiles)
            {
                string[] parts = profile.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 5)
                {
                    string desiredValue1 = parts[3];
                    string desiredValue2 = parts[4].Substring(Math.Max(0, parts[4].Length - 3));

                    // Use the values to find the corresponding keys in the mapping dictionaries
                    string year = yearToRNumber.FirstOrDefault(kv => kv.Value.Item1 == desiredValue1).Key;
                    string language = languageToRegion.FirstOrDefault(kv => kv.Value == desiredValue2).Key;

                    // Add the keys to the result list
                    civil3DInstallations.Add((year, language));
                }
            }

            return civil3DInstallations;
        }

        public Array GetCivil3DMetricProfiles(Dictionary<string, Tuple<string, string>> installations, Dictionary<string, string> languages)
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

                    bool softwareExists = utilities.RegistryExists(registryPath);
                    if (softwareExists)
                    {
                        listOfInstalls.Add(registryPath.ToString());
                    }
                }
            }

            return listOfInstalls.ToArray();
        }*/
        #endregion


        public string BuildOpenRoadsEnvironmentShortcut(string client, string version, string language)
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

    // Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Bentley\OpenRoadsDesigner\{359F376F-B120-3DD3-BC30-56D5687B766D}
}