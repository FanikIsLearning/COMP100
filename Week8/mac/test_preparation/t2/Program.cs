using System;
using System.Diagnostics.Metrics;

/*
 * Question 2A.
 * 8 Marks.
 *
 * Write a program that prints multiples of 9 in descending 
 * order on a single line.
 * The program prompts the user for the start value. 
 * 
 * Type of loop-> while
 */

namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an number: ");
            int input = Convert.ToInt32(Console.ReadLine());


            while (input > 0)
            {
                if (input % 9 == 0)
                {
                    Console.Write($"{input} ");
                }
                input--;
            }

        }
    }
}
