using ProductivityTools.MasterConfiguration;
using ProductivityTools.PSMasterConfiguration.Application.Objects;
using System.Collections.Generic;
using System.Linq;

namespace ProductivityTools.PSMasterConfiguration.Application
{
    public static class MasterConfiguration
    {
        private static string ConfigurationFilePath;
        public const string ApplicationName = "PSMasterConfiguration";

        private static MConfiguration MConfiguration = new MConfiguration();

        public static List<PSConfigItem> GetAllConfiguration(string category = null,
            string application = null,
            string value = null,
            string key = null)
        {
            SetDefaultPowershellFileName();
            var r = MConfiguration.GetValues(application, category, value, key).Select(x => new PSConfigItem(x)).ToList();
            return r;
        }

        private static string CurrentDirectory
        {
            get
            {
                var assemblylocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directoryName = System.IO.Path.GetDirectoryName(assemblylocation);
                return directoryName;
            }
        }

        private static string PSConfigurationPath
        {
            get
            {
                string r = string.Format($"{CurrentDirectory}/PSMasterConfiguration.xml");
                return r;
            }
        }

        private static void SetDefaultPowershellFileName()
        {
            if (string.IsNullOrEmpty(MConfiguration.ConfigurationFileName))
            {
                MConfiguration.SetConfigurationFileName(PSConfigurationPath);
            }
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

        public static string GetConfigurationFile()
        {
            return ConfigurationFilePath;
        }

        public static void SetConfiguration(string key, string value, string application, string file, string category)
        {
            // ReplaceCurrentConfigurationPath();
            MConfiguration.SetValue(key, value, application, file, category);
        }
    }
}
