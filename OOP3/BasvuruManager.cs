using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    { // method injection
        public void BasvuruYap(ICreditManager creditManager, List <ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme
            //
            
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler) //bana bir liste ver ve bu listenin türü ICreditManager olsun...
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
