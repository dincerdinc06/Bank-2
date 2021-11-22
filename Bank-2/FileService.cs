using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class FileService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya aktarıldı.");
        }
    }
}
