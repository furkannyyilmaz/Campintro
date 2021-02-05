using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : ICreditManager
    {
        void ICreditManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void ICreditManager.Hesapla()
        {
            Console.WriteLine("esnaf kredisi hesaplandı");
        }
    }
}
