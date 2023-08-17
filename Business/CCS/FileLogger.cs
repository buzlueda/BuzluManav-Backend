using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.CCS
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Dosyaya loglandı.");
        }
    }
}