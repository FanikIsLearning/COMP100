using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start value: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end value: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" kg      lb");
            do
            {
                double lb = start * 2.205;
                Console.WriteLine($"{start,3}   {lb,5:F2}");
                start -= 2;

            } while (start>=end);

        }
    }
}
