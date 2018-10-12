using ProductivityTools.PSMasterConfiguration.Cmldet.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet
{
    [Cmdlet(VerbsCommon.Get, "MasterConfiguration")]
    public class GetMasterConfiguration : PSCmdlet.PSCmdletPT
    {
        [Parameter(HelpMessage = "It prints whole configuration")]
        public string Category { get; set; }

        [Parameter(HelpMessage = "It prints whole configuration")]
        public string Application { get; set; }

        [Parameter(HelpMessage = "It prints whole configuration")]
        public string File { get; set; }

        [Parameter(HelpMessage = "It prints whole configuration")]
        public string Value { get; set; }

        [Parameter(HelpMessage = "It prints whole configuration")]
        public string Key { get; set; }

        public GetMasterConfiguration()
        {
            this.AddCommand(new GetAllConfiguration(this));
        }

        protected override void ProcessRecord()
        {
            base.ProcessCommands();
        }
    }
}
