using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Logger
{
    public class ConsoleWriter : ILoggerWriter
    {
        public void Write(string msg)
        {
            Console.WriteLine(DateTime.Now.ToString() + " :" + msg);
        }
    }
}
