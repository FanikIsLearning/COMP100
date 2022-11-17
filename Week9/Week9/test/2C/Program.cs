using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, times = 0;
            bool stop = true;

            Console.Write("Enter the target number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            while(stop)
            {
                if (end <= 0)
                {
                    Console.WriteLine($"It took {times} inputs to bring the target to {end}.");
                    stop = false;
                }
                else
                {
                    Console.Write($"Enter #{times+1}: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    end -= input;
                    times++;
                }
            }
        }
    }
}
