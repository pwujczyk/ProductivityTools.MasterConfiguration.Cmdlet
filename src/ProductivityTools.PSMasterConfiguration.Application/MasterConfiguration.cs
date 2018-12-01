using ProductivityTools.MasterConfiguration;
using ProductivityTools.MasterConfiguration.Models;
using ProductivityTools.PSMasterConfiguration.Application.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Application
{
    public static class MasterConfiguration
    {
        private static string ConfigurationFilePath;

        private static MConfiguration MConfiguration = new MConfiguration();

        public static List<PSConfigItem> GetAllConfiguration(string category = null, string application = null, string file = null, string value = null, string key = null)
        {
            //ReplaceCurrentConfigurationPath();
            var r = MConfiguration.GetValues(application, category , value, key).Select(x => new PSConfigItem(x)).ToList() ;
            return r;
        }

        //Powershell loads all modules to one app domain
        private static void ReplaceCurrentConfigurationPath()
        {
            MConfiguration.SetConfigurationFileName(ConfigurationFilePath);
        }
        public static void SetConfigurationFile(string file)
        {
            ConfigurationFilePath = file;
            ReplaceCurrentConfigurationPath();
        }

        public static void SetConfiguration(string key, string value, string application, string file, string category)
        {
            ReplaceCurrentConfigurationPath();
            MConfiguration.SetValue(key, value, application, file, category);
        }
    }
}
