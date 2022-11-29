using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   //IkrediManager DE Yazabiliriz  base ora
            IKrediManager konutKrediManager = new KonutKrediManager();
            //burda değiştirmesek bile bozulmasz 
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            


            ILoggerService fileService = new FileBaseLoggerService();
            ILoggerService dataBaseLogger = new DataBaseLoggerService();
            ILoggerService smsLogger = new SmsLogger();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisi(), smsLogger);
            //kimin kreidisni göndermek istersen () icine yazıp gönderebiliriz. 


            //list yaparsak isteğimiz kadar secebilirzzzzzzzzzzz
            List<IKrediManager> krediler = new List<IKrediManager>(){ıhtiyacKrediManager,tasitKrediManager,konutKrediManager};
            
              //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



            
            


        }
    }
}
