using System;
using System.Diagnostics.Metrics;

/*
 * Question 4
 * Write a program that displays the table show in the 
 * sample executable.
 * 
 * the relationship is given by the quadratic equation
 *             y = 2  + 3x - 2x^2
 *    
 * Type of loop-> your favorite (you MUST use a loop)
 * Hints:
 *  1) Generate the first column of all the rows using a
 *     Console.WriteLine() statement and a single expression 
 *     (use increment = 0.25)
 *  2) Generate successive columns one at a time by adding 
 *     another expression
 *  3) Format using a column specifier (do not use tabs)
 */

namespace t4
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
            for (; x<=end ; x+=INCREMENT)
            {
                first = 3 * x;
                second = -2 * (x * x);
                y = 2 + first + second;
                Console.WriteLine($"{x,4:F2} {first,8:F2} {second,8:F2} {2,6:F1} {y,8:F3}");
            }
        }
    }
}
