using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Project_5
{
    internal class Program
    {
        public static int Pienin(int eka, int toka, int kolmas)
        {
            int smallest = eka;
            if (eka <= toka && eka <= kolmas)
            {
                smallest = eka;
            }
            else if (toka <= eka && toka <= kolmas)
            {
                smallest = toka;
            }
            else
            {
                smallest = kolmas;
            }
            return smallest;

        }

        public static int Suurin(int eka, int toka, int kolmas)
        {

            int largest = eka;
            if (eka > toka && eka > kolmas)
            {
                largest = eka;
            }
            else if (toka > eka && toka > kolmas)
            {
                largest = toka;
            }
            else
            {
                largest = kolmas;
            }
            return largest;

        }

        public static void Main()
        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            string syote;

            Console.WriteLine("Anna eka luku:");
            syote = Console.ReadLine();
            luku1 = int.Parse(syote);

            Console.WriteLine("Anna toka luku:");
            syote = Console.ReadLine();
            luku2 = int.Parse(syote);

            Console.WriteLine("Anna kolmas luku:");
            syote = Console.ReadLine();
            luku3 = int.Parse(syote);

            pieninLuku = Pienin(luku1, luku2, luku3);
            System.Console.WriteLine(pieninLuku);

            suurinLuku = Suurin(luku1, luku2, luku3);
            System.Console.WriteLine(suurinLuku);

        }

    }

}
