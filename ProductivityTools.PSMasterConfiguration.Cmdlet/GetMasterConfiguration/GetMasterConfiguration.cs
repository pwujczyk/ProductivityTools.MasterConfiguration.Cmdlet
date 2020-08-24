using ProductivityTools.PSMasterConfiguration.Cmdlet;
using ProductivityTools.PSMasterConfiguration.Cmldet.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet
{
    [Cmdlet(VerbsCommon.Get, "MasterConfiguration")]
    [Description("Cmdlet receives configuration from configuration source")]
    public class GetMasterConfiguration : PSCmdlet.PSCmdletPT
    {
        [Parameter(HelpMessage = "It receives config value for given key", Position = 0)]
        public string Key { get; set; }

        [Parameter(HelpMessage = "It will print whole configuration in the ProductivityTools.PSMasterConfiguration.json")]
        public SwitchParameter All { get; set; }

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
