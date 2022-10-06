using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console-based program that prompts the user for an hourly pay rate. 
 * If the value entered is less than $7.50, display an error message
 */


namespace Q1_Rate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your hourly pay rate? ");
            double rate = Convert.ToDouble(Console.ReadLine());

            if (rate < 7.5)
            {
                Console.WriteLine("Sorry you have enter an invalid rate.");
            }
            else
            {
                Console.WriteLine($"Your weekly rate will be {rate:c}");
            }

            Console.ReadLine();
        }
    }
}
