using Log4netMvcWebApp.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Log4netMvcWebApp.Controllers
{
    public class DefaultController : Controller
    {
        // @Start Use Apache log4net
        /// <summary>
        /// log
        /// </summary>
        private static readonly ILogger logger = LoggingManager.GetLogger();
        // @End Use Apache log4net

        // GET: Default
        public ActionResult Index()
        {
            //@Start Use Apache log4net
            logger.Write(LogLevel.Debug, "Debug Logging test");
            logger.Write(LogLevel.Info, "Info Logging test");
            logger.Write(LogLevel.Warn, "Warn Logging test");
            logger.Write(LogLevel.Error, "Error Logging test");
            logger.Write(LogLevel.Fatal, "Fatal Logging test");
            //@End Use Apache log4net

            return View();
        }
    }
}