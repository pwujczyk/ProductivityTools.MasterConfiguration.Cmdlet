using Microsoft.Extensions.Configuration;
using ProductivityTools.MasterConfiguration;
using ProductivityTools.PSMasterConfiguration.Cmdlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public static class MasterConfiguration
    {
        private static IConfigurationRoot Configuration
        {
            get
            {
                
                var configuration = new ConfigurationBuilder()
                    .AddMasterConfiguration(Consts.PsMasterConfigurationFileName, true)
                    .Build();
                return configuration;
            }
        }          

        public static string GetValue(string value)
        { 
            string setting = Configuration[value];
            return setting;
        }

        public static List<IConfigurationSection> GetAllValues()
        {
            IEnumerable<IConfigurationSection> settings = Configuration.GetChildren();
            var result = settings.ToList();
            return result;
        }
    }
}
