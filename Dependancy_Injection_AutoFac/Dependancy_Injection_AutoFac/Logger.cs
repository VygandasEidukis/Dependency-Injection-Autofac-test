using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection_AutoFac
{
    public class Logger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
