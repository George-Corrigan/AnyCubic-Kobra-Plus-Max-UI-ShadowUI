using System;

namespace Web.ShadowUI
{
    public class Cultures
    {

        public static string VersionNumber = "v20220510, ShadowUI v1.0";

        public static string CheckCultureText(string cultureName, string cultureText)
        {
            System.Collections.Generic.Dictionary<string, string> replaces = null;

            if (cultureText.Equals("UIVersionNumber", StringComparison.CurrentCultureIgnoreCase))
            {
                if ((cultureName.Equals("de-DE", StringComparison.CurrentCultureIgnoreCase)) &&
                    (VersionNumber.EndsWith("v1.0", StringComparison.CurrentCultureIgnoreCase))
                    )
                {
                    return VersionNumber += ".1";
                }
                return VersionNumber;
            }

            if (cultureName.Equals("de-DE", StringComparison.CurrentCultureIgnoreCase)) // German
            {
                replaces = new System.Collections.Generic.Dictionary<string, string>(new System.Collections.Generic.KeyValuePair<string, string>[]
                {
                    new System.Collections.Generic.KeyValuePair<string, string>("Druckgeschwindigkeit", "Druck\u200Bgeschwindigkeit"), // Wrap Issues
                    new System.Collections.Generic.KeyValuePair<string, string>("Lüftergeschwindigkeit", "Lüfter\u200Bgeschwindigkeit"), // Wrap Issues
                    new System.Collections.Generic.KeyValuePair<string, string>("Düsentemperatur", "Düsen\u200Btemperatur"), // Wrap Issues
                    new System.Collections.Generic.KeyValuePair<string, string>("Heizbetttemperatur", "Heizbett\u200Btemperatur"), // Wrap Issues
                });
            }

            if (cultureName.Equals("zh-Hans", StringComparison.CurrentCultureIgnoreCase)) // Chinese
            {
                replaces = new System.Collections.Generic.Dictionary<string, string>(new System.Collections.Generic.KeyValuePair<string, string>[]
                {
                     new System.Collections.Generic.KeyValuePair<string, string>("1个", "1"),
                     new System.Collections.Generic.KeyValuePair<string, string>("2个", "2"),
                     new System.Collections.Generic.KeyValuePair<string, string>("3个", "3"),
                     new System.Collections.Generic.KeyValuePair<string, string>("4个", "4"),
                     new System.Collections.Generic.KeyValuePair<string, string>("5个", "5"),
                     new System.Collections.Generic.KeyValuePair<string, string>("6个", "6"),
                     new System.Collections.Generic.KeyValuePair<string, string>("8个", "8")
                     //new System.Collections.Generic.KeyValuePair<string, string>("0", "零"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("1个", "一"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("2个", "二"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("3个", "三"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("4个", "四"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("5个", "五"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("6个", "六"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("7", "七"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("8个", "八"),
                     //new System.Collections.Generic.KeyValuePair<string, string>("9", "九")
                });
            }

            if ((replaces != null) && (replaces.Count > 0) && (replaces.ContainsKey(cultureText)))
            {
                cultureText = replaces[cultureText];
            }
            return cultureText;
        }

        public static Tuple<string, string, int>[] List()
        {
            return new Tuple<string, string, int>[]
            {
                // Title, Culture, FontSizeOffset
                new Tuple<string, string, int>("Chinese", "zh-Hans", 2),
                new Tuple<string, string, int>("Dutch", "nl-NL", 0),
                new Tuple<string, string, int>("English", "en", 0),
                new Tuple<string, string, int>("French", "fr", 0),
                new Tuple<string, string, int>("German", "de-DE", 0),
                new Tuple<string, string, int>("Italian", "it", 0),
                new Tuple<string, string, int>("Spanish", "es", 0),
                new Tuple<string, string, int>("Thai", "th-TH", 2)
            };
        }

        public static System.Collections.Generic.List<System.Globalization.CultureInfo> SupportedCultures()
        {
            System.Collections.Generic.List<System.Globalization.CultureInfo> cultureInfos = new System.Collections.Generic.List<System.Globalization.CultureInfo>();
            foreach (Tuple<string, string, int> listItem in Cultures.List())
            {
                cultureInfos.Add(new System.Globalization.CultureInfo(listItem.Item2));
            }
            return cultureInfos;
        }

        public static string DefaultCulture
        {
            get
            {
                return "en";
            }
        }

    }
}
