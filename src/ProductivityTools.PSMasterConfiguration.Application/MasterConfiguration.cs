using Microsoft.Extensions.Configuration;
using ProductivityTools.MasterConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductivityTools.PSMasterConfiguration.Application
{
    public static class MasterConfiguration
    {
        public static void GetValue(string value)
        {
            var configuration = new ConfigurationBuilder()
                .AddMasterConfiguration("ProductivityTools.PSMasterConfiguration.json",true)
                .Build();
            var settings = configuration["Login"];
          
            Console.WriteLine(settings);
        }
    }
}
