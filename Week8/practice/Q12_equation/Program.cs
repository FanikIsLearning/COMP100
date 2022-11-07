using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 14	Write a program to compute the (x, y) pairs for the equation y = x4 –5x2 - 4 for x in the range -2.5 to 2.5 in 0.5 increments.
  x      x4       -5x2    4.0      y
-2.5   39.0625  -31.25   4.0    11.8125
-2.0   16.0000  -20.00   4.0     0.0
-1.5    5.0625  -11.25   4.0    -2.1875
-1.0    1.0000   -5.00   4.0     0.0
*/

namespace Q14_equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INCREMENT = 0.5, END = 2.5;
            double x = -2.5, first, second, y;
            Console.WriteLine($"  x      x4       -5x2    4.0      y");
            while ( x <= END )
            {
                first = x * x * x * x;
                second = -5 * x * x;
                y = first + second + 4;
                Console.WriteLine($"{x,4:F1} {first,10:F4} {second,8:F2} {4,4:F1} {y,8:F4}");
                x += INCREMENT;
            }
        }
    }
}
