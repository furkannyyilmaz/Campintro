using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "c# kursu";
            string kurs2 = "algoritma kursu";
            string kurs3 = "java kursu";
            string kurs4 = "python kursu";

            string[] kurslar = new string[] { "c# kursu", "algoritma kursu", "java kursu","python kursu","c++ kursu"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("------------------------------------------");

            foreach (string kurs in kurslar) // kursları tek tek dolas.
            {
                Console.WriteLine(kurs);
            }
        }
    }
}  