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
            //string application = Functions.SetPowershellIfNotDefined(this.Cmdlet.Application);
            //string file = Functions.SetPowershellIfNotDefined(this.Cmdlet.File);

            //var configuration= MasterConfiguration.GetAllConfiguration(
            //category: this.Cmdlet.Category,
            //application: application,
            //key: this.Cmdlet.Key);

            //foreach (var config in configuration)
            //{
            //    if (this.Cmdlet.Object.IsPresent)
            //    {
            //        this.Cmdlet.WriteObject(config);
            //    }
            //    else
            //    {
            //        this.Cmdlet.WriteObject(config.Value);
            //    }
            //}
        }
    }
}
