using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log4netMvcWebApp.Logging
{
    public class Logger : ILogger {
        /// <summary>
        /// 
        /// </summary>
        private ILog logger = null;

        /// <summary>
        /// 
        /// </summary>
        private Logger() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        public Logger(Type type)
        {
            logger = log4net.LogManager.GetLogger(type);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        public void Write(LogLevel level, object message)
        {
            switch(level)
            {
                case LogLevel.Debug:
                    logger.Debug(message);
                    break;
                case LogLevel.Info:
                    logger.Info(message);
                    break;
                case LogLevel.Warn:
                    logger.Warn(message);
                    break;
                case LogLevel.Error:
                    logger.Error(message);
                    break;
                case LogLevel.Fatal:
                    logger.Fatal(message);
                    break;
            }
            //ほかのやり方2
            //new Dictionary<LogLevel, WriteDelegate1>() { 
            //{ LogLevel.Fatal, (logger, message) => { logger.Fatal(message); } },
            //{ LogLevel.Error, (logger, message) => { logger.Error(message); } },
            //{ LogLevel.Warn, (logger, message) => { logger.Warn(message); } },
            //{ LogLevel.Info, (logger, message) => { logger.Info(message); } },
            //{ LogLevel.Debug, (logger, message) => { logger.Debug(message); } },
            //};
        }
    }
}