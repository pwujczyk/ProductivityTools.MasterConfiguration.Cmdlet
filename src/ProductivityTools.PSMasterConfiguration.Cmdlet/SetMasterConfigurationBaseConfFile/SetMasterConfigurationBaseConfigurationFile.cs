using ProductivityTools.PSMasterConfiguration.Cmdlet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet
{
    [Cmdlet(VerbsCommon.Set, "MasterConfigurationBaseConfigurationFile")]
    public class SetMasterConfigurationBaseConfigurationFile : PSCmdlet.PSCmdletPT
    {
        [Parameter(HelpMessage = "Sets main configuration file with all basic data")]
        public string BaseConfigurationFileName { get; set; }

        public SetMasterConfigurationBaseConfigurationFile()
        {
            this.AddCommand(new SetBaseConfigurationFile(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
