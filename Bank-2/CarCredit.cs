using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class CarCredit : ICredit
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Hesaplandı.");
        }
    }
}
