using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<int, string> pazarListesi = new Dictonary<int, string>();

            pazarListesi.Add(1, "Elma");
            pazarListesi.Add(2, "Muz");
            pazarListesi.Add(3, "Kivi");
            pazarListesi.Add(4, "Şeftali");
            pazarListesi.Add(5, "Karpuz");
            pazarListesi.Add(6, "Erik");

            Console.WriteLine(pazarListesi.Count);
        }
    }
}
