using System;

namespace lab1ex5
{
    class Program
    {
        /*Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va afisa in ordine crescatoare cele 2 numere citite de la tastatura. \n");

            Console.WriteLine("x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            var y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                    Console.WriteLine("Ordinea crescatoare: " + y + " " + x);
            }
            else
            {             
                    Console.WriteLine("Ordinea crescatoare: " + x + " " + y );
            }

        }
    }
}
