using ProductivityTools.PSMasterConfiguration.Cmdlet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet
{
    [Cmdlet(VerbsCommon.Set, "MasterConfigurationBaseConfigurationFile")]
    [Description("Cmdlet used to set file which will be used by MasterConfiguration. File can include configuration or can point to other sources like SQL Server")]
    public class SetMasterConfigurationBaseConfigurationFile : PSCmdlet.PSCmdletPT
    {
        [Parameter(
            Position =0,
            HelpMessage = "Sets main configuration file with all basic data")]
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
