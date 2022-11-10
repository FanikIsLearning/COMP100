using System;
using System.Diagnostics.Metrics;

/*
 * Question 3D.
 * 10 Marks.
 *
 * Write a program that adds evens starting from 2, 4 ... 
 * to reach a target. When the target is reached or just 
 * exceeded, the program prints the even numbers as well as
 * the sum it took to reach or exceed the target
 * 
 * Type of loop-> for
 */

namespace t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter the target number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; ; i+=2)
            {
                if (i > end)
                {
                    Console.WriteLine($"The target number is {end}, final sum is {sum}.");
                    break;
                }
                else
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
