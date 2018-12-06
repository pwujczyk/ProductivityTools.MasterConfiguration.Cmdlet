using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.PSMasterConfiguration.Cmdlet.Exceptions
{
    public class BaseConfigurationFileNotSet : Exception
    {

        private static string Mesage = "Please setup application name using MConfiguration.SetApplicationName(applicationName);";

        private static Func<string, string> exception = (message) => string.IsNullOrEmpty(message) ? Mesage : message;

        public BaseConfigurationFileNotSet() : base(message: Mesage)
        {
        }

        public BaseConfigurationFileNotSet(string message) : base(exception(message))
        {
        }

        public BaseConfigurationFileNotSet(string message, Exception innerException) : base(exception(message), innerException)
        {
        }

        protected BaseConfigurationFileNotSet(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
