using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netMvcWebApp.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        void Write(LogLevel level, object message);
    }
}
