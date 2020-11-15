using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Management.Automation;
using System.Text;
using System.Text.Json;

namespace ProductivityTools.MasterConfiguration.Cmdlet.InitMasterConfiguration
{

    [Cmdlet(VerbsCommon.Set, "MasterConfiguration")]
    [Description("Cmdlet init MasterConfiguration. It set environment variable and create test file")]
    public class SetMasterConfigurationCmdlet : PSCmdlet.PSCmdletPT
    {
        [Parameter(HelpMessage = "By default configuration file is created in user documents. You could provide your own path.", Position = 0)]
        public string Directory { get; set; }

        public SetMasterConfigurationCmdlet() { }

        protected override void ProcessRecord()
        {
            if (string.IsNullOrEmpty(this.Directory))
            {
                this.Directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ProductivityTools.MasterConfiguration");
            }

            WriteVerbose($"Crating directory: {this.Directory} for configuration file");
            System.IO.Directory.CreateDirectory(this.Directory);

            string testConfiguration =
@"{
    ""Key1"": ""Value1"",
}";
            string filePath = Path.Combine(this.Directory, Consts.PsMasterConfigurationFileName);
            if (File.Exists(filePath))
            {
                WriteVerbose($"Configuration file {filePath} exists.");
            }
            else
            {
                WriteVerbose($"Configuration file {filePath} doesn't exist - creating.");
                File.WriteAllText(filePath, testConfiguration);
            }
            string envName = MasterConfiguration.Consts.EnvironmentVariableName;
            WriteVerbose($"Setting up Environment Variable {envName} with value {this.Directory}");
            Environment.SetEnvironmentVariable(envName, this.Directory, EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable(envName, this.Directory, EnvironmentVariableTarget.Process);

            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "MasterConfiguration", EnvironmentVariableTarget.Machine);
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "MasterConfiguration", EnvironmentVariableTarget.Process);
            base.ProcessCommands();
        }
    }
}
