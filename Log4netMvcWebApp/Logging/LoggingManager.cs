using log4net;
using log4net.Config;
using log4net.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

// @Start Use Apache log4net
namespace Log4netMvcWebApp.Logging
{
    public static class LoggingManager
    {
        /// <summary>
        /// デフォルトのApp.config構成ファイルから設定情報を取得
        /// </summary>
        public static void Init()
        {
            //log4netの設定をApp.configからロードするための設定
            var assembly = null == Assembly.GetEntryAssembly() ? Assembly.GetExecutingAssembly() : Assembly.GetEntryAssembly();
            var fileInfo = new FileInfo( string.Concat(SystemInfo.AssemblyShortName(assembly), ".config"));
            XmlConfigurator.Configure(log4net.LogManager.GetRepository(), fileInfo);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Logger GetLogger()
        {
            try
            {
                const int skipFrames = 1;   //GetLoggerの呼び出し元を取得するため
                return new Logger(new StackFrame(skipFrames).GetMethod().DeclaringType);
            }
            catch
            {
                return new Logger(MethodBase.GetCurrentMethod().DeclaringType);
            }
        }
    }
}
// @End Use Apache log4net