using System;

namespace Demo1_t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ika: ");
            string stringIka = Console.ReadLine();
            ika = Convert.ToInt32(stringIka);

            Console.WriteLine(stringIka + stringIka);
            Console.WriteLine(ika + ika);

            
        }
    }
}
