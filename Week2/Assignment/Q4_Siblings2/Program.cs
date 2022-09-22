using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for the number of siblings his has. 
 * The program should display a message, “I have 4 siblings” (assuming that the user enters 3).
 * This question is not the same as question 2.
 */

namespace Q4_Siblings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have? ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = number + 1;
            
            Console.WriteLine($"I have {sum} siblings");
            Console.ReadLine();
        }
    }
}
