namespace DynamoTesting
{
    public class openRoadsModel
    {
        Utilities utilities = new Utilities();
        public List<string> installedVersionsOfOpenRoads = null;

        #region OpenRoads Client Environments
        // TO DO: Add built-in (default) versions for each software
        public static string[] clientOptions = { "MTO", "MTQ", "WSP_EN", "<Standard>" };
        // TO DO: Populate the dropdowns based on the keys of the client/version dictionaries below
        public static string[] versionOptions = { "2020 R3", "2021 (R1, R2)", "2022 (R1, R1U1)", "2022 (R2, R3, R3U1)" };

        // TO DO: Change these 3 dictionaries to be a single matrix, single source of truth
        public Dictionary<string, string[]> versionsBasedOnClient = new Dictionary<string, string[]>
        {
            { "MTO", new string[] { "2021 (R1, R2)", "2022 (R1, R1U1)", "2022 (R2, R3, R3U1)" } },
            { "MTQ", new string[] { "2020 R3", "2021 (R1, R2)", "2022 (R1, R1U1)", "2022 (R2, R3, R3U1)" } },
            { "WSP_EN", new string[] { "2022 (R2, R3, R3U1)" } },
            { "<Standard>", new string[] { "2020 R3", "2021 (R1, R2)", "2022 (R1, R1U1)", "2022 (R2, R3, R3U1)" } },
        };
        public Dictionary<string, string[]> clientsBasedOnVersion = new Dictionary<string, string[]>
        {
            { "2020 R3", new string[] { "MTQ", "<Standard>"} },
            { "2021 (R1, R2)", new string[] { "MTO", "MTQ", "<Standard>" } },
            { "2022 (R1, R1U1)", new string[] { "MTO", "MTQ", "<Standard>" } },
            { "2022 (R2, R3, R3U1)", new string[] { "MTO", "MTQ", "WSP_EN", "<Standard>" } },
        };
        #endregion


        #region Get Open Roads Installations and Windows System Info
        public Dictionary<string, string> OpenRoadsRegistryKeyList = new Dictionary<string, string>
        {
            { "2020 R3", "{D11A86DD-FF26-4139-9C79-C1ABB4C8B5BF" },
            { "2021 (R1, R2)", "{359F376F-B120-3DD3-BC30-56D5687B766D}" },
            { "2022 (R1, R1U1)", "{B0DCB521-5CE0-3CB5-AD8A-477E98D9B913}" },
            { "2022 (R2, R3, R3U1)", "{0A1BD8D1-4A49-3D5C-9824-0BC589BE1DEA}" },
        };

        public Dictionary<string, string> OpenRoadsVersionData = new Dictionary<string, string>
        {
            { "10.09.00.91", "2020 Release 3" }, // 2020 R3
            { "10.10.01.03", "2021 Release 1" }, // 2021 R1
            { "10.10.21.004", "2021 Release 2" }, // 2021 R2
            { "10.11.00.115", "2022 Release 1" }, // 2022 R1
            { "10.11.03.02", "2022 Release 1, Update 1" }, // 2022 R1U1
            { "10.12.03.02", "2022 Release 3, Update 1" }, // 2022 R3U1
            { "10.12.01.59", "2022 Release 2" }, // 2022 R2
            { "10.12.02.04", "2022 Release 3" }, // 2022 R3
            { "23.00.00.129", "2023"} // 2023
        };

        public List<string> GetOpenRoadsInstallations()
        {
            string registryPath = null;
            List<string> listOfInstalls = new List<string>();

            string location = "LocalMachine"; 
            
            foreach (var version in OpenRoadsRegistryKeyList)
            {
                registryPath = $@"SOFTWARE\Bentley\OpenRoadsDesigner\{version.Value}";

                bool softwareExists = Utilities.RegistryExists(registryPath, location);
                if (softwareExists)
                {
                    listOfInstalls.Add(version.Key);
                }
            }

            return listOfInstalls;
        }
        #endregion


        public string BuildOpenRoadsStandardShortcut(string client, string version)
        {
            string shortcut = "C:\\Program Files\\Bentley\\OpenRoads Designer CE 10.11\\OpenRoadsDesigner\\OpenRoadsDesigner.exe";
            return shortcut;
        }

        public string BuildOpenRoadsEnvironmentShortcut(string client, string version)
        {
            string shortcut = "C:\\Program Files\\Bentley\\OpenRoads Designer CE 10.11\\OpenRoadsDesigner\\OpenRoadsDesigner.exe";
            return shortcut;
        }

    }

}