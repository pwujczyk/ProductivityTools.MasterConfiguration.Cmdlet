using ProductivityTools.PSMasterConfiguration.Cmdlet.SetMasterConfiguration.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet.SetMasterConfiguration
{
    [Cmdlet(VerbsCommon.Set, "MasterConfiguration")]
    [Description("Set configuration for given key.")]
    public class SetMasterConfiguration : PSCmdlet.PSCmdletPT
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            HelpMessage = "Key under which configuration will be written to the configuration source")]
        public string Key { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            HelpMessage = "Value which will be written for given key")]
        public string Value { get; set; }

        [Parameter(HelpMessage = "Application which is connected to the key and value")]
        public string Application { get; set; }

        [Parameter(HelpMessage = "Every application can have different files configuration like dev and prod")]
        public string File { get; set; }

        [Parameter(HelpMessage = "Category for item, just for organization purpose")]
        public string Category { get; set; }

        public SetMasterConfiguration()
        {
            this.AddCommand(new SetConfiguration(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
