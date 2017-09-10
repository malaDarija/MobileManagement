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
        //SINGLETON služi da osiguramo da je isključivo jedna instanca klase dostupna kroz život aplikacije
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
        //KRAJ SINGLETON-a

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
