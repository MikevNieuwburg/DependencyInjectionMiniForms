using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFormsConsole.Core
{
    internal class ConsoleLogger : IConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG : {message}");
        }
    }
}
