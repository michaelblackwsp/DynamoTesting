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
        //
        #endregion


        public string BuildOpenRoadsEnvironmentShortcut(string client, string version, string language)
        {
            string shortcut = "";
            return shortcut;
        }

    }

    // Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Bentley\OpenRoadsDesigner\{359F376F-B120-3DD3-BC30-56D5687B766D}

    // POWERSHELL TO GET USER'S EMAIL
    // $searcher = [adsisearcher]"(samaccountname=$env:USERNAME)"
    //$searcher.FindOne().Properties.mail

    // TO DO: Make the application only run if a WSP account is logged in / recognized
    // The one-stop shop for all your production needs!

}