using ProductivityTools.PSMasterConfiguration.Application;
using ProductivityTools.PSMasterConfiguration.Cmldet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet
{
    public class GetBaseConfigurationFile : PSCmdlet.PSCommandPT<GetMasterConfigurationBaseConfigurationFile>
    {
        protected override bool Condition => true;

        public GetBaseConfigurationFile(GetMasterConfigurationBaseConfigurationFile cmdlet) : base(cmdlet) { }

        protected override void Invoke()
        {
            string s=MasterConfiguration.GetConfigurationFile();

            this.Cmdlet.WriteObject(s);
        }
    }
}
