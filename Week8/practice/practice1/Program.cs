using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a C# program that displays a conversion table from gallons to liters. The program should
 * display gallons from 10 to 20 in one-gallon increments and the corresponding liter equivalents.
 * 
 */

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int END = 20, INCREMENT = 1;
            const double GALLONS_TO_LITERS = 3.785;
            int gallon = 10;

            Console.WriteLine("Gallon    Liter");
            for (; gallon <= END;)
            {
                double liter = gallon * GALLONS_TO_LITERS;
                Console.WriteLine($"{gallon,5:F1} {liter,9:F2}");
                gallon += INCREMENT;
            };

            /* WHILE LOOP
             * Console.WriteLine("Gallon    Liter");
            while (gallon <= END)
            {
                double liter = gallon * GALLONS_TO_LITERS;
                Console.WriteLine($"{gallon,5:F1} {liter,9:F2}");
                gallon += INCREMENT;
            };
            */

            /* DO WHILE LOOP
             * Console.WriteLine("Gallon    Liter");
            do
            {
                double liter = gallon * GALLONS_TO_LITERS;
                Console.WriteLine($"{gallon,5:F1} {liter, 9:F2}");
                gallon += INCREMENT;
            }while(gallon <= END);
            */
        }
    }
}
