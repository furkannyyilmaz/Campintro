using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : ILoggerService
    {
        void ILoggerService.Log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
