using System;
using System.Collections.Generic;

namespace Bank_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICredit carcredit = new CarCredit();
            ICredit housecredit = new HouseCredit();
            ICredit personelcredit = new PersonelCredit();

            ILoggerService loggerService1 = new DatabaseService();
            ILoggerService loggerService2 = new SmsService();
            ILoggerService loggerService3 = new FileService();

            Application application = new Application();
            //application.CreditApplication(carcredit,loggerService3);

            List<ICredit> credits = new List<ICredit>() {carcredit,housecredit,personelcredit};
            application.İnformation(credits,new List<ILoggerService> { loggerService1, loggerService2 });


            Console.ReadKey();
        }
    }
}
