using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet.Extensions
{
    internal static class Functions
    {
        internal static string SetPowershellIfNotDefined(string s)
        {
            string r = s ?? "Powershell";
            return r;
        }
    }
}
