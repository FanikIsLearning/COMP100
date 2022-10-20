using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool toContinue = true;
            do
            {
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input < 0)
                    toContinue = false;
                
                else
                    sum = sum + input;

            } while (toContinue);
            Console.WriteLine($"The total is {sum}");

        }
    }
}
