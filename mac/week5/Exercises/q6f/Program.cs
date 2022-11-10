using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kinds of rider are you (student/adult/senior)? ");
            string input = Console.ReadLine();

            if (input.ToLower() == "student")
            {
                Console.WriteLine($"{input} pays $1.75");
            }
            else if (input.ToLower() == "adult")
            {
                Console.WriteLine($"{input} pays $3.75");
            }
            else if (input.ToLower() == "senior")
            {
                Console.WriteLine($"{input} pays $2.00");
            }
            else
            {
                Console.WriteLine($"I am sorry we don't accept {input} riders");

            }

        }
    }
}
