using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that displays a conversion table from Fahrenheit to Celsius. 
 * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment.
 * Thus, instead of the condition checking for a fixed count, the condition checks for the ending 
 * Fahrenheit value. Your table must look professional!
 */

namespace Q8_temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert start value of Fahrenheit: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert end value of Fahrenheit: ");
            double end = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insert increment: ");
            int increment = Convert.ToInt32(Console.ReadLine());    

            Console.Write("Fahrenheit   Celsius  Increment\n");
            Console.Write("----------   -------  ---------\n");
            /*for (; start <= end; start+=increment)
            {
                double c = (start - 32) * 5.0/9;
                
                Console.WriteLine($"{start,6} {c,12:f2} {increment,5}");
            }*/
            while (start <= end)
            {
                double c = (start - 32) * 5.0 / 9;

                Console.WriteLine($"{start,6} {c,12:f2} {increment,5}");
                start += increment;
            }

        }
    }
}
