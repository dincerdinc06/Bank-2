using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_2
{
    class PersonelCredit : ICredit
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı.");
        }
    }
}
