using ProductivityTools.PSMasterConfiguration.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public class GetAllConfiguration : PSCmdlet.PSCommandPT<GetMasterConfiguration>
    {
        protected override bool Condition => true;

        public GetAllConfiguration(GetMasterConfiguration getMasterConfiguration) : base(getMasterConfiguration) { }

        protected override void Invoke()
        {
            MasterConfiguration m = new MasterConfiguration();
            var configuration=m.GetAllConfiguration(
            this.Cmdlet.Category,
            this.Cmdlet.Application,
            this.Cmdlet.File,
            this.Cmdlet.Value,
            this.Cmdlet.Key);

            foreach (var config in configuration)
            {
                this.Cmdlet.WriteObject(config);
            }
        }
    }
}
