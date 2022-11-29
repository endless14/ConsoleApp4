using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)//buraya bütün  dataların tutulduğu baseyi eklersek kimin ne kredisi isteğini aşşada yazarsak
            //problem olmadan isteğmiz işlemi yaparız diğer türlü hepsi 1 tane kredi başvurusu tarafından aynı değerde hesaplanır. 
        {
            //basvuran bilgileri değerlendirme 
            
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }


    }
}
