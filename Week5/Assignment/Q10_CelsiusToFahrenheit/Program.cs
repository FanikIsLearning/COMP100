using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  A conversion table of Celsius to Fahrenheit temperature. The table must start with 100  
 *  Celsius and end at 0 Celsius with decrements of 10. (Fahrenheit = 9/5 * Celsius + 
 *  32). Your table must have a suitable header and the values in the table must be right-align 
 *  like the output of question 11.
 */

namespace Q10_CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = 101, stop = 0, f = 0;
            Console.Write($"{"Celsius", -10} {"Fahrenheit", -10}\n");
            Console.Write($"{"-------",-10} {"----------",-10}\n"); ;
            do
            {
                start--;
                f = (9 / 5) * start + 32;
                Console.WriteLine($"{start,-10} {f, -10}\n");
            } while (start > stop);
        }
    }
}
