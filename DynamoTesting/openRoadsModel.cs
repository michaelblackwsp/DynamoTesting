namespace DynamoTesting
{
    public class openRoadsModel
    {
        Utilities utilities = new Utilities();
        public List<(string year, string language)> installedVersionsOfOpenRoads = null;

        #region OpenRoads Client Environments
        // TO DO: Add built-in (default) versions for each software
        public static string[] clientOptions = { "MTO", "MTQ", "VDM", "WSP_EN" };
        public static string[] versionOptions = { "2020 (R1)", "2021 (R1)", "2021 (R2)", "2021 (R3)", "2022 (R3)", "2023 (R3)" };

        // TO DO: Change these 3 dictionaries to be a single matrix, single source of truth
        public Dictionary<string, string[]> versionsBasedOnClient = new Dictionary<string, string[]>
        {
            { "MTO", new string[] { "2021 (R1)", "2021 (R3)" } },
            { "MTQ", new string[] { "2021 (R3)", "2022 (R3)", "2023 (R3)" } },
            { "VDM", new string[] { "2020 (R1)" } },
            { "WSP_EN", new string[] { "2021 (R1)", "2021 (R2)", "2021 (R3)", "2022 (R3)", "2023 (R3)" } },
        };
        public Dictionary<string, string[]> clientsBasedOnVersion = new Dictionary<string, string[]>
        {
            { "2020 (R1)", new string[] { "VDM" } }, 
            { "2021 (R1)", new string[] { "MTO", "VDM", "WSP_EN" } },
            { "2021 (R2)", new string[] { "WSP_EN" } },
            { "2021 (R3)", new string[] { "MTO", "MTQ", "WSP_EN" } },
            { "2022 (R3)", new string[] { "WSP_EN" } },
            { "2023 (R3)", new string[] { "WSP_EN" } },
        };
        #endregion


        #region Get Open Roads Installations and Windows System Info
        public Dictionary<string, string> VersionRegistryKeys = new Dictionary<string, string>
        {
            { "2021 (R2)", "{359F376F-B120-3DD3-BC30-56D5687B766D}" },
            { "2022 (R1)", "{B0DCB521-5CE0-3CB5-AD8A-477E98D9B913}" },
        };

        public Array GetOpenRoadsInstallations()
        {
            string registryPath = null;
            List<string> listOfInstalls = new List<string>();

            string location = "LocalMachine"; 
            registryPath = $@"SOFTWARE\Bentley\OpenRoadsDesigner\" + "{B0DCB521-5CE0-3CB5-AD8A-477E98D9B913}";

            bool softwareExists = Utilities.RegistryExists(registryPath, location);
            if (softwareExists)
            {
                listOfInstalls.Add(registryPath.ToString());
                MessageBox.Show("ADDED");
            }
            else
            {
                MessageBox.Show("NOT FOUND");
            }
            return listOfInstalls.ToArray();
        }

            
    
        #endregion


        public string BuildOpenRoadsEnvironmentShortcut(string client, string version, string language)
        {
            string shortcut = "";
            return shortcut;
        }

    }

    // Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Bentley\OpenRoadsDesigner\{359F376F-B120-3DD3-BC30-56D5687B766D}

    // The one-stop shop for all your production needs!

    // ADD: Check EXACTLY what version they have (2022.0 vs 2022.2.1 etc)
    // ADD: launch default software

}