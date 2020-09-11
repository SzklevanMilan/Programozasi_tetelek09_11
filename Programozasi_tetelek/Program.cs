using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programozasi_tetelek
{
   class Program
    {
        static int[] tomb = new int[10] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50};
        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ",");
            }
            Console.WriteLine();
        }
         static void Osszegzes()
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                s = s + tomb[i];
            }
            Console.WriteLine("A tömb összege: {0}.", s);
        }
         static void Megszamolas()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("{0}db szám osztható 3-al a tömbben.", db);
        }
         static void Eldontes()
        {
            //bool igaz = true;
            int i = 0;
            while (i < tomb.Length && tomb[i] != 69)
            {
                //igaz = true;
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 69-es szám.");
            }
            else
            {
                Console.WriteLine("Nincs 69-es szám");
            }
        }

         static void Kivalasztas()
        {
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("Az 50 a(z) {0} helyen van.", i+1);
        }

        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamolas();
            Eldontes();
            Kivalasztas();
            Kereses();
            Console.ReadKey();
        }

        private static void Kereses()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 50 a tömbbe és a {0}. elem",i+1);
            }
            else
            {
                Console.WriteLine("Sajnos nincs a tömbbe.");
            }
        }
    }
}
