using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Logger
{
    public class WriterFactory
    {
        public static ILoggerWriter GetLoggerWriter()
        {
            var writer = ConfigurationManager.AppSettings["LoggerWriterImpl"];
            switch (writer)
            {
                case "Console":
                    return new ConsoleWriter();
                default:
                    return new ConsoleWriter();
            }
        }
    }
}
