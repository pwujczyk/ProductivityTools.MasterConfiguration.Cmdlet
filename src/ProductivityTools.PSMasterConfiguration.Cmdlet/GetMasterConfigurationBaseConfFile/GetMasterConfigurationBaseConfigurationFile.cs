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
    [Cmdlet(VerbsCommon.Get, "MasterConfigurationBaseConfigurationFile")]
    [Description("Cmdlet used to get file which will be used by MasterConfiguration. File can include configuration or can point to other sources like SQL Server")]
    public class GetMasterConfigurationBaseConfigurationFile : PSCmdlet.PSCmdletPT
    {
        public GetMasterConfigurationBaseConfigurationFile()
        {
            this.AddCommand(new GetBaseConfigurationFile(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
