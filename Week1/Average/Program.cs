using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;
            int sum;
            int average;
            Console.Write("Enter the first ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second ");
            second = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Enter the  ");
            third = Convert.ToInt32((Console.ReadLine()));
            sum = first + second + third;
            average = sum / 3;
            Console.WriteLine(average);
            Console.ReadLine();
        }
    }
}
