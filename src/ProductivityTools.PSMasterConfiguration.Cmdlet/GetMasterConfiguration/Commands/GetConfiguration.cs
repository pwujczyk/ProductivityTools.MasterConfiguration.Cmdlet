using ProductivityTools.PSMasterConfiguration.Application;
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
            Console.Write(System.AppDomain.CurrentDomain);
            var configuration= MasterConfiguration.GetAllConfiguration(
            this.Cmdlet.Category,
            this.Cmdlet.Application,
            this.Cmdlet.File,
            this.Cmdlet.Value,
            this.Cmdlet.Key);

            foreach (var config in configuration)
            {
                if (this.Cmdlet.Object.IsPresent)
                {
                    this.Cmdlet.WriteObject(config);
                }
                else
                {
                    this.Cmdlet.WriteOutput(config.Value);
                }
            }
        }
    }
}
