using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * If money is left in a particular bank for more than 5 years, 
 * the interest rate given by the bank is 7.5%, else the interest rate is 5.4%.
 * Write a program that prompt the user for the number of years that the money was left 
 * in the bank and display the appropriate interest rate depending on on the value input. 
 * How many runs should you make to very that it works correctly?
 */

namespace Q3_CompoundInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How much do you want to save in our bank? ");
            double saving = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many years do you want to leave your money in our bank? ");
/* Assumed 5.1 years are rate at 1.075 and 4.9 years are rate at 1.054
 */
            double year = Convert.ToDouble(Console.ReadLine());
            double rate1 = Math.Pow(1.075, year);
            double rate2 = Math.Pow(1.054, year);

            if (year > 5)
            {
                Console.WriteLine($"Your money will be {(saving * rate1):c} after {year} years");
            }
            else
            {
                Console.WriteLine($"Your money will be {(saving * rate2):c} after {year} years");
            }
            Console.ReadLine();
        }
    }
}
