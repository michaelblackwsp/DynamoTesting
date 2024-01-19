using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamoTesting
{
    public class ShortcutsModel
    {
        public static string[] clientOptions = { "BCMoT", "CofC", "DND", "MTQ", "MVRD", "MX", "VDG", "VDM", "VDQ", "VIA", "WSP_EN", "WSP_FR" };
        public static string[] languageOptions = { "English", "French" };
        public static string[] versionOptions = { "2018", "2019", "2020", "2021", "2022", "2023" };

        public string getShortcut(string client, string language, string version)
        {
            string shortcut = client + language + version;















/*            if (client == "CofC" && language == "English" && version == "2022")
            {
                shortcut = @"W:\1_service\2_environments\CofC\english_software\c3d_2022_en_cofc.lnk";
            }
            else if (client == "MTQ" && language == "French" && version == "2020")
            {
                shortcut = @"W:\1_service\2_environments\MTQ\logiciel_francais\c3d_2020_fr_mtq.lnk";
            }*/

            
            Console.WriteLine(shortcut);
            return shortcut;
        }

    }
}




//shortcutMappings["CofC"]["English"]["2022"] = "W:\\1_service\\2_environments\\MTQ\\logiciel_francais\\c3d_2020_fr_mtq.lnk";
//shortcutMappings["MTQ"]["French"]["2020"] = "W:\\1_service\\2_environments\\CofC\\english_software\\c3d_2022_en_cofc.lnk";