using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class DatabaseService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına aktarıldı.");
        }
    }
}
