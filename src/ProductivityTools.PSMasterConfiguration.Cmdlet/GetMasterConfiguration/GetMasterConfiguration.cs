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
        [Parameter(HelpMessage = "It prints configuration for given category")]
        public string Category { get; set; }

        [Parameter(HelpMessage = "It prints configuration for given application")]
        public string Application { get; set; }

        [Parameter(HelpMessage = "It prints configuration for given file")]
        public string File { get; set; }

        [Parameter(HelpMessage = "It receives config value for given key", Position = 0)]
        public string Key { get; set; }

        [Parameter(HelpMessage = "It prints configuration as objects")]
        public SwitchParameter Object { get; set; }

        public GetMasterConfiguration()
        {
            this.AddCommand(new GetConfiguration(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
