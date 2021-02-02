using System;

namespace Campintro
{
    class Program
    {
        static void Main(string[] args)
        {
           string  kategorietiketi = "kategoriler";
            int ogrencisayisi = 32000;
            double faizorani = 1.45;
            double  dolardun = 7.35;
            double dolarbugun = 7.45;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("artis butonu");
            }
            else if(dolardun < dolarbugun)
            {
                Console.WriteLine("azalis butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }
           
           

            bool sistemegirisyapmismi = true;

            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            } 
            Console.WriteLine(kategorietiketi);
        }
    }
}
