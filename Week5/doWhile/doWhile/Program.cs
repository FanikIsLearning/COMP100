using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {

                Console.WriteLine($"{counter} {counter * 12}");

                counter = counter + 1;

            } while (counter <= 10);

        }
    }
}
