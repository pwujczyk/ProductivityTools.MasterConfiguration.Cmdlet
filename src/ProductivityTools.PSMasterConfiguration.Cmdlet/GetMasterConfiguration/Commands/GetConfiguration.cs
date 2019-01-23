using ProductivityTools.PSMasterConfiguration.Application;
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
         //   string application = Functions.SetPowershellIfNotDefined(this.Cmdlet.Application);
           // string file = Functions.SetPowershellIfNotDefined(this.Cmdlet.File);

         
            var configuration= MasterConfiguration.GetValues(
            category: this.Cmdlet.Category,
            application: this.Cmdlet.Application,
            key: this.Cmdlet.Key);

            if (!string.IsNullOrEmpty(this.Cmdlet.Key) && this.Cmdlet.Object.IsPresent == false)
            {
                this.Cmdlet.WriteObject(configuration.Select(x=>x.Value));
            }
            else
            {
                this.Cmdlet.WriteObject(configuration);
            }

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
