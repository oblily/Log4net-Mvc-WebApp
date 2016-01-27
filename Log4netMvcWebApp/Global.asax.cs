using Log4netMvcWebApp.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Log4netMvcWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // @Start Use Apache log4net
            LoggingManager.Init();
            // @End Use Apache log4net

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
