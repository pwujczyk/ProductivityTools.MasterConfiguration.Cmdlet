using ProductivityTools.MasterConfiguration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Application.Objects
{
    public class PSConfigItem
    {
        public string Key;
        public string Value;
        public string Application;
        public string File;
        public string Category;

        public PSConfigItem(ConfigItem config)
        {
            Key = config.Key;
            Value = config.Value;
            Application = config.Application;
            File = config.File;
            Category = config.Category;
        }

        public override string ToString()
        {
            var s = $"${this.Key} ${this.Value}";

            return s;
        }
    }
}
