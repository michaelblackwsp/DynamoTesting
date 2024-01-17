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
        public string getShortcut(string client, string language, string version)
        {
            string shortcut = null;

            if (client == "CofC" && language == "English" && version == "2022")
            {
                shortcut = ("W:\\1_service\\2_environments\\CofC\\english_software\\c3d_2022_en_cofc.lnk");
            }
            else if (client == "MTQ" && language == "French" && version == "2020")
            { 
                shortcut = ("W:\\1_service\\2_environments\\MTQ\\logiciel_francais\\c3d_2020_fr_mtq.lnk");
            }

            return shortcut;
        }


    }
}




//shortcutMappings["CofC"]["English"]["2022"] = "W:\\1_service\\2_environments\\MTQ\\logiciel_francais\\c3d_2020_fr_mtq.lnk";
//shortcutMappings["MTQ"]["French"]["2020"] = "W:\\1_service\\2_environments\\CofC\\english_software\\c3d_2022_en_cofc.lnk";