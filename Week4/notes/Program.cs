using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number % 5)
            {
                case 0:
                    Console.WriteLine($"{number} is a multiple of 5");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine($"{number} is not a multiple of 5");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine($"{number} is not a multiple of 5");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
