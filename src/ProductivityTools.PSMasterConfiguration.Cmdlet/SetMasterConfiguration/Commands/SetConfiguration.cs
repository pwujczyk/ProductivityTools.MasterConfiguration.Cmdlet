using ProductivityTools.PSMasterConfiguration.Cmdlet.Extensions;
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
           // string application = Functions.SetPowershellIfNotDefined(this.Cmdlet.Application);
           // string file = Functions.SetPowershellIfNotDefined(this.Cmdlet.File);
           // MasterConfiguration.SetConfiguration(this.Cmdlet.Key, this.Cmdlet.Value, application, file, this.Cmdlet.Category);
        }
    }
}
