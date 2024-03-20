using static System.Net.Mime.MediaTypeNames;

namespace DynamoTesting
{
    public class openRoadsModel
    {
        Utilities utilities = new Utilities();
        public List<string> installedVersionsOfOpenRoads = null;

        #region OpenRoads Client Environments
        public static string[] clientOptions = { "MTO v2022", "MTQ v2021", "MTQ v2022 (CIV)", "WSP_EN v2022", "<Standard>" };
        public static string[] versionOptions = { "2020 R3", "2021 R2", "2022 R1", "2022 R3" };
        

        // CLEAN: Change these 3 dictionaries to be a single matrix, single source of truth
        public Dictionary<string, string[]> versionsBasedOnClient = new Dictionary<string, string[]>
        {
            { "MTO v2022", new string[] { "2021 R2", "2022 R1", "2022 R3" } },
            { "MTQ v2021", new string[] { "2020 R3", "2021 R2", "2022 R1" } },
            { "MTQ v2022 (CIV)", new string[] { "2022 R1", "2022 R3" } },
            { "WSP_EN v2022", new string[] { "2022 R3" } },
            { "<Standard>", new string[] { "2020 R3", "2021 R2", "2022 R1", "2022 R3" } },
        };
        public Dictionary<string, string[]> clientsBasedOnVersion = new Dictionary<string, string[]>
        {
            { "2020 R3", new string[] { "MTQ v2021", "<Standard>" } },
            { "2021 R2", new string[] { "MTO v2022", "MTQ v2021", "<Standard>" } },
            { "2022 R1", new string[] { "MTO v2022", "MTQ v2021", "MTQ v2022 (CIV)", "<Standard>" } },
            { "2022 R3", new string[] { "MTO v2022", "MTQ v2022 (CIV)", "WSP_EN v2022", "<Standard>" } },
        };
        #endregion



        #region Get Open Roads Installations and Windows System Info
        public Dictionary<string, string> OpenRoadsRegistryKeyList = new Dictionary<string, string>
        {
            { "2020 R3", "{D11A86DD-FF26-4139-9C79-C1ABB4C8B5BF" },
            { "2021 R2", "{359F376F-B120-3DD3-BC30-56D5687B766D}" },
            { "2022 R1", "{B0DCB521-5CE0-3CB5-AD8A-477E98D9B913}" },
            { "2022 R3", "{0A1BD8D1-4A49-3D5C-9824-0BC589BE1DEA}" },
        };

        public Dictionary<string, string> OpenRoadsVersionData = new Dictionary<string, string>
        {
            { "10.09.00.91", "2020 Release 3" }, // 2020 R3
            { "10.10.21.004", "2021 Release 2" }, // 2021 R2
            { "10.11.00.115", "2022 Release 1" }, // 2022 R1
            { "10.12.02.04", "2022 Release 3" }, // 2022 R3
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
            string clientNoSpaces = client.Replace(" ", "");

            int indexOfV = client.IndexOf('v');
            string clientWithoutLetterVandAfter = clientNoSpaces.Substring(0, indexOfV);

            string mainFolder = "Y:\\1_service\\2_environments\\" + clientWithoutLetterVandAfter + "\\ORD\\";

            string modifiedShortut = "ORD" + version.Replace(" ", "") + "_" + client.Replace(" ", "") + ".lnk";
            string shortcut = mainFolder + modifiedShortut;
            return shortcut;
        }

    }

}