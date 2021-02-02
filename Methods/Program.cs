using System;

namespace Methods //tekrar tekrar kullanılabilirlik
{
    class Program 
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";
            urun1.stokAdedi = 2;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 8;
            urun2.Aciklama = "diyarbakır karpuzu";
            urun2.stokAdedi = 12;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("------------------------------");



            }

            Console.WriteLine("-------------------------methods-------------------");


            //encapsulation instance (ornek)
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,8);
            sepetManager.Ekle2("elma", "yeşil elma", 42,33);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 62,8);

           

        }
    }
}
