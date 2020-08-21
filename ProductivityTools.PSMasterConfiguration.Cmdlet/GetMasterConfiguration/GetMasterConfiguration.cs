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
