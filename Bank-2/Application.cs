using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class Application
    {
        public void CreditApplication(ICredit credit,ILoggerService loggerService)
        {
            credit.Calculate();
            loggerService.Log();
        }
        public void İnformation(List<ICredit> credits,List<ILoggerService> loggerServices)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

            foreach (var logservice in loggerServices)
            {
                logservice.Log();
            }
        }
    }
}
