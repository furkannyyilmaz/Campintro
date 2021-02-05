using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> names = new MyDictionary.MyDictionary<string, string>();

            names.Add("Honda civic", "2008");
            names.Add("citroen c5", "2012");
            names.Add("Alfa Romeo", "2006");


            names.List();
            
        }
    }
}
