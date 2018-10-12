using ProductivityTools.MasterConfiguration;
using ProductivityTools.MasterConfiguration.Models;
using ProductivityTools.PSMasterConfiguration.Application.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Application
{
    public class MasterConfiguration
    {
        public List<PSConfigItem> GetAllConfiguration(string category = null, string application = null, string file = null, string value = null, string key = null)
        {
            var r = MConfiguration.GetValues(category, application, file, value, key).Select(x => new PSConfigItem(x)).ToList() ;
            return r;
        }
    }
}
