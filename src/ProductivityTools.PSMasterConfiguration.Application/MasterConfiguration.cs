using Microsoft.Extensions.Configuration;
using ProductivityTools.MasterConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductivityTools.PSMasterConfiguration.Application
{
    public static class MasterConfiguration
    {
        public static void Config()
        {
            Console.WriteLine("Hello World!");
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (String.IsNullOrWhiteSpace(environment))
                throw new ArgumentNullException("Environment not found in ASPNETCORE_ENVIRONMENT");

            Console.WriteLine("Environment: {0}", environment);

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{environment}.json", true, true)
                .AddMasterConfiguration(true)
                .Build();
            var settings = configuration["Login"];
          
            Console.WriteLine(settings);
        }
    }
}
