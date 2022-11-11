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
            int sum = 0, count=0;
            Console.Write("Enter the target number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; ; i+=2)
            {
                if (i >= end && sum >=end)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have to add {count} even to reach to the sum {sum}.");
                    break;
                }
                else
                {
                    sum += i;
                    count++;
                    Console.Write($"{i} + ");
                }
            }
        }
    }
}
