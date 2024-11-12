using System;

namespace uppgift_3._4
{
    class Program
    {
        static void Main()
        {
            // Låtens längd i minuter och sekunder
            Console.Write("Ange låtens längd i minuter: ");
            int minuter = int.Parse(Console.ReadLine());

            Console.Write("Ange låtens längd i sekunder: ");
            int sekunder = int.Parse(Console.ReadLine());

            if ((minuter == 2 && sekunder >= 45) || (minuter > 2 && minuter < 4) || (minuter == 4 && sekunder <= 20))
            {
                Console.WriteLine("Låten får spelas på radiostationen.");
            }
            else
            {
                Console.WriteLine("Låten får inte spelas på radiostationen.");
            }
        }
    }
}