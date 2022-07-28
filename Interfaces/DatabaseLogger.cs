using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Veritabanına log yazar. ");
        }    }
}
