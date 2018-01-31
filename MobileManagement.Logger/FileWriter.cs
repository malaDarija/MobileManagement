using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement.Logger
{
    public class FileWriter : ILoggerWriter
    {
        public void Write(string msg)
        {
            using(StreamWriter sw = new StreamWriter(@"C:\Users\DarijaBalen\Documents\Projekti\MobileManagement\logs.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " :" + msg);
            }
        }
    }
}
