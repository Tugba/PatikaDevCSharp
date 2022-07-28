using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}
