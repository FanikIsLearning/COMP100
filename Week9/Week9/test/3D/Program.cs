using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0;
            Console.Write("Enter the target number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; ; i += 2)
            {
                if (i >= end || end <= sum)
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
