using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine("Loggin into file Successfully");
        }
    }
}
