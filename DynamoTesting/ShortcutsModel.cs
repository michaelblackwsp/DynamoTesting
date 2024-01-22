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

        public string createShortcut(string client, string language, string version)
        {
            string shortFormLanguage = null;
            string languageForPath = null;
            string concatenatedVersionShortcut = null;

            if (language == "English")
            {
                languageForPath = "english_software";
                shortFormLanguage = "en";
            }

            if (language == "French")
            {
                languageForPath = "logiciel_francais";
                shortFormLanguage = "fr";
            }
           
            concatenatedVersionShortcut = "c3d_" + version + "_" + shortFormLanguage + "_" + client.ToLower() + ".lnk";
            string shortcut = "W:\\1_service\\2_environments\\" + client + "\\" + languageForPath + "\\" + concatenatedVersionShortcut;
            return shortcut;
        }
    }
}