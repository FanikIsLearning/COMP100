using System;
using System.Diagnostics.Metrics;

/*
 * Question 5a.
 * 14 Marks.
 *
 * Write a program that displays the pattern show in the 
 * sample executable.
 * 
 * Type of loop-> your favorite (you must use a pair of 
 * nested loops)
 * Hints:
 *  1) Use variables that increments
 *  2) When running the sample, use values between 61 and 
 *     76 for the number of columns, values between 16 and 
 *     21 the number of rows
 *  3) Start with a rectangular array of "X" then figure 
 *     out how to remove the unnecessary "X" to get the 
 *     empty spots/lines
 */

namespace t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INCREMENT = 0.25;
            Console.Write("Enter the value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the END value: ");
            double end = Convert.ToDouble(Console.ReadLine());
            double first, second, y;

            Console.WriteLine($"  x        3x     2x^2     2.0     y");
            for (; x <= end; x += INCREMENT)
            {
                first = 3 * x;
                second = -2 * (x * x);
                y = 2 + first + second;
                Console.WriteLine($"{x,4:F2} {first,8:F2} {second,8:F2} {2,6:F1} {y,8:F3}");
            }
        }
    }
}
