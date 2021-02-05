using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            // şöyle de olur.>>

            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            ICreditManager tasitKrediManager = new TasitKrediManager();
            
            ICreditManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();                       // polimorphism
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
            //    new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() }); // 2 satır üstte file gibi de yapabilirdik böyle de yapabiliriz. !!!!!!!


            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            




        }
    }
}
