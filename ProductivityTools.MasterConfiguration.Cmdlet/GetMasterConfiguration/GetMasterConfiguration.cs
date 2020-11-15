using ProductivityTools.MasterConfiguration.Cmdlet;
using ProductivityTools.MasterConfiguration.Cmldet.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.MasterConfiguration.Cmldet
{
    [Cmdlet(VerbsCommon.Get, "MasterConfiguration")]
    [Description("Cmdlet receives configuration from configuration source")]
    public class GetMasterConfiguration : PSCmdlet.PSCmdletPT
    {
        [Parameter(HelpMessage = "It receives config value for given key", Position = 0)]
        public string Key { get; set; }

        [Parameter(HelpMessage = "It will print whole configuration in the ProductivityTools.MasterConfiguration.json")]
        public SwitchParameter All { get; set; }

        [Parameter(HelpMessage = "It doesn't throw exception if key doesn't exist. It returns null")]
        public SwitchParameter Silent{ get; set; }

        public GetMasterConfiguration() { }

        protected override void BeginProcessing()
        {
            this.AddCommand(new GetConfiguration(this));
            this.AddCommand(new GetAllConfiguration(this));
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
