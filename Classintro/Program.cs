using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "furkan";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "enes Demirog";
            kurs2.izlenmeOrani = 58;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "flutter";
            kurs3.Egitmen = "saban Demirog";
            kurs3.izlenmeOrani = 48;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "yapay zeka kursu";
            kurs4.Egitmen = "furkan yilmaz";
            kurs4.izlenmeOrani = 222;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs2.Egitmen + " " + kurs3.izlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }

            public string Egitmen { get; set; }

            public int izlenmeOrani { get; set; }
        }
    }
}

