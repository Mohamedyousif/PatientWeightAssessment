using System;

namespace RavenDBHelper.Helpers
{
    public class ConfigHelper
    {
        public static string GetConfigValue(string key)
        {
            return (string)Convert.ChangeType(System.Configuration.ConfigurationManager.AppSettings[key],
                                  typeof(string));
        }
    }
}
