using ProductivityTools.PSMasterConfiguration.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet.SetMasterConfiguration.Commands
{
    public class SetConfiguration : PSCmdlet.PSCommandPT<SetMasterConfiguration>
    {
        protected override bool Condition => true;

        public SetConfiguration(SetMasterConfiguration cmdlet) : base(cmdlet) { }

        protected override void Invoke()
        {
            string application = this.Cmdlet.Application ?? "Powershell";
            string file = this.Cmdlet.File ?? "Powershell";
            MasterConfiguration.SetConfiguration(this.Cmdlet.Key, this.Cmdlet.Value, application, file, this.Cmdlet.Category);
        }
    }
}
