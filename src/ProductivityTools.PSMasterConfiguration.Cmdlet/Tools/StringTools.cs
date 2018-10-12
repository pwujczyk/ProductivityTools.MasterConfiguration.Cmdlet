using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmldet.Tools
{
    static class StringTools
    {
        public static bool NotNullNorEmpty(params string[] @params)
        {
            foreach(string s in @params)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
