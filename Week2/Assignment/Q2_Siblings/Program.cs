using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for the number of siblings his has. 
 * The program should display a message, “I also have 4 siblings” (assuming that the user enters 4).
 */

namespace Q2_Siblings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have? ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"I also have {number} siblings");
            Console.ReadLine();
        }
    }
}
