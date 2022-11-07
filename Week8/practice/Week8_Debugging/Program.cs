using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 write a program to add 4 numbers and display the average
 */

namespace Week8_Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int STOP = 4;
            int start = 0, sum = 0;
            while (start < STOP)
            {
                Console.Write($"Enter a number: ");
                sum += Convert.ToInt32(Console.ReadLine());
                start++;
            }
            Console.WriteLine($"The total is {sum} and the average is {sum/STOP}");
        }
    }
}
