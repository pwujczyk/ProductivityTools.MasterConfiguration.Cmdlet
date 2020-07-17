using ProductivityTools.PSMasterConfiguration.Cmdlet.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public class GetConfiguration : PSCmdlet.PSCommandPT<GetMasterConfiguration>
    {
        protected override bool Condition => true;

        public GetConfiguration(GetMasterConfiguration getMasterConfiguration) : base(getMasterConfiguration) { }

        protected override void Invoke()
        {
            var config=MasterConfiguration.GetValue(this.Cmdlet.Key);
            this.Cmdlet.WriteOutput(config);
            
        }
    }
}
