using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double INCREMENT = 0.5, END = 2.5;
            double x = 2.5, first, second;

            for (; x<=END;x+=INCREMENT)
            {
                first = x * x * x * x;
                Console.WriteLine($"{x,4:F1} {first,8:F4}");
            }
        }
    }
}
