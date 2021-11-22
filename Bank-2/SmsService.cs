using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class SmsService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı.");
        }
    }
}
