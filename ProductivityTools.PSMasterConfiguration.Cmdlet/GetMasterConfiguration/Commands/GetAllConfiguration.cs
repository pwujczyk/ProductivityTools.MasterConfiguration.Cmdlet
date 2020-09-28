using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Commands
{
    public class GetAllConfiguration : PSCmdlet.PSCommandPT<GetMasterConfiguration>
    {
        public GetAllConfiguration(GetMasterConfiguration cmdletType) : base(cmdletType) { }


        protected override bool Condition => this.Cmdlet.All.IsPresent || string.IsNullOrEmpty(this.Cmdlet.Key);

        protected override void Invoke()
        {
            this.Cmdlet.WriteVerbose("Hello from GetAllMasterConfiguration");
            this.Cmdlet.WriteVerbose($"Getting all values from configuration");
            var config = MasterConfiguration.GetAllValues();
            this.Cmdlet.WriteVerbose($"Value returned from MasterConfiguration {config}");
            this.Cmdlet.WriteObject(config);
        }
    }
}
