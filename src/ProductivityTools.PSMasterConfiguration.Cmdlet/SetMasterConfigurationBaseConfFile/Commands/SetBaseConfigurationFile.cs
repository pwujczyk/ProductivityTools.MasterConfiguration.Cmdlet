using ProductivityTools.PSMasterConfiguration.Cmldet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet
{
    public class SetBaseConfigurationFile : PSCmdlet.PSCommandPT<SetMasterConfigurationBaseConfigurationFile>
    {
        protected override bool Condition => !string.IsNullOrEmpty(this.Cmdlet.BaseConfigurationFileName);

        public SetBaseConfigurationFile(SetMasterConfigurationBaseConfigurationFile cmdlet) : base(cmdlet) { }

        protected override void Invoke()
        {
            //MasterConfiguration.SetConfigurationFile(this.Cmdlet.BaseConfigurationFileName);
        }
    }
}
