using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class HouseCredit : ICredit
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Hesaplandı.");
        }
    }
}
