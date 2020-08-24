using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public class GetAllConfiguration : PSCmdlet.PSCommandPT<GetMasterConfiguration>
    {
        public GetAllConfiguration(GetMasterConfiguration cmdletType) : base(cmdletType)
        {
        }

        protected override bool Condition => this.Cmdlet.All.IsPresent;

        protected override void Invoke()
        {
            throw new NotImplementedException();
        }
    }
}
