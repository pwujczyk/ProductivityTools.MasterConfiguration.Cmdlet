using Microsoft.Extensions.Configuration;
using ProductivityTools.MasterConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public static class MasterConfiguration
    {
        public static string GetValue(string value)
        {
            var configuration = new ConfigurationBuilder()
                .AddMasterConfiguration("ProductivityTools.PSMasterConfiguration.json", true)
                .Build();
            string setting = configuration[value];
            return setting;
        }
    }
}
