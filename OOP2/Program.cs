using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "furkan";
            musteri1.Soyadi = "yılmaz";
            musteri1.TcNo = "123123123";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "323232";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "4545";

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri2);





        }
    }
}
