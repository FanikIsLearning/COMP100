using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*y = 3x^2 - 7x + 2*/

namespace _4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INCREMENT = 1.0/3;

            double x = 0, end = 2;

            double first, second, y;

            Console.WriteLine($"  x       3x^2    -7x     2       y");
            Console.WriteLine($" ----     ----    ----   ----    ----");
            for (; x < end; x += INCREMENT)
            {
                first = 3 * x * x;
                second = -7 * x;
                y = first + second + 2;
                Console.WriteLine($"{x,5:F2} {first,8:F2} {second,7:F2} {2,6:F2} {y,7:F2}");
            }
        }
    }
}
