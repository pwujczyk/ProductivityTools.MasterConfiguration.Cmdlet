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
        protected override bool Condition => !string.IsNullOrEmpty(this.Cmdlet.Key) && !this.Cmdlet.All.IsPresent;

        public GetConfiguration(GetMasterConfiguration getMasterConfiguration) : base(getMasterConfiguration) { }

        protected override void Invoke()
        {
            this.Cmdlet.WriteVerbose("Hello from GetPSMasterConfiguration");
            this.Cmdlet.WriteVerbose($"Getting value from configuration using key {this.Cmdlet.Key}");
            var config = MasterConfiguration.GetValue(this.Cmdlet.Key);
            if (string.IsNullOrEmpty(config) && this.Cmdlet.Silent.IsPresent == false)
            {
                throw new Exception($"Missing configuration item with the key {this.Cmdlet.Key}");
            }
            this.Cmdlet.WriteVerbose($"Value returned from MasterConfiguration {config}");
            this.Cmdlet.WriteObject(config);
        }
    }
}


