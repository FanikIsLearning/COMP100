using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correction1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INCREMENT = 0.5, END = 3.00;
            double x = -2.00, first, y;
            Console.WriteLine("    x    2      x     -x^2    y");
            Console.WriteLine(" ----   ----   ----   ----   ----");

            while (x <= END)
            {
                first = -(x * x);
                y = 2 + x - first;
                Console.WriteLine($"{x,5:F} {2,6:F} {x,6:F} {first,6:F} {y,6:F}");
                x += INCREMENT;
            }
        }
    }
}
