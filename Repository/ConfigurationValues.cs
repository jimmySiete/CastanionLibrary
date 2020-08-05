using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastanionLibrary.Repository
{
    public class ConfigurationValues
    {
        public static String GetValuesFromConfig(String Key)
        {
            return ConfigurationManager.AppSettings[Key] != null? ConfigurationManager.AppSettings[Key].ToString() : String.Empty;
        }
    }
}
