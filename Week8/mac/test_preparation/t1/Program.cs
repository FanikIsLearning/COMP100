using System;
using System.Diagnostics.Metrics;

/*
 * Question 1C.
 * 10 Marks.
 *
 * Write a program that adds the user input to reach a target. When the sum reaches or just exceeds the target, 
 * the program prints the final sum and the number of user 
 * inputs required.
 * 
 * Type of loop-> do-while
 */

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, users = 0;
            bool stop = true;

            Console.Write("Enter the target number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (sum >= end)
                {
                    Console.WriteLine($"The target number is {end}, final sum is { sum } and number of users are { users }.");
                    stop = false;
                }
                else
                {
                    Console.Write("Enter an input: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    sum += input;
                    users++;
                }
            } while (stop) ;
        }
    }
}
