using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BaskaBisiyap()
        {
            throw new NotImplementedException();
        }
        public void Hesapla()
        {
            Console.WriteLine("İHTİYAC kredisi ödeme planı hesaplandı");
        }
    }
}
