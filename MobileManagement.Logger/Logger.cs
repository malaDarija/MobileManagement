using MobileManagement.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Logging
{
    public class Logger
    {

        private static Logger _instance;

        public static Logger Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }   
                return _instance;
            }
        }

        private Logger()
        {

        }

        public void LogInfo(string msg)
        {
            var msgToLog = "Info: " + msg;
            WriterFactory.GetLoggerWriter().Write(msgToLog);
        }
        public void LogWarning(string msg)
        {
            var msgToLog = "Warn: " + msg;
            WriterFactory.GetLoggerWriter().Write(msgToLog);
        }

        public void LogError(string msg)
        {
            var msgToLog = "Err: " + msg;
            WriterFactory.GetLoggerWriter().Write(msgToLog);
        }
    }
}
